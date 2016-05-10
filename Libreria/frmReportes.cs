using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;

namespace Libreria
{
    public partial class frmReportes : MaterialForm
    {
        Usuarios usuarioActivo;
        MetroColorStyle MetroColor;
        Datos empleados = new Datos("Empleados.txt");
        Datos productos = new Datos("productos.txt");
        Datos ventas = new Datos("Ventas.txt");
        Datos compras = new Datos("Compras.txt");
        Reportes reporte = new Reportes();

        public frmReportes(Usuarios user)
        {
            usuarioActivo = user;
            FormColor color = new FormColor(this);
            MetroColor = color.MetroColor;

            InitializeComponent();
        }
        
        private void frmReportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.abrirForm("frmMenu");
        }
        
        private void rbReportesGenrales_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReportesGenrales.Checked)
            {
                panelGenerales.Visible = true;
                panelFechas.Visible = false;
                panelEmpleados.Visible = false;
                rbTEmpleados.Checked = true;
            }
        }

        private void rbReportesFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReportesFechas.Checked)
            {
                panelGenerales.Visible = false;
                panelFechas.Visible = true;
                panelEmpleados.Visible = false;
                rbFCompras.Checked = true;
            }
        }

        private void rbReportesEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReportesEmpleados.Checked)
            {
                panelGenerales.Visible = false;
                panelFechas.Visible = false;
                panelEmpleados.Visible = true;
                rbECompras.Checked = true;
                cboEmps.SelectedIndex = -1;
            }
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: " + usuarioActivo.Usuario;
            panelEmpleados.Style = MetroColor;
            panelFechas.Style = MetroColor;
            panelGenerales.Style = MetroColor;
            rbReportesGenrales.Checked = true;
            MostrarEmp();
        }

        private void btnGenerales_Click(object sender, EventArgs e)
        {
            if (!File.Exists(reporte.RutaReporte))
            {
                FileStream fs = File.Create(reporte.RutaReporte);
                fs.Close();
            }

            List<string[]> filas = new List<string[]>();
            string titulo, formato;

            if (rbTEmpleados.Checked)
            {
                filas = empleados.LeerArchivo();
                string[] columnas = { "Código", "Nombres", "Apellidos", "Email", "DUI", "Fecha de nacimiento" };
                formato = "{0,-8}  {1,-20}  {2,-20}  {3,-20}  {4,-11}  {5}";
                titulo = "Reporte de todos los empleados";
                reporte.GenerarReporte(filas, columnas, formato, titulo);
            }
            else if (rbTProductos.Checked)
            {
                filas = productos.LeerArchivo();
                string[] columnas = { "Código", "Nombre del producto", "Precio venta", "Precio compra", "Cant. Disp.", "Detalle" };
                formato = "{0,-8}  {1,-20}  {2,-12}  {3,-12}  {4,-12}  {5, -50}";
                titulo = "Reporte de todos los productos";
                reporte.GenerarReporte(filas, columnas, formato, titulo);
            }
            else if (rbTCompras.Checked)
            {
                filas = compras.LeerArchivo();
                string[] columnas = { "Código", "Producto", "Precio", "Cant.", "Total", "Empleado", "Fecha de compra" };
                formato = "{0,-8}  {1,-9}  {2,-8}  {3,-6}  {4,-8}  {5,-8}  {6}";
                titulo = "Reporte de todos las compras";
                reporte.GenerarReporte(filas, columnas, formato, titulo);
            }
            else
            {
                filas = ventas.LeerArchivo();
                string[] columnas = { "Código", "Cliente", "", "Total venta", "Empleado", "Fecha de Venta" };
                formato = "{0,-8}  {1,-20}  {3,-12}  {4,-8}  {5}";
                titulo = "Reporte de todas las ventas";
                reporte.GenerarReporte(filas, columnas, formato, titulo);
            }
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            if (dtDesde.Value > dtHasta.Value || dtHasta.Value < dtDesde.Value)
            {
                MetroMessageBox.Show(this, "Rango de fechas incorrecto");
            }
            else
            {
                string formato;
                DateTime desde = DateTime.Parse(dtDesde.Value.ToShortDateString());
                DateTime hasta = DateTime.Parse(dtHasta.Value.ToShortDateString());
                if (!File.Exists(reporte.RutaReporte))
                {
                    FileStream fs = File.Create(reporte.RutaReporte);
                    fs.Close();
                }

                if (rbFCompras.Checked)
                {
                    string[] columnas = { "Código", "Producto", "Precio", "Cant.", "Total", "Empleado", "Fecha de compra" };
                    formato = "{0,-8}  {1,-9}  {2,-8}  {3,-6}  {4,-8}  {5,-8}  {6}";
                    reporte.GenerarReporte(desde, hasta, columnas, formato, "Compras", compras);
                }
                else if (rbFVentas.Checked)
                {
                    string[] columnas = { "Código", "Cliente", "", "Total venta", "Empleado", "Fecha de Venta" };
                    formato = "{0,-8}  {1,-20}  {3,-12}  {4,-8}  {5}";
                    reporte.GenerarReporte(desde, hasta, columnas, formato, "Ventas", ventas);
                }
            }
        }

        public void MostrarEmp()
        {
            List<string[]> emps = empleados.LeerArchivo();

            foreach (string[] item in emps)
                cboEmps.Items.Add(item[0] + " - " + item[1] + " " + item[2]);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (cboEmps.SelectedIndex != -1)
            {
                string formato;
                if (!File.Exists(reporte.RutaReporte))
                {
                    FileStream fs = File.Create(reporte.RutaReporte);
                    fs.Close();
                }

                if (rbECompras.Checked)
                {
                    string[] columnas = { "Código", "Producto", "Precio", "Cant.", "Total", "Empleado", "Fecha de compra" };
                    formato = "{0,-8}  {1,-9}  {2,-8}  {3,-6}  {4,-8}  {5,-8}  {6}";
                    reporte.GenerarReporte(cboEmps.Text.Substring(0, 6), columnas, formato, "Compras", compras);
                }
                else if (rbEVentas.Checked)
                {
                    string[] columnas = { "Código", "Cliente", "", "Total venta", "Empleado", "Fecha de Venta" };
                    formato = "{0,-8}  {1,-20}  {3,-12}  {4,-8}  {5}";
                    reporte.GenerarReporte(cboEmps.Text.Substring(0, 6), columnas, formato, "Ventas", ventas);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Por favor seleccione un empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbTVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTVentas.Checked)
                btnFacturas.Visible = true;
            else
                btnFacturas.Visible = false;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Application.StartupPath + "\\Archivos\\Facturas");
        }
    }
}
