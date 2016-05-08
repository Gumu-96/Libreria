using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Libreria
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

        public static void abrirForm(string nombre)
        {
            FormCollection formulario = Application.OpenForms;
            foreach (Form item in formulario)
            {
                if (item.Name == nombre)
                {
                    item.Show();
                    break;
                }
            }
        }
    }
}
