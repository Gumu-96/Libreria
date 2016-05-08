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
    public partial class frmMenu : MaterialForm
    {
        Usuarios usuarioActivo;

        public frmMenu(Usuarios user)
        {
            FormColor color = new FormColor(this);
            usuarioActivo = user;
            InitializeComponent();
        }

        private void btnMantEmp_Click(object sender, EventArgs e)
        {
            frmMantEmpleados mant = new frmMantEmpleados();
            mant.Show();
            Hide();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmMenuColor menuColor = new frmMenuColor();
            menuColor.Show();
            Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: " + usuarioActivo.Usuario;
            if (usuarioActivo.Tipo == "Empleado")
            {
                Text = "Menú Empleado";
                btnMantEmp.Visible = false;
                btnProductos.Location = new Point(115, 170);
                btnVentas.Location = new Point(395, 170);
                btnReportes.Location = new Point(675, 170);
                btnConfig.Location = new Point(115, 360);
                btnCerrarSesion.Location = new Point(395, 360);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas(usuarioActivo);
            ventas.Show();
            Hide();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.abrirForm("frmLogin");
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos(usuarioActivo);
            productos.Show();
            Hide();
        }
    }
}
