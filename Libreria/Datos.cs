using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;
using System.Windows.Forms;

namespace Libreria
{
    class Datos
    {
        string rutaArchivo;

        public string RutaArchivo
        {
            get { return rutaArchivo; }
            set { rutaArchivo = value; }
        }

        public Datos(string fileName)
        {
            RutaArchivo = Application.StartupPath + "\\Archivos\\" + fileName;
        }

        public List<string[]> LeerArchivo()
        {
            List<string[]> filas = new List<string[]>(); 
            string line;

            StreamReader file = new StreamReader(rutaArchivo);

            while ((line = file.ReadLine()) != null)
            {
                if (line != "")
                {
                    string[] vector = line.Split('|');
                    filas.Add(vector);
                }
            }
            file.Close();
            return filas;
        }

        public List<string[]> Filtrar(string filtro, int param)
        {
            List<string[]> todos = LeerArchivo();
            List<string[]> final = new List<string[]>();

            foreach (string[] item in todos)
                if (item[param].ToLower().Contains(filtro))
                    final.Add(item);
            return final;
        }

        public void Agregar(string nuevaFila)
        {
            StreamWriter write = File.AppendText(rutaArchivo);
            write.WriteLine(nuevaFila);
            write.Close();
        }

        public void Eliminar(string Id)
        {
            StreamWriter Write = new StreamWriter(Application.StartupPath + "\\Archivos\\temp.txt");
            StreamReader Read = new StreamReader(rutaArchivo);

            string line;
            while ((line = Read.ReadLine()) != null)
            {
                string[] datos = line.Split('|');
                if (datos[0] != Id)
                {
                    Write.WriteLine(line);
                }
            }
            Read.Close();
            Write.Close();

            File.Delete(rutaArchivo);
            File.Move(Application.StartupPath + "\\Archivos\\temp.txt", rutaArchivo);
        }

        public void Modificar(string Id, string NewLine)
        {
            StreamWriter Write = new StreamWriter(Application.StartupPath + "\\Archivos\\temp.txt");
            StreamReader Read = new StreamReader(rutaArchivo);

            string line;
            while ((line = Read.ReadLine()) != null)
            {
                string[] datos = line.Split('|');
                if (datos[0] != Id)
                {
                    Write.WriteLine(line);
                }
            }
            Write.WriteLine(NewLine);
            Read.Close();
            Write.Close();

            File.Delete(rutaArchivo);
            File.Move(Application.StartupPath + "\\Archivos\\temp.txt", rutaArchivo);
        }

        public string[] LineToVector(string linea)
        {
            string[] vector = linea.Split('|');
            return vector;
        }

        public string VectorToLine(string[] vector)
        {
            string linea = "";
            for (int i = 0; i < vector.Length; i++)
                linea += vector[i] + "|";
            linea = linea.Substring(0, linea.Length - 1);
            return linea;
        }

        public string[] ObtenerVector(string id)
        {
            List<string[]> lista = LeerArchivo();
            string[] vector = lista.Find(r => r[0] == id);
            return vector;
        }
    }
}
