namespace Proyecto_Financiero 
{
    partial class Ventana_Inicial
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_Inicial));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbDashboard = new System.Windows.Forms.Label();
            this.lbAnalitica = new System.Windows.Forms.Label();
            this.lbPlanificacion = new System.Windows.Forms.Label();
            this.lbEdicion = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnMenuPlanificacion = new System.Windows.Forms.Button();
            this.btnMenuEdicion = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMenuDashboard = new System.Windows.Forms.Button();
            this.btnMenuAnalitica = new System.Windows.Forms.Button();
            this.panelEdicion = new System.Windows.Forms.Panel();
            this.tableLayoutContenidoEditable = new System.Windows.Forms.TableLayoutPanel();
            this.panelDatosEditablesContenido = new System.Windows.Forms.Panel();
            this.dataGridViewEdicion = new System.Windows.Forms.DataGridView();
            this.panelContenidoEditableHeader = new System.Windows.Forms.Panel();
            this.lblDatosEditables = new System.Windows.Forms.Label();
            this.panelBuscadorContenido = new System.Windows.Forms.Panel();
            this.dtimeFiltroFin = new System.Windows.Forms.DateTimePicker();
            this.dtimeFiltroInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFiltroFechas = new System.Windows.Forms.Label();
            this.cmbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.txtFiltroConcepto = new System.Windows.Forms.TextBox();
            this.lblFiltroConcepto = new System.Windows.Forms.Label();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.panelBuscadorEdicionHeader = new System.Windows.Forms.Panel();
            this.lblBuscadorHeader = new System.Windows.Forms.Label();
            this.btnFiltroConcepto = new System.Windows.Forms.Button();
            this.tableLayoutEditarAnadirCategoria = new System.Windows.Forms.TableLayoutPanel();
            this.panelAnadirCategoria = new System.Windows.Forms.Panel();
            this.btnAceptarCategoriaNueva = new System.Windows.Forms.Button();
            this.txtCategoriaNueva = new System.Windows.Forms.TextBox();
            this.lblAnadirCategoria = new System.Windows.Forms.Label();
            this.lblCategoriaNueva = new System.Windows.Forms.Label();
            this.panelEdicionCategorias = new System.Windows.Forms.Panel();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.cmbCategoriasDisponibles = new System.Windows.Forms.ComboBox();
            this.btnAceptarEdicionCategoria = new System.Windows.Forms.Button();
            this.lblEditarCategoriaTitulo = new System.Windows.Forms.Label();
            this.txtConceptoEditable = new System.Windows.Forms.TextBox();
            this.lblCategoriasDisponibles = new System.Windows.Forms.Label();
            this.lblConceptoEditado = new System.Windows.Forms.Label();
            this.panelContenidoGrid = new System.Windows.Forms.Panel();
            this.lblSubtituloGrid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblLayoutPanelKpis = new System.Windows.Forms.TableLayoutPanel();
            this.cardSaldo = new System.Windows.Forms.Panel();
            this.lblSaldoTitulo = new System.Windows.Forms.Label();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.cardGastos = new System.Windows.Forms.Panel();
            this.lblGastosTitulo = new System.Windows.Forms.Label();
            this.lblGastosValor = new System.Windows.Forms.Label();
            this.cardIngresos = new System.Windows.Forms.Panel();
            this.lblIngresosTitulo = new System.Windows.Forms.Label();
            this.lblIngresosValor = new System.Windows.Forms.Label();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelAnalitica = new System.Windows.Forms.Panel();
            this.tabLayoutAnalitica = new System.Windows.Forms.TableLayoutPanel();
            this.panelPieChart = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.lblPieChartGastos = new System.Windows.Forms.Label();
            this.panelGastosContraIngresos = new System.Windows.Forms.Panel();
            this.LblGastosVSIngresos = new System.Windows.Forms.Label();
            this.cartesianChartGastosContraIngresos = new LiveCharts.WinForms.CartesianChart();
            this.panelDataGridPieChartFilter = new System.Windows.Forms.Panel();
            this.lblFiltroPieChart = new System.Windows.Forms.Label();
            this.dataGridPieChartFiltro = new System.Windows.Forms.DataGridView();
            this.panelGridTopGastos = new System.Windows.Forms.Panel();
            this.LblTopGastos = new System.Windows.Forms.Label();
            this.dataGridTopGastos = new System.Windows.Forms.DataGridView();
            this.panelEvolucionDeSueldo = new System.Windows.Forms.Panel();
            this.LblEvolucionDeSueldo = new System.Windows.Forms.Label();
            this.cartesianChartEvolucionSaldo = new LiveCharts.WinForms.CartesianChart();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.combFiltroAnio = new System.Windows.Forms.ComboBox();
            this.lblFiltroAnio = new System.Windows.Forms.Label();
            this.combFiltroMes = new System.Windows.Forms.ComboBox();
            this.lblFiltroMes = new System.Windows.Forms.Label();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelPlanificacion = new System.Windows.Forms.Panel();
            this.tableLayoutContenidoPlanificacion = new System.Windows.Forms.TableLayoutPanel();
            this.panelLimitesGastosPorCategoria = new System.Windows.Forms.Panel();
            this.tableLayoutLimitesPorCategoria = new System.Windows.Forms.TableLayoutPanel();
            this.panelTituloLimiteGastos = new System.Windows.Forms.Panel();
            this.lblLimiteGastos = new System.Windows.Forms.Label();
            this.panelMetas = new System.Windows.Forms.Panel();
            this.panelEdicionMetas = new System.Windows.Forms.Panel();
            this.btCancelarMeta = new System.Windows.Forms.Button();
            this.btAceptarMetaNueva = new System.Windows.Forms.Button();
            this.txtSaldoNecesario = new System.Windows.Forms.TextBox();
            this.txtNombreMeta = new System.Windows.Forms.TextBox();
            this.lblSaldoNecesario = new System.Windows.Forms.Label();
            this.lblNombreMeta = new System.Windows.Forms.Label();
            this.tableLayoutMetasAhorro = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeaderMetas = new System.Windows.Forms.Panel();
            this.btAnadirMeta = new System.Windows.Forms.Button();
            this.lblMetas = new System.Windows.Forms.Label();
            this.panelGastosFuturos = new System.Windows.Forms.Panel();
            this.panelEdicionGastoProgramados = new System.Windows.Forms.Panel();
            this.btCancelarGastosProgramados = new System.Windows.Forms.Button();
            this.btAceptarGastosProgramados = new System.Windows.Forms.Button();
            this.dtPickFechaPago = new System.Windows.Forms.DateTimePicker();
            this.gpGastoRepetible = new System.Windows.Forms.GroupBox();
            this.chkAnual = new System.Windows.Forms.RadioButton();
            this.chkMensual = new System.Windows.Forms.RadioButton();
            this.chkSemanal = new System.Windows.Forms.RadioButton();
            this.chkNoRepetible = new System.Windows.Forms.RadioButton();
            this.lblFechaGastoProgramado = new System.Windows.Forms.Label();
            this.txtCantidadGasto = new System.Windows.Forms.TextBox();
            this.txtNombreGasto = new System.Windows.Forms.TextBox();
            this.lblCantidadGasto = new System.Windows.Forms.Label();
            this.lblNombreGasto = new System.Windows.Forms.Label();
            this.tableLayoutGastosProgramados = new System.Windows.Forms.TableLayoutPanel();
            this.panelGastosProgramadosHeader = new System.Windows.Forms.Panel();
            this.btAnadirGastoProgramado = new System.Windows.Forms.Button();
            this.lblGastosProgramados = new System.Windows.Forms.Label();
            this.panelHeaderMetricas = new System.Windows.Forms.Panel();
            this.tableLayoutMetricas = new System.Windows.Forms.TableLayoutPanel();
            this.panelPresupuesto = new System.Windows.Forms.Panel();
            this.lblPresupuestoMes = new System.Windows.Forms.Label();
            this.panelGastosAsignados = new System.Windows.Forms.Panel();
            this.lblGastosAsignados = new System.Windows.Forms.Label();
            this.panelAhorroDisponible = new System.Windows.Forms.Panel();
            this.lblAhorroDisponible = new System.Windows.Forms.Label();
            this.lblMetricas = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelEdicion.SuspendLayout();
            this.tableLayoutContenidoEditable.SuspendLayout();
            this.panelDatosEditablesContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdicion)).BeginInit();
            this.panelContenidoEditableHeader.SuspendLayout();
            this.panelBuscadorContenido.SuspendLayout();
            this.panelBuscadorEdicionHeader.SuspendLayout();
            this.tableLayoutEditarAnadirCategoria.SuspendLayout();
            this.panelAnadirCategoria.SuspendLayout();
            this.panelEdicionCategorias.SuspendLayout();
            this.panelContenidoGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tblLayoutPanelKpis.SuspendLayout();
            this.cardSaldo.SuspendLayout();
            this.cardGastos.SuspendLayout();
            this.cardIngresos.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelAnalitica.SuspendLayout();
            this.tabLayoutAnalitica.SuspendLayout();
            this.panelPieChart.SuspendLayout();
            this.panelGastosContraIngresos.SuspendLayout();
            this.panelDataGridPieChartFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPieChartFiltro)).BeginInit();
            this.panelGridTopGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTopGastos)).BeginInit();
            this.panelEvolucionDeSueldo.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panelPlanificacion.SuspendLayout();
            this.tableLayoutContenidoPlanificacion.SuspendLayout();
            this.panelLimitesGastosPorCategoria.SuspendLayout();
            this.panelTituloLimiteGastos.SuspendLayout();
            this.panelMetas.SuspendLayout();
            this.panelEdicionMetas.SuspendLayout();
            this.panelHeaderMetas.SuspendLayout();
            this.panelGastosFuturos.SuspendLayout();
            this.panelEdicionGastoProgramados.SuspendLayout();
            this.gpGastoRepetible.SuspendLayout();
            this.panelGastosProgramadosHeader.SuspendLayout();
            this.panelHeaderMetricas.SuspendLayout();
            this.tableLayoutMetricas.SuspendLayout();
            this.panelPresupuesto.SuspendLayout();
            this.panelGastosAsignados.SuspendLayout();
            this.panelAhorroDisponible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.lbDashboard);
            this.panelHeader.Controls.Add(this.lbAnalitica);
            this.panelHeader.Controls.Add(this.lbPlanificacion);
            this.panelHeader.Controls.Add(this.lbEdicion);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1371, 70);
            this.panelHeader.TabIndex = 3;
            // 
            // lbDashboard
            // 
            this.lbDashboard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbDashboard.Location = new System.Drawing.Point(20, 15);
            this.lbDashboard.Name = "lbDashboard";
            this.lbDashboard.Size = new System.Drawing.Size(400, 39);
            this.lbDashboard.TabIndex = 0;
            this.lbDashboard.Text = "Dashboard";
            // 
            // lbAnalitica
            // 
            this.lbAnalitica.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbAnalitica.Location = new System.Drawing.Point(31, 15);
            this.lbAnalitica.Name = "lbAnalitica";
            this.lbAnalitica.Size = new System.Drawing.Size(400, 39);
            this.lbAnalitica.TabIndex = 1;
            this.lbAnalitica.Text = "Analitica";
            this.lbAnalitica.Visible = false;
            // 
            // lbPlanificacion
            // 
            this.lbPlanificacion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbPlanificacion.Location = new System.Drawing.Point(20, 15);
            this.lbPlanificacion.Name = "lbPlanificacion";
            this.lbPlanificacion.Size = new System.Drawing.Size(400, 39);
            this.lbPlanificacion.TabIndex = 2;
            this.lbPlanificacion.Text = "Planificacion";
            this.lbPlanificacion.Visible = false;
            // 
            // lbEdicion
            // 
            this.lbEdicion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbEdicion.Location = new System.Drawing.Point(20, 15);
            this.lbEdicion.Name = "lbEdicion";
            this.lbEdicion.Size = new System.Drawing.Size(400, 39);
            this.lbEdicion.TabIndex = 3;
            this.lbEdicion.Text = "Edicion";
            this.lbEdicion.Visible = false;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelSidebar.Controls.Add(this.btnMenuPlanificacion);
            this.panelSidebar.Controls.Add(this.btnMenuEdicion);
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Controls.Add(this.btnMenuDashboard);
            this.panelSidebar.Controls.Add(this.btnMenuAnalitica);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(251, 572);
            this.panelSidebar.TabIndex = 4;
            // 
            // btnMenuPlanificacion
            // 
            this.btnMenuPlanificacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuPlanificacion.FlatAppearance.BorderSize = 0;
            this.btnMenuPlanificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPlanificacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuPlanificacion.Location = new System.Drawing.Point(12, 196);
            this.btnMenuPlanificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuPlanificacion.Name = "btnMenuPlanificacion";
            this.btnMenuPlanificacion.Size = new System.Drawing.Size(232, 39);
            this.btnMenuPlanificacion.TabIndex = 4;
            this.btnMenuPlanificacion.Text = "📈 Planificacion";
            this.btnMenuPlanificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPlanificacion.UseVisualStyleBackColor = false;
            this.btnMenuPlanificacion.Click += new System.EventHandler(this.btnMenuPlanificacion_Click);
            // 
            // btnMenuEdicion
            // 
            this.btnMenuEdicion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuEdicion.FlatAppearance.BorderSize = 0;
            this.btnMenuEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEdicion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuEdicion.Location = new System.Drawing.Point(12, 262);
            this.btnMenuEdicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuEdicion.Name = "btnMenuEdicion";
            this.btnMenuEdicion.Size = new System.Drawing.Size(232, 39);
            this.btnMenuEdicion.TabIndex = 3;
            this.btnMenuEdicion.Text = "📝 Edicion";
            this.btnMenuEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEdicion.UseVisualStyleBackColor = false;
            this.btnMenuEdicion.Click += new System.EventHandler(this.btnMenuEdicion_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogo.Location = new System.Drawing.Point(12, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(176, 41);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Navegador";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuDashboard.FlatAppearance.BorderSize = 0;
            this.btnMenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuDashboard.Location = new System.Drawing.Point(12, 63);
            this.btnMenuDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Size = new System.Drawing.Size(232, 39);
            this.btnMenuDashboard.TabIndex = 1;
            this.btnMenuDashboard.Text = "🔲 Dashboard";
            this.btnMenuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDashboard.UseVisualStyleBackColor = false;
            this.btnMenuDashboard.Click += new System.EventHandler(this.btnMenuDashboard_Click);
            // 
            // btnMenuAnalitica
            // 
            this.btnMenuAnalitica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuAnalitica.FlatAppearance.BorderSize = 0;
            this.btnMenuAnalitica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAnalitica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuAnalitica.Location = new System.Drawing.Point(12, 129);
            this.btnMenuAnalitica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuAnalitica.Name = "btnMenuAnalitica";
            this.btnMenuAnalitica.Size = new System.Drawing.Size(232, 39);
            this.btnMenuAnalitica.TabIndex = 2;
            this.btnMenuAnalitica.Text = "📊 Analitica";
            this.btnMenuAnalitica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAnalitica.UseVisualStyleBackColor = false;
            this.btnMenuAnalitica.Click += new System.EventHandler(this.btnMenuAnalitica_Click);
            // 
            // panelEdicion
            // 
            this.panelEdicion.Controls.Add(this.tableLayoutContenidoEditable);
            this.panelEdicion.Controls.Add(this.tableLayoutEditarAnadirCategoria);
            this.panelEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEdicion.Location = new System.Drawing.Point(251, 70);
            this.panelEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.panelEdicion.Name = "panelEdicion";
            this.panelEdicion.Size = new System.Drawing.Size(1120, 572);
            this.panelEdicion.TabIndex = 6;
            // 
            // tableLayoutContenidoEditable
            // 
            this.tableLayoutContenidoEditable.BackColor = System.Drawing.Color.White;
            this.tableLayoutContenidoEditable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutContenidoEditable.ColumnCount = 2;
            this.tableLayoutContenidoEditable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutContenidoEditable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutContenidoEditable.Controls.Add(this.panelDatosEditablesContenido, 0, 0);
            this.tableLayoutContenidoEditable.Controls.Add(this.panelBuscadorContenido, 1, 0);
            this.tableLayoutContenidoEditable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutContenidoEditable.Location = new System.Drawing.Point(0, 199);
            this.tableLayoutContenidoEditable.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutContenidoEditable.Name = "tableLayoutContenidoEditable";
            this.tableLayoutContenidoEditable.RowCount = 1;
            this.tableLayoutContenidoEditable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutContenidoEditable.Size = new System.Drawing.Size(1120, 373);
            this.tableLayoutContenidoEditable.TabIndex = 1;
            // 
            // panelDatosEditablesContenido
            // 
            this.panelDatosEditablesContenido.Controls.Add(this.dataGridViewEdicion);
            this.panelDatosEditablesContenido.Controls.Add(this.panelContenidoEditableHeader);
            this.panelDatosEditablesContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosEditablesContenido.Location = new System.Drawing.Point(5, 5);
            this.panelDatosEditablesContenido.Margin = new System.Windows.Forms.Padding(4);
            this.panelDatosEditablesContenido.Name = "panelDatosEditablesContenido";
            this.panelDatosEditablesContenido.Size = new System.Drawing.Size(773, 363);
            this.panelDatosEditablesContenido.TabIndex = 5;
            // 
            // dataGridViewEdicion
            // 
            this.dataGridViewEdicion.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEdicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEdicion.Location = new System.Drawing.Point(0, 46);
            this.dataGridViewEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEdicion.Name = "dataGridViewEdicion";
            this.dataGridViewEdicion.RowHeadersWidth = 51;
            this.dataGridViewEdicion.Size = new System.Drawing.Size(773, 317);
            this.dataGridViewEdicion.TabIndex = 1;
            // 
            // panelContenidoEditableHeader
            // 
            this.panelContenidoEditableHeader.BackColor = System.Drawing.Color.Silver;
            this.panelContenidoEditableHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenidoEditableHeader.Controls.Add(this.lblDatosEditables);
            this.panelContenidoEditableHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContenidoEditableHeader.Location = new System.Drawing.Point(0, 0);
            this.panelContenidoEditableHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenidoEditableHeader.Name = "panelContenidoEditableHeader";
            this.panelContenidoEditableHeader.Size = new System.Drawing.Size(773, 46);
            this.panelContenidoEditableHeader.TabIndex = 0;
            // 
            // lblDatosEditables
            // 
            this.lblDatosEditables.AutoSize = true;
            this.lblDatosEditables.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDatosEditables.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEditables.Location = new System.Drawing.Point(0, 0);
            this.lblDatosEditables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosEditables.Name = "lblDatosEditables";
            this.lblDatosEditables.Size = new System.Drawing.Size(234, 36);
            this.lblDatosEditables.TabIndex = 4;
            this.lblDatosEditables.Text = "Datos editables";
            this.lblDatosEditables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBuscadorContenido
            // 
            this.panelBuscadorContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelBuscadorContenido.Controls.Add(this.dtimeFiltroFin);
            this.panelBuscadorContenido.Controls.Add(this.dtimeFiltroInicio);
            this.panelBuscadorContenido.Controls.Add(this.lblFechaFin);
            this.panelBuscadorContenido.Controls.Add(this.lblFechaInicio);
            this.panelBuscadorContenido.Controls.Add(this.lblFiltroFechas);
            this.panelBuscadorContenido.Controls.Add(this.cmbFiltroCategoria);
            this.panelBuscadorContenido.Controls.Add(this.txtFiltroConcepto);
            this.panelBuscadorContenido.Controls.Add(this.lblFiltroConcepto);
            this.panelBuscadorContenido.Controls.Add(this.lblFiltroCategoria);
            this.panelBuscadorContenido.Controls.Add(this.panelBuscadorEdicionHeader);
            this.panelBuscadorContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuscadorContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBuscadorContenido.Location = new System.Drawing.Point(787, 5);
            this.panelBuscadorContenido.Margin = new System.Windows.Forms.Padding(4);
            this.panelBuscadorContenido.Name = "panelBuscadorContenido";
            this.panelBuscadorContenido.Size = new System.Drawing.Size(328, 363);
            this.panelBuscadorContenido.TabIndex = 1;
            // 
            // dtimeFiltroFin
            // 
            this.dtimeFiltroFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtimeFiltroFin.Checked = false;
            this.dtimeFiltroFin.CustomFormat = "dd/MM/yyyy";
            this.dtimeFiltroFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimeFiltroFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtimeFiltroFin.Location = new System.Drawing.Point(188, 282);
            this.dtimeFiltroFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtimeFiltroFin.Name = "dtimeFiltroFin";
            this.dtimeFiltroFin.Size = new System.Drawing.Size(124, 26);
            this.dtimeFiltroFin.TabIndex = 13;
            // 
            // dtimeFiltroInicio
            // 
            this.dtimeFiltroInicio.Checked = false;
            this.dtimeFiltroInicio.CustomFormat = "dd/MM/yyyy";
            this.dtimeFiltroInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimeFiltroInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtimeFiltroInicio.Location = new System.Drawing.Point(17, 282);
            this.dtimeFiltroInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtimeFiltroInicio.Name = "dtimeFiltroInicio";
            this.dtimeFiltroInicio.Size = new System.Drawing.Size(124, 26);
            this.dtimeFiltroInicio.TabIndex = 12;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(183, 254);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(42, 25);
            this.lblFechaFin.TabIndex = 11;
            this.lblFechaFin.Text = "Fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 254);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(63, 25);
            this.lblFechaInicio.TabIndex = 10;
            this.lblFechaInicio.Text = "Inicio";
            // 
            // lblFiltroFechas
            // 
            this.lblFiltroFechas.AutoSize = true;
            this.lblFiltroFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroFechas.Location = new System.Drawing.Point(11, 210);
            this.lblFiltroFechas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroFechas.Name = "lblFiltroFechas";
            this.lblFiltroFechas.Size = new System.Drawing.Size(230, 31);
            this.lblFiltroFechas.TabIndex = 9;
            this.lblFiltroFechas.Text = "Filtro De Fechas";
            this.lblFiltroFechas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbFiltroCategoria
            // 
            this.cmbFiltroCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroCategoria.FormattingEnabled = true;
            this.cmbFiltroCategoria.Items.AddRange(new object[] {
            "Sin Categoria"});
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(17, 87);
            this.cmbFiltroCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            this.cmbFiltroCategoria.Size = new System.Drawing.Size(295, 33);
            this.cmbFiltroCategoria.TabIndex = 8;
            // 
            // txtFiltroConcepto
            // 
            this.txtFiltroConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroConcepto.Location = new System.Drawing.Point(17, 172);
            this.txtFiltroConcepto.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroConcepto.Name = "txtFiltroConcepto";
            this.txtFiltroConcepto.Size = new System.Drawing.Size(295, 30);
            this.txtFiltroConcepto.TabIndex = 6;
            // 
            // lblFiltroConcepto
            // 
            this.lblFiltroConcepto.AutoSize = true;
            this.lblFiltroConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroConcepto.Location = new System.Drawing.Point(12, 137);
            this.lblFiltroConcepto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroConcepto.Name = "lblFiltroConcepto";
            this.lblFiltroConcepto.Size = new System.Drawing.Size(105, 25);
            this.lblFiltroConcepto.TabIndex = 5;
            this.lblFiltroConcepto.Text = "Concepto";
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroCategoria.Location = new System.Drawing.Point(12, 58);
            this.lblFiltroCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(106, 25);
            this.lblFiltroCategoria.TabIndex = 4;
            this.lblFiltroCategoria.Text = "Categoria";
            // 
            // panelBuscadorEdicionHeader
            // 
            this.panelBuscadorEdicionHeader.BackColor = System.Drawing.Color.Silver;
            this.panelBuscadorEdicionHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBuscadorEdicionHeader.Controls.Add(this.lblBuscadorHeader);
            this.panelBuscadorEdicionHeader.Controls.Add(this.btnFiltroConcepto);
            this.panelBuscadorEdicionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscadorEdicionHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBuscadorEdicionHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelBuscadorEdicionHeader.Name = "panelBuscadorEdicionHeader";
            this.panelBuscadorEdicionHeader.Size = new System.Drawing.Size(328, 46);
            this.panelBuscadorEdicionHeader.TabIndex = 1;
            // 
            // lblBuscadorHeader
            // 
            this.lblBuscadorHeader.AutoSize = true;
            this.lblBuscadorHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBuscadorHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscadorHeader.Location = new System.Drawing.Point(0, 0);
            this.lblBuscadorHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscadorHeader.Name = "lblBuscadorHeader";
            this.lblBuscadorHeader.Size = new System.Drawing.Size(137, 31);
            this.lblBuscadorHeader.TabIndex = 0;
            this.lblBuscadorHeader.Text = "Buscador";
            this.lblBuscadorHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFiltroConcepto
            // 
            this.btnFiltroConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltroConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroConcepto.Location = new System.Drawing.Point(253, 4);
            this.btnFiltroConcepto.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltroConcepto.Name = "btnFiltroConcepto";
            this.btnFiltroConcepto.Size = new System.Drawing.Size(60, 37);
            this.btnFiltroConcepto.TabIndex = 7;
            this.btnFiltroConcepto.Text = "🔎";
            this.btnFiltroConcepto.UseVisualStyleBackColor = true;
            this.btnFiltroConcepto.Click += new System.EventHandler(this.btnFiltroConcepto_Click);
            // 
            // tableLayoutEditarAnadirCategoria
            // 
            this.tableLayoutEditarAnadirCategoria.ColumnCount = 2;
            this.tableLayoutEditarAnadirCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutEditarAnadirCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutEditarAnadirCategoria.Controls.Add(this.panelAnadirCategoria, 1, 0);
            this.tableLayoutEditarAnadirCategoria.Controls.Add(this.panelEdicionCategorias, 0, 0);
            this.tableLayoutEditarAnadirCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutEditarAnadirCategoria.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutEditarAnadirCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutEditarAnadirCategoria.Name = "tableLayoutEditarAnadirCategoria";
            this.tableLayoutEditarAnadirCategoria.RowCount = 1;
            this.tableLayoutEditarAnadirCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutEditarAnadirCategoria.Size = new System.Drawing.Size(1120, 199);
            this.tableLayoutEditarAnadirCategoria.TabIndex = 3;
            // 
            // panelAnadirCategoria
            // 
            this.panelAnadirCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelAnadirCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnadirCategoria.Controls.Add(this.btnAceptarCategoriaNueva);
            this.panelAnadirCategoria.Controls.Add(this.txtCategoriaNueva);
            this.panelAnadirCategoria.Controls.Add(this.lblAnadirCategoria);
            this.panelAnadirCategoria.Controls.Add(this.lblCategoriaNueva);
            this.panelAnadirCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnadirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAnadirCategoria.Location = new System.Drawing.Point(564, 4);
            this.panelAnadirCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.panelAnadirCategoria.Name = "panelAnadirCategoria";
            this.panelAnadirCategoria.Size = new System.Drawing.Size(552, 191);
            this.panelAnadirCategoria.TabIndex = 1;
            // 
            // btnAceptarCategoriaNueva
            // 
            this.btnAceptarCategoriaNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarCategoriaNueva.Location = new System.Drawing.Point(369, 80);
            this.btnAceptarCategoriaNueva.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarCategoriaNueva.Name = "btnAceptarCategoriaNueva";
            this.btnAceptarCategoriaNueva.Size = new System.Drawing.Size(144, 36);
            this.btnAceptarCategoriaNueva.TabIndex = 5;
            this.btnAceptarCategoriaNueva.Text = "Aceptar";
            this.btnAceptarCategoriaNueva.UseVisualStyleBackColor = true;
            this.btnAceptarCategoriaNueva.Click += new System.EventHandler(this.btnAceptarCategoriaNueva_Click);
            // 
            // txtCategoriaNueva
            // 
            this.txtCategoriaNueva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoriaNueva.Location = new System.Drawing.Point(32, 82);
            this.txtCategoriaNueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoriaNueva.Name = "txtCategoriaNueva";
            this.txtCategoriaNueva.Size = new System.Drawing.Size(316, 26);
            this.txtCategoriaNueva.TabIndex = 4;
            // 
            // lblAnadirCategoria
            // 
            this.lblAnadirCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnadirCategoria.AutoSize = true;
            this.lblAnadirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnadirCategoria.Location = new System.Drawing.Point(20, 11);
            this.lblAnadirCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnadirCategoria.Name = "lblAnadirCategoria";
            this.lblAnadirCategoria.Size = new System.Drawing.Size(249, 36);
            this.lblAnadirCategoria.TabIndex = 3;
            this.lblAnadirCategoria.Text = "Añadir categoria";
            // 
            // lblCategoriaNueva
            // 
            this.lblCategoriaNueva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoriaNueva.AutoSize = true;
            this.lblCategoriaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaNueva.Location = new System.Drawing.Point(31, 57);
            this.lblCategoriaNueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaNueva.Name = "lblCategoriaNueva";
            this.lblCategoriaNueva.Size = new System.Drawing.Size(162, 24);
            this.lblCategoriaNueva.TabIndex = 0;
            this.lblCategoriaNueva.Text = "Categoria nueva";
            // 
            // panelEdicionCategorias
            // 
            this.panelEdicionCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelEdicionCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdicionCategorias.Controls.Add(this.btnEliminarCategoria);
            this.panelEdicionCategorias.Controls.Add(this.cmbCategoriasDisponibles);
            this.panelEdicionCategorias.Controls.Add(this.btnAceptarEdicionCategoria);
            this.panelEdicionCategorias.Controls.Add(this.lblEditarCategoriaTitulo);
            this.panelEdicionCategorias.Controls.Add(this.txtConceptoEditable);
            this.panelEdicionCategorias.Controls.Add(this.lblCategoriasDisponibles);
            this.panelEdicionCategorias.Controls.Add(this.lblConceptoEditado);
            this.panelEdicionCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEdicionCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEdicionCategorias.Location = new System.Drawing.Point(4, 4);
            this.panelEdicionCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.panelEdicionCategorias.Name = "panelEdicionCategorias";
            this.panelEdicionCategorias.Size = new System.Drawing.Size(552, 191);
            this.panelEdicionCategorias.TabIndex = 0;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCategoria.Location = new System.Drawing.Point(365, 124);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(144, 59);
            this.btnEliminarCategoria.TabIndex = 6;
            this.btnEliminarCategoria.Text = "Eliminar Categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // cmbCategoriasDisponibles
            // 
            this.cmbCategoriasDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoriasDisponibles.FormattingEnabled = true;
            this.cmbCategoriasDisponibles.Items.AddRange(new object[] {
            "Sin Categoria"});
            this.cmbCategoriasDisponibles.Location = new System.Drawing.Point(147, 123);
            this.cmbCategoriasDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoriasDisponibles.Name = "cmbCategoriasDisponibles";
            this.cmbCategoriasDisponibles.Size = new System.Drawing.Size(202, 28);
            this.cmbCategoriasDisponibles.TabIndex = 5;
            // 
            // btnAceptarEdicionCategoria
            // 
            this.btnAceptarEdicionCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarEdicionCategoria.Location = new System.Drawing.Point(365, 80);
            this.btnAceptarEdicionCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarEdicionCategoria.Name = "btnAceptarEdicionCategoria";
            this.btnAceptarEdicionCategoria.Size = new System.Drawing.Size(144, 36);
            this.btnAceptarEdicionCategoria.TabIndex = 4;
            this.btnAceptarEdicionCategoria.Text = "Cambiar";
            this.btnAceptarEdicionCategoria.UseVisualStyleBackColor = true;
            this.btnAceptarEdicionCategoria.Click += new System.EventHandler(this.btnAceptarEdicionCategoria_Click);
            // 
            // lblEditarCategoriaTitulo
            // 
            this.lblEditarCategoriaTitulo.AutoSize = true;
            this.lblEditarCategoriaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCategoriaTitulo.Location = new System.Drawing.Point(20, 11);
            this.lblEditarCategoriaTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditarCategoriaTitulo.Name = "lblEditarCategoriaTitulo";
            this.lblEditarCategoriaTitulo.Size = new System.Drawing.Size(239, 36);
            this.lblEditarCategoriaTitulo.TabIndex = 3;
            this.lblEditarCategoriaTitulo.Text = "Editar categoria";
            // 
            // txtConceptoEditable
            // 
            this.txtConceptoEditable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConceptoEditable.Enabled = false;
            this.txtConceptoEditable.Location = new System.Drawing.Point(35, 84);
            this.txtConceptoEditable.Margin = new System.Windows.Forms.Padding(4);
            this.txtConceptoEditable.Name = "txtConceptoEditable";
            this.txtConceptoEditable.Size = new System.Drawing.Size(314, 26);
            this.txtConceptoEditable.TabIndex = 2;
            // 
            // lblCategoriasDisponibles
            // 
            this.lblCategoriasDisponibles.AutoSize = true;
            this.lblCategoriasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriasDisponibles.Location = new System.Drawing.Point(31, 128);
            this.lblCategoriasDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriasDisponibles.Name = "lblCategoriasDisponibles";
            this.lblCategoriasDisponibles.Size = new System.Drawing.Size(99, 24);
            this.lblCategoriasDisponibles.TabIndex = 1;
            this.lblCategoriasDisponibles.Text = "Categoria";
            // 
            // lblConceptoEditado
            // 
            this.lblConceptoEditado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConceptoEditado.AutoSize = true;
            this.lblConceptoEditado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceptoEditado.Location = new System.Drawing.Point(31, 57);
            this.lblConceptoEditado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConceptoEditado.Name = "lblConceptoEditado";
            this.lblConceptoEditado.Size = new System.Drawing.Size(100, 24);
            this.lblConceptoEditado.TabIndex = 0;
            this.lblConceptoEditado.Text = "Concepto";
            // 
            // panelContenidoGrid
            // 
            this.panelContenidoGrid.AutoSize = true;
            this.panelContenidoGrid.BackColor = System.Drawing.Color.White;
            this.panelContenidoGrid.Controls.Add(this.lblSubtituloGrid);
            this.panelContenidoGrid.Controls.Add(this.dataGridView1);
            this.panelContenidoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenidoGrid.Location = new System.Drawing.Point(0, 134);
            this.panelContenidoGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenidoGrid.Name = "panelContenidoGrid";
            this.panelContenidoGrid.Size = new System.Drawing.Size(1120, 438);
            this.panelContenidoGrid.TabIndex = 1;
            // 
            // lblSubtituloGrid
            // 
            this.lblSubtituloGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtituloGrid.Location = new System.Drawing.Point(15, 15);
            this.lblSubtituloGrid.Name = "lblSubtituloGrid";
            this.lblSubtituloGrid.Size = new System.Drawing.Size(300, 25);
            this.lblSubtituloGrid.TabIndex = 0;
            this.lblSubtituloGrid.Text = "ÚLTIMOS MOVIMIENTOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeight = 12;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(15, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 372);
            this.dataGridView1.TabIndex = 1;
            // 
            // tblLayoutPanelKpis
            // 
            this.tblLayoutPanelKpis.ColumnCount = 3;
            this.tblLayoutPanelKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelKpis.Controls.Add(this.cardSaldo, 0, 0);
            this.tblLayoutPanelKpis.Controls.Add(this.cardGastos, 2, 0);
            this.tblLayoutPanelKpis.Controls.Add(this.cardIngresos, 1, 0);
            this.tblLayoutPanelKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLayoutPanelKpis.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelKpis.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelKpis.Name = "tblLayoutPanelKpis";
            this.tblLayoutPanelKpis.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.tblLayoutPanelKpis.RowCount = 1;
            this.tblLayoutPanelKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tblLayoutPanelKpis.Size = new System.Drawing.Size(1120, 134);
            this.tblLayoutPanelKpis.TabIndex = 5;
            // 
            // cardSaldo
            // 
            this.cardSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(247)))));
            this.cardSaldo.Controls.Add(this.lblSaldoTitulo);
            this.cardSaldo.Controls.Add(this.lblSaldoValor);
            this.cardSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSaldo.Location = new System.Drawing.Point(20, 15);
            this.cardSaldo.Margin = new System.Windows.Forms.Padding(7, 15, 7, 15);
            this.cardSaldo.Name = "cardSaldo";
            this.cardSaldo.Size = new System.Drawing.Size(350, 104);
            this.cardSaldo.TabIndex = 0;
            // 
            // lblSaldoTitulo
            // 
            this.lblSaldoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSaldoTitulo.Location = new System.Drawing.Point(15, 15);
            this.lblSaldoTitulo.Name = "lblSaldoTitulo";
            this.lblSaldoTitulo.Size = new System.Drawing.Size(200, 20);
            this.lblSaldoTitulo.TabIndex = 0;
            this.lblSaldoTitulo.Text = "SALDO ACTUAL";
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSaldoValor.Location = new System.Drawing.Point(15, 46);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(251, 50);
            this.lblSaldoValor.TabIndex = 1;
            this.lblSaldoValor.Text = " €";
            // 
            // cardGastos
            // 
            this.cardGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cardGastos.Controls.Add(this.lblGastosTitulo);
            this.cardGastos.Controls.Add(this.lblGastosValor);
            this.cardGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGastos.Location = new System.Drawing.Point(748, 15);
            this.cardGastos.Margin = new System.Windows.Forms.Padding(7, 15, 7, 15);
            this.cardGastos.Name = "cardGastos";
            this.cardGastos.Size = new System.Drawing.Size(352, 104);
            this.cardGastos.TabIndex = 2;
            // 
            // lblGastosTitulo
            // 
            this.lblGastosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGastosTitulo.Location = new System.Drawing.Point(15, 15);
            this.lblGastosTitulo.Name = "lblGastosTitulo";
            this.lblGastosTitulo.Size = new System.Drawing.Size(200, 20);
            this.lblGastosTitulo.TabIndex = 0;
            this.lblGastosTitulo.Text = "GASTOS DEL MES";
            // 
            // lblGastosValor
            // 
            this.lblGastosValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblGastosValor.Location = new System.Drawing.Point(15, 46);
            this.lblGastosValor.Name = "lblGastosValor";
            this.lblGastosValor.Size = new System.Drawing.Size(251, 50);
            this.lblGastosValor.TabIndex = 1;
            this.lblGastosValor.Text = "€";
            // 
            // cardIngresos
            // 
            this.cardIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(202)))));
            this.cardIngresos.Controls.Add(this.lblIngresosTitulo);
            this.cardIngresos.Controls.Add(this.lblIngresosValor);
            this.cardIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardIngresos.Location = new System.Drawing.Point(384, 15);
            this.cardIngresos.Margin = new System.Windows.Forms.Padding(7, 15, 7, 15);
            this.cardIngresos.Name = "cardIngresos";
            this.cardIngresos.Size = new System.Drawing.Size(350, 104);
            this.cardIngresos.TabIndex = 1;
            // 
            // lblIngresosTitulo
            // 
            this.lblIngresosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIngresosTitulo.Location = new System.Drawing.Point(15, 15);
            this.lblIngresosTitulo.Name = "lblIngresosTitulo";
            this.lblIngresosTitulo.Size = new System.Drawing.Size(200, 20);
            this.lblIngresosTitulo.TabIndex = 0;
            this.lblIngresosTitulo.Text = "INGRESOS DEL MES";
            // 
            // lblIngresosValor
            // 
            this.lblIngresosValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblIngresosValor.Location = new System.Drawing.Point(15, 46);
            this.lblIngresosValor.Name = "lblIngresosValor";
            this.lblIngresosValor.Size = new System.Drawing.Size(251, 50);
            this.lblIngresosValor.TabIndex = 1;
            this.lblIngresosValor.Text = "€";
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.panelContenidoGrid);
            this.panelDashboard.Controls.Add(this.tblLayoutPanelKpis);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(251, 70);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1120, 572);
            this.panelDashboard.TabIndex = 1;
            // 
            // panelAnalitica
            // 
            this.panelAnalitica.Controls.Add(this.tabLayoutAnalitica);
            this.panelAnalitica.Controls.Add(this.panelFiltros);
            this.panelAnalitica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnalitica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelAnalitica.Location = new System.Drawing.Point(251, 70);
            this.panelAnalitica.Margin = new System.Windows.Forms.Padding(4);
            this.panelAnalitica.Name = "panelAnalitica";
            this.panelAnalitica.Size = new System.Drawing.Size(1120, 572);
            this.panelAnalitica.TabIndex = 5;
            // 
            // tabLayoutAnalitica
            // 
            this.tabLayoutAnalitica.BackColor = System.Drawing.Color.White;
            this.tabLayoutAnalitica.ColumnCount = 3;
            this.tabLayoutAnalitica.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tabLayoutAnalitica.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tabLayoutAnalitica.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tabLayoutAnalitica.Controls.Add(this.panelPieChart, 0, 0);
            this.tabLayoutAnalitica.Controls.Add(this.panelGastosContraIngresos, 2, 0);
            this.tabLayoutAnalitica.Controls.Add(this.panelDataGridPieChartFilter, 1, 0);
            this.tabLayoutAnalitica.Controls.Add(this.panelGridTopGastos, 2, 1);
            this.tabLayoutAnalitica.Controls.Add(this.panelEvolucionDeSueldo, 1, 1);
            this.tabLayoutAnalitica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutAnalitica.Location = new System.Drawing.Point(0, 70);
            this.tabLayoutAnalitica.Margin = new System.Windows.Forms.Padding(4);
            this.tabLayoutAnalitica.Name = "tabLayoutAnalitica";
            this.tabLayoutAnalitica.RowCount = 2;
            this.tabLayoutAnalitica.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayoutAnalitica.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayoutAnalitica.Size = new System.Drawing.Size(1120, 502);
            this.tabLayoutAnalitica.TabIndex = 1;
            // 
            // panelPieChart
            // 
            this.panelPieChart.BackColor = System.Drawing.Color.White;
            this.panelPieChart.Controls.Add(this.pieChart1);
            this.panelPieChart.Controls.Add(this.lblPieChartGastos);
            this.panelPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPieChart.Location = new System.Drawing.Point(4, 4);
            this.panelPieChart.Margin = new System.Windows.Forms.Padding(4);
            this.panelPieChart.Name = "panelPieChart";
            this.tabLayoutAnalitica.SetRowSpan(this.panelPieChart, 2);
            this.panelPieChart.Size = new System.Drawing.Size(328, 494);
            this.panelPieChart.TabIndex = 2;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(0, 36);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(4);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(328, 458);
            this.pieChart1.TabIndex = 0;
            // 
            // lblPieChartGastos
            // 
            this.lblPieChartGastos.AutoSize = true;
            this.lblPieChartGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPieChartGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieChartGastos.Location = new System.Drawing.Point(0, 0);
            this.lblPieChartGastos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPieChartGastos.Name = "lblPieChartGastos";
            this.lblPieChartGastos.Size = new System.Drawing.Size(275, 36);
            this.lblPieChartGastos.TabIndex = 1;
            this.lblPieChartGastos.Text = "Pie Chart de gastos";
            // 
            // panelGastosContraIngresos
            // 
            this.panelGastosContraIngresos.Controls.Add(this.LblGastosVSIngresos);
            this.panelGastosContraIngresos.Controls.Add(this.cartesianChartGastosContraIngresos);
            this.panelGastosContraIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGastosContraIngresos.Location = new System.Drawing.Point(732, 4);
            this.panelGastosContraIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.panelGastosContraIngresos.Name = "panelGastosContraIngresos";
            this.panelGastosContraIngresos.Size = new System.Drawing.Size(384, 243);
            this.panelGastosContraIngresos.TabIndex = 7;
            // 
            // LblGastosVSIngresos
            // 
            this.LblGastosVSIngresos.AutoSize = true;
            this.LblGastosVSIngresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblGastosVSIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGastosVSIngresos.Location = new System.Drawing.Point(0, 0);
            this.LblGastosVSIngresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGastosVSIngresos.Name = "LblGastosVSIngresos";
            this.LblGastosVSIngresos.Size = new System.Drawing.Size(281, 36);
            this.LblGastosVSIngresos.TabIndex = 6;
            this.LblGastosVSIngresos.Text = "Gastos VS Ingresos";
            // 
            // cartesianChartGastosContraIngresos
            // 
            this.cartesianChartGastosContraIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartGastosContraIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cartesianChartGastosContraIngresos.Location = new System.Drawing.Point(0, 36);
            this.cartesianChartGastosContraIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.cartesianChartGastosContraIngresos.Name = "cartesianChartGastosContraIngresos";
            this.cartesianChartGastosContraIngresos.Size = new System.Drawing.Size(384, 207);
            this.cartesianChartGastosContraIngresos.TabIndex = 5;
            this.cartesianChartGastosContraIngresos.Text = "cartesianChart2";
            // 
            // panelDataGridPieChartFilter
            // 
            this.panelDataGridPieChartFilter.Controls.Add(this.lblFiltroPieChart);
            this.panelDataGridPieChartFilter.Controls.Add(this.dataGridPieChartFiltro);
            this.panelDataGridPieChartFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridPieChartFilter.Location = new System.Drawing.Point(340, 4);
            this.panelDataGridPieChartFilter.Margin = new System.Windows.Forms.Padding(4);
            this.panelDataGridPieChartFilter.Name = "panelDataGridPieChartFilter";
            this.panelDataGridPieChartFilter.Size = new System.Drawing.Size(384, 243);
            this.panelDataGridPieChartFilter.TabIndex = 6;
            // 
            // lblFiltroPieChart
            // 
            this.lblFiltroPieChart.AutoSize = true;
            this.lblFiltroPieChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFiltroPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroPieChart.Location = new System.Drawing.Point(0, 0);
            this.lblFiltroPieChart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroPieChart.Name = "lblFiltroPieChart";
            this.lblFiltroPieChart.Size = new System.Drawing.Size(213, 36);
            this.lblFiltroPieChart.TabIndex = 5;
            this.lblFiltroPieChart.Text = "Filtro Pie Chart";
            // 
            // dataGridPieChartFiltro
            // 
            this.dataGridPieChartFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPieChartFiltro.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPieChartFiltro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridPieChartFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPieChartFiltro.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridPieChartFiltro.Location = new System.Drawing.Point(0, 36);
            this.dataGridPieChartFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPieChartFiltro.Name = "dataGridPieChartFiltro";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPieChartFiltro.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridPieChartFiltro.RowHeadersWidth = 51;
            this.dataGridPieChartFiltro.Size = new System.Drawing.Size(384, 207);
            this.dataGridPieChartFiltro.TabIndex = 4;
            // 
            // panelGridTopGastos
            // 
            this.panelGridTopGastos.Controls.Add(this.LblTopGastos);
            this.panelGridTopGastos.Controls.Add(this.dataGridTopGastos);
            this.panelGridTopGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridTopGastos.Location = new System.Drawing.Point(732, 255);
            this.panelGridTopGastos.Margin = new System.Windows.Forms.Padding(4);
            this.panelGridTopGastos.Name = "panelGridTopGastos";
            this.panelGridTopGastos.Size = new System.Drawing.Size(384, 243);
            this.panelGridTopGastos.TabIndex = 9;
            // 
            // LblTopGastos
            // 
            this.LblTopGastos.AutoSize = true;
            this.LblTopGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTopGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTopGastos.Location = new System.Drawing.Point(0, 0);
            this.LblTopGastos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTopGastos.Name = "LblTopGastos";
            this.LblTopGastos.Size = new System.Drawing.Size(325, 36);
            this.LblTopGastos.TabIndex = 7;
            this.LblTopGastos.Text = "Top 10 mayores gastos";
            // 
            // dataGridTopGastos
            // 
            this.dataGridTopGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTopGastos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTopGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridTopGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTopGastos.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridTopGastos.Location = new System.Drawing.Point(0, 39);
            this.dataGridTopGastos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridTopGastos.Name = "dataGridTopGastos";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTopGastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridTopGastos.RowHeadersWidth = 51;
            this.dataGridTopGastos.Size = new System.Drawing.Size(384, 203);
            this.dataGridTopGastos.TabIndex = 6;
            // 
            // panelEvolucionDeSueldo
            // 
            this.panelEvolucionDeSueldo.Controls.Add(this.LblEvolucionDeSueldo);
            this.panelEvolucionDeSueldo.Controls.Add(this.cartesianChartEvolucionSaldo);
            this.panelEvolucionDeSueldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEvolucionDeSueldo.Location = new System.Drawing.Point(340, 255);
            this.panelEvolucionDeSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.panelEvolucionDeSueldo.Name = "panelEvolucionDeSueldo";
            this.panelEvolucionDeSueldo.Size = new System.Drawing.Size(384, 243);
            this.panelEvolucionDeSueldo.TabIndex = 8;
            // 
            // LblEvolucionDeSueldo
            // 
            this.LblEvolucionDeSueldo.AutoSize = true;
            this.LblEvolucionDeSueldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblEvolucionDeSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEvolucionDeSueldo.Location = new System.Drawing.Point(0, 0);
            this.LblEvolucionDeSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEvolucionDeSueldo.Name = "LblEvolucionDeSueldo";
            this.LblEvolucionDeSueldo.Size = new System.Drawing.Size(290, 36);
            this.LblEvolucionDeSueldo.TabIndex = 7;
            this.LblEvolucionDeSueldo.Text = "Evolucion de Sueldo";
            // 
            // cartesianChartEvolucionSaldo
            // 
            this.cartesianChartEvolucionSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartEvolucionSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cartesianChartEvolucionSaldo.Location = new System.Drawing.Point(0, 39);
            this.cartesianChartEvolucionSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.cartesianChartEvolucionSaldo.Name = "cartesianChartEvolucionSaldo";
            this.cartesianChartEvolucionSaldo.Size = new System.Drawing.Size(384, 203);
            this.cartesianChartEvolucionSaldo.TabIndex = 3;
            this.cartesianChartEvolucionSaldo.Text = "cartesianChart1";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.Controls.Add(this.combFiltroAnio);
            this.panelFiltros.Controls.Add(this.lblFiltroAnio);
            this.panelFiltros.Controls.Add(this.combFiltroMes);
            this.panelFiltros.Controls.Add(this.lblFiltroMes);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 0);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1120, 70);
            this.panelFiltros.TabIndex = 0;
            // 
            // combFiltroAnio
            // 
            this.combFiltroAnio.DisplayMember = "Año";
            this.combFiltroAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combFiltroAnio.ImeMode = System.Windows.Forms.ImeMode.On;
            this.combFiltroAnio.Location = new System.Drawing.Point(237, 31);
            this.combFiltroAnio.Margin = new System.Windows.Forms.Padding(4);
            this.combFiltroAnio.Name = "combFiltroAnio";
            this.combFiltroAnio.Size = new System.Drawing.Size(159, 28);
            this.combFiltroAnio.TabIndex = 3;
            this.combFiltroAnio.ValueMember = "Año";
            this.combFiltroAnio.SelectedIndexChanged += new System.EventHandler(this.combFiltroAnio_SelectedIndexChanged);
            // 
            // lblFiltroAnio
            // 
            this.lblFiltroAnio.AutoSize = true;
            this.lblFiltroAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAnio.Location = new System.Drawing.Point(232, 2);
            this.lblFiltroAnio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroAnio.Name = "lblFiltroAnio";
            this.lblFiltroAnio.Size = new System.Drawing.Size(58, 25);
            this.lblFiltroAnio.TabIndex = 2;
            this.lblFiltroAnio.Text = "Año:";
            // 
            // combFiltroMes
            // 
            this.combFiltroMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combFiltroMes.ImeMode = System.Windows.Forms.ImeMode.On;
            this.combFiltroMes.Items.AddRange(new object[] {
            "Todos",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.combFiltroMes.Location = new System.Drawing.Point(9, 31);
            this.combFiltroMes.Margin = new System.Windows.Forms.Padding(4);
            this.combFiltroMes.Name = "combFiltroMes";
            this.combFiltroMes.Size = new System.Drawing.Size(159, 28);
            this.combFiltroMes.TabIndex = 1;
            this.combFiltroMes.SelectedIndexChanged += new System.EventHandler(this.combFiltroMes_SelectedIndexChanged);
            // 
            // lblFiltroMes
            // 
            this.lblFiltroMes.AutoSize = true;
            this.lblFiltroMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroMes.Location = new System.Drawing.Point(4, 5);
            this.lblFiltroMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroMes.Name = "lblFiltroMes";
            this.lblFiltroMes.Size = new System.Drawing.Size(60, 25);
            this.lblFiltroMes.TabIndex = 0;
            this.lblFiltroMes.Text = "Mes:";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1050, 465);
            this.panel5.TabIndex = 2;
            // 
            // panelPlanificacion
            // 
            this.panelPlanificacion.Controls.Add(this.tableLayoutContenidoPlanificacion);
            this.panelPlanificacion.Controls.Add(this.panelHeaderMetricas);
            this.panelPlanificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlanificacion.Location = new System.Drawing.Point(251, 70);
            this.panelPlanificacion.Margin = new System.Windows.Forms.Padding(4);
            this.panelPlanificacion.Name = "panelPlanificacion";
            this.panelPlanificacion.Size = new System.Drawing.Size(1120, 572);
            this.panelPlanificacion.TabIndex = 6;
            // 
            // tableLayoutContenidoPlanificacion
            // 
            this.tableLayoutContenidoPlanificacion.BackColor = System.Drawing.Color.White;
            this.tableLayoutContenidoPlanificacion.ColumnCount = 2;
            this.tableLayoutContenidoPlanificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContenidoPlanificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContenidoPlanificacion.Controls.Add(this.panelLimitesGastosPorCategoria, 0, 0);
            this.tableLayoutContenidoPlanificacion.Controls.Add(this.panelMetas, 1, 0);
            this.tableLayoutContenidoPlanificacion.Controls.Add(this.panelGastosFuturos, 1, 1);
            this.tableLayoutContenidoPlanificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutContenidoPlanificacion.Location = new System.Drawing.Point(0, 102);
            this.tableLayoutContenidoPlanificacion.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutContenidoPlanificacion.Name = "tableLayoutContenidoPlanificacion";
            this.tableLayoutContenidoPlanificacion.RowCount = 2;
            this.tableLayoutContenidoPlanificacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContenidoPlanificacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContenidoPlanificacion.Size = new System.Drawing.Size(1120, 470);
            this.tableLayoutContenidoPlanificacion.TabIndex = 1;
            // 
            // panelLimitesGastosPorCategoria
            // 
            this.panelLimitesGastosPorCategoria.BackColor = System.Drawing.Color.White;
            this.panelLimitesGastosPorCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLimitesGastosPorCategoria.Controls.Add(this.tableLayoutLimitesPorCategoria);
            this.panelLimitesGastosPorCategoria.Controls.Add(this.panelTituloLimiteGastos);
            this.panelLimitesGastosPorCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLimitesGastosPorCategoria.Location = new System.Drawing.Point(4, 4);
            this.panelLimitesGastosPorCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.panelLimitesGastosPorCategoria.Name = "panelLimitesGastosPorCategoria";
            this.tableLayoutContenidoPlanificacion.SetRowSpan(this.panelLimitesGastosPorCategoria, 2);
            this.panelLimitesGastosPorCategoria.Size = new System.Drawing.Size(552, 462);
            this.panelLimitesGastosPorCategoria.TabIndex = 0;
            // 
            // tableLayoutLimitesPorCategoria
            // 
            this.tableLayoutLimitesPorCategoria.AutoScroll = true;
            this.tableLayoutLimitesPorCategoria.AutoSize = true;
            this.tableLayoutLimitesPorCategoria.ColumnCount = 1;
            this.tableLayoutLimitesPorCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutLimitesPorCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutLimitesPorCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutLimitesPorCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLimitesPorCategoria.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutLimitesPorCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutLimitesPorCategoria.Name = "tableLayoutLimitesPorCategoria";
            this.tableLayoutLimitesPorCategoria.RowCount = 1;
            this.tableLayoutLimitesPorCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLimitesPorCategoria.Size = new System.Drawing.Size(550, 417);
            this.tableLayoutLimitesPorCategoria.TabIndex = 4;
            // 
            // panelTituloLimiteGastos
            // 
            this.panelTituloLimiteGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelTituloLimiteGastos.Controls.Add(this.lblLimiteGastos);
            this.panelTituloLimiteGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloLimiteGastos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloLimiteGastos.Margin = new System.Windows.Forms.Padding(4);
            this.panelTituloLimiteGastos.Name = "panelTituloLimiteGastos";
            this.panelTituloLimiteGastos.Size = new System.Drawing.Size(550, 43);
            this.panelTituloLimiteGastos.TabIndex = 3;
            // 
            // lblLimiteGastos
            // 
            this.lblLimiteGastos.AutoSize = true;
            this.lblLimiteGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteGastos.Location = new System.Drawing.Point(0, 5);
            this.lblLimiteGastos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimiteGastos.Name = "lblLimiteGastos";
            this.lblLimiteGastos.Size = new System.Drawing.Size(312, 25);
            this.lblLimiteGastos.TabIndex = 2;
            this.lblLimiteGastos.Text = "Limites de gastos por categoria";
            // 
            // panelMetas
            // 
            this.panelMetas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMetas.Controls.Add(this.panelEdicionMetas);
            this.panelMetas.Controls.Add(this.tableLayoutMetasAhorro);
            this.panelMetas.Controls.Add(this.panelHeaderMetas);
            this.panelMetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMetas.Location = new System.Drawing.Point(564, 4);
            this.panelMetas.Margin = new System.Windows.Forms.Padding(4);
            this.panelMetas.Name = "panelMetas";
            this.panelMetas.Size = new System.Drawing.Size(552, 227);
            this.panelMetas.TabIndex = 1;
            // 
            // panelEdicionMetas
            // 
            this.panelEdicionMetas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEdicionMetas.Controls.Add(this.btCancelarMeta);
            this.panelEdicionMetas.Controls.Add(this.btAceptarMetaNueva);
            this.panelEdicionMetas.Controls.Add(this.txtSaldoNecesario);
            this.panelEdicionMetas.Controls.Add(this.txtNombreMeta);
            this.panelEdicionMetas.Controls.Add(this.lblSaldoNecesario);
            this.panelEdicionMetas.Controls.Add(this.lblNombreMeta);
            this.panelEdicionMetas.Location = new System.Drawing.Point(270, 43);
            this.panelEdicionMetas.Margin = new System.Windows.Forms.Padding(4);
            this.panelEdicionMetas.Name = "panelEdicionMetas";
            this.panelEdicionMetas.Size = new System.Drawing.Size(280, 182);
            this.panelEdicionMetas.TabIndex = 0;
            this.panelEdicionMetas.Visible = false;
            // 
            // btCancelarMeta
            // 
            this.btCancelarMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarMeta.Location = new System.Drawing.Point(124, 164);
            this.btCancelarMeta.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelarMeta.Name = "btCancelarMeta";
            this.btCancelarMeta.Size = new System.Drawing.Size(133, 41);
            this.btCancelarMeta.TabIndex = 5;
            this.btCancelarMeta.Text = "Cancelar";
            this.btCancelarMeta.UseVisualStyleBackColor = true;
            this.btCancelarMeta.Click += new System.EventHandler(this.btCancelarMeta_Click);
            // 
            // btAceptarMetaNueva
            // 
            this.btAceptarMetaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptarMetaNueva.Location = new System.Drawing.Point(16, 164);
            this.btAceptarMetaNueva.Margin = new System.Windows.Forms.Padding(4);
            this.btAceptarMetaNueva.Name = "btAceptarMetaNueva";
            this.btAceptarMetaNueva.Size = new System.Drawing.Size(100, 41);
            this.btAceptarMetaNueva.TabIndex = 4;
            this.btAceptarMetaNueva.Text = "Aceptar";
            this.btAceptarMetaNueva.UseVisualStyleBackColor = true;
            this.btAceptarMetaNueva.Click += new System.EventHandler(this.btAceptarMetaNueva_Click);
            // 
            // txtSaldoNecesario
            // 
            this.txtSaldoNecesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoNecesario.Location = new System.Drawing.Point(16, 105);
            this.txtSaldoNecesario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldoNecesario.Name = "txtSaldoNecesario";
            this.txtSaldoNecesario.Size = new System.Drawing.Size(161, 26);
            this.txtSaldoNecesario.TabIndex = 3;
            // 
            // txtNombreMeta
            // 
            this.txtNombreMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMeta.Location = new System.Drawing.Point(15, 37);
            this.txtNombreMeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMeta.Name = "txtNombreMeta";
            this.txtNombreMeta.Size = new System.Drawing.Size(161, 26);
            this.txtNombreMeta.TabIndex = 2;
            // 
            // lblSaldoNecesario
            // 
            this.lblSaldoNecesario.AutoSize = true;
            this.lblSaldoNecesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoNecesario.Location = new System.Drawing.Point(9, 76);
            this.lblSaldoNecesario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoNecesario.Name = "lblSaldoNecesario";
            this.lblSaldoNecesario.Size = new System.Drawing.Size(168, 25);
            this.lblSaldoNecesario.TabIndex = 1;
            this.lblSaldoNecesario.Text = "Saldo necesario";
            // 
            // lblNombreMeta
            // 
            this.lblNombreMeta.AutoSize = true;
            this.lblNombreMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMeta.Location = new System.Drawing.Point(9, 9);
            this.lblNombreMeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMeta.Name = "lblNombreMeta";
            this.lblNombreMeta.Size = new System.Drawing.Size(170, 25);
            this.lblNombreMeta.TabIndex = 0;
            this.lblNombreMeta.Text = "Nombre de meta";
            // 
            // tableLayoutMetasAhorro
            // 
            this.tableLayoutMetasAhorro.ColumnCount = 1;
            this.tableLayoutMetasAhorro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMetasAhorro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMetasAhorro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutMetasAhorro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMetasAhorro.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutMetasAhorro.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutMetasAhorro.Name = "tableLayoutMetasAhorro";
            this.tableLayoutMetasAhorro.RowCount = 1;
            this.tableLayoutMetasAhorro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMetasAhorro.Size = new System.Drawing.Size(550, 182);
            this.tableLayoutMetasAhorro.TabIndex = 5;
            // 
            // panelHeaderMetas
            // 
            this.panelHeaderMetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelHeaderMetas.Controls.Add(this.btAnadirMeta);
            this.panelHeaderMetas.Controls.Add(this.lblMetas);
            this.panelHeaderMetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderMetas.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderMetas.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderMetas.Name = "panelHeaderMetas";
            this.panelHeaderMetas.Size = new System.Drawing.Size(550, 43);
            this.panelHeaderMetas.TabIndex = 4;
            // 
            // btAnadirMeta
            // 
            this.btAnadirMeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnadirMeta.BackColor = System.Drawing.Color.White;
            this.btAnadirMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnadirMeta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAnadirMeta.Location = new System.Drawing.Point(429, 2);
            this.btAnadirMeta.Margin = new System.Windows.Forms.Padding(4);
            this.btAnadirMeta.Name = "btAnadirMeta";
            this.btAnadirMeta.Size = new System.Drawing.Size(100, 32);
            this.btAnadirMeta.TabIndex = 3;
            this.btAnadirMeta.Text = "Añadir";
            this.btAnadirMeta.UseVisualStyleBackColor = false;
            this.btAnadirMeta.Click += new System.EventHandler(this.btAnadirMeta_Click);
            // 
            // lblMetas
            // 
            this.lblMetas.AutoSize = true;
            this.lblMetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetas.Location = new System.Drawing.Point(4, 5);
            this.lblMetas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetas.Name = "lblMetas";
            this.lblMetas.Size = new System.Drawing.Size(180, 25);
            this.lblMetas.TabIndex = 2;
            this.lblMetas.Text = "Metas de ahorros";
            // 
            // panelGastosFuturos
            // 
            this.panelGastosFuturos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGastosFuturos.Controls.Add(this.panelEdicionGastoProgramados);
            this.panelGastosFuturos.Controls.Add(this.tableLayoutGastosProgramados);
            this.panelGastosFuturos.Controls.Add(this.panelGastosProgramadosHeader);
            this.panelGastosFuturos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGastosFuturos.Location = new System.Drawing.Point(564, 239);
            this.panelGastosFuturos.Margin = new System.Windows.Forms.Padding(4);
            this.panelGastosFuturos.Name = "panelGastosFuturos";
            this.panelGastosFuturos.Size = new System.Drawing.Size(552, 227);
            this.panelGastosFuturos.TabIndex = 2;
            // 
            // panelEdicionGastoProgramados
            // 
            this.panelEdicionGastoProgramados.Controls.Add(this.btCancelarGastosProgramados);
            this.panelEdicionGastoProgramados.Controls.Add(this.btAceptarGastosProgramados);
            this.panelEdicionGastoProgramados.Controls.Add(this.dtPickFechaPago);
            this.panelEdicionGastoProgramados.Controls.Add(this.gpGastoRepetible);
            this.panelEdicionGastoProgramados.Controls.Add(this.lblFechaGastoProgramado);
            this.panelEdicionGastoProgramados.Controls.Add(this.txtCantidadGasto);
            this.panelEdicionGastoProgramados.Controls.Add(this.txtNombreGasto);
            this.panelEdicionGastoProgramados.Controls.Add(this.lblCantidadGasto);
            this.panelEdicionGastoProgramados.Controls.Add(this.lblNombreGasto);
            this.panelEdicionGastoProgramados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEdicionGastoProgramados.Enabled = false;
            this.panelEdicionGastoProgramados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelEdicionGastoProgramados.Location = new System.Drawing.Point(0, 43);
            this.panelEdicionGastoProgramados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEdicionGastoProgramados.Name = "panelEdicionGastoProgramados";
            this.panelEdicionGastoProgramados.Size = new System.Drawing.Size(550, 182);
            this.panelEdicionGastoProgramados.TabIndex = 0;
            this.panelEdicionGastoProgramados.Visible = false;
            // 
            // btCancelarGastosProgramados
            // 
            this.btCancelarGastosProgramados.Location = new System.Drawing.Point(201, 132);
            this.btCancelarGastosProgramados.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelarGastosProgramados.Name = "btCancelarGastosProgramados";
            this.btCancelarGastosProgramados.Size = new System.Drawing.Size(120, 37);
            this.btCancelarGastosProgramados.TabIndex = 9;
            this.btCancelarGastosProgramados.Text = "Cancelar";
            this.btCancelarGastosProgramados.UseVisualStyleBackColor = true;
            this.btCancelarGastosProgramados.Click += new System.EventHandler(this.btCancelarGastosProgramados_Click);
            // 
            // btAceptarGastosProgramados
            // 
            this.btAceptarGastosProgramados.Location = new System.Drawing.Point(7, 132);
            this.btAceptarGastosProgramados.Margin = new System.Windows.Forms.Padding(4);
            this.btAceptarGastosProgramados.Name = "btAceptarGastosProgramados";
            this.btAceptarGastosProgramados.Size = new System.Drawing.Size(100, 37);
            this.btAceptarGastosProgramados.TabIndex = 8;
            this.btAceptarGastosProgramados.Text = "Aceptar";
            this.btAceptarGastosProgramados.UseVisualStyleBackColor = true;
            this.btAceptarGastosProgramados.Click += new System.EventHandler(this.btAceptarGastosProgramados_Click);
            // 
            // dtPickFechaPago
            // 
            this.dtPickFechaPago.Checked = false;
            this.dtPickFechaPago.CustomFormat = "DD/MM/YYYY";
            this.dtPickFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickFechaPago.Location = new System.Drawing.Point(199, 31);
            this.dtPickFechaPago.Margin = new System.Windows.Forms.Padding(4);
            this.dtPickFechaPago.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtPickFechaPago.Name = "dtPickFechaPago";
            this.dtPickFechaPago.Size = new System.Drawing.Size(148, 25);
            this.dtPickFechaPago.TabIndex = 7;
            // 
            // gpGastoRepetible
            // 
            this.gpGastoRepetible.Controls.Add(this.chkAnual);
            this.gpGastoRepetible.Controls.Add(this.chkMensual);
            this.gpGastoRepetible.Controls.Add(this.chkSemanal);
            this.gpGastoRepetible.Controls.Add(this.chkNoRepetible);
            this.gpGastoRepetible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpGastoRepetible.Location = new System.Drawing.Point(372, 11);
            this.gpGastoRepetible.Margin = new System.Windows.Forms.Padding(4);
            this.gpGastoRepetible.Name = "gpGastoRepetible";
            this.gpGastoRepetible.Padding = new System.Windows.Forms.Padding(4);
            this.gpGastoRepetible.Size = new System.Drawing.Size(172, 158);
            this.gpGastoRepetible.TabIndex = 6;
            this.gpGastoRepetible.TabStop = false;
            this.gpGastoRepetible.Text = "Es Repetible?";
            // 
            // chkAnual
            // 
            this.chkAnual.AutoSize = true;
            this.chkAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkAnual.Location = new System.Drawing.Point(8, 121);
            this.chkAnual.Margin = new System.Windows.Forms.Padding(4);
            this.chkAnual.Name = "chkAnual";
            this.chkAnual.Size = new System.Drawing.Size(71, 24);
            this.chkAnual.TabIndex = 3;
            this.chkAnual.TabStop = true;
            this.chkAnual.Text = "Anual";
            this.chkAnual.UseVisualStyleBackColor = true;
            // 
            // chkMensual
            // 
            this.chkMensual.AutoSize = true;
            this.chkMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkMensual.Location = new System.Drawing.Point(8, 89);
            this.chkMensual.Margin = new System.Windows.Forms.Padding(4);
            this.chkMensual.Name = "chkMensual";
            this.chkMensual.Size = new System.Drawing.Size(90, 24);
            this.chkMensual.TabIndex = 2;
            this.chkMensual.TabStop = true;
            this.chkMensual.Text = "Mensual";
            this.chkMensual.UseVisualStyleBackColor = true;
            // 
            // chkSemanal
            // 
            this.chkSemanal.AutoSize = true;
            this.chkSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSemanal.Location = new System.Drawing.Point(8, 58);
            this.chkSemanal.Margin = new System.Windows.Forms.Padding(4);
            this.chkSemanal.Name = "chkSemanal";
            this.chkSemanal.Size = new System.Drawing.Size(93, 24);
            this.chkSemanal.TabIndex = 1;
            this.chkSemanal.TabStop = true;
            this.chkSemanal.Text = "Semanal";
            this.chkSemanal.UseVisualStyleBackColor = true;
            // 
            // chkNoRepetible
            // 
            this.chkNoRepetible.AutoSize = true;
            this.chkNoRepetible.Checked = true;
            this.chkNoRepetible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNoRepetible.Location = new System.Drawing.Point(8, 26);
            this.chkNoRepetible.Margin = new System.Windows.Forms.Padding(4);
            this.chkNoRepetible.Name = "chkNoRepetible";
            this.chkNoRepetible.Size = new System.Drawing.Size(115, 24);
            this.chkNoRepetible.TabIndex = 0;
            this.chkNoRepetible.TabStop = true;
            this.chkNoRepetible.Text = "No repetible";
            this.chkNoRepetible.UseVisualStyleBackColor = true;
            // 
            // lblFechaGastoProgramado
            // 
            this.lblFechaGastoProgramado.AutoSize = true;
            this.lblFechaGastoProgramado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFechaGastoProgramado.Location = new System.Drawing.Point(197, 12);
            this.lblFechaGastoProgramado.Name = "lblFechaGastoProgramado";
            this.lblFechaGastoProgramado.Size = new System.Drawing.Size(98, 18);
            this.lblFechaGastoProgramado.TabIndex = 5;
            this.lblFechaGastoProgramado.Text = "Fecha Pago";
            // 
            // txtCantidadGasto
            // 
            this.txtCantidadGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCantidadGasto.Location = new System.Drawing.Point(5, 100);
            this.txtCantidadGasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadGasto.Name = "txtCantidadGasto";
            this.txtCantidadGasto.Size = new System.Drawing.Size(100, 24);
            this.txtCantidadGasto.TabIndex = 4;
            // 
            // txtNombreGasto
            // 
            this.txtNombreGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNombreGasto.Location = new System.Drawing.Point(5, 32);
            this.txtNombreGasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreGasto.Name = "txtNombreGasto";
            this.txtNombreGasto.Size = new System.Drawing.Size(147, 24);
            this.txtNombreGasto.TabIndex = 3;
            // 
            // lblCantidadGasto
            // 
            this.lblCantidadGasto.AutoSize = true;
            this.lblCantidadGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCantidadGasto.Location = new System.Drawing.Point(3, 79);
            this.lblCantidadGasto.Name = "lblCantidadGasto";
            this.lblCantidadGasto.Size = new System.Drawing.Size(65, 18);
            this.lblCantidadGasto.TabIndex = 1;
            this.lblCantidadGasto.Text = "Cantiad";
            // 
            // lblNombreGasto
            // 
            this.lblNombreGasto.AutoSize = true;
            this.lblNombreGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNombreGasto.Location = new System.Drawing.Point(3, 11);
            this.lblNombreGasto.Name = "lblNombreGasto";
            this.lblNombreGasto.Size = new System.Drawing.Size(138, 18);
            this.lblNombreGasto.TabIndex = 0;
            this.lblNombreGasto.Text = "Nombre de gasto";
            // 
            // tableLayoutGastosProgramados
            // 
            this.tableLayoutGastosProgramados.ColumnCount = 1;
            this.tableLayoutGastosProgramados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutGastosProgramados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutGastosProgramados.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutGastosProgramados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutGastosProgramados.Name = "tableLayoutGastosProgramados";
            this.tableLayoutGastosProgramados.RowCount = 1;
            this.tableLayoutGastosProgramados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutGastosProgramados.Size = new System.Drawing.Size(550, 182);
            this.tableLayoutGastosProgramados.TabIndex = 0;
            // 
            // panelGastosProgramadosHeader
            // 
            this.panelGastosProgramadosHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelGastosProgramadosHeader.Controls.Add(this.btAnadirGastoProgramado);
            this.panelGastosProgramadosHeader.Controls.Add(this.lblGastosProgramados);
            this.panelGastosProgramadosHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGastosProgramadosHeader.Location = new System.Drawing.Point(0, 0);
            this.panelGastosProgramadosHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelGastosProgramadosHeader.Name = "panelGastosProgramadosHeader";
            this.panelGastosProgramadosHeader.Size = new System.Drawing.Size(550, 43);
            this.panelGastosProgramadosHeader.TabIndex = 4;
            // 
            // btAnadirGastoProgramado
            // 
            this.btAnadirGastoProgramado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnadirGastoProgramado.BackColor = System.Drawing.Color.White;
            this.btAnadirGastoProgramado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnadirGastoProgramado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAnadirGastoProgramado.Location = new System.Drawing.Point(429, 1);
            this.btAnadirGastoProgramado.Margin = new System.Windows.Forms.Padding(4);
            this.btAnadirGastoProgramado.Name = "btAnadirGastoProgramado";
            this.btAnadirGastoProgramado.Size = new System.Drawing.Size(100, 32);
            this.btAnadirGastoProgramado.TabIndex = 4;
            this.btAnadirGastoProgramado.Text = "Añadir";
            this.btAnadirGastoProgramado.UseVisualStyleBackColor = false;
            this.btAnadirGastoProgramado.Click += new System.EventHandler(this.btAnadirGastoProgramado_Click);
            // 
            // lblGastosProgramados
            // 
            this.lblGastosProgramados.AutoSize = true;
            this.lblGastosProgramados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosProgramados.Location = new System.Drawing.Point(0, 5);
            this.lblGastosProgramados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGastosProgramados.Name = "lblGastosProgramados";
            this.lblGastosProgramados.Size = new System.Drawing.Size(212, 25);
            this.lblGastosProgramados.TabIndex = 2;
            this.lblGastosProgramados.Text = "Gastos programados";
            // 
            // panelHeaderMetricas
            // 
            this.panelHeaderMetricas.Controls.Add(this.tableLayoutMetricas);
            this.panelHeaderMetricas.Controls.Add(this.lblMetricas);
            this.panelHeaderMetricas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderMetricas.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderMetricas.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderMetricas.Name = "panelHeaderMetricas";
            this.panelHeaderMetricas.Size = new System.Drawing.Size(1120, 102);
            this.panelHeaderMetricas.TabIndex = 0;
            // 
            // tableLayoutMetricas
            // 
            this.tableLayoutMetricas.BackColor = System.Drawing.Color.White;
            this.tableLayoutMetricas.ColumnCount = 3;
            this.tableLayoutMetricas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutMetricas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutMetricas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutMetricas.Controls.Add(this.panelPresupuesto, 0, 0);
            this.tableLayoutMetricas.Controls.Add(this.panelGastosAsignados, 1, 0);
            this.tableLayoutMetricas.Controls.Add(this.panelAhorroDisponible, 2, 0);
            this.tableLayoutMetricas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutMetricas.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutMetricas.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutMetricas.Name = "tableLayoutMetricas";
            this.tableLayoutMetricas.RowCount = 1;
            this.tableLayoutMetricas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMetricas.Size = new System.Drawing.Size(1120, 54);
            this.tableLayoutMetricas.TabIndex = 1;
            // 
            // panelPresupuesto
            // 
            this.panelPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelPresupuesto.Controls.Add(this.lblPresupuestoMes);
            this.panelPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPresupuesto.Location = new System.Drawing.Point(4, 4);
            this.panelPresupuesto.Margin = new System.Windows.Forms.Padding(4);
            this.panelPresupuesto.Name = "panelPresupuesto";
            this.panelPresupuesto.Size = new System.Drawing.Size(365, 46);
            this.panelPresupuesto.TabIndex = 1;
            // 
            // lblPresupuestoMes
            // 
            this.lblPresupuestoMes.AutoSize = true;
            this.lblPresupuestoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuestoMes.Location = new System.Drawing.Point(4, 11);
            this.lblPresupuestoMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPresupuestoMes.Name = "lblPresupuestoMes";
            this.lblPresupuestoMes.Size = new System.Drawing.Size(222, 25);
            this.lblPresupuestoMes.TabIndex = 1;
            this.lblPresupuestoMes.Text = "Presupuesto del Mes:";
            // 
            // panelGastosAsignados
            // 
            this.panelGastosAsignados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelGastosAsignados.Controls.Add(this.lblGastosAsignados);
            this.panelGastosAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGastosAsignados.Location = new System.Drawing.Point(377, 4);
            this.panelGastosAsignados.Margin = new System.Windows.Forms.Padding(4);
            this.panelGastosAsignados.Name = "panelGastosAsignados";
            this.panelGastosAsignados.Size = new System.Drawing.Size(365, 46);
            this.panelGastosAsignados.TabIndex = 2;
            // 
            // lblGastosAsignados
            // 
            this.lblGastosAsignados.AutoSize = true;
            this.lblGastosAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosAsignados.Location = new System.Drawing.Point(11, 11);
            this.lblGastosAsignados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGastosAsignados.Name = "lblGastosAsignados";
            this.lblGastosAsignados.Size = new System.Drawing.Size(195, 25);
            this.lblGastosAsignados.TabIndex = 2;
            this.lblGastosAsignados.Text = "Gastos Asignados:";
            // 
            // panelAhorroDisponible
            // 
            this.panelAhorroDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelAhorroDisponible.Controls.Add(this.lblAhorroDisponible);
            this.panelAhorroDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAhorroDisponible.Location = new System.Drawing.Point(750, 4);
            this.panelAhorroDisponible.Margin = new System.Windows.Forms.Padding(4);
            this.panelAhorroDisponible.Name = "panelAhorroDisponible";
            this.panelAhorroDisponible.Size = new System.Drawing.Size(366, 46);
            this.panelAhorroDisponible.TabIndex = 3;
            // 
            // lblAhorroDisponible
            // 
            this.lblAhorroDisponible.AutoSize = true;
            this.lblAhorroDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorroDisponible.Location = new System.Drawing.Point(12, 11);
            this.lblAhorroDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAhorroDisponible.Name = "lblAhorroDisponible";
            this.lblAhorroDisponible.Size = new System.Drawing.Size(191, 25);
            this.lblAhorroDisponible.TabIndex = 3;
            this.lblAhorroDisponible.Text = "Ahorro Disponible:";
            // 
            // lblMetricas
            // 
            this.lblMetricas.AutoSize = true;
            this.lblMetricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricas.Location = new System.Drawing.Point(8, 12);
            this.lblMetricas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetricas.Name = "lblMetricas";
            this.lblMetricas.Size = new System.Drawing.Size(125, 31);
            this.lblMetricas.TabIndex = 0;
            this.lblMetricas.Text = "Metricas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(204, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // Ventana_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1371, 642);
            this.Controls.Add(this.panelEdicion);
            this.Controls.Add(this.panelPlanificacion);
            this.Controls.Add(this.panelAnalitica);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ventana_Inicial";
            this.Text = "Personal Finance Manager";
            this.Load += new System.EventHandler(this.Ventana_Inicial_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelEdicion.ResumeLayout(false);
            this.tableLayoutContenidoEditable.ResumeLayout(false);
            this.panelDatosEditablesContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdicion)).EndInit();
            this.panelContenidoEditableHeader.ResumeLayout(false);
            this.panelContenidoEditableHeader.PerformLayout();
            this.panelBuscadorContenido.ResumeLayout(false);
            this.panelBuscadorContenido.PerformLayout();
            this.panelBuscadorEdicionHeader.ResumeLayout(false);
            this.panelBuscadorEdicionHeader.PerformLayout();
            this.tableLayoutEditarAnadirCategoria.ResumeLayout(false);
            this.panelAnadirCategoria.ResumeLayout(false);
            this.panelAnadirCategoria.PerformLayout();
            this.panelEdicionCategorias.ResumeLayout(false);
            this.panelEdicionCategorias.PerformLayout();
            this.panelContenidoGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tblLayoutPanelKpis.ResumeLayout(false);
            this.cardSaldo.ResumeLayout(false);
            this.cardGastos.ResumeLayout(false);
            this.cardIngresos.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelAnalitica.ResumeLayout(false);
            this.tabLayoutAnalitica.ResumeLayout(false);
            this.panelPieChart.ResumeLayout(false);
            this.panelPieChart.PerformLayout();
            this.panelGastosContraIngresos.ResumeLayout(false);
            this.panelGastosContraIngresos.PerformLayout();
            this.panelDataGridPieChartFilter.ResumeLayout(false);
            this.panelDataGridPieChartFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPieChartFiltro)).EndInit();
            this.panelGridTopGastos.ResumeLayout(false);
            this.panelGridTopGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTopGastos)).EndInit();
            this.panelEvolucionDeSueldo.ResumeLayout(false);
            this.panelEvolucionDeSueldo.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelPlanificacion.ResumeLayout(false);
            this.tableLayoutContenidoPlanificacion.ResumeLayout(false);
            this.panelLimitesGastosPorCategoria.ResumeLayout(false);
            this.panelLimitesGastosPorCategoria.PerformLayout();
            this.panelTituloLimiteGastos.ResumeLayout(false);
            this.panelTituloLimiteGastos.PerformLayout();
            this.panelMetas.ResumeLayout(false);
            this.panelEdicionMetas.ResumeLayout(false);
            this.panelEdicionMetas.PerformLayout();
            this.panelHeaderMetas.ResumeLayout(false);
            this.panelHeaderMetas.PerformLayout();
            this.panelGastosFuturos.ResumeLayout(false);
            this.panelEdicionGastoProgramados.ResumeLayout(false);
            this.panelEdicionGastoProgramados.PerformLayout();
            this.gpGastoRepetible.ResumeLayout(false);
            this.gpGastoRepetible.PerformLayout();
            this.panelGastosProgramadosHeader.ResumeLayout(false);
            this.panelGastosProgramadosHeader.PerformLayout();
            this.panelHeaderMetricas.ResumeLayout(false);
            this.panelHeaderMetricas.PerformLayout();
            this.tableLayoutMetricas.ResumeLayout(false);
            this.panelPresupuesto.ResumeLayout(false);
            this.panelPresupuesto.PerformLayout();
            this.panelGastosAsignados.ResumeLayout(false);
            this.panelGastosAsignados.PerformLayout();
            this.panelAhorroDisponible.ResumeLayout(false);
            this.panelAhorroDisponible.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbDashboard;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnMenuPlanificacion;
        private System.Windows.Forms.Button btnMenuEdicion;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnMenuDashboard;
        private System.Windows.Forms.Button btnMenuAnalitica;
        private System.Windows.Forms.Panel panelEdicion;
        private System.Windows.Forms.Label lbAnalitica;
        private System.Windows.Forms.Label lbEdicion;
        private System.Windows.Forms.Label lbPlanificacion;
        private System.Windows.Forms.Panel panelContenidoGrid;
        private System.Windows.Forms.Label lblSubtituloGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelKpis;
        private System.Windows.Forms.Panel cardSaldo;
        private System.Windows.Forms.Label lblSaldoTitulo;
        private System.Windows.Forms.Label lblSaldoValor;
        private System.Windows.Forms.Panel cardGastos;
        private System.Windows.Forms.Label lblGastosTitulo;
        private System.Windows.Forms.Label lblGastosValor;
        private System.Windows.Forms.Panel cardIngresos;
        private System.Windows.Forms.Label lblIngresosTitulo;
        private System.Windows.Forms.Label lblIngresosValor;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelAnalitica;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblFiltroMes;
        private System.Windows.Forms.ComboBox combFiltroMes;
        private System.Windows.Forms.Label lblFiltroAnio;
        private System.Windows.Forms.ComboBox combFiltroAnio;
        private System.Windows.Forms.TableLayoutPanel tabLayoutAnalitica;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Panel panelPieChart;
        private System.Windows.Forms.Panel panelDataGridPieChartFilter;
        private System.Windows.Forms.DataGridView dataGridPieChartFiltro;
        private System.Windows.Forms.Panel panelGastosContraIngresos;
        private LiveCharts.WinForms.CartesianChart cartesianChartGastosContraIngresos;
        private System.Windows.Forms.Panel panelEvolucionDeSueldo;
        private LiveCharts.WinForms.CartesianChart cartesianChartEvolucionSaldo;
        private System.Windows.Forms.Panel panelGridTopGastos;
        private System.Windows.Forms.DataGridView dataGridTopGastos;
        private System.Windows.Forms.Label lblPieChartGastos;
        private System.Windows.Forms.Label lblFiltroPieChart;
        private System.Windows.Forms.Label LblGastosVSIngresos;
        private System.Windows.Forms.Label LblEvolucionDeSueldo;
        private System.Windows.Forms.Label LblTopGastos;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelPlanificacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutContenidoPlanificacion;
        private System.Windows.Forms.Panel panelHeaderMetricas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMetricas;
        private System.Windows.Forms.Panel panelPresupuesto;
        private System.Windows.Forms.Label lblPresupuestoMes;
        private System.Windows.Forms.Panel panelGastosAsignados;
        private System.Windows.Forms.Label lblGastosAsignados;
        private System.Windows.Forms.Panel panelAhorroDisponible;
        private System.Windows.Forms.Label lblAhorroDisponible;
        private System.Windows.Forms.Label lblMetricas;
        private System.Windows.Forms.Panel panelLimitesGastosPorCategoria;
        private System.Windows.Forms.Panel panelTituloLimiteGastos;
        private System.Windows.Forms.Label lblLimiteGastos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLimitesPorCategoria;
        private System.Windows.Forms.Panel panelMetas;
        private System.Windows.Forms.Panel panelGastosFuturos;
        private System.Windows.Forms.Panel panelHeaderMetas;
        private System.Windows.Forms.Label lblMetas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMetasAhorro;
        private System.Windows.Forms.Button btAnadirMeta;
        private System.Windows.Forms.Panel panelEdicionMetas;
        private System.Windows.Forms.Label lblSaldoNecesario;
        private System.Windows.Forms.Label lblNombreMeta;
        private System.Windows.Forms.Button btAceptarMetaNueva;
        private System.Windows.Forms.TextBox txtSaldoNecesario;
        private System.Windows.Forms.TextBox txtNombreMeta;
        private System.Windows.Forms.Button btCancelarMeta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutGastosProgramados;
        private System.Windows.Forms.Panel panelGastosProgramadosHeader;
        private System.Windows.Forms.Label lblGastosProgramados;
        private System.Windows.Forms.Button btAnadirGastoProgramado;
        private System.Windows.Forms.Panel panelEdicionGastoProgramados;
        private System.Windows.Forms.Label lblCantidadGasto;
        private System.Windows.Forms.Label lblNombreGasto;
        private System.Windows.Forms.Label lblFechaGastoProgramado;
        private System.Windows.Forms.TextBox txtCantidadGasto;
        private System.Windows.Forms.TextBox txtNombreGasto;
        private System.Windows.Forms.GroupBox gpGastoRepetible;
        private System.Windows.Forms.RadioButton chkAnual;
        private System.Windows.Forms.RadioButton chkMensual;
        private System.Windows.Forms.RadioButton chkSemanal;
        private System.Windows.Forms.RadioButton chkNoRepetible;
        private System.Windows.Forms.Button btCancelarGastosProgramados;
        private System.Windows.Forms.Button btAceptarGastosProgramados;
        private System.Windows.Forms.DateTimePicker dtPickFechaPago;
        private System.Windows.Forms.Panel panelEdicionCategorias;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutContenidoEditable;
        private System.Windows.Forms.Label lblConceptoEditado;
        private System.Windows.Forms.Label lblCategoriasDisponibles;
        private System.Windows.Forms.TextBox txtConceptoEditable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutEditarAnadirCategoria;
        private System.Windows.Forms.Label lblEditarCategoriaTitulo;
        private System.Windows.Forms.Panel panelAnadirCategoria;
        private System.Windows.Forms.Label lblAnadirCategoria;
        private System.Windows.Forms.Label lblCategoriaNueva;
        private System.Windows.Forms.ComboBox cmbCategoriasDisponibles;
        private System.Windows.Forms.Button btnAceptarEdicionCategoria;
        private System.Windows.Forms.Panel panelContenidoEditableHeader;
        private System.Windows.Forms.Panel panelBuscadorEdicionHeader;
        private System.Windows.Forms.Label lblDatosEditables;
        private System.Windows.Forms.TextBox txtCategoriaNueva;
        private System.Windows.Forms.Button btnAceptarCategoriaNueva;
        private System.Windows.Forms.Label lblBuscadorHeader;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Panel panelBuscadorContenido;
        private System.Windows.Forms.Panel panelDatosEditablesContenido;
        private System.Windows.Forms.DataGridView dataGridViewEdicion;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.Button btnFiltroConcepto;
        private System.Windows.Forms.TextBox txtFiltroConcepto;
        private System.Windows.Forms.Label lblFiltroConcepto;
        private System.Windows.Forms.ComboBox cmbFiltroCategoria;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFiltroFechas;
        private System.Windows.Forms.DateTimePicker dtimeFiltroFin;
        private System.Windows.Forms.DateTimePicker dtimeFiltroInicio;
        private System.Windows.Forms.Label lblFechaFin;
    }
}