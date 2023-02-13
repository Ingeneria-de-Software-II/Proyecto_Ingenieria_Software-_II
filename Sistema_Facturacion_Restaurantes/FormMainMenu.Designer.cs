namespace Sistema_Facturacion_Restaurantes
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnReservar = new FontAwesome.Sharp.IconButton();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.pnlPersonasContainer = new System.Windows.Forms.Panel();
            this.pnlBotonesPersonas = new System.Windows.Forms.Panel();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnPersonas = new FontAwesome.Sharp.IconButton();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.pnlProductosContainer = new System.Windows.Forms.Panel();
            this.pnBotonesProducto = new System.Windows.Forms.Panel();
            this.btnBebidas = new FontAwesome.Sharp.IconButton();
            this.btnPlatos = new FontAwesome.Sharp.IconButton();
            this.btnOrders = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnSucursal = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.ttButtonMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnRestaurar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.pnlPersonasContainer.SuspendLayout();
            this.pnlBotonesPersonas.SuspendLayout();
            this.pnlProductosContainer.SuspendLayout();
            this.pnBotonesProducto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnReservar);
            this.panelMenu.Controls.Add(this.splitter4);
            this.panelMenu.Controls.Add(this.pnlPersonasContainer);
            this.panelMenu.Controls.Add(this.splitter3);
            this.panelMenu.Controls.Add(this.pnlProductosContainer);
            this.panelMenu.Controls.Add(this.splitter2);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnSucursal);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(400, 1033);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSetting.IconColor = System.Drawing.Color.White;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 28;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 984);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(400, 49);
            this.btnSetting.TabIndex = 18;
            this.btnSetting.Text = "Configuración";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnReservar.IconColor = System.Drawing.Color.White;
            this.btnReservar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReservar.IconSize = 28;
            this.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservar.Location = new System.Drawing.Point(0, 590);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnReservar.Size = new System.Drawing.Size(400, 49);
            this.btnReservar.TabIndex = 17;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Visible = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(0, 586);
            this.splitter4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(400, 4);
            this.splitter4.TabIndex = 24;
            this.splitter4.TabStop = false;
            // 
            // pnlPersonasContainer
            // 
            this.pnlPersonasContainer.Controls.Add(this.pnlBotonesPersonas);
            this.pnlPersonasContainer.Controls.Add(this.btnPersonas);
            this.pnlPersonasContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPersonasContainer.Location = new System.Drawing.Point(0, 377);
            this.pnlPersonasContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPersonasContainer.MaximumSize = new System.Drawing.Size(400, 209);
            this.pnlPersonasContainer.MinimumSize = new System.Drawing.Size(400, 62);
            this.pnlPersonasContainer.Name = "pnlPersonasContainer";
            this.pnlPersonasContainer.Size = new System.Drawing.Size(400, 209);
            this.pnlPersonasContainer.TabIndex = 14;
            // 
            // pnlBotonesPersonas
            // 
            this.pnlBotonesPersonas.Controls.Add(this.btnProveedores);
            this.pnlBotonesPersonas.Controls.Add(this.btnClientes);
            this.pnlBotonesPersonas.Controls.Add(this.btnEmpleados);
            this.pnlBotonesPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotonesPersonas.Location = new System.Drawing.Point(0, 62);
            this.pnlBotonesPersonas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBotonesPersonas.Name = "pnlBotonesPersonas";
            this.pnlBotonesPersonas.Size = new System.Drawing.Size(400, 148);
            this.pnlBotonesPersonas.TabIndex = 3;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnProveedores.IconColor = System.Drawing.Color.White;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 28;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 98);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(400, 49);
            this.btnProveedores.TabIndex = 9;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 28;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 49);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(400, 49);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 28;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(400, 49);
            this.btnEmpleados.TabIndex = 7;
            this.btnEmpleados.Tag = "";
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonas.FlatAppearance.BorderSize = 0;
            this.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonas.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPersonas.ForeColor = System.Drawing.Color.White;
            this.btnPersonas.IconChar = FontAwesome.Sharp.IconChar.CircleChevronDown;
            this.btnPersonas.IconColor = System.Drawing.Color.White;
            this.btnPersonas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonas.IconSize = 26;
            this.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonas.Location = new System.Drawing.Point(0, 0);
            this.btnPersonas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(400, 62);
            this.btnPersonas.TabIndex = 3;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.UseVisualStyleBackColor = false;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 373);
            this.splitter3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(400, 4);
            this.splitter3.TabIndex = 23;
            this.splitter3.TabStop = false;
            // 
            // pnlProductosContainer
            // 
            this.pnlProductosContainer.Controls.Add(this.pnBotonesProducto);
            this.pnlProductosContainer.Controls.Add(this.btnProductos);
            this.pnlProductosContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductosContainer.Location = new System.Drawing.Point(0, 164);
            this.pnlProductosContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlProductosContainer.MaximumSize = new System.Drawing.Size(400, 209);
            this.pnlProductosContainer.MinimumSize = new System.Drawing.Size(400, 62);
            this.pnlProductosContainer.Name = "pnlProductosContainer";
            this.pnlProductosContainer.Size = new System.Drawing.Size(400, 209);
            this.pnlProductosContainer.TabIndex = 13;
            // 
            // pnBotonesProducto
            // 
            this.pnBotonesProducto.Controls.Add(this.btnBebidas);
            this.pnBotonesProducto.Controls.Add(this.btnPlatos);
            this.pnBotonesProducto.Controls.Add(this.btnOrders);
            this.pnBotonesProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBotonesProducto.Location = new System.Drawing.Point(0, 62);
            this.pnBotonesProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnBotonesProducto.Name = "pnBotonesProducto";
            this.pnBotonesProducto.Size = new System.Drawing.Size(400, 148);
            this.pnBotonesProducto.TabIndex = 3;
            // 
            // btnBebidas
            // 
            this.btnBebidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBebidas.FlatAppearance.BorderSize = 0;
            this.btnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBebidas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBebidas.ForeColor = System.Drawing.Color.White;
            this.btnBebidas.IconChar = FontAwesome.Sharp.IconChar.WineGlass;
            this.btnBebidas.IconColor = System.Drawing.Color.White;
            this.btnBebidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBebidas.IconSize = 28;
            this.btnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBebidas.Location = new System.Drawing.Point(0, 98);
            this.btnBebidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnBebidas.Size = new System.Drawing.Size(400, 49);
            this.btnBebidas.TabIndex = 9;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBebidas.UseVisualStyleBackColor = false;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnPlatos
            // 
            this.btnPlatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlatos.FlatAppearance.BorderSize = 0;
            this.btnPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlatos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPlatos.ForeColor = System.Drawing.Color.White;
            this.btnPlatos.IconChar = FontAwesome.Sharp.IconChar.BowlRice;
            this.btnPlatos.IconColor = System.Drawing.Color.White;
            this.btnPlatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlatos.IconSize = 28;
            this.btnPlatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlatos.Location = new System.Drawing.Point(0, 49);
            this.btnPlatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlatos.Name = "btnPlatos";
            this.btnPlatos.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnPlatos.Size = new System.Drawing.Size(400, 49);
            this.btnPlatos.TabIndex = 8;
            this.btnPlatos.Text = "Platos";
            this.btnPlatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlatos.UseVisualStyleBackColor = false;
            this.btnPlatos.Click += new System.EventHandler(this.btnPlatos_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnOrders.IconColor = System.Drawing.Color.White;
            this.btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrders.IconSize = 28;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 0);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(400, 49);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "Ordenes";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.CircleChevronDown;
            this.btnProductos.IconColor = System.Drawing.Color.White;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 26;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(400, 62);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 160);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(400, 4);
            this.splitter2.TabIndex = 22;
            this.splitter2.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnReport.IconColor = System.Drawing.Color.White;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 28;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 111);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(400, 49);
            this.btnReport.TabIndex = 16;
            this.btnReport.Tag = "";
            this.btnReport.Text = "Reportes";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSucursal
            // 
            this.btnSucursal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSucursal.FlatAppearance.BorderSize = 0;
            this.btnSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSucursal.ForeColor = System.Drawing.Color.White;
            this.btnSucursal.IconChar = FontAwesome.Sharp.IconChar.LocationDot;
            this.btnSucursal.IconColor = System.Drawing.Color.White;
            this.btnSucursal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSucursal.IconSize = 28;
            this.btnSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSucursal.Location = new System.Drawing.Point(0, 62);
            this.btnSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSucursal.Name = "btnSucursal";
            this.btnSucursal.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSucursal.Size = new System.Drawing.Size(400, 49);
            this.btnSucursal.TabIndex = 15;
            this.btnSucursal.Tag = "";
            this.btnSucursal.Text = "Sucursales";
            this.btnSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSucursal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSucursal.UseVisualStyleBackColor = false;
            this.btnSucursal.Visible = false;
            this.btnSucursal.Click += new System.EventHandler(this.btnSucursal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 62);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Restaurante \"Las Kalas\"";
            // 
            // splitter5
            // 
            this.splitter5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter5.Location = new System.Drawing.Point(0, 519);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(300, 3);
            this.splitter5.TabIndex = 25;
            this.splitter5.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(96)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 90);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(300, 3);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(400, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1244, 74);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnCloseChildForm.IconColor = System.Drawing.Color.White;
            this.btnCloseChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseChildForm.IconSize = 40;
            this.btnCloseChildForm.Location = new System.Drawing.Point(1164, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(80, 74);
            this.btnCloseChildForm.TabIndex = 8;
            this.btnCloseChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(27, 18, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(122, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(400, 74);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1244, 959);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(118)))), ((int)(((byte)(198)))));
            this.pnlBarraTitulo.Controls.Add(this.label1);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnMaximizar);
            this.pnlBarraTitulo.Controls.Add(this.btnRestaurar);
            this.pnlBarraTitulo.Controls.Add(this.btnSalir);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1644, 0);
            this.pnlBarraTitulo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 12, 0, 0);
            this.label1.Size = new System.Drawing.Size(255, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de facturación ";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 26;
            this.btnMinimizar.Location = new System.Drawing.Point(1472, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 0);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 26;
            this.btnMaximizar.Location = new System.Drawing.Point(1515, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(43, 0);
            this.btnMaximizar.TabIndex = 7;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestaurar.IconColor = System.Drawing.Color.White;
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaurar.IconSize = 26;
            this.btnRestaurar.Location = new System.Drawing.Point(1558, 0);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(43, 0);
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 26;
            this.btnSalir.Location = new System.Drawing.Point(1601, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(43, 0);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 1033);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(950, 496);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de facturación";
            this.panelMenu.ResumeLayout(false);
            this.pnlPersonasContainer.ResumeLayout(false);
            this.pnlBotonesPersonas.ResumeLayout(false);
            this.pnlProductosContainer.ResumeLayout(false);
            this.pnBotonesProducto.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.ToolTip ttButtonMensaje;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        public FontAwesome.Sharp.IconButton btnMinimizar;
        public FontAwesome.Sharp.IconButton btnMaximizar;
        public FontAwesome.Sharp.IconButton btnRestaurar;
        public FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProductosContainer;
        private System.Windows.Forms.Panel pnBotonesProducto;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnBebidas;
        private FontAwesome.Sharp.IconButton btnPlatos;
        private FontAwesome.Sharp.IconButton btnOrders;
        private System.Windows.Forms.Panel pnlPersonasContainer;
        private System.Windows.Forms.Panel pnlBotonesPersonas;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private FontAwesome.Sharp.IconButton btnPersonas;
        private FontAwesome.Sharp.IconButton btnCloseChildForm;
        private FontAwesome.Sharp.IconButton btnSucursal;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnReservar;
        private FontAwesome.Sharp.IconButton btnSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
    }
}

