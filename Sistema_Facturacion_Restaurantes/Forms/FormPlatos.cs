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

namespace Sistema_Facturacion_Restaurantes.Forms
{
    public partial class FormPlatos : System.Windows.Forms.Form
    {
        String rol;
        String rpta;

        public Boolean AgregarPlatoAOrden = false;
        public FormPlatos(string RolUsuario)
        {

            rol = RolUsuario;


            InitializeComponent();
            switch (rol)
            {
                case "Recepcionista":
                    {
                        btnAgregar.Enabled = false;
                        btnActualizar.Enabled = false;
                        btnEliminar.Enabled = false;
                        break;
                    }
                case "Jefe Cocina":
                    {
                        btnAgregar.Enabled = false;
                        btnActualizar.Enabled = false;
                        //btnEliminar.Enabled = false;
                        //btnEmpleados.Hide();
                        break;
                    }
                case "Chef":
                    {

                        break;
                    }

            }

            this.dgvPlatos.DataSource = CPlato.MostrarPlato();
            this.dgvPlatos.Columns[0].Visible = false;
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            //LoadTheme();
            //if (!AgregarPlatoAOrden)
            //    btnAgregarPlatoAOrden.Hide(); // Oculto ese boton si no voy a agregar plato a la orden
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmPlato frmPlato = new FrmPlato();
            frmPlato.isUpdate = false;
            frmPlato.ShowDialog();
            this.dgvPlatos.DataSource = CPlato.MostrarPlato();
            this.dgvPlatos.Columns[0].Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPlatos.Rows.Count == 0 || dgvPlatos.CurrentCell == null)
            {
                MessageBox.Show("Para Actualizar un registro debe seleccionar una fila");
                return;
            }
            // Respaldo de los datos iniciales
            int PlatoID = (int)this.dgvPlatos.CurrentRow.Cells[0].Value;
            string Nombre = Convert.ToString(this.dgvPlatos.CurrentRow.Cells[1].Value);
            string Categoria = Convert.ToString(this.dgvPlatos.CurrentRow.Cells[2].Value);
            string Descripcion = Convert.ToString(this.dgvPlatos.CurrentRow.Cells[3].Value);
            double Precio = Double.Parse(Convert.ToString(this.dgvPlatos.CurrentRow.Cells[4].Value));

            // Llamada al form que contine los datos de entrada del 'objeto' Sucursal
            FrmPlato frmPlato = new FrmPlato();
            frmPlato.isUpdate = true;
            frmPlato.fillSpaces(Nombre, Descripcion, Precio, Categoria);
            frmPlato.EditablePlatoID = PlatoID;
            frmPlato.ShowDialog();
            this.dgvPlatos.DataSource = CPlato.MostrarPlato();
            this.dgvPlatos.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarPlatoAOrden_Click(object sender, EventArgs e)
        {
            int PlatoID = (int)this.dgvPlatos.CurrentRow.Cells[0].Value;
            string Nombre = Convert.ToString(this.dgvPlatos.CurrentRow.Cells[1].Value);

            if (AgregarPlatoAOrden)
            {
                FrmComidaDeOrden co = Owner as FrmComidaDeOrden;
                co.PlatoID = PlatoID;
                co.txtComida.Text = Nombre;
                AgregarPlatoAOrden = false;
                this.Dispose();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int PlatoID = (int)this.dgvPlatos.CurrentRow.Cells[0].Value;

            //FrmPlatoIngredientesCatalogo pic = new FrmPlatoIngredientesCatalogo(PlatoID);
            FrmPlatoIngredientesCatalogo pic = new FrmPlatoIngredientesCatalogo(PlatoID, rol);
            pic.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlatos.Rows.Count == 0 || dgvPlatos.CurrentCell == null)
            {
                MessageBox.Show("Para Eliminar un registro debe seleccionar una fila");
                return;
            }

            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro importante?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int OrdenID = (int)this.dgvPlatos.CurrentRow.Cells[0].Value;
                rpta = CPlato.Eliminar(OrdenID);
                dgvPlatos.DataSource = CPlato.MostrarPlato();
                this.dgvPlatos.Columns[0].Visible = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvPlatos.DataSource = CPlato.Buscar(txtBuscar.Text);
            this.dgvPlatos.Columns[0].Visible = false;

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "Ingrese el nombre")
            txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if(txtBuscar.Text == string.Empty)
            {
                txtBuscar.Text = "Ingrese el nombre";
                dgvPlatos.DataSource = CPlato.MostrarPlato();
                this.dgvPlatos.Columns[0].Visible = false;
            }
        }
    }

}
