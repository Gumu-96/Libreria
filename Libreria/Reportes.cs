using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Libreria
{
    class Reportes
    {
        string rutaReporte = Application.StartupPath + "\\Archivos\\Reporte.txt";

        public string RutaReporte
        {
            get { return rutaReporte; }
            set { rutaReporte = value; }
        }

        public void GenerarReporte(List<string[]> filas, string[] columnas, string formato, string titulo)
        {
            StreamWriter write = new StreamWriter(rutaReporte);
            string separador = "";
            string encabezados = String.Format(formato, columnas);

            foreach (char letra in encabezados)
                separador += "-";

            write.WriteLine("\t\t\t {0}", titulo);
            write.WriteLine();
            write.WriteLine("Reporte generado: {0} - {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
            write.WriteLine();

            write.WriteLine(separador);
            write.WriteLine(encabezados);
            write.WriteLine(separador);

            foreach (string[] fila in filas)
                write.WriteLine(String.Format(formato, fila));
            write.WriteLine(separador);

            write.Close();
            Process.Start(rutaReporte);
        }

        public void GenerarReporte(DateTime desde, DateTime hasta, string[] columnas, string formato, string opcion, Datos tipo)
        {
            StreamWriter write = new StreamWriter(rutaReporte);
            List<string[]> todos = tipo.LeerArchivo();
            string separador = "";
            string encabezados = String.Format(formato, columnas);

            foreach (char letra in encabezados)
                separador += "-";

            write.WriteLine("\t\t Reporte de {0} desde {1} hasta {2}", opcion, desde.ToShortDateString(), hasta.ToShortDateString());
            write.WriteLine();
            write.WriteLine("Reporte generado: {0} - {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
            write.WriteLine();

            write.WriteLine(separador);
            write.WriteLine(encabezados);
            write.WriteLine(separador);

            foreach (string[] fila in todos)
            {
                DateTime fecha = DateTime.Parse(fila[fila.Length - 1]);
                if ((fecha > desde && fecha < hasta) || fecha == desde || fecha == hasta || (fecha == desde && fecha == hasta))
                    write.WriteLine(String.Format(formato, fila));
            }
            write.WriteLine(separador);

            write.Close();
            Process.Start(rutaReporte);
        }

        public void GenerarReporte(string IdEmpleado, string[] columnas, string formato, string opcion, Datos tipo)
        {
            StreamWriter write = new StreamWriter(rutaReporte);
            List<string[]> todos = tipo.LeerArchivo();
            string separador = "";
            string encabezados = String.Format(formato, columnas);

            foreach (char letra in encabezados)
                separador += "-";

            write.WriteLine("\t\t Reporte de {0} por el empleado {1}", opcion, IdEmpleado);
            write.WriteLine();
            write.WriteLine("Reporte generado: {0} - {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
            write.WriteLine();

            write.WriteLine(separador);
            write.WriteLine(encabezados);
            write.WriteLine(separador);

            foreach (string[] fila in todos)
            {
                //if (fecha >= desde && fecha <= hasta)
                //    write.WriteLine(String.Format(formato, fila));
            }
            write.WriteLine(separador);

            write.Close();
            Process.Start(rutaReporte);
        }
    }
}
