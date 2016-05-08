namespace Libreria
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReporte = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.rbReportesGenrales = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbReportesFechas = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbReportesEmpleados = new MaterialSkin.Controls.MaterialRadioButton();
            this.panelGenerales = new MetroFramework.Controls.MetroPanel();
            this.btnGenerales = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.rbTVentas = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbTCompras = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbTProductos = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbTEmpleados = new MaterialSkin.Controls.MaterialRadioButton();
            this.panelFechas = new MetroFramework.Controls.MetroPanel();
            this.panelEmpleados = new MetroFramework.Controls.MetroPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtDesde = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dtHasta = new MetroFramework.Controls.MetroDateTime();
            this.rbFVentas = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFCompras = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnFechas = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.panelGenerales.SuspendLayout();
            this.panelFechas.SuspendLayout();
            this.panelEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.Image = null;
            this.btnReporte.Location = new System.Drawing.Point(49, 285);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(145, 36);
            this.btnReporte.Style = MetroFramework.MetroColorStyle.Green;
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseSelectable = true;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Visible = false;
            // 
            // rbReportesGenrales
            // 
            this.rbReportesGenrales.AutoSize = true;
            this.rbReportesGenrales.Depth = 0;
            this.rbReportesGenrales.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbReportesGenrales.Location = new System.Drawing.Point(25, 110);
            this.rbReportesGenrales.Margin = new System.Windows.Forms.Padding(0);
            this.rbReportesGenrales.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbReportesGenrales.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbReportesGenrales.Name = "rbReportesGenrales";
            this.rbReportesGenrales.Ripple = true;
            this.rbReportesGenrales.Size = new System.Drawing.Size(148, 30);
            this.rbReportesGenrales.TabIndex = 1;
            this.rbReportesGenrales.TabStop = true;
            this.rbReportesGenrales.Text = "Reportes generales";
            this.rbReportesGenrales.UseVisualStyleBackColor = true;
            this.rbReportesGenrales.CheckedChanged += new System.EventHandler(this.rbReportesGenrales_CheckedChanged);
            // 
            // rbReportesFechas
            // 
            this.rbReportesFechas.AutoSize = true;
            this.rbReportesFechas.Depth = 0;
            this.rbReportesFechas.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbReportesFechas.Location = new System.Drawing.Point(25, 140);
            this.rbReportesFechas.Margin = new System.Windows.Forms.Padding(0);
            this.rbReportesFechas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbReportesFechas.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbReportesFechas.Name = "rbReportesFechas";
            this.rbReportesFechas.Ripple = true;
            this.rbReportesFechas.Size = new System.Drawing.Size(153, 30);
            this.rbReportesFechas.TabIndex = 2;
            this.rbReportesFechas.TabStop = true;
            this.rbReportesFechas.Text = "Reportes por fechas";
            this.rbReportesFechas.UseVisualStyleBackColor = true;
            this.rbReportesFechas.CheckedChanged += new System.EventHandler(this.rbReportesFechas_CheckedChanged);
            // 
            // rbReportesEmpleados
            // 
            this.rbReportesEmpleados.AutoSize = true;
            this.rbReportesEmpleados.Depth = 0;
            this.rbReportesEmpleados.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbReportesEmpleados.Location = new System.Drawing.Point(25, 170);
            this.rbReportesEmpleados.Margin = new System.Windows.Forms.Padding(0);
            this.rbReportesEmpleados.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbReportesEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbReportesEmpleados.Name = "rbReportesEmpleados";
            this.rbReportesEmpleados.Ripple = true;
            this.rbReportesEmpleados.Size = new System.Drawing.Size(180, 30);
            this.rbReportesEmpleados.TabIndex = 3;
            this.rbReportesEmpleados.TabStop = true;
            this.rbReportesEmpleados.Text = "Reportes por empleados";
            this.rbReportesEmpleados.UseVisualStyleBackColor = true;
            this.rbReportesEmpleados.CheckedChanged += new System.EventHandler(this.rbReportesEmpleados_CheckedChanged);
            // 
            // panelGenerales
            // 
            this.panelGenerales.Controls.Add(this.btnGenerales);
            this.panelGenerales.Controls.Add(this.rbTVentas);
            this.panelGenerales.Controls.Add(this.rbTCompras);
            this.panelGenerales.Controls.Add(this.rbTProductos);
            this.panelGenerales.Controls.Add(this.rbTEmpleados);
            this.panelGenerales.HorizontalScrollbarBarColor = true;
            this.panelGenerales.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGenerales.HorizontalScrollbarSize = 10;
            this.panelGenerales.Location = new System.Drawing.Point(275, 85);
            this.panelGenerales.Name = "panelGenerales";
            this.panelGenerales.Size = new System.Drawing.Size(440, 215);
            this.panelGenerales.TabIndex = 4;
            this.panelGenerales.VerticalScrollbarBarColor = true;
            this.panelGenerales.VerticalScrollbarHighlightOnWheel = false;
            this.panelGenerales.VerticalScrollbarSize = 10;
            this.panelGenerales.Visible = false;
            // 
            // btnGenerales
            // 
            this.btnGenerales.Image = null;
            this.btnGenerales.Location = new System.Drawing.Point(262, 40);
            this.btnGenerales.Name = "btnGenerales";
            this.btnGenerales.Size = new System.Drawing.Size(117, 36);
            this.btnGenerales.TabIndex = 6;
            this.btnGenerales.Text = "Generar reporte";
            this.btnGenerales.UseSelectable = true;
            this.btnGenerales.UseVisualStyleBackColor = true;
            this.btnGenerales.Click += new System.EventHandler(this.btnGenerales_Click);
            // 
            // rbTVentas
            // 
            this.rbTVentas.AutoSize = true;
            this.rbTVentas.Depth = 0;
            this.rbTVentas.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbTVentas.Location = new System.Drawing.Point(44, 90);
            this.rbTVentas.Margin = new System.Windows.Forms.Padding(0);
            this.rbTVentas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTVentas.Name = "rbTVentas";
            this.rbTVentas.Ripple = true;
            this.rbTVentas.Size = new System.Drawing.Size(133, 30);
            this.rbTVentas.TabIndex = 5;
            this.rbTVentas.TabStop = true;
            this.rbTVentas.Text = "Todas las ventas";
            this.rbTVentas.UseVisualStyleBackColor = true;
            // 
            // rbTCompras
            // 
            this.rbTCompras.AutoSize = true;
            this.rbTCompras.Depth = 0;
            this.rbTCompras.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbTCompras.Location = new System.Drawing.Point(44, 60);
            this.rbTCompras.Margin = new System.Windows.Forms.Padding(0);
            this.rbTCompras.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTCompras.Name = "rbTCompras";
            this.rbTCompras.Ripple = true;
            this.rbTCompras.Size = new System.Drawing.Size(146, 30);
            this.rbTCompras.TabIndex = 4;
            this.rbTCompras.TabStop = true;
            this.rbTCompras.Text = "Todas las compras";
            this.rbTCompras.UseVisualStyleBackColor = true;
            // 
            // rbTProductos
            // 
            this.rbTProductos.AutoSize = true;
            this.rbTProductos.Depth = 0;
            this.rbTProductos.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbTProductos.Location = new System.Drawing.Point(44, 30);
            this.rbTProductos.Margin = new System.Windows.Forms.Padding(0);
            this.rbTProductos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTProductos.Name = "rbTProductos";
            this.rbTProductos.Ripple = true;
            this.rbTProductos.Size = new System.Drawing.Size(155, 30);
            this.rbTProductos.TabIndex = 3;
            this.rbTProductos.TabStop = true;
            this.rbTProductos.Text = "Todos los productos";
            this.rbTProductos.UseVisualStyleBackColor = true;
            // 
            // rbTEmpleados
            // 
            this.rbTEmpleados.AutoSize = true;
            this.rbTEmpleados.Depth = 0;
            this.rbTEmpleados.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbTEmpleados.Location = new System.Drawing.Point(44, 0);
            this.rbTEmpleados.Margin = new System.Windows.Forms.Padding(0);
            this.rbTEmpleados.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTEmpleados.Name = "rbTEmpleados";
            this.rbTEmpleados.Ripple = true;
            this.rbTEmpleados.Size = new System.Drawing.Size(161, 30);
            this.rbTEmpleados.TabIndex = 2;
            this.rbTEmpleados.TabStop = true;
            this.rbTEmpleados.Text = "Todos los empleados";
            this.rbTEmpleados.UseVisualStyleBackColor = true;
            // 
            // panelFechas
            // 
            this.panelFechas.Controls.Add(this.btnFechas);
            this.panelFechas.Controls.Add(this.rbFVentas);
            this.panelFechas.Controls.Add(this.rbFCompras);
            this.panelFechas.Controls.Add(this.dtHasta);
            this.panelFechas.Controls.Add(this.materialLabel3);
            this.panelFechas.Controls.Add(this.materialLabel1);
            this.panelFechas.Controls.Add(this.dtDesde);
            this.panelFechas.HorizontalScrollbarBarColor = true;
            this.panelFechas.HorizontalScrollbarHighlightOnWheel = false;
            this.panelFechas.HorizontalScrollbarSize = 10;
            this.panelFechas.Location = new System.Drawing.Point(275, 85);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(440, 215);
            this.panelFechas.TabIndex = 6;
            this.panelFechas.VerticalScrollbarBarColor = true;
            this.panelFechas.VerticalScrollbarHighlightOnWheel = false;
            this.panelFechas.VerticalScrollbarSize = 10;
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.Controls.Add(this.materialLabel2);
            this.panelEmpleados.HorizontalScrollbarBarColor = true;
            this.panelEmpleados.HorizontalScrollbarHighlightOnWheel = false;
            this.panelEmpleados.HorizontalScrollbarSize = 10;
            this.panelEmpleados.Location = new System.Drawing.Point(275, 85);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Size = new System.Drawing.Size(440, 215);
            this.panelEmpleados.TabIndex = 7;
            this.panelEmpleados.VerticalScrollbarBarColor = true;
            this.panelEmpleados.VerticalScrollbarHighlightOnWheel = false;
            this.panelEmpleados.VerticalScrollbarSize = 10;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(56, 48);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "materialLabel2";
            // 
            // dtDesde
            // 
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(45, 28);
            this.dtDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(119, 29);
            this.dtDesde.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(41, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Desde:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(241, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Hasta:";
            // 
            // dtHasta
            // 
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(245, 28);
            this.dtHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(119, 29);
            this.dtHasta.TabIndex = 5;
            // 
            // rbFVentas
            // 
            this.rbFVentas.AutoSize = true;
            this.rbFVentas.Depth = 0;
            this.rbFVentas.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbFVentas.Location = new System.Drawing.Point(45, 115);
            this.rbFVentas.Margin = new System.Windows.Forms.Padding(0);
            this.rbFVentas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFVentas.Name = "rbFVentas";
            this.rbFVentas.Ripple = true;
            this.rbFVentas.Size = new System.Drawing.Size(72, 30);
            this.rbFVentas.TabIndex = 7;
            this.rbFVentas.TabStop = true;
            this.rbFVentas.Text = "Ventas";
            this.rbFVentas.UseVisualStyleBackColor = true;
            // 
            // rbFCompras
            // 
            this.rbFCompras.AutoSize = true;
            this.rbFCompras.Depth = 0;
            this.rbFCompras.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbFCompras.Location = new System.Drawing.Point(45, 85);
            this.rbFCompras.Margin = new System.Windows.Forms.Padding(0);
            this.rbFCompras.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFCompras.Name = "rbFCompras";
            this.rbFCompras.Ripple = true;
            this.rbFCompras.Size = new System.Drawing.Size(85, 30);
            this.rbFCompras.TabIndex = 6;
            this.rbFCompras.TabStop = true;
            this.rbFCompras.Text = "Compras";
            this.rbFCompras.UseVisualStyleBackColor = true;
            // 
            // btnFechas
            // 
            this.btnFechas.Image = null;
            this.btnFechas.Location = new System.Drawing.Point(245, 94);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(117, 36);
            this.btnFechas.TabIndex = 8;
            this.btnFechas.Text = "Generar reporte";
            this.btnFechas.UseSelectable = true;
            this.btnFechas.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(21, 85);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(111, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Tipo de reporte";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.rbReportesEmpleados);
            this.Controls.Add(this.rbReportesFechas);
            this.Controls.Add(this.rbReportesGenrales);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.panelFechas);
            this.Controls.Add(this.panelGenerales);
            this.Controls.Add(this.panelEmpleados);
            this.MaximizeBox = false;
            this.Name = "frmReportes";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReportes_FormClosed);
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.panelGenerales.ResumeLayout(false);
            this.panelGenerales.PerformLayout();
            this.panelFechas.ResumeLayout(false);
            this.panelFechas.PerformLayout();
            this.panelEmpleados.ResumeLayout(false);
            this.panelEmpleados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnReporte;
        private MaterialSkin.Controls.MaterialRadioButton rbReportesGenrales;
        private MaterialSkin.Controls.MaterialRadioButton rbReportesFechas;
        private MaterialSkin.Controls.MaterialRadioButton rbReportesEmpleados;
        private MetroFramework.Controls.MetroPanel panelGenerales;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnGenerales;
        private MaterialSkin.Controls.MaterialRadioButton rbTVentas;
        private MaterialSkin.Controls.MaterialRadioButton rbTCompras;
        private MaterialSkin.Controls.MaterialRadioButton rbTProductos;
        private MaterialSkin.Controls.MaterialRadioButton rbTEmpleados;
        private MetroFramework.Controls.MetroPanel panelFechas;
        private MetroFramework.Controls.MetroPanel panelEmpleados;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroDateTime dtHasta;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroDateTime dtDesde;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnFechas;
        private MaterialSkin.Controls.MaterialRadioButton rbFVentas;
        private MaterialSkin.Controls.MaterialRadioButton rbFCompras;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}