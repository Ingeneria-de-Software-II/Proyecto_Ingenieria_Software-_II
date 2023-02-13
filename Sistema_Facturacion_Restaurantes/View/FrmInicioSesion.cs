using Sistema_Facturacion_Restaurantes.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion_Restaurantes.View
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dato;
            dato = CUsuario.Validar_acceso(this.txtUsuario.Text, this.txtContraseña.Text);

            if (dato != null)
            {
                if (dato.Rows.Count > 0)
                {
                    if (dato.Rows[0][0].ToString() == "Acceso exitoso")
                    {
                        string NombreUsuario = dato.Rows[0][2].ToString();
                        string Rol = dato.Rows[0][1].ToString();

                        MessageBox.Show("Bienvenido al Sistema", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMainMenu fc = new FormMainMenu(NombreUsuario, Rol);
                        fc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado al Sistema de Reservaciones", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtUsuario.Text = string.Empty;
                        this.txtContraseña.Text = string.Empty;
                        this.txtUsuario.Focus();
                    }
                }
            }
            else
                MessageBox.Show("No hay Conexión al Servidor", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
                txtUsuario.Text = "";
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == string.Empty)
                txtUsuario.Text = "Usuario";
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "Contraseña")
            {
                txtContraseña.PasswordChar = '*';
                txtContraseña.Text = "";
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == string.Empty)
            {
                txtContraseña.PasswordChar = '\0';
                txtContraseña.Text = "Contraseña";
            }
        }
    }
}
