using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;
using System.Diagnostics;

namespace Libreria
{
    public partial class frmVentas : MaterialForm
    {
        Usuarios usuarioActivo;
        string[] empleado;
        List<string[]> ListaEliminar = new List<string[]>();
        List<string[]> FilasProd = new List<string[]>();
        List<string[]> ProdFactura = new List<string[]>();
        Datos productos = new Datos("productos.txt");
        Datos ventas = new Datos("ventas.txt");
        Datos config = new Datos("Config.txt");

        public frmVentas(Usuarios user, string[] emp)
        {
            FormColor color = new FormColor(this);
            usuarioActivo = user;
            empleado = emp;

            InitializeComponent();
        }

        public string GenerarIdVenta()
        {
            string[] linea = config.ObtenerVector("ventas");
            int correlativo = int.Parse(linea[1]) + 1;
            linea[1] = correlativo.ToString();
            config.Modificar("ventas", config.VectorToLine(linea));
            string pd = "v" + Convert.ToString(correlativo).PadLeft(6, '0');
            return pd;
        }

        public void fillDataGrid()
        {
            if (File.Exists(productos.RutaArchivo))
            {
                FilasProd = productos.LeerArchivo();
                foreach (string[] fila in FilasProd)
                    dgvProd.Rows.Add(fila[0], fila[1], fila[2], fila[4], fila[5]);
            }
            else
            {
                MetroMessageBox.Show(this, "No se encontro archivo 'Productos.txt'", "Advertencia");
            }
        }

        public string CambiarFila(string cod, string cant)
        {
            string fila = "";
            foreach (string[] row in FilasProd)
            {
                if (row[0] == cod)
                {
                    row[4] = cant;
                    fila = productos.VectorToLine(row);
                }
            }
            return fila;
        }

        public void fillDataGridFactura(int cantidad)
        {
            string idProd = dgvProd.CurrentRow.Cells[0].Value.ToString();
            string prod = dgvProd.CurrentRow.Cells[1].Value.ToString();
            double precio = double.Parse(dgvProd.CurrentRow.Cells[2].Value.ToString());
            double precioCant = Math.Round(precio * cantidad, 2);
            string[] prodFact = { idProd, prod, precio.ToString(), cantidad.ToString(), precioCant.ToString() };
            dgvVentas.Rows.Add(prodFact[1], prodFact[2], prodFact[3], prodFact[4], prodFact[0]);
            ProdFactura.Add(prodFact);
        }

