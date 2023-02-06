namespace Sistema_Facturacion_Restaurantes.Forms
{
    partial class formBebidas
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
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarAOrden = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.AllowUserToResizeColumns = false;
            this.dgvBebidas.AllowUserToResizeRows = false;
            this.dgvBebidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBebidas.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBebidas.Location = new System.Drawing.Point(16, 16);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.RowHeadersWidth = 51;
            this.dgvBebidas.Size = new System.Drawing.Size(1031, 606);
            this.dgvBebidas.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 60);
            this.panel2.TabIndex = 39;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAgregarAOrden);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(833, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(16, 14, 0, 14);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(228, 58);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAgregar);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 58);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.dgvBebidas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16, 16, 16, 0);
            this.panel1.Size = new System.Drawing.Size(1063, 622);
            this.panel1.TabIndex = 40;
            // 
            // btnAgregarAOrden
            // 
            this.btnAgregarAOrden.AutoSize = true;
            this.btnAgregarAOrden.BackColor = System.Drawing.Color.MintCream;
            this.btnAgregarAOrden.FlatAppearance.BorderSize = 0;
            this.btnAgregarAOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAOrden.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarAOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAgregarAOrden.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnAgregarAOrden.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAgregarAOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarAOrden.IconSize = 26;
            this.btnAgregarAOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAOrden.Location = new System.Drawing.Point(72, 14);
            this.btnAgregarAOrden.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnAgregarAOrden.Name = "btnAgregarAOrden";
            this.btnAgregarAOrden.Size = new System.Drawing.Size(136, 32);
            this.btnAgregarAOrden.TabIndex = 22;
            this.btnAgregarAOrden.Text = "Agregar Orden";
            this.btnAgregarAOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarAOrden.UseVisualStyleBackColor = false;
            this.btnAgregarAOrden.Click += new System.EventHandler(this.btnAgregarAOrden_Click);
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
            this.btnAgregar.Size = new System.Drawing.Size(130, 32);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Nueva Bebida";
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
            this.btnActualizar.Location = new System.Drawing.Point(154, 14);
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
            this.btnEliminar.Location = new System.Drawing.Point(194, 14);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(32, 32);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // formBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "formBebidas";
            this.Text = "Bebidas";
            this.Load += new System.EventHandler(this.FormReporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBebidas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public FontAwesome.Sharp.IconButton btnAgregarAOrden;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public FontAwesome.Sharp.IconButton btnAgregar;
        public FontAwesome.Sharp.IconButton btnActualizar;
        public FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}