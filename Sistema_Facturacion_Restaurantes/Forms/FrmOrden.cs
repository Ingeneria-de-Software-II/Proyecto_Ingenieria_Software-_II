﻿using Sistema_Facturacion_Restaurantes.Controller;
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
    public partial class FrmOrden : Form
    {
        int SucursalID = 0;
        public int ClienteID = 0;
        public Boolean isUpdate = false;
        public int EditableOrdenID = 0;
        String rol;

        public bool cancelado = false; 
        public FrmOrden(int Sucursal,String rolUsuario)
        {
            SucursalID = Sucursal;
            rol = rolUsuario;
            InitializeComponent();
            // Cargar los meseros que tragajan en la sucursal seleccionada
            Dictionary<int, string> Meseros = new Dictionary<int, string>();

            foreach (DataRow row in CComboxes.CargarMesero(1).Rows)
            {
                Meseros.Add((int)row[1], (string)row[0]);
            }
            this.cmbMeseros.DataSource = new BindingSource(Meseros, null);
            this.cmbMeseros.DisplayMember = "Value";
            this.cmbMeseros.ValueMember = "Key";
            // Cargar las mesas de la sucursar selecionada
            Dictionary<int, string> Mesas = new Dictionary<int, string>();

            foreach (DataRow row in CComboxes.CargarMesas(1).Rows)
            {
                Mesas.Add((int)row[1], (string)row[0]);
            }
            this.cmbMesas.DataSource = new BindingSource(Mesas, null);
            this.cmbMesas.DisplayMember = "Value";
            this.cmbMesas.ValueMember = "Key";

        }


        //Eventos de Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Get combobox selection (in handler)
                int EmpleadoID = ((KeyValuePair<int, string>)this.cmbMeseros.SelectedItem).Key;
                int MesaID = ((KeyValuePair<int, string>)this.cmbMesas.SelectedItem).Key;
                int Cliente = rbtnCredito.Checked ? ClienteID : 0;
                string FechaRealizacion = dtpFecha.Value.ToString();
                
                string rpta = "";
                if (isUpdate)
                {
                    rpta = COrden.Actualizar(EditableOrdenID, EmpleadoID, MesaID, Cliente, FechaRealizacion);

                    if (rpta.Equals("OK"))
                        MessageBox.Show("Datos actualizados exitosamente", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    rpta = COrden.Insertar(EmpleadoID, MesaID, Cliente, FechaRealizacion);

                    if (rpta.Equals("OK"))
                        MessageBox.Show("Datos ingresados exitosamente", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                this.isUpdate = false;
                this.Dispose();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Dispose();
        }



        //Eventos de Combobox
        private void rbtnContado_CheckedChanged(object sender, EventArgs e)
        {
            // Establecemos 0 porque solo registramos los clientes que pagan con tarjeta, entonces 0 significa que se pago en efectivo
            // No se puede hacer lo de arriba porque OrdenID es una llave foranea, entonces las ordenes con cliente ID = 5 quieren
            // decir que la orden se pago al contado
            if (rbtnContado.Checked)
                ClienteID = 0;
        }
        private void rbtnCredito_CheckedChanged(object sender, EventArgs e)
        {
            FrmOrden c = new FrmOrden(SucursalID, rol);
            if (rbtnCredito.Checked)
            {
                FrmClienteCatalogo cc = new FrmClienteCatalogo(rol, this);
                // Le indicamos a VS que cc va a formar de este form (FrmOrden) desde donde lo instanciamos
                // es decir que cc sera hijo de FrmOrden
                this.AddOwnedForm(cc);
                cc.Show();
            }
        }

        public void fillSpaces(int MeseroID, int MesaID, int ClienteID, string FechaRealizacion)
        {
            //Cargar los comboxes con los datos iniciales
            cmbMeseros.SelectedValue = MeseroID;
            cmbMesas.SelectedValue = MesaID;
            this.ClienteID = ClienteID;
            DateTime fr = Convert.ToDateTime(FechaRealizacion);
            dtpFecha.Value = fr.AddDays(0);
        }
        

        
    }
}
