namespace Libreria
{
    partial class frmMantEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantEmpleados));
            this.dgvEmp = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdEmp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDui = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtFecha = new MetroFramework.Controls.MetroDateTime();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnRegresar = new MetroFramework.Controls.MetroButton();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.panelUsuario = new MetroFramework.Controls.MetroPanel();
            this.chkAdmin = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtContrasena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnMantUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.panelUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            this.dgvEmp.AllowUserToResizeColumns = false;
            this.dgvEmp.AllowUserToResizeRows = false;
            this.dgvEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombres,
            this.Apellidos,
            this.Email,
            this.Dui,
            this.FechaNacimiento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmp.EnableHeadersVisualStyles = false;
            this.dgvEmp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmp.Location = new System.Drawing.Point(25, 85);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmp.Size = new System.Drawing.Size(700, 475);
            this.dgvEmp.TabIndex = 1;
            this.dgvEmp.SelectionChanged += new System.EventHandler(this.dgvEmp_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Dui
            // 
            this.Dui.HeaderText = "DUI";
            this.Dui.Name = "Dui";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Width = 157;
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Depth = 0;
            this.txtIdEmp.Enabled = false;
            this.txtIdEmp.Hint = "Id";
            this.txtIdEmp.Location = new System.Drawing.Point(769, 118);
            this.txtIdEmp.MaxLength = 32767;
            this.txtIdEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.PasswordChar = '\0';
            this.txtIdEmp.SelectedText = "";
            this.txtIdEmp.SelectionLength = 0;
            this.txtIdEmp.SelectionStart = 0;
            this.txtIdEmp.Size = new System.Drawing.Size(190, 23);
            this.txtIdEmp.TabIndex = 2;
            this.txtIdEmp.TabStop = false;
            this.txtIdEmp.UseSystemPasswordChar = false;
            // 
            // txtNombres
            // 
            this.txtNombres.Depth = 0;
            this.txtNombres.Hint = "Nombres";
            this.txtNombres.Location = new System.Drawing.Point(769, 158);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.Size = new System.Drawing.Size(190, 23);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.TabStop = false;
            this.txtNombres.UseSystemPasswordChar = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Hint = "Apellidos";
            this.txtApellidos.Location = new System.Drawing.Point(769, 198);
            this.txtApellidos.MaxLength = 30;
            this.txtApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.Size = new System.Drawing.Size(190, 23);
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.TabStop = false;
            this.txtApellidos.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(769, 238);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(190, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtDui
            // 
            this.txtDui.Depth = 0;
            this.txtDui.Hint = "DUI (12345678-9)";
            this.txtDui.Location = new System.Drawing.Point(769, 278);
            this.txtDui.MaxLength = 10;
            this.txtDui.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDui.Name = "txtDui";
            this.txtDui.PasswordChar = '\0';
            this.txtDui.SelectedText = "";
            this.txtDui.SelectionLength = 0;
            this.txtDui.SelectionStart = 0;
            this.txtDui.Size = new System.Drawing.Size(190, 23);
            this.txtDui.TabIndex = 6;
            this.txtDui.TabStop = false;
            this.txtDui.UseSystemPasswordChar = false;
            this.txtDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDui_KeyPress);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(769, 318);
            this.dtFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(190, 29);
            this.dtFecha.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(745, 524);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(75, 36);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(826, 524);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(75, 36);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(907, 524);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(75, 36);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(867, 524);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(75, 36);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(777, 524);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(82, 36);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Depth = 0;
            this.lbl1.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl1.Location = new System.Drawing.Point(741, 85);
            this.lbl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(135, 19);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "Datos del emplado";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 575);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1000, 25);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::Libreria.Properties.Resources.regresarTrans;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(0, 575);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 25);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.UseSelectable = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(100, 578);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 19);
            this.lblUsuario.TabIndex = 57;
            this.lblUsuario.Text = "Usuario";
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.chkAdmin);
            this.panelUsuario.Controls.Add(this.txtContrasena);
            this.panelUsuario.Controls.Add(this.txtUsuario);
            this.panelUsuario.Controls.Add(this.lbl2);
            this.panelUsuario.HorizontalScrollbarBarColor = true;
            this.panelUsuario.HorizontalScrollbarHighlightOnWheel = false;
            this.panelUsuario.HorizontalScrollbarSize = 10;
            this.panelUsuario.Location = new System.Drawing.Point(731, 353);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(251, 165);
            this.panelUsuario.TabIndex = 58;
            this.panelUsuario.VerticalScrollbarBarColor = true;
            this.panelUsuario.VerticalScrollbarHighlightOnWheel = false;
            this.panelUsuario.VerticalScrollbarSize = 10;
            this.panelUsuario.Visible = false;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Depth = 0;
            this.chkAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkAdmin.Location = new System.Drawing.Point(38, 124);
            this.chkAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.chkAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Ripple = true;
            this.chkAdmin.Size = new System.Drawing.Size(118, 30);
            this.chkAdmin.TabIndex = 17;
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Depth = 0;
            this.txtContrasena.Hint = "Contraseña";
            this.txtContrasena.Location = new System.Drawing.Point(38, 85);
            this.txtContrasena.MaxLength = 30;
            this.txtContrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '●';
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.Size = new System.Drawing.Size(190, 23);
            this.txtContrasena.TabIndex = 16;
            this.txtContrasena.TabStop = false;
            this.txtContrasena.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.Location = new System.Drawing.Point(38, 45);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(190, 23);
            this.txtUsuario.TabIndex = 15;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Depth = 0;
            this.lbl2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl2.Location = new System.Drawing.Point(10, 11);
            this.lbl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(127, 19);
            this.lbl2.TabIndex = 18;
            this.lbl2.Text = "Datos del usuario";
            // 
            // btnMantUsuario
            // 
            this.btnMantUsuario.Depth = 0;
            this.btnMantUsuario.Location = new System.Drawing.Point(800, 410);
            this.btnMantUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMantUsuario.Name = "btnMantUsuario";
            this.btnMantUsuario.Primary = true;
            this.btnMantUsuario.Size = new System.Drawing.Size(130, 36);
            this.btnMantUsuario.TabIndex = 59;
            this.btnMantUsuario.Text = "Mant. Usuarios";
            this.btnMantUsuario.UseVisualStyleBackColor = true;
            this.btnMantUsuario.Click += new System.EventHandler(this.btnMantUsuario_Click);
            // 
            // frmMantEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnMantUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtIdEmp);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.panelUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantEmpleados";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Empleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMantEmpleados_FormClosed);
            this.Load += new System.EventHandler(this.frmMantEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid dgvEmp;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdEmp;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombres;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDui;
        private MetroFramework.Controls.MetroDateTime dtFecha;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialLabel lbl1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroButton btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MetroFramework.Controls.MetroPanel panelUsuario;
        private MaterialSkin.Controls.MaterialCheckBox chkAdmin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasena;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialLabel lbl2;
        private MaterialSkin.Controls.MaterialRaisedButton btnMantUsuario;
    }
}