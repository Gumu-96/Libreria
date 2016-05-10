namespace Libreria
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.btnSell = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvProd = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCant = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDetalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCod = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRegresar = new MetroFramework.Controls.MetroButton();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.panelCompra = new MetroFramework.Controls.MetroPanel();
            this.btnCancelarCompra = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblSeleccio = new MaterialSkin.Controls.MaterialLabel();
            this.lblProdCompra = new MaterialSkin.Controls.MaterialLabel();
            this.btnComprar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCantComprar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.panelCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSell
            // 
            this.btnSell.Depth = 0;
            this.btnSell.Location = new System.Drawing.Point(797, 499);
            this.btnSell.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSell.Name = "btnSell";
            this.btnSell.Primary = true;
            this.btnSell.Size = new System.Drawing.Size(132, 36);
            this.btnSell.TabIndex = 41;
            this.btnSell.Text = "REALIZAR COMPRA";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.PrecioVenta,
            this.PrecioCompra,
            this.CantDisp,
            this.Detalles});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProd.EnableHeadersVisualStyles = false;
            this.dgvProd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProd.Location = new System.Drawing.Point(25, 85);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(700, 385);
            this.dgvProd.TabIndex = 37;
            this.dgvProd.SelectionChanged += new System.EventHandler(this.dgvProd_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 70;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 145;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Width = 50;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Width = 50;
            // 
            // CantDisp
            // 
            this.CantDisp.HeaderText = "Cant. Disponble";
            this.CantDisp.Name = "CantDisp";
            this.CantDisp.Width = 60;
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            this.Detalles.Width = 282;
            // 
            // txtCant
            // 
            this.txtCant.Depth = 0;
            this.txtCant.Hint = "Cantidad";
            this.txtCant.Location = new System.Drawing.Point(769, 278);
            this.txtCant.MaxLength = 3;
            this.txtCant.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCant.Name = "txtCant";
            this.txtCant.PasswordChar = '\0';
            this.txtCant.SelectedText = "";
            this.txtCant.SelectionLength = 0;
            this.txtCant.SelectionStart = 0;
            this.txtCant.Size = new System.Drawing.Size(190, 23);
            this.txtCant.TabIndex = 30;
            this.txtCant.TabStop = false;
            this.txtCant.UseSystemPasswordChar = false;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(826, 434);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(75, 36);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(907, 434);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(75, 36);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(745, 434);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(75, 36);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(867, 434);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(75, 36);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(777, 434);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(82, 36);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Depth = 0;
            this.txtDetalle.Hint = "Detalles de producto";
            this.txtDetalle.Location = new System.Drawing.Point(769, 318);
            this.txtDetalle.MaxLength = 32767;
            this.txtDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.PasswordChar = '\0';
            this.txtDetalle.SelectedText = "";
            this.txtDetalle.SelectionLength = 0;
            this.txtDetalle.SelectionStart = 0;
            this.txtDetalle.Size = new System.Drawing.Size(190, 23);
            this.txtDetalle.TabIndex = 31;
            this.txtDetalle.TabStop = false;
            this.txtDetalle.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Hint = "Precio de venta";
            this.txtPrecioVenta.Location = new System.Drawing.Point(769, 238);
            this.txtPrecioVenta.MaxLength = 5;
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(190, 23);
            this.txtPrecioVenta.TabIndex = 29;
            this.txtPrecioVenta.TabStop = false;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "Precio de compra";
            this.txtPrecioCompra.Location = new System.Drawing.Point(769, 198);
            this.txtPrecioCompra.MaxLength = 5;
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(190, 23);
            this.txtPrecioCompra.TabIndex = 28;
            this.txtPrecioCompra.TabStop = false;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // txtProducto
            // 
            this.txtProducto.Depth = 0;
            this.txtProducto.Hint = "Nombre del producto";
            this.txtProducto.Location = new System.Drawing.Point(769, 158);
            this.txtProducto.MaxLength = 32767;
            this.txtProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.SelectedText = "";
            this.txtProducto.SelectionLength = 0;
            this.txtProducto.SelectionStart = 0;
            this.txtProducto.Size = new System.Drawing.Size(190, 23);
            this.txtProducto.TabIndex = 27;
            this.txtProducto.TabStop = false;
            this.txtProducto.UseSystemPasswordChar = false;
            // 
            // txtCod
            // 
            this.txtCod.Depth = 0;
            this.txtCod.Enabled = false;
            this.txtCod.Hint = "Codigo";
            this.txtCod.Location = new System.Drawing.Point(769, 118);
            this.txtCod.MaxLength = 32767;
            this.txtCod.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCod.Name = "txtCod";
            this.txtCod.PasswordChar = '\0';
            this.txtCod.SelectedText = "";
            this.txtCod.SelectionLength = 0;
            this.txtCod.SelectionStart = 0;
            this.txtCod.Size = new System.Drawing.Size(190, 23);
            this.txtCod.TabIndex = 26;
            this.txtCod.TabStop = false;
            this.txtCod.UseSystemPasswordChar = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::Libreria.Properties.Resources.regresarTrans;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(0, 575);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 25);
            this.btnRegresar.TabIndex = 57;
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
            this.lblUsuario.TabIndex = 56;
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
            this.materialDivider1.TabIndex = 55;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // panelCompra
            // 
            this.panelCompra.Controls.Add(this.btnCancelarCompra);
            this.panelCompra.Controls.Add(this.lblSeleccio);
            this.panelCompra.Controls.Add(this.lblProdCompra);
            this.panelCompra.Controls.Add(this.btnComprar);
            this.panelCompra.Controls.Add(this.txtCantComprar);
            this.panelCompra.HorizontalScrollbarBarColor = true;
            this.panelCompra.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCompra.HorizontalScrollbarSize = 10;
            this.panelCompra.Location = new System.Drawing.Point(25, 480);
            this.panelCompra.Name = "panelCompra";
            this.panelCompra.Size = new System.Drawing.Size(700, 80);
            this.panelCompra.TabIndex = 58;
            this.panelCompra.VerticalScrollbarBarColor = true;
            this.panelCompra.VerticalScrollbarHighlightOnWheel = false;
            this.panelCompra.VerticalScrollbarSize = 10;
            this.panelCompra.Visible = false;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Depth = 0;
            this.btnCancelarCompra.Location = new System.Drawing.Point(615, 36);
            this.btnCancelarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Primary = true;
            this.btnCancelarCompra.Size = new System.Drawing.Size(82, 36);
            this.btnCancelarCompra.TabIndex = 50;
            this.btnCancelarCompra.Text = "CANCELAR";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // lblSeleccio
            // 
            this.lblSeleccio.AutoSize = true;
            this.lblSeleccio.Depth = 0;
            this.lblSeleccio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSeleccio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSeleccio.Location = new System.Drawing.Point(171, 10);
            this.lblSeleccio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccio.Name = "lblSeleccio";
            this.lblSeleccio.Size = new System.Drawing.Size(383, 19);
            this.lblSeleccio.TabIndex = 49;
            this.lblSeleccio.Text = "-- Selecione en la tabla el producto que desea agregar  --";
            // 
            // lblProdCompra
            // 
            this.lblProdCompra.AutoSize = true;
            this.lblProdCompra.Depth = 0;
            this.lblProdCompra.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProdCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProdCompra.Location = new System.Drawing.Point(37, 44);
            this.lblProdCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProdCompra.Name = "lblProdCompra";
            this.lblProdCompra.Size = new System.Drawing.Size(74, 19);
            this.lblProdCompra.TabIndex = 48;
            this.lblProdCompra.Text = "Producto:";
            // 
            // btnComprar
            // 
            this.btnComprar.Depth = 0;
            this.btnComprar.Location = new System.Drawing.Point(455, 36);
            this.btnComprar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Primary = true;
            this.btnComprar.Size = new System.Drawing.Size(154, 36);
            this.btnComprar.TabIndex = 47;
            this.btnComprar.Text = "AGREGAR EXISTENTE";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtCantComprar
            // 
            this.txtCantComprar.Depth = 0;
            this.txtCantComprar.Hint = "Cantidad";
            this.txtCantComprar.Location = new System.Drawing.Point(295, 44);
            this.txtCantComprar.MaxLength = 3;
            this.txtCantComprar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantComprar.Name = "txtCantComprar";
            this.txtCantComprar.PasswordChar = '\0';
            this.txtCantComprar.SelectedText = "";
            this.txtCantComprar.SelectionLength = 0;
            this.txtCantComprar.SelectionStart = 0;
            this.txtCantComprar.Size = new System.Drawing.Size(65, 23);
            this.txtCantComprar.TabIndex = 46;
            this.txtCantComprar.TabStop = false;
            this.txtCantComprar.UseSystemPasswordChar = false;
            this.txtCantComprar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantComprar_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(741, 85);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(137, 19);
            this.materialLabel1.TabIndex = 59;
            this.materialLabel1.Text = "Datos del producto";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.panelCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProductos";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProductos_FormClosed_1);
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.panelCompra.ResumeLayout(false);
            this.panelCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnSell;
        private MetroFramework.Controls.MetroGrid dgvProd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCant;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDetalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCod;
        private MetroFramework.Controls.MetroButton btnRegresar;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroPanel panelCompra;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelarCompra;
        private MaterialSkin.Controls.MaterialLabel lblSeleccio;
        private MaterialSkin.Controls.MaterialLabel lblProdCompra;
        private MaterialSkin.Controls.MaterialRaisedButton btnComprar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}