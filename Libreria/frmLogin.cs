using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework;
using MetroFramework.Forms;

namespace Libreria
{
    public partial class frmLogin : MaterialForm
    {
        Datos datos = new Datos("Usuarios.txt");
        public frmLogin()
        {
            FormColor color = new FormColor(this);

            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContrasena.Text == "")
            {
                lblInfo.Visible = true;
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Ingrese usuario y contraseña";
            }
            else if (File.Exists(Application.StartupPath + "\\Archivos\\Usuarios.txt"))
            {
                int i = 0;
                string user = txtUsuario.Text, pass = txtContrasena.Text;
                List<Usuarios> usuarios = new List<Usuarios>();
                List<string[]> lista = datos.LeerArchivo();

                foreach (string[] item in lista)
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Usuario = item[0];
                    usuario.Contrasena = item[1];
                    usuario.Tipo = item[2];
                    usuarios.Add(usuario);
                }

                foreach (Usuarios item in usuarios)
                {
                    i++;
                    if (item.Iniciar(user, pass))
                    {
                        frmMenu Menu = new frmMenu(item);
                        Menu.Show();
                        Hide();
                        
                        txtContrasena.Clear();
                        txtUsuario.Clear();
                        txtUsuario.Focus();
                        break;
                    }
                    else if (i == (usuarios.Count))
                    {
                        lblInfo.Visible = true;
                        lblInfo.ForeColor = Color.Red;
                        lblInfo.Text = "Usuario y/o contraseña incorrectos";
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "No se encontró el archivo 'Usuarios.txt'", "Error");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }
    }
}