        public void ObtenerTotal()
        {
            double total = 0;

            foreach (DataGridViewRow r in dgvVentas.Rows)
                total += double.Parse(r.Cells[3].Value.ToString());

            lblTotal.Text = total.ToString();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: " + usuarioActivo.Usuario;
            cboBuscar.SelectedIndex = 0;
            dgvProd.BorderStyle = BorderStyle.Fixed3D;
            dgvVentas.BorderStyle = BorderStyle.Fixed3D;
            fillDataGrid();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProd_SelectionChanged(object sender, EventArgs e)
        {
            lblProdSeleccionado.Text = "Producto: " + dgvProd.CurrentRow.Cells[1].Value.ToString();
            if (int.Parse(dgvProd.CurrentRow.Cells[3].Value.ToString()) > 0)
                txtCant.Text = "1";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCant.Text != "")
            {
                int cantidad = int.Parse(dgvProd.CurrentRow.Cells[3].Value.ToString());
                int solicitado = int.Parse(txtCant.Text);
                int cantidadFinal = cantidad - solicitado;

                if (cantidadFinal >= 0)
                {
                    string[] arreglo = new string[2];
                    if (ListaEliminar.Exists(p => p[0] == dgvProd.CurrentRow.Cells[0].Value.ToString()))
                    {
                        arreglo = ListaEliminar.Find(p => p[0] == dgvProd.CurrentRow.Cells[0].Value.ToString());
                        string[] prodFact = ProdFactura.Find(p => p[0] == arreglo[0]);

                        if ((solicitado + (cantidad - int.Parse(arreglo[1]))) <= cantidad)
                        {
                            ListaEliminar.Remove(arreglo);
                            ProdFactura.Remove(prodFact);
                            solicitado += (cantidad - int.Parse(arreglo[1]));
                            arreglo[1] = (cantidad - solicitado).ToString();
                            ListaEliminar.Add(arreglo);
                            foreach (DataGridViewRow row in dgvVentas.Rows)
                                if (row.Cells[4].Value.ToString() == arreglo[0])
                                {
                                    dgvVentas.Rows.Remove(row);
                                    break;
                                }
                            fillDataGridFactura(solicitado);
                        }

                    }
                    else
                    {
                        arreglo[0] = dgvProd.CurrentRow.Cells[0].Value.ToString();
                        arreglo[1] = cantidadFinal.ToString();
                        ListaEliminar.Add(arreglo);
                        fillDataGridFactura(solicitado);
                    }

                    if (dgvVentas.RowCount != 0)
                        ObtenerTotal();
                }
                else
                {
                    MetroMessageBox.Show(this, "La cantidad solicitada es mayor a la que se tiene de productos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void frmVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.abrirForm("frmMenu");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<string[]> vectores = new List<string[]>();

            switch (cboBuscar.SelectedIndex)
            {
                case 0:
                    vectores = productos.Filtrar(txtBuscar.Text.ToLower(), 0);
                    break;
                case 1:
                    vectores = productos.Filtrar(txtBuscar.Text.ToLower(), 1);
                    break;
                case 2:
                    vectores = productos.Filtrar(txtBuscar.Text.ToLower(), 5);
                    break;
                default:
                    break;
            }
            
            dgvProd.Rows.Clear();

            foreach (string[] item in vectores)
                dgvProd.Rows.Add(item[0], item[1], item[2], item[4], item[5]);
            dgvProd.Refresh();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvVentas.RowCount != 0)
            {
                string[] prodFact = ProdFactura.Find(p => p[0] == dgvVentas.CurrentRow.Cells[4].Value.ToString());
                ProdFactura.Remove(prodFact);
                ListaEliminar.RemoveAt(dgvVentas.SelectedRows[0].Index);
                dgvVentas.Rows.RemoveAt(dgvVentas.SelectedRows[0].Index);
                ObtenerTotal();
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (dgvVentas.RowCount != 0)
            {
                string strVenta = "";
                if (txtPago.Text == "") txtPago.Text = "0";
                
                if (double.Parse(txtPago.Text) < double.Parse(lblTotal.Text))
                {
                    MetroMessageBox.Show(this, "El monto de pago es menor al total, por favor ingrese otra cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    double cambio = double.Parse(txtPago.Text) - double.Parse(lblTotal.Text);
                    lblCambio.Text = "$" + cambio.ToString();

                    if (!File.Exists(ventas.RutaArchivo))
                    {
                        FileStream fs = File.Create(ventas.RutaArchivo);
                        fs.Close();
                    }

                    string productosVendidos = "";
                    foreach (DataGridViewRow r in dgvVentas.Rows)
                    {
                        productosVendidos += "[" + r.Cells[0].Value.ToString() + "_" + r.Cells[3].Value.ToString();
                    }

                    string idVenta = GenerarIdVenta();

                    if (txtCliente.Text != "")
                    {
                        strVenta = idVenta + "|" + txtCliente.Text + "|" + productosVendidos + "|" + lblTotal.Text + "|" + usuarioActivo.Usuario + "|" + DateTime.Now.ToShortDateString();
                    }
                    else
                    {
                        strVenta = idVenta + "|" + "...Anonimo..." + "|" + productosVendidos + "|" + lblTotal.Text + "|" + usuarioActivo.Usuario + "|" + DateTime.Now.ToShortDateString();
                    }

                    //Modificando cantidades en stock
                    foreach (string[] s in ListaEliminar)
                    {
                        string line = CambiarFila(s[0], s[1]);
                        productos.Modificar(s[0], line);
                    }

                    ventas.Agregar(strVenta);
                    dgvProd.Rows.Clear();
                    fillDataGrid();
                    dgvVentas.Rows.Clear();

                    //Creando factura
                    string rutaFactura = Application.StartupPath + "\\Archivos\\Facturas\\" + idVenta + ".txt";
                    FileStream fact = File.Create(rutaFactura);
                    fact.Close();
                    StreamWriter write = new StreamWriter(rutaFactura);
                    string[] columnas = { "N°", "Producto", "Precio", "Cant.", "Subtotal" };
                    string formato = "{0,3}  {1,-20}  {2,-6}  {3,-5}  {4}";
                    string separador = "", borde = "";
                    string encabezados = String.Format(formato, columnas);
                    foreach (char letra in encabezados)
                    {
                        separador += "-";
                        borde += "*";
                    }

                    write.WriteLine(borde);
                    write.WriteLine("\t\t Factura {0}", idVenta);
                    write.WriteLine("\t\t    Libreria");
                    write.WriteLine();
                    write.WriteLine("Empleado: {0} {1}", empleado[1], empleado[2]);
                    write.WriteLine("Fecha: {0}", DateTime.Now.ToShortDateString());
                    write.WriteLine("Hora: {0}", DateTime.Now.ToLongTimeString());
                    write.WriteLine();

                    write.WriteLine(separador);
                    write.WriteLine(encabezados);
                    write.WriteLine(separador);

                    int i = 0;
                    foreach (string[] item in ProdFactura)
                    {
                        i++;
                        write.WriteLine(String.Format(formato, i, item[1], item[2], item[3], item[4]));
                    }

                    write.WriteLine(separador);
                    write.WriteLine();
                    write.WriteLine(String.Format("{0, 45}{1}", "Total: $", lblTotal.Text));
                    write.WriteLine(String.Format("{0, 45}{1}", "Pago recibido: $", txtPago.Text));
                    write.WriteLine(String.Format("{0, 45}{1}", "Cambio: $", cambio));
                    write.WriteLine(borde);
                    write.Close();

                    Process.Start(rutaFactura);

                    lblTotal.Text = "0";
                    lblCambio.Text = "0";
                    txtPago.Clear();
                    ProdFactura.Clear();
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

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
