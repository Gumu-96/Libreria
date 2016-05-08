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

namespace Libreria
{
    public partial class frmMenuColor : MaterialForm
    {
        public frmMenuColor()
        {
            FormColor color = new FormColor(this);

            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            NewColor(1);
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            NewColor(2);
        }

        private void btnColor3_Click(object sender, EventArgs e)
        {
            NewColor(3);
        }

        private void btnColor4_Click(object sender, EventArgs e)
        {
            NewColor(4);
        }

        private void NewColor(int color)
        {
            Datos newColor = new Datos("Config.txt");
            string[] linea = newColor.ObtenerVector("color");
            linea[1] = Convert.ToString(color);
            newColor.Modificar("color", newColor.VectorToLine(linea));
            FormColor fColor = new FormColor(this);
        }

        private void frmMenuColor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.abrirForm("frmMenu");
        }
    }
}
