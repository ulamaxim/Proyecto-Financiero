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
            dataGridView1.Columns["Fecha_Operacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["Fecha_Operacion"].FillWeight = 80;
            dataGridView1.Columns["Fecha_Operacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Formateamos Concepto
            dataGridView1.Columns["Concepto"].FillWeight = 280;

            // Formateamos Categoria
            dataGridView1.Columns["Categoria"].FillWeight = 70;

            // Formateamos Importe
            dataGridView1.Columns["Importe"].FillWeight = 45;
            dataGridView1.Columns["Importe"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Importe"].DefaultCellStyle.FormatProvider = euro;
            dataGridView1.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Formateamos Saldo
            dataGridView1.Columns["Saldo"].FillWeight = 45;
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

            CargaPieChart();
            FiltrosAnioMesPorDefecto();
            CargaGastosVSIngresos();
            CargaTop10Gastos();
            EvolucionDeSueldo();
        }

        private void pieChart1_DataClick(object sender, LiveCharts.ChartPoint chartPoint)
        {
            // chartPoint.SeriesView.Title contiene el nombre de la Categoría seleccionada (ej: "Supermercado")
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
        }

        // Filtros del mes y año selecionados
        private void FiltrosAnioMesPorDefecto()
        {
            // Mes
            combFiltroMes.SelectedIndex = DateTime.Now.Month;

            // Año: Le asignamos directamente el número o string al SelectedValue
            combFiltroAnio.SelectedValue = DateTime.Now.Year;
        }
    }
}