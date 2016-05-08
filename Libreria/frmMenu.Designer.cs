namespace Libreria
{
    partial class frmMenu
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
            this.btnReportes = new MetroFramework.Controls.MetroButton();
            this.btnCerrarSesion = new MetroFramework.Controls.MetroButton();
            this.btnConfig = new MetroFramework.Controls.MetroButton();
            this.btnVentas = new MetroFramework.Controls.MetroButton();
            this.btnProductos = new MetroFramework.Controls.MetroButton();
            this.btnMantEmp = new MetroFramework.Controls.MetroButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnReportes
            // 
            this.btnReportes.BackgroundImage = global::Libreria.Properties.Resources.Reportes;
            this.btnReportes.Location = new System.Drawing.Point(115, 360);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(210, 120);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.UseSelectable = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImage = global::Libreria.Properties.Resources.LogOut;
            this.btnCerrarSesion.Location = new System.Drawing.Point(675, 360);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(210, 120);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.UseSelectable = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackgroundImage = global::Libreria.Properties.Resources.Settings;
            this.btnConfig.Location = new System.Drawing.Point(395, 360);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(210, 120);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.UseSelectable = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImage = global::Libreria.Properties.Resources.Ventas;
            this.btnVentas.Location = new System.Drawing.Point(675, 170);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(210, 120);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.UseSelectable = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImage = global::Libreria.Properties.Resources.Productos;
            this.btnProductos.Location = new System.Drawing.Point(395, 170);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(210, 120);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.UseSelectable = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnMantEmp
            // 
            this.btnMantEmp.BackgroundImage = global::Libreria.Properties.Resources.mantEmp;
            this.btnMantEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMantEmp.Location = new System.Drawing.Point(115, 170);
            this.btnMantEmp.Name = "btnMantEmp";
            this.btnMantEmp.Size = new System.Drawing.Size(210, 120);
            this.btnMantEmp.TabIndex = 0;
            this.btnMantEmp.UseSelectable = true;
            this.btnMantEmp.Click += new System.EventHandler(this.btnMantEmp_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 575);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1000, 25);
            this.materialDivider1.TabIndex = 21;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(3, 578);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 19);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuario";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnMantEmp);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnMantEmp;
        private MetroFramework.Controls.MetroButton btnProductos;
        private MetroFramework.Controls.MetroButton btnVentas;
        private MetroFramework.Controls.MetroButton btnReportes;
        private MetroFramework.Controls.MetroButton btnConfig;
        private MetroFramework.Controls.MetroButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
    }
}