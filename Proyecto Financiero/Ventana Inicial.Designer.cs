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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMenuDashboard = new System.Windows.Forms.Button();
            this.btnMenuTransacciones = new System.Windows.Forms.Button();
            this.btnMenuReportes = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTituloHeader = new System.Windows.Forms.Label();
            this.cardSaldo = new System.Windows.Forms.Panel();
            this.lblSaldoTitulo = new System.Windows.Forms.Label();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.cardIngresos = new System.Windows.Forms.Panel();
            this.lblIngresosTitulo = new System.Windows.Forms.Label();
            this.lblIngresosValor = new System.Windows.Forms.Label();
            this.cardGastos = new System.Windows.Forms.Panel();
            this.lblGastosTitulo = new System.Windows.Forms.Label();
            this.lblGastosValor = new System.Windows.Forms.Label();
            this.panelContenidoGrid = new System.Windows.Forms.Panel();
            this.lblSubtituloGrid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.lblTituloAcciones = new System.Windows.Forms.Label();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Panel();
            this.panelKpis = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.cardSaldo.SuspendLayout();
            this.cardIngresos.SuspendLayout();
            this.cardGastos.SuspendLayout();
            this.panelContenidoGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAcciones.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.panelKpis.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Controls.Add(this.btnMenuDashboard);
            this.panelSidebar.Controls.Add(this.btnMenuTransacciones);
            this.panelSidebar.Controls.Add(this.btnMenuReportes);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 57);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(150, 465);
            this.panelSidebar.TabIndex = 4;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogo.Location = new System.Drawing.Point(9, 16);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(132, 41);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Personal Finance";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.FlatAppearance.BorderSize = 0;
            this.btnMenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuDashboard.Location = new System.Drawing.Point(9, 65);
            this.btnMenuDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Size = new System.Drawing.Size(132, 32);
            this.btnMenuDashboard.TabIndex = 1;
            this.btnMenuDashboard.Text = "  Dashboard";
            this.btnMenuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMenuTransacciones
            // 
            this.btnMenuTransacciones.FlatAppearance.BorderSize = 0;
            this.btnMenuTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTransacciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuTransacciones.Location = new System.Drawing.Point(9, 106);
            this.btnMenuTransacciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuTransacciones.Name = "btnMenuTransacciones";
            this.btnMenuTransacciones.Size = new System.Drawing.Size(132, 32);
            this.btnMenuTransacciones.TabIndex = 2;
            this.btnMenuTransacciones.Text = "  Transacciones";
            this.btnMenuTransacciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMenuReportes
            // 
            this.btnMenuReportes.FlatAppearance.BorderSize = 0;
            this.btnMenuReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuReportes.Location = new System.Drawing.Point(9, 146);
            this.btnMenuReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuReportes.Name = "btnMenuReportes";
            this.btnMenuReportes.Size = new System.Drawing.Size(132, 32);
            this.btnMenuReportes.TabIndex = 3;
            this.btnMenuReportes.Text = "  Reportes";
            this.btnMenuReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTituloHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1118, 57);
            this.panelHeader.TabIndex = 3;
            // 
            // lblTituloHeader
            // 
            this.lblTituloHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloHeader.Location = new System.Drawing.Point(15, 12);
            this.lblTituloHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloHeader.Name = "lblTituloHeader";
            this.lblTituloHeader.Size = new System.Drawing.Size(300, 32);
            this.lblTituloHeader.TabIndex = 0;
            this.lblTituloHeader.Text = "Dashboard Finanzas";
            // 
            // cardSaldo
            // 
            this.cardSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(247)))));
            this.cardSaldo.Controls.Add(this.lblSaldoTitulo);
            this.cardSaldo.Controls.Add(this.lblSaldoValor);
            this.cardSaldo.Location = new System.Drawing.Point(13, 2);
            this.cardSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.cardSaldo.Name = "cardSaldo";
            this.cardSaldo.Size = new System.Drawing.Size(210, 98);
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
            this.lblSaldoValor.Text = "1.319,31 €";
            // 
            // cardIngresos
            // 
            this.cardIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(202)))));
            this.cardIngresos.Controls.Add(this.lblIngresosTitulo);
            this.cardIngresos.Controls.Add(this.lblIngresosValor);
            this.cardIngresos.Location = new System.Drawing.Point(227, 2);
            this.cardIngresos.Margin = new System.Windows.Forms.Padding(2);
            this.cardIngresos.Name = "cardIngresos";
            this.cardIngresos.Size = new System.Drawing.Size(210, 98);
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
            this.lblIngresosValor.Text = "2.450,00 €";
            // 
            // cardGastos
            // 
            this.cardGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cardGastos.Controls.Add(this.lblGastosTitulo);
            this.cardGastos.Controls.Add(this.lblGastosValor);
            this.cardGastos.Location = new System.Drawing.Point(441, 2);
            this.cardGastos.Margin = new System.Windows.Forms.Padding(2);
            this.cardGastos.Name = "cardGastos";
            this.cardGastos.Size = new System.Drawing.Size(210, 98);
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
            this.lblGastosValor.Text = "-1.130,69 €";
            // 
            // panelContenidoGrid
            // 
            this.panelContenidoGrid.BackColor = System.Drawing.Color.White;
            this.panelContenidoGrid.Controls.Add(this.lblSubtituloGrid);
            this.panelContenidoGrid.Controls.Add(this.dataGridView1);
            this.panelContenidoGrid.Location = new System.Drawing.Point(163, 187);
            this.panelContenidoGrid.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenidoGrid.Name = "panelContenidoGrid";
            this.panelContenidoGrid.Size = new System.Drawing.Size(766, 324);
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeight = 12;
            this.dataGridView1.Location = new System.Drawing.Point(11, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(740, 270);
            this.dataGridView1.TabIndex = 1;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.White;
            this.panelAcciones.Controls.Add(this.lblTituloAcciones);
            this.panelAcciones.Controls.Add(this.btnVerReportes);
            this.panelAcciones.Controls.Add(this.btnNuevaCategoria);
            this.panelAcciones.Controls.Add(this.btnConfiguracion);
            this.panelAcciones.Location = new System.Drawing.Point(935, 57);
            this.panelAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(172, 471);
            this.panelAcciones.TabIndex = 0;
            // 
            // lblTituloAcciones
            // 
            this.lblTituloAcciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloAcciones.Location = new System.Drawing.Point(11, 12);
            this.lblTituloAcciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloAcciones.Name = "lblTituloAcciones";
            this.lblTituloAcciones.Size = new System.Drawing.Size(150, 20);
            this.lblTituloAcciones.TabIndex = 0;
            this.lblTituloAcciones.Text = "ACCIONES RÁPIDAS";
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.btnVerReportes.FlatAppearance.BorderSize = 0;
            this.btnVerReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReportes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnVerReportes.Location = new System.Drawing.Point(11, 39);
            this.btnVerReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(150, 32);
            this.btnVerReportes.TabIndex = 2;
            this.btnVerReportes.Text = "📊 Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = false;
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.btnNuevaCategoria.FlatAppearance.BorderSize = 0;
            this.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNuevaCategoria.Location = new System.Drawing.Point(11, 75);
            this.btnNuevaCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Size = new System.Drawing.Size(150, 32);
            this.btnNuevaCategoria.TabIndex = 3;
            this.btnNuevaCategoria.Text = "➕ Nueva Categoría";
            this.btnNuevaCategoria.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnConfiguracion.Location = new System.Drawing.Point(15, 422);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(150, 32);
            this.btnConfiguracion.TabIndex = 4;
            this.btnConfiguracion.Text = "⚙️ Configuración";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.panelKpis);
            this.Dashboard.Controls.Add(this.panelAcciones);
            this.Dashboard.Controls.Add(this.panelSidebar);
            this.Dashboard.Controls.Add(this.panelHeader);
            this.Dashboard.Controls.Add(this.panelContenidoGrid);
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(1118, 522);
            this.Dashboard.TabIndex = 1;
            // 
            // panelKpis
            // 
            this.panelKpis.Controls.Add(this.cardSaldo);
            this.panelKpis.Controls.Add(this.cardIngresos);
            this.panelKpis.Controls.Add(this.cardGastos);
            this.panelKpis.Location = new System.Drawing.Point(150, 57);
            this.panelKpis.Margin = new System.Windows.Forms.Padding(2);
            this.panelKpis.Name = "panelKpis";
            this.panelKpis.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.panelKpis.Size = new System.Drawing.Size(779, 114);
            this.panelKpis.TabIndex = 2;
            // 
            // Ventana_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1118, 522);
            this.Controls.Add(this.Dashboard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ventana_Inicial";
            this.Text = "Personal Finance Manager";
            this.Load += new System.EventHandler(this.Ventana_Inicial_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.cardSaldo.ResumeLayout(false);
            this.cardIngresos.ResumeLayout(false);
            this.cardGastos.ResumeLayout(false);
            this.panelContenidoGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAcciones.ResumeLayout(false);
            this.Dashboard.ResumeLayout(false);
            this.panelKpis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnMenuDashboard;
        private System.Windows.Forms.Button btnMenuTransacciones;
        private System.Windows.Forms.Button btnMenuReportes;
        private System.Windows.Forms.Panel panelHeader;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblTituloHeader;
        private System.Windows.Forms.Panel cardSaldo;
        private System.Windows.Forms.Label lblSaldoTitulo;
        private System.Windows.Forms.Label lblSaldoValor;
        private System.Windows.Forms.Panel cardIngresos;
        private System.Windows.Forms.Label lblIngresosTitulo;
        private System.Windows.Forms.Label lblIngresosValor;
        private System.Windows.Forms.Panel cardGastos;
        private System.Windows.Forms.Label lblGastosTitulo;
        private System.Windows.Forms.Label lblGastosValor;
        private System.Windows.Forms.Panel panelContenidoGrid;
        private System.Windows.Forms.Label lblSubtituloGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Label lblTituloAcciones;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnNuevaCategoria;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Panel Dashboard;
        private System.Windows.Forms.FlowLayoutPanel panelKpis;
    }
}