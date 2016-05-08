namespace Libreria
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemover = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtCant = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVender = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboBuscar = new MetroFramework.Controls.MetroComboBox();
            this.dgvVentas = new MetroFramework.Controls.MetroGrid();
            this.dgvProd = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRegresar = new MetroFramework.Controls.MetroButton();
            this.lblProdSeleccionado = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSize = true;
            this.btnRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemover.Depth = 0;
            this.btnRemover.Location = new System.Drawing.Point(580, 392);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Primary = true;
            this.btnRemover.Size = new System.Drawing.Size(110, 36);
            this.btnRemover.TabIndex = 48;
            this.btnRemover.Text = "Remover item";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtCant
            // 
            this.txtCant.Depth = 0;
            this.txtCant.Hint = "Cantidad";
            this.txtCant.Location = new System.Drawing.Point(311, 529);
            this.txtCant.MaxLength = 3;
            this.txtCant.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCant.Name = "txtCant";
            this.txtCant.PasswordChar = '\0';
            this.txtCant.SelectedText = "";
            this.txtCant.SelectionLength = 0;
            this.txtCant.SelectionStart = 0;
            this.txtCant.Size = new System.Drawing.Size(70, 23);
            this.txtCant.TabIndex = 47;
            this.txtCant.TabStop = false;
            this.txtCant.UseSystemPasswordChar = false;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(874, 400);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 19);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "0";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(406, 521);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(150, 36);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Añadir al carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Depth = 0;
            this.btnVender.Location = new System.Drawing.Point(788, 521);
            this.btnVender.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVender.Name = "btnVender";
            this.btnVender.Primary = true;
            this.btnVender.Size = new System.Drawing.Size(186, 36);
            this.btnVender.TabIndex = 40;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(580, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 39;
            this.materialLabel1.Text = "Carrito";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar";
            this.txtBuscar.Location = new System.Drawing.Point(245, 78);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(189, 23);
            this.txtBuscar.TabIndex = 38;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cboBuscar
            // 
            this.cboBuscar.DisplayFocus = true;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.ItemHeight = 23;
            this.cboBuscar.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Descripción"});
            this.cboBuscar.Location = new System.Drawing.Point(106, 74);
            this.cboBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(124, 29);
            this.cboBuscar.TabIndex = 37;
            this.cboBuscar.UseSelectable = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.unitario,
            this.cantidad,
            this.pTotal,
            this.IdProd});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVentas.Location = new System.Drawing.Point(580, 112);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(394, 274);
            this.dgvVentas.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvVentas.TabIndex = 36;
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.AllowUserToResizeColumns = false;
            this.dgvProd.AllowUserToResizeRows = false;
            this.dgvProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prod,
            this.venta,
            this.stock,
            this.detalles});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProd.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProd.EnableHeadersVisualStyles = false;
            this.dgvProd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProd.Location = new System.Drawing.Point(20, 112);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(536, 393);
            this.dgvProd.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvProd.TabIndex = 35;
            this.dgvProd.SelectionChanged += new System.EventHandler(this.dgvProd_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Width = 70;
            // 
            // prod
            // 
            this.prod.HeaderText = "Producto";
            this.prod.Name = "prod";
            this.prod.Width = 130;
            // 
            // venta
            // 
            this.venta.HeaderText = "Precio Unitario";
            this.venta.Name = "venta";
            this.venta.Width = 60;
            // 
            // stock
            // 
            this.stock.HeaderText = "Cantidad";
            this.stock.Name = "stock";
            this.stock.Width = 55;
            // 
            // detalles
            // 
            this.detalles.HeaderText = "Detalles";
            this.detalles.Name = "detalles";
            this.detalles.Width = 178;
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
            this.lblUsuario.TabIndex = 50;
            this.lblUsuario.Text = "Usuario";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 575);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1000, 25);
            this.materialDivider1.TabIndex = 49;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(16, 78);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(85, 19);
            this.materialLabel4.TabIndex = 51;
            this.materialLabel4.Text = "Buscar por:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(576, 450);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(134, 19);
            this.materialLabel2.TabIndex = 53;
            this.materialLabel2.Text = "Factura de compra";
            // 
            // txtCliente
            // 
            this.txtCliente.Depth = 0;
            this.txtCliente.Hint = "Nombre del cliente";
            this.txtCliente.Location = new System.Drawing.Point(580, 482);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.Size = new System.Drawing.Size(208, 23);
            this.txtCliente.TabIndex = 52;
            this.txtCliente.TabStop = false;
            this.txtCliente.UseSystemPasswordChar = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::Libreria.Properties.Resources.regresarTrans;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(0, 575);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 25);
            this.btnRegresar.TabIndex = 54;
            this.btnRegresar.UseSelectable = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblProdSeleccionado
            // 
            this.lblProdSeleccionado.AutoSize = true;
            this.lblProdSeleccionado.Depth = 0;
            this.lblProdSeleccionado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProdSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProdSeleccionado.Location = new System.Drawing.Point(16, 529);
            this.lblProdSeleccionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProdSeleccionado.Name = "lblProdSeleccionado";
            this.lblProdSeleccionado.Size = new System.Drawing.Size(70, 19);
            this.lblProdSeleccionado.TabIndex = 55;
            this.lblProdSeleccionado.Text = "Producto";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(766, 400);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(113, 19);
            this.materialLabel3.TabIndex = 56;
            this.materialLabel3.Text = "Total a pagar: $";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Producto";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 165;
            // 
            // unitario
            // 
            this.unitario.HeaderText = "Precio unitario";
            this.unitario.Name = "unitario";
            this.unitario.Width = 50;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 65;
            // 
            // pTotal
            // 
            this.pTotal.HeaderText = "Precio total";
            this.pTotal.Name = "pTotal";
            this.pTotal.Width = 70;
            // 
            // IdProd
            // 
            this.IdProd.HeaderText = "Id";
            this.IdProd.Name = "IdProd";
            this.IdProd.Visible = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lblProdSeleccionado);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.dgvProd);
            this.MaximizeBox = false;
            this.Name = "frmVentas";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVentas_FormClosed);
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnRemover;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCant;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnVender;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MetroFramework.Controls.MetroComboBox cboBuscar;
        private MetroFramework.Controls.MetroGrid dgvVentas;
        private MetroFramework.Controls.MetroGrid dgvProd;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCliente;
        private MetroFramework.Controls.MetroButton btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalles;
        private MaterialSkin.Controls.MaterialLabel lblProdSeleccionado;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProd;
    }
}