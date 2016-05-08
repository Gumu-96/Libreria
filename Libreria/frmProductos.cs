using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;

namespace Libreria
{
    public partial class frmProductos : MaterialForm
    {
        Usuarios usuarioActivo;
        int add = 0;
        Datos productos = new Datos("Productos.txt");
        Datos compras = new Datos("Compras.txt");
        Datos config = new Datos("Config.txt");
        List<string[]> filasProd = new List<string[]>();

        public frmProductos(Usuarios user)
        {
            FormColor color = new FormColor(this);
            usuarioActivo = user;

            InitializeComponent();
        }

        public void fillDataGrid()
        {
            if (File.Exists(productos.RutaArchivo))
            {
                dgvProd.Rows.Clear();
                filasProd = productos.LeerArchivo();
                foreach (string[] fila in filasProd)
                    dgvProd.Rows.Add(fila);
            }
            else
            {
                MetroMessageBox.Show(this, "No se encontro archivo 'Productos.txt'", "Advertencia");
            }
        }

        public void BotonesAccion(bool b)
        {
            btnEditar.Visible = !b;
            btnNuevo.Visible = !b;
            btnEliminar.Visible = !b;
            btnCancelar.Visible = b;
            btnGuardar.Visible = b;
            btnRegresar.Visible = !b;
            btnSell.Visible = !b;
            txtProducto.Enabled = b;
            txtPrecioVenta.Enabled = b;
            txtPrecioCompra.Enabled = b;
            txtCant.Enabled = b;
            txtDetalle.Enabled = b;
        }

        public void Limpiar()
        {
            txtCod.Text = "Id";
            txtProducto.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtCant.Clear();
            txtDetalle.Clear();
        }

        public string GenerarIdProducto()
        {
            string[] linea = config.ObtenerVector("productos");
            int correlativo = int.Parse(linea[1]) + 1;
            linea[1] = correlativo.ToString();
            config.Modificar("productos", config.VectorToLine(linea));
            string pd = "prod" + Convert.ToString(correlativo).PadLeft(4, '0');
            return pd;
        }

        public string GenerarIdCompra()
        {
            string[] linea = config.ObtenerVector("compras");
            int correlativo = int.Parse(linea[1]) + 1;
            linea[1] = correlativo.ToString();
            config.Modificar("compras", config.VectorToLine(linea));
            string pd = "cp" + Convert.ToString(correlativo).PadLeft(5, '0');
            return pd;

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: " + usuarioActivo.Usuario;
            dgvProd.Size = new Size(700, 475);
            dgvProd.BorderStyle = BorderStyle.Fixed3D;
            fillDataGrid();
            BotonesAccion(false);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.abrirForm("frmMenu");
        }

        private void dgvProd_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProd.RowCount != 0)
            {
                txtCod.Text = dgvProd.CurrentRow.Cells[0].Value.ToString();
                txtProducto.Text = dgvProd.CurrentRow.Cells[1].Value.ToString();
                txtPrecioCompra.Text = dgvProd.CurrentRow.Cells[2].Value.ToString();
                txtPrecioVenta.Text = dgvProd.CurrentRow.Cells[3].Value.ToString();
                txtCant.Text = dgvProd.CurrentRow.Cells[4].Value.ToString();
                txtDetalle.Text = dgvProd.CurrentRow.Cells[5].Value.ToString();
                lblProdCompra.Text = "Producto: " + dgvProd.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            dgvProd.Size = new Size(700, 385);
            panelCompra.Visible = true;
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            txtCantComprar.Clear();
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            panelCompra.Visible = false;
            dgvProd.Size = new Size(700, 475);
            btnNuevo.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProd.RowCount != 0)
            {
                BotonesAccion(true);
                txtCant.Enabled = false;
            }
            add = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            BotonesAccion(true);
            add = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fillDataGrid();
            BotonesAccion(false);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtCantComprar.Text != "")
            {
                int nuevaCant = int.Parse(txtCant.Text) + int.Parse(txtCantComprar.Text);

                string linea = txtCod.Text + "|" + txtProducto.Text + "|" + txtPrecioVenta.Text + "|" + txtPrecioCompra.Text + "|" + nuevaCant.ToString() + "|" + txtDetalle.Text;
                productos.Modificar(txtCod.Text, linea);

                double totalCompra = double.Parse(txtPrecioCompra.Text) * double.Parse(txtCantComprar.Text);
                string nuevaCompra = GenerarIdCompra() + "|" + txtCod.Text + "|" + txtPrecioCompra.Text + "|" + txtCantComprar.Text + "|" + totalCompra.ToString() + "|" + usuarioActivo.Usuario + "|" + DateTime.Now.ToShortDateString();
                compras.Agregar(nuevaCompra);

                panelCompra.Visible = false;
                dgvProd.Size = new Size(700, 475);
                btnNuevo.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;

                fillDataGrid();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text == "" || txtPrecioVenta.Text == "" || txtPrecioCompra.Text == "" || txtCant.Text == "" || txtDetalle.Text == "")
            {
                MetroMessageBox.Show(this, "Todos los campos son requeridos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (add == 1)
                {
                    txtCod.Text = GenerarIdProducto();
                    string linea = txtCod.Text + "|" + txtProducto.Text + "|" + txtPrecioVenta.Text + "|" + txtPrecioCompra.Text + "|" + txtCant.Text + "|" + txtDetalle.Text;
                    productos.Agregar(linea);

                    //Al agregar un nuevo producto se toma como una compra
                    double totalCompra = double.Parse(txtPrecioCompra.Text) * double.Parse(txtCant.Text);
                    totalCompra = Math.Round(totalCompra, 2);
                    string nuevaCompra = GenerarIdCompra() + "|" + txtCod.Text + "|" + txtPrecioCompra.Text + "|" + txtCant.Text + "|" + totalCompra.ToString() + "|" + usuarioActivo.Usuario + "|" + DateTime.Now.ToShortDateString();
                    compras.Agregar(nuevaCompra);

                }
                else
                {
                    string linea = txtCod.Text + "|" + txtProducto.Text + "|" + txtPrecioVenta.Text + "|" + txtPrecioCompra.Text + "|" + txtCant.Text + "|" + txtDetalle.Text;
                    productos.Modificar(txtCod.Text, linea);
                }
            }

            BotonesAccion(false);
            fillDataGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProd.RowCount != 0)
            {
                DialogResult rs = MetroMessageBox.Show(this, "¿Desea eliminar estos datos?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    if (File.Exists(productos.RutaArchivo))
                    {
                        productos.Eliminar(txtCod.Text);
                        fillDataGrid();
                    }
                }
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtCantComprar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void frmProductos_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Program.abrirForm("frmMenu");
        }
    }
}
