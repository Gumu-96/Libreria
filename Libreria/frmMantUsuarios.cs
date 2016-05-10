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
    public partial class frmMantUsuarios : MaterialForm
    {
        Usuarios usuarioActivo;
        MetroColorStyle MetroColor;
        Datos usuarios = new Datos("Usuarios.txt");

        public frmMantUsuarios(Usuarios user)
        {
            FormColor color = new FormColor(this);
            MetroColor = color.MetroColor;
            usuarioActivo = user;

            InitializeComponent();
        }

        private void FillListView()
        {
            dgvUsuarios.Rows.Clear();
            List<string[]> filas = new List<string[]>();

            if (File.Exists(usuarios.RutaArchivo))
            {
                filas = usuarios.LeerArchivo();

                foreach (string[] fila in filas)
                    dgvUsuarios.Rows.Add(fila);
            }
            else
            {
                MetroMessageBox.Show(this, "No se encontro el archivo 'Empleados.txt'", "Advertencia");
            }
        }

        private void frmMantUsuarios_Load(object sender, EventArgs e)
        {
            FillListView();
            dgvUsuarios.BorderStyle = BorderStyle.Fixed3D;
            dgvUsuarios.Style = MetroColor;
            lblUsuario.Text = "Usuario: " + usuarioActivo.Usuario;
            controles(false);
        }

        private void controles(bool val)
        {
            txtContrasena.Enabled = val;
            chkAdmin.Enabled = val;
            btnEditar.Visible = !val;
            btnGuardar.Visible = val;
            btnCancelar.Visible = val;
            btnRegresar.Visible = !val;
            dgvUsuarios.Enabled = !val;
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtContrasena.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            chkAdmin.Checked = bool.Parse(dgvUsuarios.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controles(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controles(false);
            FillListView();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text != "")
            {
                if (File.Exists(usuarios.RutaArchivo))
                {
                    bool isAdmin = false;
                    if (chkAdmin.Checked)
                        isAdmin = true;
                    string[] user = { txtUsuario.Text, txtContrasena.Text, isAdmin.ToString() };
                    usuarios.Modificar(txtUsuario.Text, usuarios.VectorToLine(user));

                    MetroMessageBox.Show(this, "Datos guardados!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    controles(false);
                    FillListView();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "El campo 'Contraseña' es requerido!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMantUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.abrirForm("frmMantEmpleados");
        }
    }
}
