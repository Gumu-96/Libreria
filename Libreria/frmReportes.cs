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
        Datos reporte = new Datos("Reporte.txt");
        Datos empleados = new Datos("Empleados.txt");
        Datos productos = new Datos("productos.txt");
        Datos ventas = new Datos("Ventas.txt");
        Datos compras = new Datos("Compras.txt");

        public frmReportes(Usuarios user)
        {
            usuarioActivo = user;
            FormColor colr = new FormColor(this);

            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (File.Exists(reporte.RutaArchivo))
            {
                List<string[]> emp = empleados.LeerArchivo();
                StreamWriter write = new StreamWriter(reporte.RutaArchivo);
                write.WriteLine("\t\t Reporte de todos los empleados");
                write.WriteLine();

                write.WriteLine("------------------------------------------------------------------------------------------------------");
                write.WriteLine(String.Format("{0,-8} | {1,-15} | {2,-15} | {3,-20} | {4,-10} | {5}", "Código", "Nombres", "Apellidos", "Email", "DUI", "Fecha de nacimiento"));
                write.WriteLine("------------------------------------------------------------------------------------------------------");
                foreach (string[] empleado in emp)
                {
                    write.WriteLine(String.Format("{0,-8} | {1,-15} | {2,-15} | {3,-20} | {4,-10} | {5}", empleado[0], empleado[1], empleado[2], empleado[3], empleado[4], empleado[5]));
                }
                write.WriteLine("------------------------------------------------------------------------------------------------------");
                write.Close();

                Process.Start(reporte.RutaArchivo);
            }
        }

        private void frmReportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.abrirForm("frmMenu");
        }
    }
}
