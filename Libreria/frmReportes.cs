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
        Datos empleados = new Datos("Empleados.txt");
        Datos productos = new Datos("productos.txt");
        Datos ventas = new Datos("Ventas.txt");
        Datos compras = new Datos("Compras.txt");
        Reportes reporte = new Reportes();

        public frmReportes(Usuarios user)
        {
            usuarioActivo = user;
            FormColor colr = new FormColor(this);

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
            }
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            if (usuarioActivo.Tipo == "Admin")
            {
                rbReportesGenrales.Checked = true;
            }
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
                if (!File.Exists(reporte.RutaReporte))
                {
                    FileStream fs = File.Create(reporte.RutaReporte);
                    fs.Close();
                }

                if (rbFCompras.Checked)
                {
                    string[] columnas = { "Código", "Producto", "Precio", "Cant.", "Total", "Empleado", "Fecha de compra" };
                    formato = "{0,-8}  {1,-9}  {2,-8}  {3,-6}  {4,-8}  {5,-8}  {6}";
                    reporte.GenerarReporte(dtDesde.Value, dtHasta.Value, columnas, formato, "Compras", compras);
                }
                else if (rbFVentas.Checked)
                {
                    string[] columnas = { "Código", "Cliente", "", "Total venta", "Empleado", "Fecha de Venta" };
                    formato = "{0,-8}  {1,-20}  {3,-12}  {4,-8}  {5}";
                    reporte.GenerarReporte(dtDesde.Value, dtHasta.Value, columnas, formato, "Ventas", ventas);
                }
            }
        }
    }
}
