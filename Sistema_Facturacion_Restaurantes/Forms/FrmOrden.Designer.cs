
namespace Sistema_Facturacion_Restaurantes.Forms
{
    partial class FrmOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxFormaPago = new System.Windows.Forms.GroupBox();
            this.rbtnCredito = new System.Windows.Forms.RadioButton();
            this.rbtnContado = new System.Windows.Forms.RadioButton();
            this.cmbMesas = new System.Windows.Forms.ComboBox();
            this.cmbMeseros = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbxFormaPago.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFormaPago
            // 
            this.gbxFormaPago.Controls.Add(this.rbtnCredito);
            this.gbxFormaPago.Controls.Add(this.rbtnContado);
            this.gbxFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxFormaPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFormaPago.ForeColor = System.Drawing.Color.White;
            this.gbxFormaPago.Location = new System.Drawing.Point(363, 27);
            this.gbxFormaPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxFormaPago.Name = "gbxFormaPago";
            this.gbxFormaPago.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxFormaPago.Size = new System.Drawing.Size(174, 90);
            this.gbxFormaPago.TabIndex = 51;
            this.gbxFormaPago.TabStop = false;
            this.gbxFormaPago.Text = "Forma de pago";
            // 
            // rbtnCredito
            // 
            this.rbtnCredito.AutoSize = true;
            this.rbtnCredito.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCredito.Location = new System.Drawing.Point(16, 51);
            this.rbtnCredito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnCredito.Name = "rbtnCredito";
            this.rbtnCredito.Size = new System.Drawing.Size(118, 21);
            this.rbtnCredito.TabIndex = 1;
            this.rbtnCredito.Text = "Credito (tarjeta)";
            this.rbtnCredito.UseVisualStyleBackColor = true;
            this.rbtnCredito.CheckedChanged += new System.EventHandler(this.rbtnCredito_CheckedChanged);
            // 
            // rbtnContado
            // 
            this.rbtnContado.AutoSize = true;
            this.rbtnContado.Checked = true;
            this.rbtnContado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnContado.Location = new System.Drawing.Point(16, 22);
            this.rbtnContado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnContado.Name = "rbtnContado";
            this.rbtnContado.Size = new System.Drawing.Size(76, 21);
            this.rbtnContado.TabIndex = 0;
            this.rbtnContado.TabStop = true;
            this.rbtnContado.Text = "Contado";
            this.rbtnContado.UseVisualStyleBackColor = true;
            this.rbtnContado.CheckedChanged += new System.EventHandler(this.rbtnContado_CheckedChanged);
            // 
            // cmbMesas
            // 
            this.cmbMesas.BackColor = System.Drawing.Color.MintCream;
            this.cmbMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMesas.FormattingEnabled = true;
            this.cmbMesas.Location = new System.Drawing.Point(110, 80);
            this.cmbMesas.Name = "cmbMesas";
            this.cmbMesas.Size = new System.Drawing.Size(200, 21);
            this.cmbMesas.TabIndex = 50;
            // 
            // cmbMeseros
            // 
            this.cmbMeseros.BackColor = System.Drawing.Color.MintCream;
            this.cmbMeseros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMeseros.FormattingEnabled = true;
            this.cmbMeseros.Location = new System.Drawing.Point(110, 30);
            this.cmbMeseros.Name = "cmbMeseros";
            this.cmbMeseros.Size = new System.Drawing.Size(200, 21);
            this.cmbMeseros.TabIndex = 47;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "\"yyyy-MM-dd hh:mm:ss.fff\"";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(110, 130);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 20);
            this.dtpFecha.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mesa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mesero:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardar.Location = new System.Drawing.Point(393, 10);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MintCream;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCancelar.Location = new System.Drawing.Point(477, 10);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 50);
            this.flowLayoutPanel1.TabIndex = 54;
            // 
            // FrmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(567, 288);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gbxFormaPago);
            this.Controls.Add(this.cmbMesas);
            this.Controls.Add(this.cmbMeseros);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden";
            this.gbxFormaPago.ResumeLayout(false);
            this.gbxFormaPago.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFormaPago;
        private System.Windows.Forms.RadioButton rbtnCredito;
        private System.Windows.Forms.RadioButton rbtnContado;
        private System.Windows.Forms.ComboBox cmbMesas;
        private System.Windows.Forms.ComboBox cmbMeseros;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}