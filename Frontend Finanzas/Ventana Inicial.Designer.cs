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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panelPlanificacion = new System.Windows.Forms.Panel();
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
            this.panelPieChart = new System.Windows.Forms.Panel();
            this.lblPieChartGastos = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.tabLayoutAnalitica = new System.Windows.Forms.TableLayoutPanel();
            this.panelDataGridPieChartFilter = new System.Windows.Forms.Panel();
            this.lblFiltroPieChart = new System.Windows.Forms.Label();
            this.dataGridPieChartFiltro = new System.Windows.Forms.DataGridView();
            this.panelGastosContraIngresos = new System.Windows.Forms.Panel();
            this.LblGastosVSIngresos = new System.Windows.Forms.Label();
            this.cartesianChartGastosContraIngresos = new LiveCharts.WinForms.CartesianChart();
            this.panelEvolucionDeSueldo = new System.Windows.Forms.Panel();
            this.LblEvolucionDeSueldo = new System.Windows.Forms.Label();
            this.cartesianChartEvolucionSaldo = new LiveCharts.WinForms.CartesianChart();
            this.panelGridTopGastos = new System.Windows.Forms.Panel();
            this.LblTopGastos = new System.Windows.Forms.Label();
            this.dataGridTopGastos = new System.Windows.Forms.DataGridView();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.combFiltroAnio = new System.Windows.Forms.ComboBox();
            this.vwFiltroAñosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finanzasDBDataSet = new Proyecto_Financiero.FinanzasDBDataSet();
            this.lblFiltroAnio = new System.Windows.Forms.Label();
            this.combFiltroMes = new System.Windows.Forms.ComboBox();
            this.lblFiltroMes = new System.Windows.Forms.Label();
            this.vw_Filtro_AñosTableAdapter = new Proyecto_Financiero.FinanzasDBDataSetTableAdapters.vw_Filtro_AñosTableAdapter();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContenidoGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tblLayoutPanelKpis.SuspendLayout();
            this.cardSaldo.SuspendLayout();
            this.cardGastos.SuspendLayout();
            this.cardIngresos.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelAnalitica.SuspendLayout();
            this.panelPieChart.SuspendLayout();
            this.tabLayoutAnalitica.SuspendLayout();
            this.panelDataGridPieChartFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPieChartFiltro)).BeginInit();
            this.panelGastosContraIngresos.SuspendLayout();
            this.panelEvolucionDeSueldo.SuspendLayout();
            this.panelGridTopGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTopGastos)).BeginInit();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwFiltroAñosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanzasDBDataSet)).BeginInit();
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
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1118, 57);
            this.panelHeader.TabIndex = 3;
            // 
            // lbDashboard
            // 
            this.lbDashboard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbDashboard.Location = new System.Drawing.Point(15, 12);
            this.lbDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDashboard.Name = "lbDashboard";
            this.lbDashboard.Size = new System.Drawing.Size(300, 32);
            this.lbDashboard.TabIndex = 0;
            this.lbDashboard.Text = "Dashboard";
            // 
            // lbAnalitica
            // 
            this.lbAnalitica.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbAnalitica.Location = new System.Drawing.Point(23, 12);
            this.lbAnalitica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAnalitica.Name = "lbAnalitica";
            this.lbAnalitica.Size = new System.Drawing.Size(300, 32);
            this.lbAnalitica.TabIndex = 1;
            this.lbAnalitica.Text = "Analitica";
            this.lbAnalitica.Visible = false;
            // 
            // lbPlanificacion
            // 
            this.lbPlanificacion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbPlanificacion.Location = new System.Drawing.Point(15, 12);
            this.lbPlanificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPlanificacion.Name = "lbPlanificacion";
            this.lbPlanificacion.Size = new System.Drawing.Size(300, 32);
            this.lbPlanificacion.TabIndex = 2;
            this.lbPlanificacion.Text = "Planificacion";
            this.lbPlanificacion.Visible = false;
            // 
            // lbEdicion
            // 
            this.lbEdicion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbEdicion.Location = new System.Drawing.Point(15, 12);
            this.lbEdicion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEdicion.Name = "lbEdicion";
            this.lbEdicion.Size = new System.Drawing.Size(300, 32);
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
            this.panelSidebar.Location = new System.Drawing.Point(0, 57);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(150, 465);
            this.panelSidebar.TabIndex = 4;
            // 
            // btnMenuPlanificacion
            // 
            this.btnMenuPlanificacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuPlanificacion.FlatAppearance.BorderSize = 0;
            this.btnMenuPlanificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPlanificacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuPlanificacion.Location = new System.Drawing.Point(9, 159);
            this.btnMenuPlanificacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuPlanificacion.Name = "btnMenuPlanificacion";
            this.btnMenuPlanificacion.Size = new System.Drawing.Size(132, 32);
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
            this.btnMenuEdicion.Location = new System.Drawing.Point(9, 213);
            this.btnMenuEdicion.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuEdicion.Name = "btnMenuEdicion";
            this.btnMenuEdicion.Size = new System.Drawing.Size(132, 32);
            this.btnMenuEdicion.TabIndex = 3;
            this.btnMenuEdicion.Text = "📝 Edicion";
            this.btnMenuEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEdicion.UseVisualStyleBackColor = false;
            this.btnMenuEdicion.Click += new System.EventHandler(this.btnMenuEdicion_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogo.Location = new System.Drawing.Point(9, 16);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(132, 33);
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
            this.btnMenuDashboard.Location = new System.Drawing.Point(9, 51);
            this.btnMenuDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Size = new System.Drawing.Size(132, 32);
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
            this.btnMenuAnalitica.Location = new System.Drawing.Point(9, 105);
            this.btnMenuAnalitica.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuAnalitica.Name = "btnMenuAnalitica";
            this.btnMenuAnalitica.Size = new System.Drawing.Size(132, 32);
            this.btnMenuAnalitica.TabIndex = 2;
            this.btnMenuAnalitica.Text = "📊 Analitica";
            this.btnMenuAnalitica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAnalitica.UseVisualStyleBackColor = false;
            this.btnMenuAnalitica.Click += new System.EventHandler(this.btnMenuAnalitica_Click);
            // 
            // panelEdicion
            // 
            this.panelEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEdicion.Location = new System.Drawing.Point(150, 57);
            this.panelEdicion.Name = "panelEdicion";
            this.panelEdicion.Size = new System.Drawing.Size(968, 465);
            this.panelEdicion.TabIndex = 6;
            // 
            // panelPlanificacion
            // 
            this.panelPlanificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlanificacion.Location = new System.Drawing.Point(150, 57);
            this.panelPlanificacion.Name = "panelPlanificacion";
            this.panelPlanificacion.Size = new System.Drawing.Size(968, 465);
            this.panelPlanificacion.TabIndex = 6;
            // 
            // panelContenidoGrid
            // 
            this.panelContenidoGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenidoGrid.AutoSize = true;
            this.panelContenidoGrid.BackColor = System.Drawing.Color.White;
            this.panelContenidoGrid.Controls.Add(this.lblSubtituloGrid);
            this.panelContenidoGrid.Controls.Add(this.dataGridView1);
            this.panelContenidoGrid.Location = new System.Drawing.Point(7, 114);
            this.panelContenidoGrid.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenidoGrid.Name = "panelContenidoGrid";
            this.panelContenidoGrid.Size = new System.Drawing.Size(961, 349);
            this.panelContenidoGrid.TabIndex = 1;
            // 
            // lblSubtituloGrid
            // 
            this.lblSubtituloGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtituloGrid.Location = new System.Drawing.Point(11, 12);
            this.lblSubtituloGrid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtituloGrid.Name = "lblSubtituloGrid";
            this.lblSubtituloGrid.Size = new System.Drawing.Size(225, 20);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 12;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(11, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(940, 295);
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
            this.tblLayoutPanelKpis.Name = "tblLayoutPanelKpis";
            this.tblLayoutPanelKpis.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tblLayoutPanelKpis.RowCount = 1;
            this.tblLayoutPanelKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tblLayoutPanelKpis.Size = new System.Drawing.Size(968, 109);
            this.tblLayoutPanelKpis.TabIndex = 5;
            // 
            // cardSaldo
            // 
            this.cardSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(247)))));
            this.cardSaldo.Controls.Add(this.lblSaldoTitulo);
            this.cardSaldo.Controls.Add(this.lblSaldoValor);
            this.cardSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSaldo.Location = new System.Drawing.Point(12, 2);
            this.cardSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.cardSaldo.Name = "cardSaldo";
            this.cardSaldo.Size = new System.Drawing.Size(312, 105);
            this.cardSaldo.TabIndex = 0;
            // 
            // lblSaldoTitulo
            // 
            this.lblSaldoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSaldoTitulo.Location = new System.Drawing.Point(11, 12);
            this.lblSaldoTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldoTitulo.Name = "lblSaldoTitulo";
            this.lblSaldoTitulo.Size = new System.Drawing.Size(150, 16);
            this.lblSaldoTitulo.TabIndex = 0;
            this.lblSaldoTitulo.Text = "SALDO ACTUAL";
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSaldoValor.Location = new System.Drawing.Point(11, 37);
            this.lblSaldoValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(188, 41);
            this.lblSaldoValor.TabIndex = 1;
            this.lblSaldoValor.Text = " €";
            // 
            // cardGastos
            // 
            this.cardGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cardGastos.Controls.Add(this.lblGastosTitulo);
            this.cardGastos.Controls.Add(this.lblGastosValor);
            this.cardGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGastos.Location = new System.Drawing.Point(644, 2);
            this.cardGastos.Margin = new System.Windows.Forms.Padding(2);
            this.cardGastos.Name = "cardGastos";
            this.cardGastos.Size = new System.Drawing.Size(312, 105);
            this.cardGastos.TabIndex = 2;
            // 
            // lblGastosTitulo
            // 
            this.lblGastosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGastosTitulo.Location = new System.Drawing.Point(11, 12);
            this.lblGastosTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGastosTitulo.Name = "lblGastosTitulo";
            this.lblGastosTitulo.Size = new System.Drawing.Size(150, 16);
            this.lblGastosTitulo.TabIndex = 0;
            this.lblGastosTitulo.Text = "GASTOS DEL MES";
            // 
            // lblGastosValor
            // 
            this.lblGastosValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblGastosValor.Location = new System.Drawing.Point(11, 37);
            this.lblGastosValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGastosValor.Name = "lblGastosValor";
            this.lblGastosValor.Size = new System.Drawing.Size(188, 41);
            this.lblGastosValor.TabIndex = 1;
            this.lblGastosValor.Text = "€";
            // 
            // cardIngresos
            // 
            this.cardIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(202)))));
            this.cardIngresos.Controls.Add(this.lblIngresosTitulo);
            this.cardIngresos.Controls.Add(this.lblIngresosValor);
            this.cardIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardIngresos.Location = new System.Drawing.Point(328, 2);
            this.cardIngresos.Margin = new System.Windows.Forms.Padding(2);
            this.cardIngresos.Name = "cardIngresos";
            this.cardIngresos.Size = new System.Drawing.Size(312, 105);
            this.cardIngresos.TabIndex = 1;
            // 
            // lblIngresosTitulo
            // 
            this.lblIngresosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIngresosTitulo.Location = new System.Drawing.Point(11, 12);
            this.lblIngresosTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresosTitulo.Name = "lblIngresosTitulo";
            this.lblIngresosTitulo.Size = new System.Drawing.Size(150, 16);
            this.lblIngresosTitulo.TabIndex = 0;
            this.lblIngresosTitulo.Text = "INGRESOS DEL MES";
            // 
            // lblIngresosValor
            // 
            this.lblIngresosValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblIngresosValor.Location = new System.Drawing.Point(11, 37);
            this.lblIngresosValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresosValor.Name = "lblIngresosValor";
            this.lblIngresosValor.Size = new System.Drawing.Size(188, 41);
            this.lblIngresosValor.TabIndex = 1;
            this.lblIngresosValor.Text = "€";
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.tblLayoutPanelKpis);
            this.panelDashboard.Controls.Add(this.panelContenidoGrid);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(150, 57);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(968, 465);
            this.panelDashboard.TabIndex = 1;
            // 
            // panelAnalitica
            // 
            this.panelAnalitica.Controls.Add(this.panelPieChart);
            this.panelAnalitica.Controls.Add(this.tabLayoutAnalitica);
            this.panelAnalitica.Controls.Add(this.panelFiltros);
            this.panelAnalitica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnalitica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelAnalitica.Location = new System.Drawing.Point(150, 57);
            this.panelAnalitica.Name = "panelAnalitica";
            this.panelAnalitica.Size = new System.Drawing.Size(968, 465);
            this.panelAnalitica.TabIndex = 5;
            // 
            // panelPieChart
            // 
            this.panelPieChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPieChart.BackColor = System.Drawing.Color.White;
            this.panelPieChart.Controls.Add(this.lblPieChartGastos);
            this.panelPieChart.Controls.Add(this.pieChart1);
            this.panelPieChart.Location = new System.Drawing.Point(0, 57);
            this.panelPieChart.Name = "panelPieChart";
            this.panelPieChart.Size = new System.Drawing.Size(246, 408);
            this.panelPieChart.TabIndex = 2;
            // 
            // lblPieChartGastos
            // 
            this.lblPieChartGastos.AutoSize = true;
            this.lblPieChartGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieChartGastos.Location = new System.Drawing.Point(13, 0);
            this.lblPieChartGastos.Name = "lblPieChartGastos";
            this.lblPieChartGastos.Size = new System.Drawing.Size(223, 29);
            this.lblPieChartGastos.TabIndex = 1;
            this.lblPieChartGastos.Text = "Pie Chart de gastos";
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pieChart1.Location = new System.Drawing.Point(0, 35);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(246, 373);
            this.pieChart1.TabIndex = 0;
            // 
            // tabLayoutAnalitica
            // 
            this.tabLayoutAnalitica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLayoutAnalitica.BackColor = System.Drawing.Color.White;
            this.tabLayoutAnalitica.ColumnCount = 2;
            this.tabLayoutAnalitica.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayoutAnalitica.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayoutAnalitica.Controls.Add(this.panelDataGridPieChartFilter, 0, 0);
            this.tabLayoutAnalitica.Controls.Add(this.panelGastosContraIngresos, 1, 0);
            this.tabLayoutAnalitica.Controls.Add(this.panelEvolucionDeSueldo, 0, 1);
            this.tabLayoutAnalitica.Controls.Add(this.panelGridTopGastos, 1, 1);
            this.tabLayoutAnalitica.Location = new System.Drawing.Point(249, 57);
            this.tabLayoutAnalitica.Name = "tabLayoutAnalitica";
            this.tabLayoutAnalitica.RowCount = 2;
            this.tabLayoutAnalitica.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayoutAnalitica.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayoutAnalitica.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayoutAnalitica.Size = new System.Drawing.Size(716, 406);
            this.tabLayoutAnalitica.TabIndex = 1;
            // 
            // panelDataGridPieChartFilter
            // 
            this.panelDataGridPieChartFilter.Controls.Add(this.lblFiltroPieChart);
            this.panelDataGridPieChartFilter.Controls.Add(this.dataGridPieChartFiltro);
            this.panelDataGridPieChartFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridPieChartFilter.Location = new System.Drawing.Point(3, 3);
            this.panelDataGridPieChartFilter.Name = "panelDataGridPieChartFilter";
            this.panelDataGridPieChartFilter.Size = new System.Drawing.Size(352, 197);
            this.panelDataGridPieChartFilter.TabIndex = 6;
            // 
            // lblFiltroPieChart
            // 
            this.lblFiltroPieChart.AutoSize = true;
            this.lblFiltroPieChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFiltroPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroPieChart.Location = new System.Drawing.Point(0, 0);
            this.lblFiltroPieChart.Name = "lblFiltroPieChart";
            this.lblFiltroPieChart.Size = new System.Drawing.Size(173, 29);
            this.lblFiltroPieChart.TabIndex = 5;
            this.lblFiltroPieChart.Text = "Filtro Pie Chart";
            // 
            // dataGridPieChartFiltro
            // 
            this.dataGridPieChartFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPieChartFiltro.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPieChartFiltro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridPieChartFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPieChartFiltro.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridPieChartFiltro.Location = new System.Drawing.Point(0, 32);
            this.dataGridPieChartFiltro.Name = "dataGridPieChartFiltro";
            this.dataGridPieChartFiltro.Size = new System.Drawing.Size(352, 165);
            this.dataGridPieChartFiltro.TabIndex = 4;
            // 
            // panelGastosContraIngresos
            // 
            this.panelGastosContraIngresos.Controls.Add(this.LblGastosVSIngresos);
            this.panelGastosContraIngresos.Controls.Add(this.cartesianChartGastosContraIngresos);
            this.panelGastosContraIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGastosContraIngresos.Location = new System.Drawing.Point(361, 3);
            this.panelGastosContraIngresos.Name = "panelGastosContraIngresos";
            this.panelGastosContraIngresos.Size = new System.Drawing.Size(352, 197);
            this.panelGastosContraIngresos.TabIndex = 7;
            // 
            // LblGastosVSIngresos
            // 
            this.LblGastosVSIngresos.AutoSize = true;
            this.LblGastosVSIngresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblGastosVSIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGastosVSIngresos.Location = new System.Drawing.Point(0, 0);
            this.LblGastosVSIngresos.Name = "LblGastosVSIngresos";
            this.LblGastosVSIngresos.Size = new System.Drawing.Size(224, 29);
            this.LblGastosVSIngresos.TabIndex = 6;
            this.LblGastosVSIngresos.Text = "Gastos VS Ingresos";
            // 
            // cartesianChartGastosContraIngresos
            // 
            this.cartesianChartGastosContraIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartGastosContraIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cartesianChartGastosContraIngresos.Location = new System.Drawing.Point(0, 32);
            this.cartesianChartGastosContraIngresos.Name = "cartesianChartGastosContraIngresos";
            this.cartesianChartGastosContraIngresos.Size = new System.Drawing.Size(352, 165);
            this.cartesianChartGastosContraIngresos.TabIndex = 5;
            this.cartesianChartGastosContraIngresos.Text = "cartesianChart2";
            // 
            // panelEvolucionDeSueldo
            // 
            this.panelEvolucionDeSueldo.Controls.Add(this.LblEvolucionDeSueldo);
            this.panelEvolucionDeSueldo.Controls.Add(this.cartesianChartEvolucionSaldo);
            this.panelEvolucionDeSueldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEvolucionDeSueldo.Location = new System.Drawing.Point(3, 206);
            this.panelEvolucionDeSueldo.Name = "panelEvolucionDeSueldo";
            this.panelEvolucionDeSueldo.Size = new System.Drawing.Size(352, 197);
            this.panelEvolucionDeSueldo.TabIndex = 8;
            // 
            // LblEvolucionDeSueldo
            // 
            this.LblEvolucionDeSueldo.AutoSize = true;
            this.LblEvolucionDeSueldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblEvolucionDeSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEvolucionDeSueldo.Location = new System.Drawing.Point(0, 0);
            this.LblEvolucionDeSueldo.Name = "LblEvolucionDeSueldo";
            this.LblEvolucionDeSueldo.Size = new System.Drawing.Size(235, 29);
            this.LblEvolucionDeSueldo.TabIndex = 7;
            this.LblEvolucionDeSueldo.Text = "Evolucion de Sueldo";
            // 
            // cartesianChartEvolucionSaldo
            // 
            this.cartesianChartEvolucionSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartEvolucionSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cartesianChartEvolucionSaldo.Location = new System.Drawing.Point(0, 32);
            this.cartesianChartEvolucionSaldo.Name = "cartesianChartEvolucionSaldo";
            this.cartesianChartEvolucionSaldo.Size = new System.Drawing.Size(352, 165);
            this.cartesianChartEvolucionSaldo.TabIndex = 3;
            this.cartesianChartEvolucionSaldo.Text = "cartesianChart1";
            // 
            // panelGridTopGastos
            // 
            this.panelGridTopGastos.Controls.Add(this.LblTopGastos);
            this.panelGridTopGastos.Controls.Add(this.dataGridTopGastos);
            this.panelGridTopGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridTopGastos.Location = new System.Drawing.Point(361, 206);
            this.panelGridTopGastos.Name = "panelGridTopGastos";
            this.panelGridTopGastos.Size = new System.Drawing.Size(352, 197);
            this.panelGridTopGastos.TabIndex = 9;
            // 
            // LblTopGastos
            // 
            this.LblTopGastos.AutoSize = true;
            this.LblTopGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTopGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTopGastos.Location = new System.Drawing.Point(0, 0);
            this.LblTopGastos.Name = "LblTopGastos";
            this.LblTopGastos.Size = new System.Drawing.Size(264, 29);
            this.LblTopGastos.TabIndex = 7;
            this.LblTopGastos.Text = "Top 10 mayores gastos";
            // 
            // dataGridTopGastos
            // 
            this.dataGridTopGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTopGastos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTopGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridTopGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTopGastos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridTopGastos.Location = new System.Drawing.Point(0, 32);
            this.dataGridTopGastos.Name = "dataGridTopGastos";
            this.dataGridTopGastos.Size = new System.Drawing.Size(352, 165);
            this.dataGridTopGastos.TabIndex = 6;
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
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(968, 57);
            this.panelFiltros.TabIndex = 0;
            // 
            // combFiltroAnio
            // 
            this.combFiltroAnio.DataSource = this.vwFiltroAñosBindingSource;
            this.combFiltroAnio.DisplayMember = "Año";
            this.combFiltroAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combFiltroAnio.ImeMode = System.Windows.Forms.ImeMode.On;
            this.combFiltroAnio.Location = new System.Drawing.Point(131, 27);
            this.combFiltroAnio.Name = "combFiltroAnio";
            this.combFiltroAnio.Size = new System.Drawing.Size(95, 24);
            this.combFiltroAnio.TabIndex = 3;
            this.combFiltroAnio.ValueMember = "Año";
            this.combFiltroAnio.SelectedIndexChanged += new System.EventHandler(this.combFiltroAnio_SelectedIndexChanged);
            // 
            // vwFiltroAñosBindingSource
            // 
            this.vwFiltroAñosBindingSource.DataMember = "vw_Filtro_Años";
            this.vwFiltroAñosBindingSource.DataSource = this.finanzasDBDataSet;
            // 
            // finanzasDBDataSet
            // 
            this.finanzasDBDataSet.DataSetName = "FinanzasDBDataSet";
            this.finanzasDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFiltroAnio
            // 
            this.lblFiltroAnio.AutoSize = true;
            this.lblFiltroAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAnio.Location = new System.Drawing.Point(127, 4);
            this.lblFiltroAnio.Name = "lblFiltroAnio";
            this.lblFiltroAnio.Size = new System.Drawing.Size(46, 20);
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
            this.combFiltroMes.Location = new System.Drawing.Point(7, 27);
            this.combFiltroMes.Name = "combFiltroMes";
            this.combFiltroMes.Size = new System.Drawing.Size(95, 24);
            this.combFiltroMes.TabIndex = 1;
            this.combFiltroMes.SelectedIndexChanged += new System.EventHandler(this.combFiltroMes_SelectedIndexChanged);
            // 
            // lblFiltroMes
            // 
            this.lblFiltroMes.AutoSize = true;
            this.lblFiltroMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroMes.Location = new System.Drawing.Point(3, 4);
            this.lblFiltroMes.Name = "lblFiltroMes";
            this.lblFiltroMes.Size = new System.Drawing.Size(47, 20);
            this.lblFiltroMes.TabIndex = 0;
            this.lblFiltroMes.Text = "Mes:";
            // 
            // vw_Filtro_AñosTableAdapter
            // 
            this.vw_Filtro_AñosTableAdapter.ClearBeforeFill = true;
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
            // Ventana_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1118, 522);
            this.Controls.Add(this.panelAnalitica);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelPlanificacion);
            this.Controls.Add(this.panelEdicion);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ventana_Inicial";
            this.Text = "Personal Finance Manager";
            this.Load += new System.EventHandler(this.Ventana_Inicial_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelContenidoGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tblLayoutPanelKpis.ResumeLayout(false);
            this.cardSaldo.ResumeLayout(false);
            this.cardGastos.ResumeLayout(false);
            this.cardIngresos.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelAnalitica.ResumeLayout(false);
            this.panelPieChart.ResumeLayout(false);
            this.panelPieChart.PerformLayout();
            this.tabLayoutAnalitica.ResumeLayout(false);
            this.panelDataGridPieChartFilter.ResumeLayout(false);
            this.panelDataGridPieChartFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPieChartFiltro)).EndInit();
            this.panelGastosContraIngresos.ResumeLayout(false);
            this.panelGastosContraIngresos.PerformLayout();
            this.panelEvolucionDeSueldo.ResumeLayout(false);
            this.panelEvolucionDeSueldo.PerformLayout();
            this.panelGridTopGastos.ResumeLayout(false);
            this.panelGridTopGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTopGastos)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwFiltroAñosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanzasDBDataSet)).EndInit();
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
        private System.Windows.Forms.Panel panelPlanificacion;
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
        private FinanzasDBDataSet finanzasDBDataSet;
        private System.Windows.Forms.BindingSource vwFiltroAñosBindingSource;
        private FinanzasDBDataSetTableAdapters.vw_Filtro_AñosTableAdapter vw_Filtro_AñosTableAdapter;
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
    }
}