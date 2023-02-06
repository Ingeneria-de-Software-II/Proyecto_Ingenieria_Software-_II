
namespace Sistema_Facturacion_Restaurantes.Forms
{
    partial class FrmProveedorCatalogo
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
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarCliente = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSeleccionarProveedor = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.btnSeleccionarCliente.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToResizeColumns = false;
            this.dgvProveedor.AllowUserToResizeRows = false;
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedor.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedor.Location = new System.Drawing.Point(16, 16);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.Size = new System.Drawing.Size(905, 495);
            this.dgvProveedor.TabIndex = 19;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.BackColor = System.Drawing.Color.MintCream;
            this.btnSeleccionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSeleccionarCliente.Controls.Add(this.flowLayoutPanel1);
            this.btnSeleccionarCliente.Controls.Add(this.flowLayoutPanel2);
            this.btnSeleccionarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(937, 60);
            this.btnSeleccionarCliente.TabIndex = 41;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSeleccionarProveedor);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(250, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(14, 14, 0, 14);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(326, 58);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.AutoSize = true;
            this.btnSeleccionarProveedor.BackColor = System.Drawing.Color.MintCream;
            this.btnSeleccionarProveedor.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarProveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSeleccionarProveedor.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnSeleccionarProveedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSeleccionarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionarProveedor.IconSize = 26;
            this.btnSeleccionarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarProveedor.Location = new System.Drawing.Point(14, 14);
            this.btnSeleccionarProveedor.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.Size = new System.Drawing.Size(130, 32);
            this.btnSeleccionarProveedor.TabIndex = 21;
            this.btnSeleccionarProveedor.Text = "Proveedor";
            this.btnSeleccionarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionarProveedor.UseVisualStyleBackColor = false;
            this.btnSeleccionarProveedor.Click += new System.EventHandler(this.btnSeleccionarProveedor_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAgregar);
            this.flowLayoutPanel2.Controls.Add(this.btnActualizar);
            this.flowLayoutPanel2.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(250, 58);
            this.flowLayoutPanel2.TabIndex = 24;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 26;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(16, 14);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 32);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftRotate;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 26;
            this.btnActualizar.Location = new System.Drawing.Point(124, 14);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(32, 32);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Tag = "Actualizar x";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 26;
            this.btnEliminar.Location = new System.Drawing.Point(164, 14);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(32, 32);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.dgvProveedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(937, 527);
            this.panel1.TabIndex = 42;
            // 
            // FrmProveedorCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmProveedorCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catalogo de proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.btnSeleccionarCliente.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Panel btnSeleccionarCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public FontAwesome.Sharp.IconButton btnSeleccionarProveedor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public FontAwesome.Sharp.IconButton btnAgregar;
        public FontAwesome.Sharp.IconButton btnActualizar;
        public FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}