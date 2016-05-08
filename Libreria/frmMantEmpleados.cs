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
    public partial class frmMantEmpleados : MaterialForm
    {
        int add = 0;
        MetroColorStyle MetroColor;
        Datos datos = new Datos("Empleados.txt");
        Datos usuario = new Datos("Usuarios.txt");

        public frmMantEmpleados()
        {
            InitializeComponent();
        }

        private void botonesAccion(bool val)
        {
            dgvEmp.Enabled = !val;
            txtNombres.Enabled = val;
            txtApellidos.Enabled = val;
            txtEmail.Enabled = val;
            txtDui.Enabled = val;
            dtFecha.Enabled = val;
            btnNuevo.Visible = !val;
            btnEditar.Visible = !val;
            btnEliminar.Visible = !val;
            btnGuardar.Visible = val;
            btnCancelar.Visible = val;
            btnRegresar.Visible = !val;
        }

        private void CamposUsuario(bool val)
        {
            lbl2.Visible = val;
            txtUsuario.Visible = val;
            txtUsuario.Text = "Usuario";
            txtContrasena.Visible = val;
            txtContrasena.Clear();
            chkAdmin.Visible = val;
            chkAdmin.Checked = false;
        }

        private void Limpiar()
        {
            txtIdEmp.Text = "Id";
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtDui.Clear();
            dtFecha.Value = DateTime.Today;
        }

        private void FillListView()
        {
            dgvEmp.Rows.Clear();
            List<string[]> filas = new List<string[]>();

            if (File.Exists(datos.RutaArchivo))
            {
                filas = datos.LeerArchivo();

                foreach (string[] fila in filas)
                    dgvEmp.Rows.Add(fila);
            }
            else
            {
                MetroMessageBox.Show(this, "No se encontro el archivo 'Empleados.txt'", "Advertencia");
            }
        }

        private string GenerarId()
        {
            Datos config = new Datos("Config.txt");
            string newId = txtNombres.Text.Substring(0, 1).ToUpper() + txtApellidos.Text.Substring(0, 1).ToUpper();
            string[] linea = config.ObtenerVector("datos");
            int correlativo = int.Parse(linea[1]) + 1;
            linea[1] = correlativo.ToString();
            config.Modificar("datos", config.VectorToLine(linea));
            return newId += Convert.ToString(correlativo).PadLeft(4, '0');
        }

        private void frmMantEmpleados_Load(object sender, EventArgs e)
        {
            FormColor color = new FormColor(this);
            MetroColor = color.MetroColor;
            FillListView();
            dgvEmp.Style = MetroColor;
            dgvEmp.BorderStyle = BorderStyle.Fixed3D;
            botonesAccion(false);
            CamposUsuario(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            botonesAccion(true);
            CamposUsuario(true);
            add = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            botonesAccion(false);
            CamposUsuario(false);
            FillListView();
        }

        private void dgvEmp_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmp.RowCount != 0)
            {
                txtIdEmp.Text = dgvEmp.CurrentRow.Cells[0].Value.ToString();
                txtNombres.Text = dgvEmp.CurrentRow.Cells[1].Value.ToString();
                txtApellidos.Text = dgvEmp.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvEmp.CurrentRow.Cells[3].Value.ToString();
                txtDui.Text = dgvEmp.CurrentRow.Cells[4].Value.ToString();
                dtFecha.Value = DateTime.Parse(dgvEmp.CurrentRow.Cells[5].Value.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdEmp.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtEmail.Text == "" || txtDui.Text == "")
            {
                MetroMessageBox.Show(this, "Todos los campos son requeridos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dtFecha.Value >= DateTime.Today)
            {
                MetroMessageBox.Show(this, "La fecha debe ser menor a " + DateTime.Today, "Advertencia");
            }
            else
            {
                if (add == 1)
                {
                    if (txtContrasena.Text == "")
                    {
                        MetroMessageBox.Show(this, "Todos los campos son requeridos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txtIdEmp.Text = GenerarId();
                        txtUsuario.Text = txtIdEmp.Text;
                        string[] empleado = {  txtIdEmp.Text, txtNombres.Text, txtApellidos.Text, txtEmail.Text, txtDui.Text, dtFecha.Value.ToShortDateString() };
                        string isAdmin = "Empleado";
                        if (chkAdmin.Checked)
                            isAdmin = "Admin";
                        string[] user = { txtUsuario.Text, txtContrasena.Text, isAdmin };
                        datos.Agregar(datos.VectorToLine(empleado));
                        usuario.Agregar(usuario.VectorToLine(user));
                    }
                }
                else
                {
                    string[] empleado = { txtIdEmp.Text, txtNombres.Text, txtApellidos.Text, txtEmail.Text, txtDui.Text, dtFecha.Value.ToShortDateString() };
                    datos.Modificar(txtIdEmp.Text, datos.VectorToLine(empleado));
                }
                
                botonesAccion(false);
                CamposUsuario(false);
                MetroMessageBox.Show(this, "Datos guardados!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FillListView();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmp.RowCount != 0)
            {
                botonesAccion(true);
            }
            add = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmp.RowCount != 0)
            {
                DialogResult resp = MetroMessageBox.Show(this, "¿Desea eliminar estos datos?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    if (File.Exists(datos.RutaArchivo))
                    {
                        datos.Eliminar(txtIdEmp.Text);
                        usuario.Eliminar(txtIdEmp.Text);
                        FillListView();
                    }
                }
            }
        }
        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMantEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.abrirForm("frmMenu");
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDui.Text.Length < 8 || txtDui.Text.Length > 8)
                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;

            if (txtDui.Text.Length == 8)
                if (e.KeyChar == '-' || char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
        }
    }
}
