namespace Libreria
{
    partial class frmLogin
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
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContrasena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnIniciar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblInfo = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(229, 127);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(142, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.Depth = 0;
            this.txtContrasena.Hint = "Contraseña";
            this.txtContrasena.Location = new System.Drawing.Point(229, 170);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '●';
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.Size = new System.Drawing.Size(142, 23);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.TabStop = false;
            this.txtContrasena.UseSystemPasswordChar = false;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Depth = 0;
            this.btnIniciar.Location = new System.Drawing.Point(263, 276);
            this.btnIniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Primary = true;
            this.btnIniciar.Size = new System.Drawing.Size(75, 35);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Depth = 0;
            this.lblInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(160, 221);
            this.lblInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(280, 28);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 385);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasena;
        private MaterialSkin.Controls.MaterialRaisedButton btnIniciar;
        private MaterialSkin.Controls.MaterialLabel lblInfo;
    }
}

