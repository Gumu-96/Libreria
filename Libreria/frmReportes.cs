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

namespace Libreria
{
    public partial class frmReportes : MaterialForm
    {
        Usuarios usuarioActivo;

        public frmReportes(Usuarios user)
        {
            usuarioActivo = user;
            FormColor colr = new FormColor(this);

            InitializeComponent();
        }
    }
}
