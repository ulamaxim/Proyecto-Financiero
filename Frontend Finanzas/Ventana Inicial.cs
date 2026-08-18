//=======================================================
// Proyecto Financiero - Ventana Inicial (Form Principal)
// Creado por: [Maksim Iulamanov]
// Fecha de creacion: 2026-07-05
//=======================================================

using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Financiero
{
    public partial class Ventana_Inicial : Form
    {
        /// <summary>
        /// Constructor principal del formulario. Inicializa los componentes de la interfaz de usuario.
        /// </summary>
        public Ventana_Inicial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta al cargar por primera vez el formulario.
        /// Sincroniza datos mediante Python, carga la información en los controles y establece la vista predeterminada.
        /// </summary>
        private void Ventana_Inicial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finanzasDBDataSet.vw_Filtro_Años' Puede moverla o quitarla según sea necesario.
            this.vw_Filtro_AñosTableAdapter.Fill(this.finanzasDBDataSet.vw_Filtro_Años);

            // 1. Ejecutamos el script de Python para actualizar la base de datos
            EjecutarScriptPython();

            // 2. Cargamos los datos actualizados en tu DataGridView
            CargarTransacciones();

            //3. Visualizamos el panel de Dashboard y ocultamos las demás secciones por defecto
            panelDashboard.Visible = true;
            panelDashboard.Enabled = true;
            lbDashboard.Visible = true;

            panelAnalitica.Visible = false;
            panelAnalitica.Enabled = false;
            lbAnalitica.Visible = false;

            panelPlanificacion.Visible = false;
            panelPlanificacion.Enabled = false;
            lbPlanificacion.Visible = false;

            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
            lbEdicion.Visible = false;
        }

        //===================================================
        //          EJECUCION DE SCRIPT DE PYTHON
        //===================================================

        /// <summary>
        /// Ejecuta de forma secundaria y silenciosa un script de Python que procesa, 
        /// limpia e inserta información financiera directamente en SQL Server.
        /// </summary>
        private void EjecutarScriptPython()
        {
            // === OBTENER LA RUTA DEL USUARIO ===
            // Obtiene de forma dinámica la ruta del perfil de usuario actual en Windows (C:\Users\NombreUsuario)
            string carpetaUsuario = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // === CONSTRUIR LAS RUTAS EXACTAS ===
            // Ruta al ejecutable de Python (en tu AppData)
            string pythonPath = Path.Combine(carpetaUsuario, @"AppData\Local\Programs\Python\Python39\python.exe");

            // Ruta al script de Python (dentro de tu carpeta del proyecto)
            string scriptPath = Path.Combine(carpetaUsuario, @"source\repos\Proyecto Financiero\Backend Finanzas\BackendFinanzas.py");

            // === COMPROBACIONES DE SEGURIDAD ===
            // Verifica que el interprete de Python 3.9 exista en la ruta especificada
            if (!File.Exists(pythonPath))
            {
                throw new FileNotFoundException($"No se pudo encontrar el ejecutable de Python en la ruta:\n{pythonPath}\n\nPor favor, verifica si la versión de Python instalada es la 3.9 o si la ruta ha cambiado.");
            }

            // Verifica que el script .py exista antes de intentar lanzarlo
            if (!File.Exists(scriptPath))
            {
                throw new FileNotFoundException($"No se pudo encontrar tu script de Python en la ruta:\n{scriptPath}\n\nVerifica que el nombre del archivo '.py' coincida exactamente.");
            }

            // === EJECUCIÓN SILENCIOSA DEL PROCESO ===
            // Configuración del proceso para ocultar la consola de comandos de Python y capturar sus salidas
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = pythonPath;
            // Envolvemos el script entre comillas por si hay espacios en "Proyecto Financiero" o "Backend Finanzas"
            start.Arguments = $"\"{scriptPath}\"";
            start.UseShellExecute = false;
            start.CreateNoWindow = true; // Oculta la ventana de símbolo del sistema (CMD)
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.StandardOutputEncoding = System.Text.Encoding.UTF8;
            start.StandardErrorEncoding = System.Text.Encoding.UTF8;

            // Inicia el proceso externo
            using (Process proceso = Process.Start(start))
            {
                // Esperamos a que Python termine de limpiar e insertar datos en SQL Server
                proceso.WaitForExit();

                // Comprobamos si hubo algún error dentro de la ejecución de Python
                using (StreamReader reader = proceso.StandardError)
                {
                    string erroresPython = reader.ReadToEnd();
                    if (!string.IsNullOrEmpty(erroresPython))
                    {
                        // Mostramos el error real de Python si algo falló internamente (ej. error de pandas, conexión SQL, etc.)
                        MessageBox.Show($"Python ejecutó con errores:\n\n{erroresPython}", "Error en Script de Python", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //===================================================
        //          CARGA DE DATOS A DATAGRIDVIEW
        //===================================================

        // Instancia del contexto de LINQ to SQL para interactuar con la base de datos
        DataClasses1DataContext datalinq = new DataClasses1DataContext();

        /// <summary>
        /// Consulta la vista de transacciones mediante LINQ, vincula los datos al DataGridView,
        /// y desencadena el formateo visual y el cálculo del balance financiero.
        /// </summary>
        public void CargarTransacciones()
        {
            // Obtención de los registros desde la vista de la base de datos
            var transactions = from vw in datalinq.vw_datagrid1
                               select vw;

            // Asignación de los resultados como origen de datos del DataGridView
            dataGridView1.DataSource = transactions;

            // Aplicar estilos y formatos numéricos/moneda
            FormatearDiseñoTabla();

            // Calcular ingresos, gastos del último mes y el saldo actual
            SaldoIngresosGastos(transactions);
        }

        //================================================
        //          FORMATEO DE TABLAS 
        //================================================

        /// <summary>
        /// Ajusta el diseño, anchos, alineaciones y formatos monetarios (en Euros)
        /// de las columnas del DataGridView principal.
        /// </summary>
        private void FormatearDiseñoTabla()
        {
            // Definición de la cultura española para el formato correcto del Euro (€)
            CultureInfo euro = new CultureInfo("es-ES");

            // Ajustamos las columnas para que llenen el espacio del dataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumnHeadersHeight();

            // Formateamos Fecha_Operacion
            dataGridView1.Columns["Fecha_Operacion"].HeaderText = "Fecha";
            dataGridView1.Columns["Fecha_Operacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["Fecha_Operacion"].FillWeight = 12;
            dataGridView1.Columns["Fecha_Operacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Formateamos Concepto
            dataGridView1.Columns["Concepto"].FillWeight = 48;

            // Formateamos Categoria
            dataGridView1.Columns["Categoria"].FillWeight = 20;

            // Formateamos Importe
            dataGridView1.Columns["Importe"].FillWeight = 10;
            dataGridView1.Columns["Importe"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Importe"].DefaultCellStyle.FormatProvider = euro;
            dataGridView1.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Formateamos Saldo
            dataGridView1.Columns["Saldo"].FillWeight = 10;
            dataGridView1.Columns["Saldo"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Saldo"].DefaultCellStyle.FormatProvider = euro;
            dataGridView1.Columns["Saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Hacemos que las filas alternen de color para facilitar la lectura
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 250);

        }

        //======================================================
        //          CALCULO DE SALDO INGRESOS Y GASTOS
        //======================================================

        /// <summary>
        /// Realizamos los cálculos financieros del saldo más reciente, y la suma de
        /// ingresos y gastos correspondientes al último mes registrado en los datos.
        /// </summary>
        /// <param name="transactions">Colección con el listado de transacciones consultadas.</param>
        void SaldoIngresosGastos(IEnumerable<vw_datagrid1> transactions)
        {
            CultureInfo euro = new CultureInfo("es-ES");

            // Saldo Actual: Toma el primer registro de la consulta
            lblSaldoValor.Text = (transactions.FirstOrDefault()?.Saldo ?? 0).ToString("C2", euro);

            // Creamos una la fecha limite con la que vamos a comparar para sacar los datos solo del ultimo mes
            DateTime ultimaFecha = transactions
                .Where(i => i.Fecha_Operacion.HasValue)
                .Max(i => i.Fecha_Operacion.Value);

            int mesLim = ultimaFecha.Month;
            int añoLim = ultimaFecha.Year;

            // Ingresos. Ccalculamos la suma de valores positivos de la columna importe
            // del ultimo mes natural
            decimal ingresos = transactions
                .Where(i => i.Fecha_Operacion.Value.Month == mesLim &&
                            i.Fecha_Operacion.Value.Year == añoLim)
                .Where(i => i.Importe.HasValue && i.Importe > 0)
                .Sum(i => i.Importe.Value);


            // Gastos. Hacemos calculo de valores negativos de la columna Importe
            // del ultimo mes natural
            decimal gastos = transactions
                .Where(i => i.Fecha_Operacion.Value.Month == mesLim &&
                            i.Fecha_Operacion.Value.Year == añoLim)
                .Where(g => g.Importe.HasValue && g.Importe < 0)
                .Sum(g => g.Importe.Value);

            // Pasamos los valores a los labels
            lblIngresosValor.Text = ingresos.ToString("C2", euro);
            lblGastosValor.Text = gastos.ToString("C2", euro);
        }

        //===============================================================
        //         CARGA DE DATOS A EL PANEL DE ANALITICA
        //===============================================================

        /// <summary>
        /// Carga de datos del datagridview1 al pie chart,
        /// aplicando los filtros de tiempos
        /// </summary>
        private void CargaPieChart()
        {
            // Obtención de los registros desde la vista de la base de datos
            var transactions = (IEnumerable<vw_datagrid1>)dataGridView1.DataSource;

            // Ajustamos los filtros del mes i año para el pie chart
            int? mesSeleccionado = combFiltroMes.SelectedIndex > 0 ? (int?)combFiltroMes.SelectedIndex : null;
            object valorAnio = combFiltroAnio.SelectedValue ?? combFiltroAnio.SelectedItem;

            int? anioSeleccionado = null;

            if (valorAnio != null && int.TryParse(valorAnio.ToString(), out int anioParseado))
            {
                anioSeleccionado = anioParseado;
            }

            // Carga de datos a la variable gastosPieChart que se utilizara para rellenar el Pie Chart
            var gastosPieChart = transactions
                .Where(i => i.Importe.HasValue && i.Importe < 0 && !string.IsNullOrEmpty(i.Categoria))
                .Where(i => i.Fecha_Operacion.HasValue &&
                            (!mesSeleccionado.HasValue || i.Fecha_Operacion.Value.Month == mesSeleccionado.Value) &&
                            (!anioSeleccionado.HasValue || i.Fecha_Operacion.Value.Year == anioSeleccionado.Value))
                .GroupBy(i => i.Categoria)
                .Select(g => new
                {
                    Categoria = g.Key,
                    Total = Math.Abs(g.Sum(i => i.Importe.Value))
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            // Calculamos el total global para saber los porcentajes manualmente sin fallos de LiveCharts
            decimal totalGastos = gastosPieChart.Sum(x => x.Total);

            // Cultivo de moneda local para formatear a Euros
            var euro = new System.Globalization.CultureInfo("es-ES");

            // Definimos las series
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

            foreach (var item in gastosPieChart)
            {
                // Calculamos el porcentaje real
                decimal porcentaje = totalGastos > 0 ? (item.Total / totalGastos) : 0;

                // Si la categoría representa menos del 4%, desactivamos su etiqueta visual interna
                bool mostrarEtiqueta = porcentaje >= 0.04m;

                series.Add(new PieSeries
                {
                    Title = item.Categoria,
                    Values = new ChartValues<decimal> { item.Total },
                    DataLabels = mostrarEtiqueta,
                    LabelPoint = point => item.Total.ToString("C2", euro),
                    FontSize = 10,
                    Foreground = System.Windows.Media.Brushes.Black,
                });
            }

            // Asignamos la colección y la estética
            pieChart1.Series = series;
            pieChart1.InnerRadius = 40;
            pieChart1.LegendLocation = LiveCharts.LegendLocation.Top;

            pieChart1.DataClick -= pieChart1_DataClick;
            pieChart1.DataClick += pieChart1_DataClick;

            // Creamos un Tooltip nativo de LiveCharts y le pedimos que muestre la selección de forma clara
            var customTooltip = new LiveCharts.Wpf.DefaultTooltip
            {
                SelectionMode = LiveCharts.TooltipSelectionMode.OnlySender
            };

            pieChart1.DataTooltip = customTooltip;
        }

        private void CargarFiltroAños()
        {
            // Obtenemos únicamente los años de las transacciones reales guardadas
            var añosDisponibles = datalinq.vw_datagrid1
                .Where(t => t.Fecha_Operacion.HasValue)
                .Select(t => t.Fecha_Operacion.Value.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToList();

            // Asignamos la lista limpia al ComboBox de años
            combFiltroAnio.DataSource = añosDisponibles;
        }

        /// <summary>
        /// Carga de datos a Filtro Pie Chart
        /// </summary>
        private void CargaFiltroPieChart(string categoria)
        {
            // Obtención de los registros desde la vista principal
            var transactions = (IEnumerable<vw_datagrid1>)dataGridView1.DataSource;

            // Leemos los filtros activos de mes y año
            int? mesSeleccionado = combFiltroMes.SelectedIndex > 0 ? (int?)combFiltroMes.SelectedIndex : null;
            object valorAnio = combFiltroAnio.SelectedValue ?? combFiltroAnio.SelectedItem;
            int? anioSeleccionado = null;

            if (valorAnio != null && int.TryParse(valorAnio.ToString(), out int anioParseado) && anioParseado > 0)
            {
                anioSeleccionado = anioParseado;
            }

            // Filtramos los registros por la categoría pulsada, la fecha y solo gastos (Importe < 0)
            var filtroPieChart = transactions
                .Where(i => i.Categoria == categoria)
                .Where(i => i.Importe.HasValue && i.Importe < 0)
                .Where(i => i.Fecha_Operacion.HasValue &&
                            (!mesSeleccionado.HasValue || i.Fecha_Operacion.Value.Month == mesSeleccionado.Value) &&
                            (!anioSeleccionado.HasValue || i.Fecha_Operacion.Value.Year == anioSeleccionado.Value))
                .Select(i => new
                {
                    Fecha = i.Fecha_Operacion.Value,
                    Descripcion = i.Concepto,
                    Gasto = Math.Abs(i.Importe.Value).ToString("C2", new System.Globalization.CultureInfo("es-ES"))
                })
                .ToList();

            // Asignamos el resultado al DataGridView especificado
            dataGridPieChartFiltro.DataSource = filtroPieChart;

            // Formateamos el datagridwiew resultado
            dataGridPieChartFiltro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPieChartFiltro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 250);
            dataGridPieChartFiltro.RowHeadersVisible = false;

            dataGridPieChartFiltro.Columns["Descripcion"].FillWeight = 240;

            dataGridPieChartFiltro.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        /// <summary>
        /// Carga de datos a Gastos VS Ingresos para los últimos 6 meses
        /// </summary>
        private void CargaGastosVSIngresos()
        {
            // Obtención de los registros desde la vista de la base de datos
            var transactions = (IEnumerable<vw_datagrid1>)dataGridView1.DataSource;

            // Calculamos la fecha límite (hace 6 meses desde el primer día del mes actual)
            DateTime fechaHoy = DateTime.Now;
            DateTime fechaInicio = new DateTime(fechaHoy.Year, fechaHoy.Month, 1).AddMonths(-5);

            // Generamos la lista de las 6 etiquetas de meses 
            var mesesNombres = new List<string>();
            var mesesClaves = new List<(int Anio, int Mes)>();

            for (int i = 0; i < 6; i++)
            {
                DateTime fechaMes = fechaInicio.AddMonths(i);
                // Nombre del mes en español abreviado 
                mesesNombres.Add(fechaMes.ToString("MMM yyyy", new System.Globalization.CultureInfo("es-ES")));
                mesesClaves.Add((fechaMes.Year, fechaMes.Month));
            }

            // Filtramos los registros dentro del rango de los últimos 6 meses
            var transaccionesFiltradas = transactions
                .Where(i => i.Fecha_Operacion.HasValue && i.Importe.HasValue && i.Fecha_Operacion.Value >= fechaInicio)
                .ToList();

            // Inicializamos las listas de valores para el gráfico (una posición por cada mes)
            var listaIngresos = new ChartValues<decimal>();
            var listaGastos = new ChartValues<decimal>();

            // Rellenamos los valores iterando sobre los 6 meses generados
            foreach (var clave in mesesClaves)
            {
                // Ingresos del mes (positivos)
                decimal totalIngresos = transaccionesFiltradas
                    .Where(t => t.Fecha_Operacion.Value.Year == clave.Anio &&
                                t.Fecha_Operacion.Value.Month == clave.Mes &&
                                t.Importe.Value > 0)
                    .Sum(t => t.Importe.Value);

                // Gastos del mes (se pasa a valor positivo con Math.Abs para graficar barras hacia arriba)
                decimal totalGastos = Math.Abs(transaccionesFiltradas
                    .Where(t => t.Fecha_Operacion.Value.Year == clave.Anio &&
                                t.Fecha_Operacion.Value.Month == clave.Mes &&
                                t.Importe.Value < 0)
                    .Sum(t => t.Importe.Value));

                listaIngresos.Add(totalIngresos);
                listaGastos.Add(totalGastos);
            }

            // Creación de las series para el CartesianChart
            cartesianChartGastosContraIngresos.Series = new LiveCharts.SeriesCollection
            {
                new LiveCharts.Wpf.ColumnSeries
                {
                    Title = "Ingresos",
                    Values = listaIngresos,
                    Fill = System.Windows.Media.Brushes.MediumSeaGreen,
                    MaxColumnWidth = 20,
                    ColumnPadding = 4
                },
                new LiveCharts.Wpf.ColumnSeries
                {
                    Title = "Gastos",
                    Values = listaGastos,
                    Fill = System.Windows.Media.Brushes.IndianRed,
                    MaxColumnWidth = 20,
                    ColumnPadding = 4
                }
            };

            // Configuración del Eje X 
            cartesianChartGastosContraIngresos.AxisX.Clear();
            cartesianChartGastosContraIngresos.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Meses",
                Labels = mesesNombres,
                Foreground = System.Windows.Media.Brushes.DimGray,
                FontSize = 11,
                Separator = new LiveCharts.Wpf.Separator
                {
                    IsEnabled = false
                }
            });

            // Configuración del Eje Y 
            var euro = new System.Globalization.CultureInfo("es-ES");
            cartesianChartGastosContraIngresos.AxisY.Clear();
            cartesianChartGastosContraIngresos.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Monto",
                LabelFormatter = value => value.ToString("C0", euro),
                Foreground = System.Windows.Media.Brushes.DimGray,
                FontSize = 11,
                Separator = new LiveCharts.Wpf.Separator
                {
                    IsEnabled = true,
                    Stroke = System.Windows.Media.Brushes.Black,
                    StrokeThickness = 1
                }
            });
        }

        /// <summary>
        /// Carga de datos a top 10 mayores gastos segun el filtro de tiempo
        /// <summary>
        private void CargaTop10Gastos()
        {
            // Obtención de los registros desde la vista de la base de datos
            var transactions = (IEnumerable<vw_datagrid1>)dataGridView1.DataSource;

            // Leemos los filtros activos de mes y año
            int? mesSeleccionado = combFiltroMes.SelectedIndex > 0 ? (int?)combFiltroMes.SelectedIndex : null;
            object valorAnio = combFiltroAnio.SelectedValue ?? combFiltroAnio.SelectedItem;
            int? anioSeleccionado = null;

            if (valorAnio != null && int.TryParse(valorAnio.ToString(), out int anioParseado) && anioParseado > 0)
            {
                anioSeleccionado = anioParseado;
            }

            var top10Gastos = transactions
                .Where(i => i.Importe.HasValue)
                .Where(i => i.Importe.HasValue && i.Importe < 0)
                .Where(i => i.Fecha_Operacion.HasValue &&
                            (!mesSeleccionado.HasValue || i.Fecha_Operacion.Value.Month == mesSeleccionado.Value) &&
                            (!anioSeleccionado.HasValue || i.Fecha_Operacion.Value.Year == anioSeleccionado.Value))
                .OrderByDescending(i => Math.Abs(i.Importe.Value))
                .Take(10)
                .Select(i => new
                {
                    Fecha = i.Fecha_Operacion.Value,
                    Descripcion = i.Concepto,
                    Gasto = Math.Abs(i.Importe.Value).ToString("C2", new System.Globalization.CultureInfo("es-ES"))
                })
                .ToList();

            // Cargamos los datos a dataGridTopGastos
            dataGridTopGastos.DataSource = top10Gastos;

            // Formateamos la tabla resultante
            dataGridTopGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTopGastos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 200, 200);
            dataGridTopGastos.RowHeadersVisible = false;

            dataGridTopGastos.Columns["Descripcion"].FillWeight = 240;

            dataGridTopGastos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        /// <summary>
        /// Carga de datos a evolucion de sueldo segun el filtro de tiempo
        /// </summary>
        private void EvolucionDeSueldo()
        {
            // 1. Obtención de los registros desde el DataGridView principal
            var transactions = (IEnumerable<vw_datagrid1>)dataGridView1.DataSource;

            // Leemos los filtros activos de mes y año
            int? mesSeleccionado = combFiltroMes.SelectedIndex > 0 ? (int?)combFiltroMes.SelectedIndex : null;
            object valorAnio = combFiltroAnio.SelectedValue ?? combFiltroAnio.SelectedItem;
            int? anioSeleccionado = null;

            if (valorAnio != null && int.TryParse(valorAnio.ToString(), out int anioParseado) && anioParseado > 0)
            {
                anioSeleccionado = anioParseado;
            }

            var evolucionSaldo = transactions
                .Where(i => i.Importe.HasValue)
                .Where(i => (!mesSeleccionado.HasValue || i.Fecha_Operacion.Value.Month == mesSeleccionado.Value) &&
                            (!anioSeleccionado.HasValue || i.Fecha_Operacion.Value.Year == anioSeleccionado.Value))
                .OrderBy(i => i.Fecha_Operacion.Value)
                .ToList();

            if (!evolucionSaldo.Any())
            {
                // Si no hay datos en ese mes/año limpidamos el gráfico
                cartesianChartEvolucionSaldo.Series.Clear();
                cartesianChartEvolucionSaldo.AxisX.Clear();
                return;
            }

            // Etiquetas de fechas y valores
            var valoresSaldo = new ChartValues<decimal>();
            var etiquetasFechas = new List<string>();

            foreach (var item in evolucionSaldo)
            {
                valoresSaldo.Add(item.Saldo.Value);
                etiquetasFechas.Add(item.Fecha_Operacion.Value.ToString("dd/MM"));
            }

            var euro = new System.Globalization.CultureInfo("es-ES");

            var lineaY = new LineSeries
            {
                Title = "Saldo",
                Values = valoresSaldo,
                Stroke = System.Windows.Media.Brushes.DodgerBlue,
                Fill = System.Windows.Media.Brushes.AliceBlue,
                PointGeometrySize = 5,
                PointForeground = System.Windows.Media.Brushes.SteelBlue,
                LineSmoothness = 0.2,
                LabelPoint = point => point.Y.ToString("C2", euro)
            };

            cartesianChartEvolucionSaldo.Series = new LiveCharts.SeriesCollection { lineaY };

            cartesianChartEvolucionSaldo.AxisX.Clear();
            cartesianChartEvolucionSaldo.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Fecha",
                Labels = etiquetasFechas,
                Foreground = System.Windows.Media.Brushes.DimGray,
                FontSize = 10,
                LabelsRotation = 45,
                Separator = new LiveCharts.Wpf.Separator
                {
                    Step = 2,
                    IsEnabled = false,
                }
            });
        }

        //===============================================================
        //         CARGA DE DATOS A EL PANEL DE PLANIFICACION
        //===============================================================

        /// <summary>
        /// Carga de los paneles de metricas
        /// </summary>

        private void CargaPanelesMetricas()
        {
            // Variable para formatear los valores monetarios en Euros
            var euro = new System.Globalization.CultureInfo("es-ES");

            // Obtenemos datos para las tarjetas
            decimal presupuestoMes = datalinq.vw_datagrid1
                .Where(t => t.Fecha_Operacion.HasValue &&
                            t.Fecha_Operacion.Value.Month == DateTime.Now.Month &&
                            t.Fecha_Operacion.Value.Year == DateTime.Now.Year)
                .Where(t => t.Importe.HasValue && t.Importe > 0)
                .Where(t => t.Categoria == "Nomina")
                .Sum(t => t.Importe.Value);

            // Obtenemos valores de gastos asignados del mes
            decimal gastosMes = datalinq.GastosProgramados
                .Where (g => g.FechaGasto.Month == DateTime.Now.Month && 
                        g.FechaGasto.Year == DateTime.Now.Year)
                .Where (g => g.Completado == false)
                .Sum(g => (decimal?)g.CantidadGasto) ?? 0m;

            decimal ahorroDisponible = presupuestoMes - gastosMes;

            lblPresupuestoMes.Text = "Presupuesto del mes: " + presupuestoMes.ToString("C2", euro);
            lblGastosAsignados.Text = "Gastos asignados: " + gastosMes.ToString("C2", euro);
            lblAhorroDisponible.Text = "Ahorro Disponible: " + ahorroDisponible.ToString("C2", euro);
        }

        /// <summary>
        /// Carga de datos al panel de limites de gastos 
        /// al pulsar el boton de planificacion
        /// </summary>
        private void CargarTarjetasLimites()
        {
            // Limpiar filas y controles previos del TableLayoutPanel
            tableLayoutLimitesPorCategoria.SuspendLayout();
            tableLayoutLimitesPorCategoria.Controls.Clear();
            tableLayoutLimitesPorCategoria.RowStyles.Clear();
            tableLayoutLimitesPorCategoria.RowCount = 0;

            // Nuevo layout por columnas para evitar solapamientos
            tableLayoutLimitesPorCategoria.ColumnCount = 4;
            tableLayoutLimitesPorCategoria.ColumnStyles.Clear();
            tableLayoutLimitesPorCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F)); // Categoria
            tableLayoutLimitesPorCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // Barra de progreso
            tableLayoutLimitesPorCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F)); // Valores
            tableLayoutLimitesPorCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));  // Botón editar

            // Obtener gastos por categoría
            var resumenGastos = datalinq.vw_datagrid1
                .Where(t => t.Importe.HasValue && t.Importe < 0 && t.Fecha_Operacion.Value.Month == DateTime.Now.Month)
                .GroupBy(t => t.Categoria)
                .Select(g => new
                {
                    Categoria = g.Key,
                    Gastado = Math.Abs((double)g.Sum(t => t.Importe.Value))
                })
                .ToList();

            // Consultar los límites existentes en la BD en un diccionario para acceso rápido
            var limitesBD = datalinq.Limites.ToDictionary(l => l.Categoria, l => (double)l.Limite);

            // Crear filas: una fila por categoría (controles en columnas separadas)
            foreach (var item in resumenGastos)
            {
                int rowIndex = tableLayoutLimitesPorCategoria.RowCount;
                tableLayoutLimitesPorCategoria.RowCount++;
                tableLayoutLimitesPorCategoria.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                double limitePresupuesto = limitesBD.ContainsKey(item.Categoria) ? limitesBD[item.Categoria] : 0;

                // Crear controles para la fila
                var tuple = CrearControlesFila(item.Categoria, item.Gastado, limitePresupuesto);

                // Añadir controles a columnas separadas
                tableLayoutLimitesPorCategoria.Controls.Add(tuple.lblCategoria, 0, rowIndex);
                tableLayoutLimitesPorCategoria.Controls.Add(tuple.pnlBarraFondo, 1, rowIndex);
                tableLayoutLimitesPorCategoria.Controls.Add(tuple.lblValores, 2, rowIndex);
                tableLayoutLimitesPorCategoria.Controls.Add(tuple.btnEditar, 3, rowIndex);

                // Ajustes visuales
                tuple.lblCategoria.Dock = DockStyle.Fill;
                tuple.lblCategoria.Margin = new Padding(4, 10, 4, 10);

                tuple.pnlBarraFondo.Dock = DockStyle.Fill;
                tuple.pnlBarraFondo.Margin = new Padding(4, 18, 4, 12);

                tuple.lblValores.Dock = DockStyle.Fill;
                tuple.lblValores.Margin = new Padding(4, 12, 4, 12);

                tuple.btnEditar.Dock = DockStyle.Fill;
                tuple.btnEditar.Margin = new Padding(6, 12, 6, 12);
            }

            // Añadir fila espaciadora invisible para que el layout tenga un área final
            int spacerRowIndex = tableLayoutLimitesPorCategoria.RowCount;
            tableLayoutLimitesPorCategoria.RowCount++;
            // Esta fila en porcentaje ocupará el espacio restante disponible
            tableLayoutLimitesPorCategoria.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Panel pnlSpacer = new Panel { BackColor = Color.Transparent, Dock = DockStyle.Fill };
            tableLayoutLimitesPorCategoria.Controls.Add(pnlSpacer, 0, spacerRowIndex);
            tableLayoutLimitesPorCategoria.SetColumnSpan(pnlSpacer, tableLayoutLimitesPorCategoria.ColumnCount);

            tableLayoutLimitesPorCategoria.ResumeLayout();
        }

        // Crea los controles que van en una fila (columna por control). Devuelve un tuple con los elementos.
        private (Label lblCategoria, Panel pnlBarraFondo, Label lblValores, Button btnEditar) CrearControlesFila(string categoria, double gastado, double limite)
        {
            Label lblCategoria = new Label
            {
                Text = categoria,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                AutoEllipsis = true,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // BARRA DE PROGRESO (Fondo Gris)
            Panel pnlBarraFondo = new Panel
            {
                BackColor = Color.FromArgb(230, 230, 230)
            };

            Color colorRelleno = Color.Transparent;
            if (limite > 0)
            {
                double pctTemp = (gastado / limite) * 100.0;
                colorRelleno = pctTemp < 70 ? Color.MediumSeaGreen : pctTemp < 90 ? Color.Goldenrod : Color.IndianRed;
            }

            Panel pnlBarraRelleno = new Panel
            {
                BackColor = colorRelleno,
                Width = 0,
                Height = 12,
                Dock = DockStyle.Left
            };
            pnlBarraFondo.Controls.Add(pnlBarraRelleno);

            Label lblValores = new Label
            {
                Text = $"{gastado:N0}€/{limite:N0}€",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleRight
            };

            Button btnEditar = new Button
            {
                Text = "✏️",
                FlatStyle = FlatStyle.Flat,
                Tag = categoria
            };
            btnEditar.FlatAppearance.BorderSize = 0;

            // Actualizar ancho del relleno cuando cambie tamaño del fondo
            pnlBarraFondo.SizeChanged += (s, e) =>
            {
                if (limite <= 0)
                {
                    pnlBarraRelleno.Width = 0;
                    return;
                }
                double pctReal = (gastado / limite) * 100.0;
                double pctVisual = Math.Min(pctReal, 100.0);
                int ancho = (int)Math.Round(pnlBarraFondo.Width * (pctVisual / 100.0));
                pnlBarraRelleno.Width = Math.Max(0, Math.Min(ancho, pnlBarraFondo.Width));
            };

            // Click editar -> mostrar diálogo modal para editar límite
            btnEditar.Click += (s, e) =>
            {
                if (MostrarDialogoLimite(categoria, limite, out decimal nuevoLimite) && nuevoLimite > 0)
                {
                    try
                    {
                        var presupuestoExistente = datalinq.Limites.FirstOrDefault(p => p.Categoria == categoria);
                        if (presupuestoExistente != null)
                        {
                            presupuestoExistente.Limite = nuevoLimite;
                            presupuestoExistente.FechaModificacion = DateTime.Now;
                        }
                        else
                        {
                            Limites nuevo = new Limites
                            {
                                Categoria = categoria,
                                Limite = nuevoLimite,
                                FechaModificacion = DateTime.Now
                            };
                            datalinq.Limites.InsertOnSubmit(nuevo);
                        }

                        datalinq.SubmitChanges();
                        CargarTarjetasLimites();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar el límite: {ex.Message}", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            return (lblCategoria, pnlBarraFondo, lblValores, btnEditar);
        }

        // Muestra un diálogo modal simple para editar un límite. Devuelve true si el usuario aceptó.
        private bool MostrarDialogoLimite(string categoria, double limiteActual, out decimal nuevoLimite)
        {
            nuevoLimite = 0;
            using (Form dlg = new Form())
            {
                dlg.Text = $"Editar límite - {categoria}";
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.ClientSize = new Size(300, 110);
                dlg.MinimizeBox = false;
                dlg.MaximizeBox = false;

                Label lbl = new Label { Text = "Límite (€):", Location = new Point(12, 15), AutoSize = true };
                TextBox txt = new TextBox { Location = new Point(90, 12), Width = 180, Text = limiteActual.ToString("F0") };
                Button ok = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(110, 60), Width = 70 };
                Button cancel = new Button { Text = "Cancelar", DialogResult = DialogResult.Cancel, Location = new Point(190, 60), Width = 70 };

                dlg.Controls.Add(lbl);
                dlg.Controls.Add(txt);
                dlg.Controls.Add(ok);
                dlg.Controls.Add(cancel);

                dlg.AcceptButton = ok;
                dlg.CancelButton = cancel;

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    if (decimal.TryParse(txt.Text, out decimal parsed) && parsed > 0)
                    {
                        nuevoLimite = parsed;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Introduce un importe válido mayor que 0.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Carga de datos al panel de metas de ahorro 
        /// al pulsar el boton de planificacion
        /// </summary>
        private void btAnadirMeta_Click(object sender, EventArgs e)
        {
            panelEdicionMetas.Visible = true;
            panelEdicionMetas.Enabled = true;
        }

        private void btCancelarMeta_Click(object sender, EventArgs e)
        {
            panelEdicionMetas.Visible = false;
            panelEdicionMetas.Enabled = false;
            txtNombreMeta.Clear();
            txtSaldoNecesario.Clear();

        }

        private void btAceptarMetaNueva_Click(object sender, EventArgs e)
        {
            // Validar campos
            string nombre = txtNombreMeta.Text?.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce un nombre para la meta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreMeta.Focus();
                return;
            }

            if (!decimal.TryParse(txtSaldoNecesario.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Introduce un importe válido mayor que 0.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaldoNecesario.Focus();
                return;
            }

            try
            {
                // Crear nueva entidad MetasAhorro y guardarla en la base de datos
                MetasAhorro nueva = new MetasAhorro
                {
                    Concepto = nombre,
                    MontoObjetivo = monto,
                    Completada = false,
                    FechaCreacion = DateTime.Now
                };

                datalinq.MetasAhorro.InsertOnSubmit(nueva);
                datalinq.SubmitChanges();

                // Actualizar UI
                panelEdicionMetas.Visible = false;
                panelEdicionMetas.Enabled = false;
                txtNombreMeta.Clear();
                txtSaldoNecesario.Clear();

                CargarTarjetasMetas();

                MessageBox.Show("Meta guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la meta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTarjetasMetas()
        {
            // Limpiar
            tableLayoutMetasAhorro.SuspendLayout();
            tableLayoutMetasAhorro.Controls.Clear();
            tableLayoutMetasAhorro.RowStyles.Clear();
            tableLayoutMetasAhorro.RowCount = 0;

            // Configurar columnas: Nombre | Barra | Valores | Completar
            tableLayoutMetasAhorro.ColumnCount = 4;
            tableLayoutMetasAhorro.ColumnStyles.Clear();
            tableLayoutMetasAhorro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutMetasAhorro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMetasAhorro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutMetasAhorro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));

            // Leer metas no completadas desde BD
            var metas = datalinq.MetasAhorro
                .Where(m => m.Completada == false)
                .OrderBy(m => m.FechaCreacion)
                .ToList();

            // Obtener saldo disponible global (primera fila Saldo de vw_datagrid1)
            var primerSaldoNullable = datalinq.vw_datagrid1
                .OrderByDescending(t => t.Fecha_Operacion)
                .Select(t => t.Saldo)
                .FirstOrDefault();
            decimal saldoDisponibleGlobal = primerSaldoNullable.HasValue ? primerSaldoNullable.Value : 0m;

            // Calculamos el saldo restante dinámicamente: cada meta reserva su MontoObjetivo
            decimal restante = saldoDisponibleGlobal;
            foreach (var meta in metas)
            {
                int row = tableLayoutMetasAhorro.RowCount;
                tableLayoutMetasAhorro.RowCount++;
                tableLayoutMetasAhorro.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                var controles = CrearControlesMeta(meta, restante);

                tableLayoutMetasAhorro.Controls.Add(controles.lblNombre, 0, row);
                tableLayoutMetasAhorro.Controls.Add(controles.pnlBarraFondo, 1, row);
                tableLayoutMetasAhorro.Controls.Add(controles.lblValores, 2, row);
                tableLayoutMetasAhorro.Controls.Add(controles.btnCompletar, 3, row);

                controles.lblNombre.Dock = DockStyle.Fill;
                controles.lblNombre.Margin = new Padding(4, 12, 4, 12);

                controles.pnlBarraFondo.Dock = DockStyle.Fill;
                controles.pnlBarraFondo.Margin = new Padding(4, 18, 4, 12);

                controles.lblValores.Dock = DockStyle.Fill;
                controles.lblValores.Margin = new Padding(4, 12, 4, 12);

                controles.btnCompletar.Dock = DockStyle.Fill;
                controles.btnCompletar.Margin = new Padding(6, 12, 6, 12);

                // Reducir el saldo restante después de reservar para esta meta
                restante -= meta.MontoObjetivo;
                if (restante < 0) restante = 0;
            }

            // Spacer final
            int spacerIndex = tableLayoutMetasAhorro.RowCount;
            tableLayoutMetasAhorro.RowCount++;
            tableLayoutMetasAhorro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Panel spacer = new Panel { BackColor = Color.Transparent, Dock = DockStyle.Fill };
            tableLayoutMetasAhorro.Controls.Add(spacer, 0, spacerIndex);
            tableLayoutMetasAhorro.SetColumnSpan(spacer, tableLayoutMetasAhorro.ColumnCount);

            tableLayoutMetasAhorro.ResumeLayout();
        }

        private (Label lblNombre, Panel pnlBarraFondo, Label lblValores, Button btnCompletar) CrearControlesMeta(MetasAhorro meta, decimal saldoDisponible)
        {
            Label lblNombre = new Label
            {
                Text = meta.Concepto,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            Panel pnlBarraFondo = new Panel { BackColor = Color.FromArgb(230, 230, 230) };

            Color colorRelleno = Color.Transparent;
            if (meta.MontoObjetivo > 0)
            {
                double pct = (double)saldoDisponible / (double)meta.MontoObjetivo * 100.0;
                colorRelleno = pct <= 100 ? Color.Goldenrod : Color.Blue;
            }

            Panel pnlBarraRelleno = new Panel { BackColor = colorRelleno, Width = 0, Height = 12, Dock = DockStyle.Left };
            pnlBarraFondo.Controls.Add(pnlBarraRelleno);

            Label lblValores = new Label
            {
                Text = $"{saldoDisponible:N0}€/{meta.MontoObjetivo:N0}€",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleRight
            };

            Button btnCompletar = new Button
            {
                Text = meta.Completada ? "✔" : "✚",
                FlatStyle = FlatStyle.Flat,
                Tag = meta.Id
            };
            btnCompletar.FlatAppearance.BorderSize = 0;
            btnCompletar.Enabled = !meta.Completada;

            // Actualizar ancho del relleno
            pnlBarraFondo.SizeChanged += (s, e) =>
            {
                if (meta.MontoObjetivo <= 0)
                {
                    pnlBarraRelleno.Width = 0;
                    return;
                }
                double pct = (double)saldoDisponible / (double)meta.MontoObjetivo;
                pct = Math.Min(1.0, Math.Max(0.0, pct));
                pnlBarraRelleno.Width = (int)Math.Round(pnlBarraFondo.Width * pct);
            };

            btnCompletar.Click += (s, e) =>
            {
                if (MessageBox.Show($"Marcar la meta '{meta.Concepto}' como completada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var m = datalinq.MetasAhorro.FirstOrDefault(x => x.Id == meta.Id);
                    if (m != null)
                    {
                        m.Completada = true;
                        try
                        {
                            datalinq.SubmitChanges();
                            // Refrescar vistas: eliminamos la meta de la lista mostrando solo no completadas
                            CargarTarjetasMetas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al marcar meta completada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            };

            return (lblNombre, pnlBarraFondo, lblValores, btnCompletar);
        }

        /// <summary>
        /// Carga de datos al panel de gastos programados
        /// </summary>

        private void btAnadirGastoProgramado_Click(object sender, EventArgs e)
        {
            panelEdicionGastoProgramados.Visible = true;
            panelEdicionGastoProgramados.Enabled = true;
        }

        private void btCancelarGastosProgramados_Click(object sender, EventArgs e)
        {
            txtNombreGasto.Clear();
            txtCantidadGasto.Clear();
            panelEdicionGastoProgramados.Visible = false;
            panelEdicionGastoProgramados.Enabled = false;
        }

        private void btAceptarGastosProgramados_Click(object sender, EventArgs e)
        {
            // Validar campos
            string nombre = txtNombreGasto.Text?.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce un nombre para el gasto programado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreGasto.Focus();
                return;
            }

            if (!decimal.TryParse(txtCantidadGasto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Introduce un importe válido mayor que 0.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadGasto.Focus();
                return;
            }

            bool repetible = !chkNoRepetible.Checked;
            string repetibleTipo = "No Repetible";

            if (chkSemanal.Checked) repetibleTipo = "Semanal";
            else if (chkMensual.Checked) repetibleTipo = "Mensual";
            else if (chkAnual.Checked) repetibleTipo = "Anual";

            int limiteRegistros = repetible ? 5 : 1;
            DateTime fechaBase = dtPickFechaPago.Value;

            try
            {
                for (int i = 0; i < limiteRegistros; i++)
                {
                    DateTime fechaCalculada = fechaBase;

                    if (repetible)
                    {
                        switch (repetibleTipo)
                        {
                            case "Semanal":
                                fechaCalculada = fechaBase.AddDays(i * 7);
                                break;
                            case "Mensual":
                                fechaCalculada = fechaBase.AddMonths(i);
                                break;
                            case "Anual":
                                fechaCalculada = fechaBase.AddYears(i);
                                break;
                        }
                    }

                    GastosProgramados nuevo = new GastosProgramados
                    {
                        NombreGasto = nombre,
                        CantidadGasto = monto,
                        FechaGasto = fechaCalculada,
                        Repetible = repetible,
                        RepetibleTipo = repetibleTipo,
                        Completado = false,
                        FechaCreacion = DateTime.Now
                    };

                    datalinq.GastosProgramados.InsertOnSubmit(nuevo);
                }

                datalinq.SubmitChanges();

                // Limpiar UI
                txtNombreGasto.Clear();
                txtCantidadGasto.Clear();
                panelEdicionGastoProgramados.Visible = false;
                panelEdicionGastoProgramados.Enabled = false;

                // Recargar vista
                CargaGastosProgramados();
                CargaPanelesMetricas();

                MessageBox.Show("Gasto(s) programado(s) guardado(s) correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar gasto programado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga de datos al Table Layout de gastos programados (tableLayoutGastosProgramados)
        private void CargaGastosProgramados()
        {
            tableLayoutGastosProgramados.SuspendLayout();
            tableLayoutGastosProgramados.Controls.Clear();
            tableLayoutGastosProgramados.RowStyles.Clear();
            tableLayoutGastosProgramados.RowCount = 0;

            tableLayoutGastosProgramados.ColumnCount = 4;
            tableLayoutGastosProgramados.ColumnStyles.Clear();
            tableLayoutGastosProgramados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutGastosProgramados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutGastosProgramados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutGastosProgramados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));

            DateTime hoy = DateTime.Today;
            DateTime inicioMesActual = new DateTime(hoy.Year, hoy.Month, 1);
            DateTime limiteExclusivo = inicioMesActual.AddMonths(2);

            var gastosProgramados = datalinq.GastosProgramados
                .Where(g => g.Completado == false
                         && g.FechaGasto >= inicioMesActual
                         && g.FechaGasto < limiteExclusivo)
                .OrderBy(g => g.FechaGasto)
                .ToList();

            foreach (var gasto in gastosProgramados)
            {
                int row = tableLayoutGastosProgramados.RowCount;
                tableLayoutGastosProgramados.RowCount++;
                tableLayoutGastosProgramados.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                // Evaluamos si el gasto pertenece al mes actual
                bool esMesActual = gasto.FechaGasto.Month == hoy.Month && gasto.FechaGasto.Year == hoy.Year;

                var controles = CrearControlesGastoProgramado(gasto, esMesActual);

                tableLayoutGastosProgramados.Controls.Add(controles.lblNombre, 0, row);
                tableLayoutGastosProgramados.Controls.Add(controles.lblFecha, 1, row);
                tableLayoutGastosProgramados.Controls.Add(controles.lblMonto, 2, row);
                tableLayoutGastosProgramados.Controls.Add(controles.btnCompletar, 3, row);

                controles.lblNombre.Dock = DockStyle.Fill;
                controles.lblNombre.Margin = new Padding(4, 12, 4, 12);

                controles.lblFecha.Dock = DockStyle.Fill;
                controles.lblFecha.Margin = new Padding(4, 12, 4, 12);

                controles.lblMonto.Dock = DockStyle.Fill;
                controles.lblMonto.Margin = new Padding(4, 12, 4, 12);

                controles.btnCompletar.Dock = DockStyle.Fill;
                controles.btnCompletar.Margin = new Padding(6, 12, 6, 12);
            }

            // Spacer final
            int spacerIndex = tableLayoutGastosProgramados.RowCount;
            tableLayoutGastosProgramados.RowCount++;
            tableLayoutGastosProgramados.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Panel spacer = new Panel { BackColor = Color.Transparent, Dock = DockStyle.Fill };
            tableLayoutGastosProgramados.Controls.Add(spacer, 0, spacerIndex);
            tableLayoutGastosProgramados.SetColumnSpan(spacer, tableLayoutGastosProgramados.ColumnCount);

            tableLayoutGastosProgramados.ResumeLayout();
        }

        private (Label lblNombre, Label lblFecha, Label lblMonto, Button btnCompletar) CrearControlesGastoProgramado(GastosProgramados gasto, bool esMesActual)
        {
            // Colores según el mes
            Color colorFecha = esMesActual ? Color.DarkSlateGray : Color.SaddleBrown;
            string textoFecha = esMesActual
                ? gasto.FechaGasto.ToString("dd/MM/yyyy")
                : $"{gasto.FechaGasto:dd/MM/yyyy} (Próx. mes)";

            Label lblNombre = new Label
            {
                Text = gasto.NombreGasto,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = esMesActual ? Color.Black : Color.DimGray,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            Label lblFecha = new Label
            {
                Text = textoFecha,
                Font = new Font("Segoe UI", 9.5F, esMesActual ? FontStyle.Regular : FontStyle.Bold),
                ForeColor = colorFecha,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblMonto = new Label
            {
                Text = $"{gasto.CantidadGasto:N2} €",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = esMesActual ? Color.DarkRed : Color.IndianRed, // Tono más suave si es del próximo mes
                TextAlign = ContentAlignment.MiddleRight
            };

            Button btnCompletar = new Button
            {
                Text = gasto.Completado ? "✔" : "✚",
                FlatStyle = FlatStyle.Flat,
                Tag = gasto.Id,
                Enabled = !gasto.Completado
            };
            btnCompletar.FlatAppearance.BorderSize = 0;

            btnCompletar.Click += (s, e) =>
            {
                if (MessageBox.Show($"¿Marcar el gasto '{gasto.NombreGasto}' como pagado/completado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var registro = datalinq.GastosProgramados.FirstOrDefault(x => x.Id == gasto.Id);
                    if (registro != null)
                    {
                        registro.Completado = true;
                        try
                        {
                            datalinq.SubmitChanges();
                            CargaGastosProgramados();
                            CargaPanelesMetricas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al marcar gasto como completado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            };

            return (lblNombre, lblFecha, lblMonto, btnCompletar);
        }

        //======================================================
        //        CARGA DE DATOS AL PANEL EDICION
        //======================================================

        // Carga de datos al datagridView
        private void CargaDatagridEditable()
        {
            // Variable para formatear los valores monetarios en Euros
            var euro = new System.Globalization.CultureInfo("es-ES");

            var datos = datalinq.vw_datagrid1
                .OrderByDescending(t => t.Fecha_Operacion)
                .Select(t => new
                {
                    t.Fecha_Operacion,
                    t.Concepto,
                    t.Categoria,
                    Importe = t.Importe.Value.ToString("C2", euro),
                    Saldo = t.Saldo.Value.ToString("C2", euro)
                })
                .ToList();
            dataGridViewEdicion.DataSource = datos;

            // Formateamos la tabla visualmente
            dataGridViewEdicion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewEdicion.Columns["Fecha_Operacion"].HeaderText = "Fecha";

            dataGridViewEdicion.Columns["Fecha_Operacion"].FillWeight = 20;
            dataGridViewEdicion.Columns["Concepto"].FillWeight = 40;
            dataGridViewEdicion.Columns["Categoria"].FillWeight = 20;
            dataGridViewEdicion.Columns["Importe"].FillWeight = 10;
            dataGridViewEdicion.Columns["Saldo"].FillWeight = 10;

            // Hacemos que las filas alternen de color para facilitar la lectura
            dataGridViewEdicion.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 250);


        }

        // Carga de categorias nuevas al SQL server mediante lectura de la tabla Transacciones
        // y a los combo box de filtro y edicion
        private void CargaCategoriasNuevas()
        {
            var nuevas = datalinq.Transacciones
                .Where(t => t.Categoria != null)
                .GroupBy(t => t.Categoria)
                .Select(g => new
                {
                    Categoria = g.Key,
                    Concepto = g.Select(x => x.Concepto).FirstOrDefault()
                })
                .OrderBy(x => x.Categoria)
                .ToList();

            var existentes = new HashSet<string>(datalinq.Categorias.Select(c => c.CategoriaNombre));

            var porInsertar = nuevas
                .Where(n => !existentes.Contains(n.Categoria))
                .Select(n => new Categorias
                {
                    CategoriaNombre = n.Categoria,
                    Concepto = n.Concepto
                })
                .ToList();

            if (porInsertar.Any())
            {
                datalinq.Categorias.InsertAllOnSubmit(porInsertar);
                datalinq.SubmitChanges();
            }

            // Actualizamos los combo box de filtro y edición 
            var listaCategorias = datalinq.Categorias.Select(c => c.CategoriaNombre).ToArray();
            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.AddRange(listaCategorias);
            cmbCategoriasDisponibles.Items.Clear();
            cmbCategoriasDisponibles.Items.AddRange(listaCategorias);
        }



        //======================================================
        //        BOTONES DE CONTROL DE PANELES PRINCIPALES
        //======================================================


        // Evento clic para el botón 'Dashboard'. Muestra el panel principal y oculta las demás vistas.
        private void btnMenuDashboard_Click(object sender, EventArgs e)
        {
            // Cambiamos de visibilidad de paneles de contenido
            panelDashboard.Visible = true;
            panelDashboard.Enabled = true;
            lbDashboard.Visible = true;

            panelAnalitica.Visible = false;
            panelAnalitica.Enabled = false;
            lbAnalitica.Visible = false;

            panelPlanificacion.Visible = false;
            panelPlanificacion.Enabled = false;
            lbPlanificacion.Visible = false;

            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
            lbEdicion.Visible = false;
        }

        // Evento clic para el botón 'Analítica'. Muestra el panel de analítica y oculta las demás vistas.
        private void btnMenuAnalitica_Click(object sender, EventArgs e)
        {
            // Cambiamos de visibilidad de paneles de contenido
            panelDashboard.Visible = false;
            panelDashboard.Enabled = false;
            lbDashboard.Visible = false;

            panelAnalitica.Visible = true;
            panelAnalitica.Enabled = true;
            lbAnalitica.Visible = true;

            panelPlanificacion.Visible = false;
            panelPlanificacion.Enabled = false;
            lbPlanificacion.Visible = false;

            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
            lbEdicion.Visible = false;

            // Filtro de mes y año por defecto
            combFiltroMes.SelectedIndex = DateTime.Now.Month;
            combFiltroAnio.SelectedValue = DateTime.Now.Year;

            CargaPieChart();
            CargaGastosVSIngresos();
            CargaTop10Gastos();
            EvolucionDeSueldo();
            CargarFiltroAños();
        }

        private void pieChart1_DataClick(object sender, LiveCharts.ChartPoint chartPoint)
        {
            // chartPoint.SeriesView.Title contiene el nombre de la Categoría seleccionada
            string categoriaSeleccionada = chartPoint.SeriesView.Title;

            // Llamamos al filtro para actualizar el DataGridView
            CargaFiltroPieChart(categoriaSeleccionada);
        }

        // Actualizacion de PieChart1 al cambiar de mes
        private void combFiltroMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaPieChart();
            CargaTop10Gastos();
            EvolucionDeSueldo();
        }

        // Actualizacion de PieChart1 al cambiar de año
        private void combFiltroAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaPieChart();
            CargaTop10Gastos();
            EvolucionDeSueldo();
        }

        // Evento clic para el botón 'Planificación'. Muestra el panel de planificación y oculta las demás vistas.
        private void btnMenuPlanificacion_Click(object sender, EventArgs e)
        {
            // Cambiamos de visibilidad de paneles de contenido
            panelDashboard.Visible = false;
            panelDashboard.Enabled = false;
            lbDashboard.Visible = false;

            panelAnalitica.Visible = false;
            panelAnalitica.Enabled = false;
            lbAnalitica.Visible = false;

            panelPlanificacion.Visible = true;
            panelPlanificacion.Enabled = true;
            lbPlanificacion.Visible = true;

            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
            lbEdicion.Visible = false;

            CargarTarjetasLimites();
            CargarTarjetasMetas();
            CargaGastosProgramados();
            CargaPanelesMetricas();
        }

        // Evento clic para el botón 'Edición'. Muestra el panel de edición y oculta las demás vistas.
        private void btnMenuEdicion_Click(object sender, EventArgs e)
        {
            // Cambiamos de visibilidad de paneles de contenido
            panelDashboard.Visible = false;
            panelDashboard.Enabled = false;
            lbDashboard.Visible = false;

            panelAnalitica.Visible = false;
            panelAnalitica.Enabled = false;
            lbAnalitica.Visible = false;

            panelPlanificacion.Visible = false;
            panelPlanificacion.Enabled = false;
            lbPlanificacion.Visible = false;

            panelEdicion.Visible = true;
            panelEdicion.Enabled = true;
            lbEdicion.Visible = true;

            CargaCategoriasNuevas();
            CargaDatagridEditable();
        }
    }
}