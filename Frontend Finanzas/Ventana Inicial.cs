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
        #region === VARIABLES Y OBJETOS GLOBALES ===

        // Instancia del contexto de LINQ to SQL para interactuar con la base de datos
        DataClasses1DataContext datalinq = new DataClasses1DataContext();

        #endregion

        #region === INICIALIZACIÓN Y CARGA PRINCIPAL ===

        /// <summary>
        /// Constructor principal del formulario. Inicializa los componentes de la interfaz de usuario.
        /// </summary>
        public Ventana_Inicial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento de carga inicial del formulario. Sincroniza datos, actualiza controles y establece el estado predeterminado de los paneles.
        /// </summary>
        private void Ventana_Inicial_Load(object sender, EventArgs e)
        {
            // Carga de la vista de años en el DataSet predeterminado
            this.vw_Filtro_AñosTableAdapter.Fill(this.finanzasDBDataSet.vw_Filtro_Años);

            // 1. Ejecución del script de Python para el procesamiento y sincronización de datos
            EjecutarScriptPython();

            // 2. Carga de los registros procesados en la tabla principal
            CargarTransacciones();

            // 3. Configuración inicial de visibilidad de vistas (Dashboard activo por defecto)
            MostrarPanelPrincipal(panelDashboard, lbDashboard);
            OcultarPanel(panelAnalitica, lbAnalitica);
            OcultarPanel(panelPlanificacion, lbPlanificacion);
            OcultarPanel(panelEdicion, lbEdicion);
        }

        #endregion

        #region === INTEGRACIÓN CON PYTHON ===

        /// <summary>
        /// Ejecuta en segundo plano un script de Python encargado de la limpieza e inserción de datos en SQL Server.
        /// </summary>
        private void EjecutarScriptPython()
        {
            // Rutas dinámicas basadas en el perfil de usuario activo en Windows
            string carpetaUsuario = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string pythonPath = Path.Combine(carpetaUsuario, @"AppData\Local\Programs\Python\Python39\python.exe");
            string scriptPath = Path.Combine(carpetaUsuario, @"source\repos\Proyecto Financiero\Backend Finanzas\BackendFinanzas.py");

            // Validación de existencia de archivos requeridos
            if (!File.Exists(pythonPath))
            {
                throw new FileNotFoundException($"No se pudo encontrar el ejecutable de Python en:\n{pythonPath}");
            }

            if (!File.Exists(scriptPath))
            {
                throw new FileNotFoundException($"No se pudo encontrar el script de Python en:\n{scriptPath}");
            }

            // Configuración del proceso silencioso (sin ventana de consola)
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = pythonPath,
                Arguments = $"\"{scriptPath}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                StandardOutputEncoding = System.Text.Encoding.UTF8,
                StandardErrorEncoding = System.Text.Encoding.UTF8
            };

            // Ejecución y captura de salida de errores
            using (Process proceso = Process.Start(start))
            {
                proceso.WaitForExit();

                using (StreamReader reader = proceso.StandardError)
                {
                    string erroresPython = reader.ReadToEnd();
                    if (!string.IsNullOrEmpty(erroresPython))
                    {
                        MessageBox.Show($"Python ejecutó con errores:\n\n{erroresPython}", "Error en Script de Python", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Actualización de categorías asignadas en la base de datos tras la sincronización
            ActualizacionTransacciones();
        }

        #endregion

        #region === MÓDULO DASHBOARD Y TABLA PRINCIPAL ===

        /// <summary>
        /// Consulta las transacciones mediante LINQ, vincula los datos al DataGridView y recalcula métricas del Dashboard.
        /// </summary>
        public void CargarTransacciones()
        {
            var transactions = from vw in datalinq.vw_datagrid1
                               select vw;

            dataGridView1.DataSource = transactions;

            FormatearDiseñoTabla();
            SaldoIngresosGastos(transactions);
        }

        /// <summary>
        /// Aplica formatos visuales, anchos de columna y estilo de moneda (EUR) a la tabla principal.
        /// </summary>
        private void FormatearDiseñoTabla()
        {
            CultureInfo euro = new CultureInfo("es-ES");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumnHeadersHeight();

            // Columna: Fecha
            dataGridView1.Columns["Fecha_Operacion"].HeaderText = "Fecha";
            dataGridView1.Columns["Fecha_Operacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["Fecha_Operacion"].FillWeight = 12;
            dataGridView1.Columns["Fecha_Operacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Columna: Concepto
            dataGridView1.Columns["Concepto"].FillWeight = 48;

            // Columna: Categoría
            dataGridView1.Columns["Categoria"].FillWeight = 20;

            // Columna: Importe
            dataGridView1.Columns["Importe"].FillWeight = 10;
            dataGridView1.Columns["Importe"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Importe"].DefaultCellStyle.FormatProvider = euro;
            dataGridView1.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Columna: Saldo
            dataGridView1.Columns["Saldo"].FillWeight = 10;
            dataGridView1.Columns["Saldo"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Saldo"].DefaultCellStyle.FormatProvider = euro;
            dataGridView1.Columns["Saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Estilo de filas alternadas
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 250);
        }

        /// <summary>
        /// Calcula y actualiza las etiquetas con el saldo total, ingresos y gastos del último mes disponible.
        /// </summary>
        /// <param name="transactions">Colección de transacciones para el cálculo.</param>
        private void SaldoIngresosGastos(IEnumerable<vw_datagrid1> transactions)
        {
            CultureInfo euro = new CultureInfo("es-ES");

            // Muestra el saldo global actual (primer registro)
            lblSaldoValor.Text = (transactions.FirstOrDefault()?.Saldo ?? 0).ToString("C2", euro);

            // Determinación del último mes registrado en el dataset
            DateTime ultimaFecha = transactions
                .Where(i => i.Fecha_Operacion.HasValue)
                .Max(i => i.Fecha_Operacion.Value);

            int mesLim = ultimaFecha.Month;
            int añoLim = ultimaFecha.Year;

            // Sumatoria de ingresos (valores positivos) del último mes
            decimal ingresos = transactions
                .Where(i => i.Fecha_Operacion.Value.Month == mesLim &&
                            i.Fecha_Operacion.Value.Year == añoLim)
                .Where(i => i.Importe.HasValue && i.Importe > 0)
                .Sum(i => i.Importe.Value);

            // Sumatoria de gastos (valores negativos) del último mes
            decimal gastos = transactions
                .Where(i => i.Fecha_Operacion.Value.Month == mesLim &&
                            i.Fecha_Operacion.Value.Year == añoLim)
                .Where(g => g.Importe.HasValue && g.Importe < 0)
                .Sum(g => g.Importe.Value);

            // Asignación de resultados a los controles visuales
            lblIngresosValor.Text = ingresos.ToString("C2", euro);
            lblGastosValor.Text = gastos.ToString("C2", euro);
        }

        #endregion

        #region === MÓDULO DE ANALÍTICA (GRÁFICOS Y ESTADÍSTICAS) ===

        /// <summary>
        /// Configura y carga el gráfico circular (PieChart) de gastos desglosados por categoría según los filtros seleccionados.
        /// </summary>
        private void CargaPieChart()
        {
            // Obtención de la fuente de datos original del DataGridView principal
            var transactions = (IEnumerable<vw_datagrid1>)dataGridView1.DataSource;

            // Filtrado de mes y año según selección del usuario
            int? mesSeleccionado = combFiltroMes.SelectedIndex > 0 ? (int?)combFiltroMes.SelectedIndex : null;
            object valorAnio = combFiltroAnio.SelectedValue ?? combFiltroAnio.SelectedItem;
            int? anioSeleccionado = null;

            if (valorAnio != null && int.TryParse(valorAnio.ToString(), out int anioParseado))
            {
                anioSeleccionado = anioParseado;
            }

            // Agrupación y sumatoria de gastos por categoría
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

            // Cálculo del total de gastos para determinar proporciones
            decimal totalGastos = gastosPieChart.Sum(x => x.Total);
            var euro = new CultureInfo("es-ES");
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

            // Creación de series para el PieChart, ocultando etiquetas para proporciones menores al 4%
            foreach (var item in gastosPieChart)
            {
                decimal porcentaje = totalGastos > 0 ? (item.Total / totalGastos) : 0;
                bool mostrarEtiqueta = porcentaje >= 0.04m; // Oculta etiquetas para proporciones < 4%

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

            // Configuración final del PieChart
            pieChart1.Series = series;
            pieChart1.InnerRadius = 40;
            pieChart1.LegendLocation = LiveCharts.LegendLocation.Top;

            pieChart1.DataClick -= pieChart1_DataClick;
            pieChart1.DataClick += pieChart1_DataClick;

            pieChart1.DataTooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.OnlySender
            };
        }

        /// <summary>
        /// Manejador de clic sobre las secciones del PieChart para filtrar la tabla auxiliar por categoría.
        /// </summary>
        private void pieChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            string categoriaSeleccionada = chartPoint.SeriesView.Title;
            CargaFiltroPieChart(categoriaSeleccionada);
        }

        /// <summary>
        /// Carga los años disponibles existentes en la base de datos dentro del ComboBox de filtros.
        /// </summary>
        private void CargarFiltroAños()
        {
            var añosDisponibles = datalinq.vw_datagrid1
                .Where(t => t.Fecha_Operacion.HasValue)
                .Select(t => t.Fecha_Operacion.Value.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToList();

            combFiltroAnio.DataSource = añosDisponibles;
        }

        /// <summary>
        /// Filtra y muestra el detalle de los gastos de la categoría seleccionada en el DataGridView auxiliar.
        /// </summary>
        private void CargaFiltroPieChart(string categoria)
        {
            // Obtención de la fuente de datos original del DataGridView principal
            var transactions = (IEnumerable<vw_datagrid1>)dataGridView1.DataSource;

            // Filtrado de mes y año según selección del usuario
            int? mesSeleccionado = combFiltroMes.SelectedIndex > 0 ? (int?)combFiltroMes.SelectedIndex : null;
            object valorAnio = combFiltroAnio.SelectedValue ?? combFiltroAnio.SelectedItem;
            int? anioSeleccionado = null;

            // Validación y parseo del año seleccionado
            if (valorAnio != null && int.TryParse(valorAnio.ToString(), out int anioParseado) && anioParseado > 0)
            {
                anioSeleccionado = anioParseado;
            }

            // Filtrado de transacciones por categoría, mes y año, mostrando solo gastos (importe negativo)
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
                    Gasto = Math.Abs(i.Importe.Value).ToString("C2", new CultureInfo("es-ES"))
                })
                .ToList();

            // Configuración del DataGridView auxiliar para mostrar los detalles filtrados
            dataGridPieChartFiltro.DataSource = filtroPieChart;
            dataGridPieChartFiltro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPieChartFiltro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 250);
            dataGridPieChartFiltro.RowHeadersVisible = false;
            dataGridPieChartFiltro.Columns["Descripcion"].FillWeight = 240;
            dataGridPieChartFiltro.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // Manejador del evento de selección del mes en el ComboBox de filtros.
        private void combFiltroMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaPieChart();
            CargaTop10Gastos();
            EvolucionDeSueldo();
        }

        // Manejador del evento de selección del año en el ComboBox de filtros.
        private void combFiltroAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaPieChart();
            CargaTop10Gastos();
            EvolucionDeSueldo();
        }

        /// <summary>
        /// Genera la comparativa en gráfico de barras entre Ingresos y Gastos de los últimos 6 meses.
        /// </summary>
        private void CargaGastosVSIngresos()
        {
            // Obtención de la fuente de datos original del DataGridView principal
            var transactions = (IEnumerable<vw_datagrid1>)dataGridView1.DataSource;

            // Determinación de la fecha de inicio (5 meses atrás desde el primer día del mes actual)
            DateTime fechaHoy = DateTime.Now;
            DateTime fechaInicio = new DateTime(fechaHoy.Year, fechaHoy.Month, 1).AddMonths(-5);

            var mesesNombres = new List<string>();
            var mesesClaves = new List<(int Anio, int Mes)>();

            // Generación de nombres y claves de los últimos 6 meses
            for (int i = 0; i < 6; i++)
            {
                DateTime fechaMes = fechaInicio.AddMonths(i);
                mesesNombres.Add(fechaMes.ToString("MMM yyyy", new CultureInfo("es-ES")));
                mesesClaves.Add((fechaMes.Year, fechaMes.Month));
            }

            var transaccionesFiltradas = transactions
                .Where(i => i.Fecha_Operacion.HasValue && i.Importe.HasValue && i.Fecha_Operacion.Value >= fechaInicio)
                .ToList();

            var listaIngresos = new ChartValues<decimal>();
            var listaGastos = new ChartValues<decimal>();

            // Cálculo de ingresos y gastos por cada mes clave
            foreach (var clave in mesesClaves)
            {
                decimal totalIngresos = transaccionesFiltradas
                    .Where(t => t.Fecha_Operacion.Value.Year == clave.Anio &&
                                t.Fecha_Operacion.Value.Month == clave.Mes &&
                                t.Importe.Value > 0)
                    .Sum(t => t.Importe.Value);

                decimal totalGastos = Math.Abs(transaccionesFiltradas
                    .Where(t => t.Fecha_Operacion.Value.Year == clave.Anio &&
                                t.Fecha_Operacion.Value.Month == clave.Mes &&
                                t.Importe.Value < 0)
                    .Sum(t => t.Importe.Value));

                listaIngresos.Add(totalIngresos);
                listaGastos.Add(totalGastos);
            }

            // Configuración de la serie de datos para el gráfico de barras
            cartesianChartGastosContraIngresos.Series = new LiveCharts.SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Ingresos",
                    Values = listaIngresos,
                    Fill = System.Windows.Media.Brushes.MediumSeaGreen,
                    MaxColumnWidth = 20,
                    ColumnPadding = 4
                },
                new ColumnSeries
                {
                    Title = "Gastos",
                    Values = listaGastos,
                    Fill = System.Windows.Media.Brushes.IndianRed,
                    MaxColumnWidth = 20,
                    ColumnPadding = 4
                }
            };

            // Configuración de los ejes X e Y del gráfico
            cartesianChartGastosContraIngresos.AxisX.Clear();
            cartesianChartGastosContraIngresos.AxisX.Add(new Axis
            {
                Title = "Meses",
                Labels = mesesNombres,
                Foreground = System.Windows.Media.Brushes.DimGray,
                FontSize = 11,
                Separator = new Separator { IsEnabled = false }
            });

            // Configuración del eje Y con formato de moneda (EUR)
            var euro = new CultureInfo("es-ES");
            cartesianChartGastosContraIngresos.AxisY.Clear();
            cartesianChartGastosContraIngresos.AxisY.Add(new Axis
            {
                Title = "Monto",
                LabelFormatter = value => value.ToString("C0", euro),
                Foreground = System.Windows.Media.Brushes.DimGray,
                FontSize = 11,
                Separator = new Separator
                {
                    IsEnabled = true,
                    Stroke = System.Windows.Media.Brushes.Black,
                    StrokeThickness = 1
                }
            });
        }

        /// <summary>
        /// Muestra el top 10 de transacciones de mayor importe negativo según el filtro activo.
        /// </summary>
        private void CargaTop10Gastos()
        {
            // Obtención de la fuente de datos original del DataGridView principal
            var transactions = (IEnumerable<vw_datagrid1>)dataGridView1.DataSource;

            // Filtrado de mes y año según selección del usuario
            int? mesSeleccionado = combFiltroMes.SelectedIndex > 0 ? (int?)combFiltroMes.SelectedIndex : null;
            object valorAnio = combFiltroAnio.SelectedValue ?? combFiltroAnio.SelectedItem;
            int? anioSeleccionado = null;

            if (valorAnio != null && int.TryParse(valorAnio.ToString(), out int anioParseado) && anioParseado > 0)
            {
                anioSeleccionado = anioParseado;
            }

            // Selección de las 10 transacciones con mayor gasto (importe negativo) según los filtros aplicados
            var top10Gastos = transactions
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
                    Gasto = Math.Abs(i.Importe.Value).ToString("C2", new CultureInfo("es-ES"))
                })
                .ToList();

            // Configuración del DataGridView para mostrar el top 10 de gastos
            dataGridTopGastos.DataSource = top10Gastos;
            dataGridTopGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTopGastos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 200, 200);
            dataGridTopGastos.RowHeadersVisible = false;
            dataGridTopGastos.Columns["Descripcion"].FillWeight = 240;
            dataGridTopGastos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        /// <summary>
        /// Dibuja la línea de tendencia de evolución del saldo para el rango temporal seleccionado.
        /// </summary>
        private void EvolucionDeSueldo()
        {
            // Obtención de la fuente de datos original del DataGridView principal
            var transactions = (IEnumerable<vw_datagrid1>)dataGridView1.DataSource;

            // Filtrado de mes y año según selección del usuario
            int? mesSeleccionado = combFiltroMes.SelectedIndex > 0 ? (int?)combFiltroMes.SelectedIndex : null;
            object valorAnio = combFiltroAnio.SelectedValue ?? combFiltroAnio.SelectedItem;
            int? anioSeleccionado = null;

            if (valorAnio != null && int.TryParse(valorAnio.ToString(), out int anioParseado) && anioParseado > 0)
            {
                anioSeleccionado = anioParseado;
            }

            // Filtrado y ordenamiento de las transacciones para la evolución del saldo
            var evolucionSaldo = transactions
                .Where(i => i.Importe.HasValue)
                .Where(i => (!mesSeleccionado.HasValue || i.Fecha_Operacion.Value.Month == mesSeleccionado.Value) &&
                            (!anioSeleccionado.HasValue || i.Fecha_Operacion.Value.Year == anioSeleccionado.Value))
                .OrderBy(i => i.Fecha_Operacion.Value)
                .ToList();

            // Validación de existencia de datos para evitar errores en el gráfico
            if (!evolucionSaldo.Any())
            {
                cartesianChartEvolucionSaldo.Series.Clear();
                cartesianChartEvolucionSaldo.AxisX.Clear();
                return;
            }

            // Preparación de valores y etiquetas para el gráfico de línea
            var valoresSaldo = new ChartValues<decimal>();
            var etiquetasFechas = new List<string>();

            // Iteración sobre las transacciones filtradas para extraer los valores de saldo y las fechas correspondientes
            foreach (var item in evolucionSaldo)
            {
                valoresSaldo.Add(item.Saldo.Value);
                etiquetasFechas.Add(item.Fecha_Operacion.Value.ToString("dd/MM"));
            }

            // Configuración de la cultura para el formato de moneda (EUR)
            var euro = new CultureInfo("es-ES");

            // Configuración de la serie de línea para el gráfico de evolución del saldo
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

            // Asignación de la serie al gráfico y configuración del eje X con las etiquetas de fechas
            cartesianChartEvolucionSaldo.Series = new LiveCharts.SeriesCollection { lineaY };
            cartesianChartEvolucionSaldo.AxisX.Clear();
            cartesianChartEvolucionSaldo.AxisX.Add(new Axis
            {
                Title = "Fecha",
                Labels = etiquetasFechas,
                Foreground = System.Windows.Media.Brushes.DimGray,
                FontSize = 10,
                LabelsRotation = 45,
                Separator = new Separator
                {
                    Step = 2,
                    IsEnabled = false,
                }
            });
        }

        #endregion

        #region === MÓDULO DE PLANIFICACIÓN (PRESUPUESTOS, METAS Y PROGRAMACIÓN) ===

        #region -- Métricas Globales --

        /// <summary>
        /// Calcula el presupuesto mensual disponible en función del sueldo y gastos pendientes.
        /// </summary>
        private void CargaPanelesMetricas()
        {
            // Configuración de la cultura para el formato de moneda (EUR)
            var euro = new CultureInfo("es-ES");

            // Cálculo del presupuesto mensual basado en transacciones de nómina del mes actual
            decimal presupuestoMes = datalinq.vw_datagrid1
                .Where(t => t.Fecha_Operacion.HasValue &&
                            t.Fecha_Operacion.Value.Month == DateTime.Now.Month &&
                            t.Fecha_Operacion.Value.Year == DateTime.Now.Year)
                .Where(t => t.Importe.HasValue && t.Importe > 0)
                .Where(t => t.Categoria == "Nomina")
                .Sum(t => t.Importe.Value);

            // Cálculo de los gastos programados pendientes del mes actual
            decimal gastosMes = datalinq.GastosProgramados
                .Where(g => g.FechaGasto.Month == DateTime.Now.Month &&
                            g.FechaGasto.Year == DateTime.Now.Year)
                .Where(g => g.Completado == false)
                .Sum(g => (decimal?)g.CantidadGasto) ?? 0m;

            decimal ahorroDisponible = presupuestoMes - gastosMes;

            // Actualización de las etiquetas del panel de métricas con los valores calculados
            lblPresupuestoMes.Text = "Presupuesto del mes: " + presupuestoMes.ToString("C2", euro);
            lblGastosAsignados.Text = "Gastos asignados: " + gastosMes.ToString("C2", euro);
            lblAhorroDisponible.Text = "Ahorro Disponible: " + ahorroDisponible.ToString("C2", euro);
        }

        #endregion

        #region -- Límites de Gastos por Categoría --

        /// <summary>
        /// Genera dinámicamente las tarjetas de límites presupuestarios por categoría mediante controles en un TableLayoutPanel.
        /// </summary>
        private void CargarTarjetasLimites()
        {
            // Limpieza y preparación del TableLayoutPanel para la inserción de nuevas filas
            tableLayoutLimitesPorCategoria.SuspendLayout();
            tableLayoutLimitesPorCategoria.Controls.Clear();
            tableLayoutLimitesPorCategoria.RowStyles.Clear();
            tableLayoutLimitesPorCategoria.RowCount = 0;

            // Configuración de columnas: Categoría, Barra de Progreso, Valores y Botón de Edición
            tableLayoutLimitesPorCategoria.ColumnCount = 4;
            tableLayoutLimitesPorCategoria.ColumnStyles.Clear();
            tableLayoutLimitesPorCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutLimitesPorCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutLimitesPorCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutLimitesPorCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));

            // Consulta de gastos agrupados por categoría para el mes actual
            var resumenGastos = datalinq.vw_datagrid1
                .Where(t => t.Importe.HasValue && t.Importe < 0 && t.Fecha_Operacion.Value.Month == DateTime.Now.Month)
                .GroupBy(t => t.Categoria)
                .Select(g => new
                {
                    Categoria = g.Key,
                    Gastado = Math.Abs((double)g.Sum(t => t.Importe.Value))
                })
                .ToList();

            var limitesBD = datalinq.Limites.ToDictionary(l => l.Categoria, l => (double)l.Limite);

            // Iteración sobre cada categoría para crear y agregar controles dinámicos al TableLayoutPanel
            foreach (var item in resumenGastos)
            {
                int rowIndex = tableLayoutLimitesPorCategoria.RowCount;
                tableLayoutLimitesPorCategoria.RowCount++;
                tableLayoutLimitesPorCategoria.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                double limitePresupuesto = limitesBD.ContainsKey(item.Categoria) ? limitesBD[item.Categoria] : 0;
                var tuple = CrearControlesFila(item.Categoria, item.Gastado, limitePresupuesto);

                tableLayoutLimitesPorCategoria.Controls.Add(tuple.lblCategoria, 0, rowIndex);
                tableLayoutLimitesPorCategoria.Controls.Add(tuple.pnlBarraFondo, 1, rowIndex);
                tableLayoutLimitesPorCategoria.Controls.Add(tuple.lblValores, 2, rowIndex);
                tableLayoutLimitesPorCategoria.Controls.Add(tuple.btnEditar, 3, rowIndex);

                tuple.lblCategoria.Dock = DockStyle.Fill;
                tuple.lblCategoria.Margin = new Padding(4, 10, 4, 10);

                tuple.pnlBarraFondo.Dock = DockStyle.Fill;
                tuple.pnlBarraFondo.Margin = new Padding(4, 18, 4, 12);

                tuple.lblValores.Dock = DockStyle.Fill;
                tuple.lblValores.Margin = new Padding(4, 12, 4, 12);

                tuple.btnEditar.Dock = DockStyle.Fill;
                tuple.btnEditar.Margin = new Padding(6, 12, 6, 12);
            }

            // Espaciador inferior flexible
            int spacerRowIndex = tableLayoutLimitesPorCategoria.RowCount;
            tableLayoutLimitesPorCategoria.RowCount++;
            tableLayoutLimitesPorCategoria.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Panel pnlSpacer = new Panel { BackColor = Color.Transparent, Dock = DockStyle.Fill };
            tableLayoutLimitesPorCategoria.Controls.Add(pnlSpacer, 0, spacerRowIndex);
            tableLayoutLimitesPorCategoria.SetColumnSpan(pnlSpacer, tableLayoutLimitesPorCategoria.ColumnCount);

            tableLayoutLimitesPorCategoria.ResumeLayout();
        }

        /// <summary>
        /// Crea e inicializa los controles UI necesarios para representar una categoría dentro del panel de límites.
        /// </summary>
        private (Label lblCategoria, Panel pnlBarraFondo, Label lblValores, Button btnEditar) CrearControlesFila(string categoria, double gastado, double limite)
        {
            // Creación de la etiqueta de categoría con estilo y alineación
            Label lblCategoria = new Label
            {
                Text = categoria,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                AutoEllipsis = true,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Panel pnlBarraFondo = new Panel { BackColor = Color.FromArgb(230, 230, 230) };

            // Determinación del color de relleno de la barra según el porcentaje gastado respecto al límite
            Color colorRelleno = Color.Transparent;
            if (limite > 0)
            {
                double pctTemp = (gastado / limite) * 100.0;
                colorRelleno = pctTemp < 70 ? Color.MediumSeaGreen : pctTemp < 90 ? Color.Goldenrod : Color.IndianRed;
            }

            // Creación del panel de relleno que representa visualmente el porcentaje gastado
            Panel pnlBarraRelleno = new Panel
            {
                BackColor = colorRelleno,
                Width = 0,
                Height = 12,
                Dock = DockStyle.Left
            };
            pnlBarraFondo.Controls.Add(pnlBarraRelleno);

            // Creación de la etiqueta que muestra los valores gastados y el límite en formato monetario
            Label lblValores = new Label
            {
                Text = $"{gastado:N0}€/{limite:N0}€",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleRight
            };

            // Creación del botón de edición con icono y estilo plano, asociado a la categoría correspondiente
            Button btnEditar = new Button
            {
                Text = "✏️",
                FlatStyle = FlatStyle.Flat,
                Tag = categoria
            };
            btnEditar.FlatAppearance.BorderSize = 0;

            // Ajuste dinámico del ancho de la barra de progreso según el tamaño del panel contenedor y los valores actuales
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

            // Manejador del evento de clic del botón de edición para mostrar un diálogo de modificación del límite
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

        /// <summary>
        /// Despliega una ventana emergente modal para modificar el límite monetario asignado a una categoría.
        /// </summary>
        private bool MostrarDialogoLimite(string categoria, double limiteActual, out decimal nuevoLimite)
        {
            // Inicialización de la variable de salida
            nuevoLimite = 0;
            using (Form dlg = new Form())
            {
                // Configuración básica del formulario de diálogo
                dlg.Text = $"Editar límite - {categoria}";
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.ClientSize = new Size(300, 110);
                dlg.MinimizeBox = false;
                dlg.MaximizeBox = false;

                // Creación de controles internos: etiqueta, cuadro de texto y botones
                Label lbl = new Label { Text = "Límite (€):", Location = new Point(12, 15), AutoSize = true };
                TextBox txt = new TextBox { Location = new Point(90, 12), Width = 180, Text = limiteActual.ToString("F0") };
                Button ok = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(110, 60), Width = 70 };
                Button cancel = new Button { Text = "Cancelar", DialogResult = DialogResult.Cancel, Location = new Point(190, 60), Width = 70 };

                // Adición de controles al formulario de diálogo
                dlg.Controls.Add(lbl);
                dlg.Controls.Add(txt);
                dlg.Controls.Add(ok);
                dlg.Controls.Add(cancel);

                dlg.AcceptButton = ok;
                dlg.CancelButton = cancel;

                // Despliegue del diálogo y validación de la entrada del usuario
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

        #endregion

        #region -- Metas de Ahorro --

        /// <summary>
        /// Maneja el evento de clic del botón para agregar una nueva meta de ahorro.
        /// </summary>
        private void btAnadirMeta_Click(object sender, EventArgs e)
        {
            panelEdicionMetas.Visible = true;
            panelEdicionMetas.Enabled = true;
        }

        /// <summary>
        /// Maneja el evento de clic del botón para cancelar la edición de una meta de ahorro.
        /// </summary>
        private void btCancelarMeta_Click(object sender, EventArgs e)
        {
            panelEdicionMetas.Visible = false;
            panelEdicionMetas.Enabled = false;
            txtNombreMeta.Clear();
            txtSaldoNecesario.Clear();
        }

        /// <summary>
        /// Maneja el evento de clic del botón para aceptar la edición de una meta de ahorro.
        /// </summary>
        private void btAceptarMetaNueva_Click(object sender, EventArgs e)
        {
            // Validación de los campos de entrada para la nueva meta de ahorro
            string nombre = txtNombreMeta.Text?.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce un nombre para la meta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreMeta.Focus();
                return;
            }

            // Validación del monto necesario para la meta de ahorro
            if (!decimal.TryParse(txtSaldoNecesario.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Introduce un importe válido mayor que 0.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaldoNecesario.Focus();
                return;
            }

            // Creación de la nueva meta de ahorro y persistencia en la base de datos
            try
            {
                MetasAhorro nueva = new MetasAhorro
                {
                    Concepto = nombre,
                    MontoObjetivo = monto,
                    Completada = false,
                    FechaCreacion = DateTime.Now
                };

                datalinq.MetasAhorro.InsertOnSubmit(nueva);
                datalinq.SubmitChanges();

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

        /// <summary>
        /// Consulta y dibuja las tarjetas correspondientes a metas de ahorro vigentes.
        /// </summary>
        private void CargarTarjetasMetas()
        {
            // Limpieza y preparación del TableLayoutPanel para la inserción de nuevas filas
            tableLayoutMetasAhorro.SuspendLayout();
            tableLayoutMetasAhorro.Controls.Clear();
            tableLayoutMetasAhorro.RowStyles.Clear();
            tableLayoutMetasAhorro.RowCount = 0;

            // Configuración de columnas: Nombre de la meta, Barra de progreso, Valores y Botón de completar
            tableLayoutMetasAhorro.ColumnCount = 4;
            tableLayoutMetasAhorro.ColumnStyles.Clear();
            tableLayoutMetasAhorro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutMetasAhorro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMetasAhorro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutMetasAhorro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));

            // Consulta de metas de ahorro no completadas, ordenadas por fecha de creación
            var metas = datalinq.MetasAhorro
                .Where(m => m.Completada == false)
                .OrderBy(m => m.FechaCreacion)
                .ToList();

            // Obtención del saldo disponible global a partir de la última transacción registrada
            var primerSaldoNullable = datalinq.vw_datagrid1
                .OrderByDescending(t => t.Fecha_Operacion)
                .Select(t => t.Saldo)
                .FirstOrDefault();
            decimal saldoDisponibleGlobal = primerSaldoNullable.HasValue ? primerSaldoNullable.Value : 0m;

            // Variable para llevar el saldo restante a medida que se asigna a cada meta
            decimal restante = saldoDisponibleGlobal;
            foreach (var meta in metas)
            {
                // Creación de una nueva fila en el TableLayoutPanel para cada meta de ahorro
                int row = tableLayoutMetasAhorro.RowCount;
                tableLayoutMetasAhorro.RowCount++;
                tableLayoutMetasAhorro.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                var controles = CrearControlesMeta(meta, restante);

                // Adición de los controles creados a la fila correspondiente en el TableLayoutPanel
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

                restante -= meta.MontoObjetivo;
                if (restante < 0) restante = 0;
            }

            // Agregamos un espaciador flexible al final del TableLayoutPanel para que las tarjetas se alineen hacia arriba
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
            // Creación de la etiqueta que muestra el nombre de la meta con estilo y alineación
            Label lblNombre = new Label
            {
                Text = meta.Concepto,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            // Creación del panel de fondo que contendrá la barra de progreso de la meta
            Panel pnlBarraFondo = new Panel { BackColor = Color.FromArgb(230, 230, 230) };

            // Determinación del color de relleno de la barra según el porcentaje del saldo disponible respecto al monto objetivo de la meta
            Color colorRelleno = Color.Transparent;
            if (meta.MontoObjetivo > 0)
            {
                double pct = (double)saldoDisponible / (double)meta.MontoObjetivo * 100.0;
                colorRelleno = pct <= 100 ? Color.Goldenrod : Color.Blue;
            }

            // Creación del panel de relleno que representa visualmente el porcentaje del saldo disponible respecto al monto objetivo de la meta
            Panel pnlBarraRelleno = new Panel { BackColor = colorRelleno, Width = 0, Height = 12, Dock = DockStyle.Left };
            pnlBarraFondo.Controls.Add(pnlBarraRelleno);

            // Creación de la etiqueta que muestra los valores del saldo disponible y el monto objetivo de la meta en formato monetario
            Label lblValores = new Label
            {
                Text = $"{saldoDisponible:N0}€/{meta.MontoObjetivo:N0}€",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleRight
            };

            // Creación del botón de completar meta con icono y estilo plano, asociado al ID de la meta correspondiente
            Button btnCompletar = new Button
            {
                Text = meta.Completada ? "✔" : "✚",
                FlatStyle = FlatStyle.Flat,
                Tag = meta.Id
            };
            btnCompletar.FlatAppearance.BorderSize = 0;
            btnCompletar.Enabled = !meta.Completada;

            // Ajuste dinámico del ancho de la barra de progreso según el tamaño del panel contenedor y los valores actuales
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

            // Manejador del evento de clic del botón de completar meta para marcar la meta como completada en la base de datos
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

        #endregion

        #region -- Gastos Programados --

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

        /// <summary>
        /// Evento click para aceptar y guardar un gasto programado, validando los campos y creando registros según la repetición seleccionada.
        /// </summary>
        private void btAceptarGastosProgramados_Click(object sender, EventArgs e)
        {
            // Validación de los campos de entrada para el gasto programado
            string nombre = txtNombreGasto.Text?.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce un nombre para el gasto programado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreGasto.Focus();
                return;
            }

            // Validación del monto del gasto programado
            if (!decimal.TryParse(txtCantidadGasto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Introduce un importe válido mayor que 0.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadGasto.Focus();
                return;
            }

            // Validación de el tipo de repeticion seleccionado para el gasto programado
            bool repetible = !chkNoRepetible.Checked;
            string repetibleTipo = "No Repetible";

            if (chkSemanal.Checked) repetibleTipo = "Semanal";
            else if (chkMensual.Checked) repetibleTipo = "Mensual";
            else if (chkAnual.Checked) repetibleTipo = "Anual";

            int limiteRegistros = repetible ? 5 : 1;
            DateTime fechaBase = dtPickFechaPago.Value;

            // Creación de los registros de gastos programados según la configuración seleccionada
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

                    // Creación de un nuevo objeto GastosProgramados con los datos proporcionados y la fecha calculada
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

                // Limpieza de los campos de entrada y ocultación del panel de edición
                txtNombreGasto.Clear();
                txtCantidadGasto.Clear();
                panelEdicionGastoProgramados.Visible = false;
                panelEdicionGastoProgramados.Enabled = false;

                CargaGastosProgramados();
                CargaPanelesMetricas();

                MessageBox.Show("Gasto(s) programado(s) guardado(s) correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar gasto programado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga y muestra los pagos futuros o programados en la tabla de planificación.
        /// </summary>
        private void CargaGastosProgramados()
        {
            // Limpieza y preparación del TableLayoutPanel para la inserción de nuevas filas
            tableLayoutGastosProgramados.SuspendLayout();
            tableLayoutGastosProgramados.Controls.Clear();
            tableLayoutGastosProgramados.RowStyles.Clear();
            tableLayoutGastosProgramados.RowCount = 0;

            // Configuración de columnas: Nombre del gasto, Fecha, Monto y Botón de completar
            tableLayoutGastosProgramados.ColumnCount = 4;
            tableLayoutGastosProgramados.ColumnStyles.Clear();
            tableLayoutGastosProgramados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutGastosProgramados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutGastosProgramados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutGastosProgramados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));

            // Consulta de gastos programados no completados, filtrando por el mes actual y el siguiente
            DateTime hoy = DateTime.Today;
            DateTime inicioMesActual = new DateTime(hoy.Year, hoy.Month, 1);
            DateTime limiteExclusivo = inicioMesActual.AddMonths(2);

            var gastosProgramados = datalinq.GastosProgramados
                .Where(g => g.Completado == false
                         && g.FechaGasto >= inicioMesActual
                         && g.FechaGasto < limiteExclusivo)
                .OrderBy(g => g.FechaGasto)
                .ToList();

            // Iteración sobre cada gasto programado para crear y agregar controles dinámicos al TableLayoutPanel
            foreach (var gasto in gastosProgramados)
            {
                // Creación de una nueva fila en el TableLayoutPanel para cada gasto programado
                int row = tableLayoutGastosProgramados.RowCount;
                tableLayoutGastosProgramados.RowCount++;
                tableLayoutGastosProgramados.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                bool esMesActual = gasto.FechaGasto.Month == hoy.Month && gasto.FechaGasto.Year == hoy.Year;

                var controles = CrearControlesGastoProgramado(gasto, esMesActual);

                // Adición de los controles creados a la fila correspondiente en el TableLayoutPanel
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

            // Agregamos un espaciador flexible al final del TableLayoutPanel para que las tarjetas se alineen hacia arriba
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
            // Determinación del color de la fecha y el texto a mostrar según si el gasto es del mes actual o del próximo mes
            Color colorFecha = esMesActual ? Color.DarkSlateGray : Color.SaddleBrown;
            string textoFecha = esMesActual
                ? gasto.FechaGasto.ToString("dd/MM/yyyy")
                : $"{gasto.FechaGasto:dd/MM/yyyy} (Próx. mes)";

            // Creación de la etiqueta que muestra el nombre del gasto con estilo y alineación,
            // ajustando el color según si es del mes actual o no
            Label lblNombre = new Label
            {
                Text = gasto.NombreGasto,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = esMesActual ? Color.Black : Color.DimGray,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            // Creación de la etiqueta que muestra la fecha del gasto con estilo y alineación,
            Label lblFecha = new Label
            {
                Text = textoFecha,
                Font = new Font("Segoe UI", 9.5F, esMesActual ? FontStyle.Regular : FontStyle.Bold),
                ForeColor = colorFecha,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Creación de la etiqueta que muestra el monto del gasto con estilo y alineación,
            Label lblMonto = new Label
            {
                Text = $"{gasto.CantidadGasto:N2} €",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = esMesActual ? Color.DarkRed : Color.IndianRed,
                TextAlign = ContentAlignment.MiddleRight
            };

            // Creación del botón de completar gasto con icono y estilo plano, asociado al ID del gasto correspondiente
            Button btnCompletar = new Button
            {
                Text = gasto.Completado ? "✔" : "✚",
                FlatStyle = FlatStyle.Flat,
                Tag = gasto.Id,
                Enabled = !gasto.Completado
            };
            btnCompletar.FlatAppearance.BorderSize = 0;

            // Manejador del evento de clic del botón de completar gasto para marcar el gasto como completado en la base de datos
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

        #endregion

        #endregion

        #region === MÓDULO DE EDICIÓN Y CATEGORIZACIÓN ===

        /// <summary>
        /// Carga todas las transacciones dentro del DataGridView editable de mantenimiento.
        /// </summary>
        private void CargaDatagridEditable()
        {
            // Configuración de la cultura para el formato monetario en euros
            var euro = new CultureInfo("es-ES");

            // Consulta de todas las transacciones desde la vista vw_datagrid1, ordenadas por fecha de operación descendente,
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

            // Asignación de los datos al DataGridView y configuración de las columnas y estilos visuales
            dataGridViewEdicion.DataSource = datos;
            dataGridViewEdicion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewEdicion.Columns["Fecha_Operacion"].HeaderText = "Fecha";
            dataGridViewEdicion.Columns["Fecha_Operacion"].FillWeight = 20;
            dataGridViewEdicion.Columns["Concepto"].FillWeight = 40;
            dataGridViewEdicion.Columns["Categoria"].FillWeight = 20;
            dataGridViewEdicion.Columns["Importe"].FillWeight = 10;
            dataGridViewEdicion.Columns["Saldo"].FillWeight = 10;

            dataGridViewEdicion.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 250);
            dataGridViewEdicion.CellClick += dataGridViewEdicion_CellClick;
        }

        /// <summary>
        /// Sincroniza la tabla Categorías extrayendo conceptos únicos de la tabla Transacciones.
        /// </summary>
        private void CargaCategoriasNuevas()
        {
            // Consulta de conceptos únicos desde la tabla Transacciones, agrupando por concepto y obteniendo la primera categoría asociada
            var conceptos = datalinq.Transacciones
                .Where(t => t.Concepto != null)
                .GroupBy(t => t.Concepto)
                .Select(g => new
                {
                    Concepto = g.Key,
                    Categoria = g.Select(x => x.Categoria).FirstOrDefault()
                })
                .ToList();

            // Creación de un HashSet para almacenar los conceptos existentes en la tabla Categorías, ignorando mayúsculas y minúsculas
            var existentes = new HashSet<string>(datalinq.Categorias.Select(c => c.Concepto ?? ""), StringComparer.OrdinalIgnoreCase);

            // Filtrado de los conceptos que no existen en la tabla Categorías y creación de nuevas instancias de Categorias para insertar
            var porInsertar = conceptos
                .Where(c => !existentes.Contains(c.Concepto))
                .Select(c => new Categorias
                {
                    CategoriaNombre = c.Categoria,
                    Concepto = c.Concepto
                })
                .ToList();

            // Inserción de los nuevos conceptos en la tabla Categorías si hay alguno por insertar
            if (porInsertar.Any())
            {
                datalinq.Categorias.InsertAllOnSubmit(porInsertar);
                datalinq.SubmitChanges();
            }

            // Actualización de los ComboBox de filtro y categorías disponibles con la lista de categorías únicas
            var listaCategorias = datalinq.Categorias.Select(c => c.CategoriaNombre).Distinct().ToArray();
            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.AddRange(listaCategorias);
            cmbCategoriasDisponibles.Items.Clear();
            cmbCategoriasDisponibles.Items.AddRange(listaCategorias);
        }

        /// <summary>
        /// Ajuste de filtros de rango de fechas para que muestren un formato vacío hasta que se seleccione una fecha.
        /// </summary>
        private void AjustarFiltrosRangoFechas()
        {
            dtimeFiltroInicio.CustomFormat = " ";
            dtimeFiltroFin.CustomFormat = " ";

            dtimeFiltroInicio.ValueChanged += Dtp_ValueChanged;
            dtimeFiltroFin.ValueChanged += Dtp_ValueChanged;
        }

        /// <summary>
        /// Maneja el evento de cambio de valor en los controles DateTimePicker.
        /// </summary>
        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            if (dtp != null)
            {
                dtp.CustomFormat = "dd/MM/yyyy";
            }
        }

        /// <summary>
        /// Aplica los filtros de concepto, categoría y fechas sobre la tabla editable.
        /// </summary>
        private void btnFiltroConcepto_Click(object sender, EventArgs e)
        {
            // Configuración de la cultura para el formato monetario en euros
            var euro = new CultureInfo("es-ES");

            // Extracción de los valores de filtro desde los controles de la interfaz
            string conceptoFiltro = txtFiltroConcepto.Text?.Trim();
            string categoriaFiltro = cmbFiltroCategoria.SelectedItem?.ToString();

            // Determinación de las fechas de inicio y fin del filtro, considerando si los DateTimePicker están marcados o no
            DateTime filtroFechaInicio = dtimeFiltroInicio.Checked ? dtimeFiltroInicio.Value.Date : DateTime.MinValue;
            DateTime filtroFechaFin = dtimeFiltroFin.Checked ? dtimeFiltroFin.Value.Date : DateTime.MaxValue;

            // Aplicación de los filtros sobre la vista vw_datagrid1 utilizando LINQ, considerando concepto, categoría y rango de fechas
            var datosfiltrados = datalinq.vw_datagrid1
                .Where(f => string.IsNullOrWhiteSpace(conceptoFiltro)
                            || (f.Concepto != null && f.Concepto.ToLower().Contains(conceptoFiltro.ToLower())))
                .Where(f => string.IsNullOrEmpty(categoriaFiltro) || f.Categoria == categoriaFiltro)
                .Where(f => f.Fecha_Operacion >= filtroFechaInicio)
                .Where(f => f.Fecha_Operacion <= filtroFechaFin)
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

            dataGridViewEdicion.DataSource = datosfiltrados;

            // Limpieza de los filtros de fecha
            dtimeFiltroInicio.CustomFormat = " ";
            dtimeFiltroFin.CustomFormat = " ";
            dtimeFiltroInicio.Checked = false;
            dtimeFiltroFin.Checked = false;
        }

        /// <summary>
        /// Evento click para aceptar y guardar una nueva categoría, validando la entrada del usuario y 
        /// actualizando los ComboBox de categorías.
        /// </summary>
        private void btnAceptarCategoriaNueva_Click(object sender, EventArgs e)
        {
            string categoriaNueva = txtCategoriaNueva.Text;

            if (string.IsNullOrWhiteSpace(categoriaNueva))
            {
                MessageBox.Show("Introduce un nombre válido para la categoría.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Categorias nueva = new Categorias
                {
                    CategoriaNombre = categoriaNueva,
                    Concepto = null
                };
                datalinq.Categorias.InsertOnSubmit(nueva);
                datalinq.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la categoría: {ex.Message}", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtCategoriaNueva.Clear();

            var listaCategorias = datalinq.Categorias.Select(c => c.CategoriaNombre).Distinct().ToArray();
            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.AddRange(listaCategorias);
            cmbCategoriasDisponibles.Items.Clear();
            cmbCategoriasDisponibles.Items.AddRange(listaCategorias);
        }

        /// <summary>
        /// Evento de clic en el botón para eliminar una categoría seleccionada.
        /// </summary>
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            // Validación de que se haya seleccionado una categoría para eliminar
            var categoriaSeleccionada = cmbCategoriasDisponibles.SelectedItem?.ToString();
            datalinq.Categorias.DeleteAllOnSubmit(datalinq.Categorias.Where(c => c.CategoriaNombre == categoriaSeleccionada));
            datalinq.SubmitChanges();

            cmbCategoriasDisponibles.ResetText();

            // Actualización de los ComboBox de filtro y categorías disponibles con la lista de categorías únicas
            var listaCategorias = datalinq.Categorias.Select(c => c.CategoriaNombre).Distinct().ToArray();
            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.AddRange(listaCategorias);
            cmbCategoriasDisponibles.Items.Clear();
            cmbCategoriasDisponibles.Items.AddRange(listaCategorias);
            CargaDatagridEditable();
        }

        /// <summary>
        /// Evento de clic en una celda del DataGridView editable para cargar el concepto seleccionado en el TextBox de edición.
        /// </summary>
        private void dataGridViewEdicion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtConceptoEditable.Text = dataGridViewEdicion.Rows[e.RowIndex].Cells["Concepto"].Value?.ToString();
            }
        }

        /// <summary>
        /// Evento click para aceptar y guardar la edición de la categoría asociada a un concepto, 
        /// validando la entrada del usuario y actualizando las transacciones correspondientes.
        /// </summary>
        private void btnAceptarEdicionCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de que se haya introducido un concepto válido para buscar en la tabla Categorías
                string conceptoBuscado = txtConceptoEditable.Text?.Trim();
                if (string.IsNullOrWhiteSpace(conceptoBuscado))
                {
                    MessageBox.Show("Introduce un concepto válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var cambioCategoria = datalinq.Categorias
                    .SingleOrDefault(c => c.Concepto == conceptoBuscado);

                // Validación de que se haya encontrado una categoría asociada al concepto especificado
                if (cambioCategoria == null)
                {
                    MessageBox.Show("No se encontró una categoría asociada al concepto especificado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de que se haya seleccionado una nueva categoría válida para asignar al concepto
                string nuevaCategoria = cmbCategoriasDisponibles.SelectedValue?.ToString()
                                        ?? cmbCategoriasDisponibles.SelectedItem?.ToString()
                                        ?? cmbCategoriasDisponibles.Text?.Trim();

                // Validación de que la nueva categoría no esté vacía o en blanco
                if (string.IsNullOrWhiteSpace(nuevaCategoria))
                {
                    MessageBox.Show("Selecciona una categoría válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Actualización de la categoría en la tabla Categorías y envío de los cambios a la base de datos
                cambioCategoria.CategoriaNombre = nuevaCategoria;
                datalinq.SubmitChanges();

                MessageBox.Show("Categoría actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar la categoría: {ex.Message}", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpieza de los campos de texto y del combo box
            txtConceptoEditable.Clear();
            cmbCategoriasDisponibles.ResetText();

            ActualizacionTransacciones();
            CargaDatagridEditable();
        }

        /// <summary>
        /// Ejecuta la actualización SQL masiva en la tabla Transacciones cruzando datos con Categorías.
        /// </summary>
        private void ActualizacionTransacciones()
        {
            try
            {
                // Ejecución de un comando SQL para actualizar la columna Categoria en la tabla Transacciones
                int filasAfectadas = datalinq.ExecuteCommand(@"
                    UPDATE T
                    SET T.Categoria = C.CategoriaNombre
                    FROM Transacciones T
                    INNER JOIN Categorias C
                        ON LOWER(ISNULL(T.Concepto, '')) = LOWER(ISNULL(C.Concepto, ''))
                ");

                CargarTransacciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar transacciones: {ex.Message}", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region === NAVEGACIÓN Y CONTROL DE PANELES ===

        private void btnMenuDashboard_Click(object sender, EventArgs e)
        {
            MostrarPanelPrincipal(panelDashboard, lbDashboard);
            OcultarPanel(panelAnalitica, lbAnalitica);
            OcultarPanel(panelPlanificacion, lbPlanificacion);
            OcultarPanel(panelEdicion, lbEdicion);
        }

        private void btnMenuAnalitica_Click(object sender, EventArgs e)
        {
            OcultarPanel(panelDashboard, lbDashboard);
            MostrarPanelPrincipal(panelAnalitica, lbAnalitica);
            OcultarPanel(panelPlanificacion, lbPlanificacion);
            OcultarPanel(panelEdicion, lbEdicion);

            combFiltroMes.SelectedIndex = DateTime.Now.Month;
            combFiltroAnio.SelectedValue = DateTime.Now.Year;

            CargaPieChart();
            CargaGastosVSIngresos();
            CargaTop10Gastos();
            EvolucionDeSueldo();
            CargarFiltroAños();
        }

        private void btnMenuPlanificacion_Click(object sender, EventArgs e)
        {
            OcultarPanel(panelDashboard, lbDashboard);
            OcultarPanel(panelAnalitica, lbAnalitica);
            MostrarPanelPrincipal(panelPlanificacion, lbPlanificacion);
            OcultarPanel(panelEdicion, lbEdicion);

            CargarTarjetasLimites();
            CargarTarjetasMetas();
            CargaGastosProgramados();
            CargaPanelesMetricas();
        }

        private void btnMenuEdicion_Click(object sender, EventArgs e)
        {
            OcultarPanel(panelDashboard, lbDashboard);
            OcultarPanel(panelAnalitica, lbAnalitica);
            OcultarPanel(panelPlanificacion, lbPlanificacion);
            MostrarPanelPrincipal(panelEdicion, lbEdicion);

            CargaCategoriasNuevas();
            AjustarFiltrosRangoFechas();
            CargaDatagridEditable();
        }

        #region -- Métodos Auxiliares de Visualización --

        private void MostrarPanelPrincipal(Panel p, Label l)
        {
            p.Visible = true;
            p.Enabled = true;
            if (l != null) l.Visible = true;
        }

        private void OcultarPanel(Panel p, Label l)
        {
            p.Visible = false;
            p.Enabled = false;
            if (l != null) l.Visible = false;
        }

        #endregion

        #endregion
    }
}