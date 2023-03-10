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
    public partial class FrmOrdenCatalogo : System.Windows.Forms.Form
    {
        int SucursalId;
        String rol;
        string rpta;
        public FrmOrdenCatalogo(String rolUsuario)
        {
            rol = rolUsuario; 
            InitializeComponent();
            // Cargar el cmb comodin Sucursal
            /*Dictionary<int, string> Sucursales = new Dictionary<int, string>();

            foreach (DataRow row in CComboxes.CargarSucursal().Rows)
            {
                Sucursales.Add((int)row[1], (string)row[0]);
            }*/
            //this.cmbSucursal.DataSource = new BindingSource(Sucursales, null);
            //this.cmbSucursal.DisplayMember = "Value";
            //this.cmbSucursal.ValueMember = "Key";

            // Get combobox selection (in handler)
            // = ((KeyValuePair<int, string>)this.cmbSucursal.SelectedItem).Key;
            // Cargar las ordenes de la sucursar selecionada
            dgvOrdenes.DataSource = CComboxes.CargarOrden(1);
            dgvOrdenes.Columns[0].Visible = true;
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            //LoadTheme();
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
            //label4.ForeColor = ThemeColor.SecondaryColor;
            ///label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update 1 var
            //1 = ((KeyValuePair<int, string>)this.cmbSucursal.SelectedItem).Key;
            // Cargar las ordenes de la sucursar selecionada
            //dgvOrdenes.DataSource = CComboxes.CargarOrden(1);
            //this.dgvOrdenes.Columns[0].Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmOrden o = new FrmOrden(1,rol);
            o.isUpdate = false;
            o.ShowDialog();
            dgvOrdenes.DataSource = CComboxes.CargarOrden(1);


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            if (dgvOrdenes.Rows.Count == 0 || dgvOrdenes.CurrentCell == null)
            {
                MessageBox.Show("Para actualizar un registro debe seleccionar una fila");
                return;
            }

            // Respaldo de los datos iniciales
            int OrdenID = (int)this.dgvOrdenes.CurrentRow.Cells[0].Value;

            DataRow[] SelectedRow = CComboxes.MostrarOrdenForeignKey(1).Select("OrdenID = " + OrdenID);

            int MeseroID = (int)SelectedRow[0][1];
            int MesaID = (int)SelectedRow[0][2];
            int ClienteID = (int)SelectedRow[0][3];
            string FechaRealizacion = Convert.ToString(this.dgvOrdenes.CurrentRow.Cells[4].Value);

            // Llamada al form que contine los datos de entrada del 'objeto' Sucursal
            FrmOrden frmOrden = new FrmOrden(1, rol);
            frmOrden.isUpdate = true;
            frmOrden.fillSpaces(MeseroID, MesaID, ClienteID, FechaRealizacion);
            frmOrden.EditableOrdenID = OrdenID;
            frmOrden.ShowDialog();
            dgvOrdenes.DataSource = CComboxes.CargarOrden(1);

        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.Rows.Count == 0 || dgvOrdenes.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Para actualizar un registro debe seleccionar una fila");
                return;
            }

            // Respaldo de los datos iniciales
            int OrdenID = (int)this.dgvOrdenes.CurrentRow.Cells[0].Value;

            FrmComidasDeOrdenCatalogo co = new FrmComidasDeOrdenCatalogo(OrdenID,rol);
            co.ShowDialog();

            dgvOrdenes.DataSource = CComboxes.CargarOrden(1);
            //dgvOrdenes.Columns[0].Visible = false;
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.Rows.Count == 0 || dgvOrdenes.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Para actualizar un registro debe seleccionar una fila");
                return;
            }

            // Respaldo de los datos iniciales
            int OrdenID = (int)this.dgvOrdenes.CurrentRow.Cells[0].Value;

            FrmBebidaDeOrdenCatalogo co = new FrmBebidaDeOrdenCatalogo(OrdenID);
            co.ShowDialog();

            dgvOrdenes.DataSource = CComboxes.CargarOrden(1);
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvOrdenes.Rows.Count == 0 || dgvOrdenes.CurrentCell == null)
            {
                MessageBox.Show("Para Eliminar un registro debe seleccionar una fila");
                return;
            }

            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro importante?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int OrdenID = (int)this.dgvOrdenes.CurrentRow.Cells[0].Value;
                rpta = COrden.Eliminar(OrdenID);
                dgvOrdenes.DataSource = CComboxes.CargarOrden(1);
            }

        }
    }
}
