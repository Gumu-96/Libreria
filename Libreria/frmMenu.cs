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
        public string[] empleado;

        public frmMenu(Usuarios user)
        {
            FormColor color = new FormColor(this);
            Datos emp = new Datos("Empleados.txt");
            usuarioActivo = user;
            empleado = emp.ObtenerVector(usuarioActivo.Usuario);
            InitializeComponent();
        }

        private void btnMantEmp_Click(object sender, EventArgs e)
        {
            frmMantEmpleados mant = new frmMantEmpleados(usuarioActivo);
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
            lblFechaHora.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
            if (!usuarioActivo.Tipo)
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
            frmVentas ventas = new frmVentas(usuarioActivo, empleado);
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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (usuarioActivo.Tipo)
            {
                frmReportes reportes = new frmReportes(usuarioActivo);
                reportes.Show();
            }
            else
            {
                frmReportesEmpleado reportesEmp = new frmReportesEmpleado(usuarioActivo);
                reportesEmp.Show();
            }
            Hide();
        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
        }
    }
}
