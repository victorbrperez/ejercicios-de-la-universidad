namespace Sistema_de_Inventario_SC
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.manualBtn = new System.Windows.Forms.Button();
            this.opcionesBtn = new System.Windows.Forms.Button();
            this.consultarInventarioBtn = new System.Windows.Forms.Button();
            this.actualizarInventarioBtn = new System.Windows.Forms.Button();
            this.nuevoProductoBtn = new System.Windows.Forms.Button();
            this.logPanel = new System.Windows.Forms.Panel();
            this.loginIdPanel = new System.Windows.Forms.Panel();
            this.accederBtn = new System.Windows.Forms.Button();
            this.usuarioLb = new System.Windows.Forms.Label();
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.usuarioTbx = new System.Windows.Forms.MaskedTextBox();
            this.passwordLb = new System.Windows.Forms.Label();
            this.regUsuarioPanel = new System.Windows.Forms.Panel();
            this.registrarBtn = new System.Windows.Forms.Button();
            this.nPasswordTb = new System.Windows.Forms.TextBox();
            this.nPasswordLb = new System.Windows.Forms.Label();
            this.nTelefonoTb = new System.Windows.Forms.TextBox();
            this.nTelefonoLb = new System.Windows.Forms.Label();
            this.nNombreTb = new System.Windows.Forms.TextBox();
            this.nNombreLb = new System.Windows.Forms.Label();
            this.UsuarioIdLb = new System.Windows.Forms.Label();
            this.UsuarioIdMskTb = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.estadoLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUnProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosEnBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            this.logPanel.SuspendLayout();
            this.loginIdPanel.SuspendLayout();
            this.regUsuarioPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.manualBtn);
            this.mainPanel.Controls.Add(this.opcionesBtn);
            this.mainPanel.Controls.Add(this.consultarInventarioBtn);
            this.mainPanel.Controls.Add(this.actualizarInventarioBtn);
            this.mainPanel.Controls.Add(this.nuevoProductoBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(891, 537);
            this.mainPanel.TabIndex = 2;
            // 
            // manualBtn
            // 
            this.manualBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.manualBtn.BackColor = System.Drawing.Color.White;
            this.manualBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.manualBtn.FlatAppearance.BorderSize = 0;
            this.manualBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.manualBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualBtn.Image = ((System.Drawing.Image)(resources.GetObject("manualBtn.Image")));
            this.manualBtn.Location = new System.Drawing.Point(337, 295);
            this.manualBtn.Name = "manualBtn";
            this.manualBtn.Size = new System.Drawing.Size(212, 130);
            this.manualBtn.TabIndex = 6;
            this.manualBtn.UseVisualStyleBackColor = false;
            this.manualBtn.Click += new System.EventHandler(this.manualBtn_Click);
            // 
            // opcionesBtn
            // 
            this.opcionesBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.opcionesBtn.BackColor = System.Drawing.Color.White;
            this.opcionesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.opcionesBtn.FlatAppearance.BorderSize = 0;
            this.opcionesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.opcionesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcionesBtn.Image = ((System.Drawing.Image)(resources.GetObject("opcionesBtn.Image")));
            this.opcionesBtn.Location = new System.Drawing.Point(70, 295);
            this.opcionesBtn.Name = "opcionesBtn";
            this.opcionesBtn.Size = new System.Drawing.Size(212, 130);
            this.opcionesBtn.TabIndex = 5;
            this.opcionesBtn.UseVisualStyleBackColor = false;
            this.opcionesBtn.Click += new System.EventHandler(this.opcionesBtn_Click);
            // 
            // consultarInventarioBtn
            // 
            this.consultarInventarioBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.consultarInventarioBtn.BackColor = System.Drawing.Color.White;
            this.consultarInventarioBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.consultarInventarioBtn.FlatAppearance.BorderSize = 0;
            this.consultarInventarioBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.consultarInventarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarInventarioBtn.Image = ((System.Drawing.Image)(resources.GetObject("consultarInventarioBtn.Image")));
            this.consultarInventarioBtn.Location = new System.Drawing.Point(600, 106);
            this.consultarInventarioBtn.Name = "consultarInventarioBtn";
            this.consultarInventarioBtn.Size = new System.Drawing.Size(212, 130);
            this.consultarInventarioBtn.TabIndex = 4;
            this.consultarInventarioBtn.UseVisualStyleBackColor = false;
            this.consultarInventarioBtn.Click += new System.EventHandler(this.consultarInventarioBtn_Click);
            // 
            // actualizarInventarioBtn
            // 
            this.actualizarInventarioBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.actualizarInventarioBtn.BackColor = System.Drawing.Color.White;
            this.actualizarInventarioBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.actualizarInventarioBtn.FlatAppearance.BorderSize = 0;
            this.actualizarInventarioBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.actualizarInventarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizarInventarioBtn.Image = ((System.Drawing.Image)(resources.GetObject("actualizarInventarioBtn.Image")));
            this.actualizarInventarioBtn.Location = new System.Drawing.Point(337, 106);
            this.actualizarInventarioBtn.Name = "actualizarInventarioBtn";
            this.actualizarInventarioBtn.Size = new System.Drawing.Size(212, 130);
            this.actualizarInventarioBtn.TabIndex = 3;
            this.actualizarInventarioBtn.UseVisualStyleBackColor = false;
            this.actualizarInventarioBtn.Click += new System.EventHandler(this.actualizarInventarioBtn_Click);
            // 
            // nuevoProductoBtn
            // 
            this.nuevoProductoBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nuevoProductoBtn.BackColor = System.Drawing.Color.White;
            this.nuevoProductoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nuevoProductoBtn.FlatAppearance.BorderSize = 0;
            this.nuevoProductoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.nuevoProductoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoProductoBtn.Image = ((System.Drawing.Image)(resources.GetObject("nuevoProductoBtn.Image")));
            this.nuevoProductoBtn.Location = new System.Drawing.Point(70, 106);
            this.nuevoProductoBtn.Name = "nuevoProductoBtn";
            this.nuevoProductoBtn.Size = new System.Drawing.Size(212, 130);
            this.nuevoProductoBtn.TabIndex = 2;
            this.nuevoProductoBtn.UseVisualStyleBackColor = false;
            this.nuevoProductoBtn.Click += new System.EventHandler(this.nuevoProductoBtn_Click);
            // 
            // logPanel
            // 
            this.logPanel.BackColor = System.Drawing.Color.White;
            this.logPanel.Controls.Add(this.loginIdPanel);
            this.logPanel.Controls.Add(this.regUsuarioPanel);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPanel.Location = new System.Drawing.Point(0, 0);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(891, 537);
            this.logPanel.TabIndex = 3;
            this.logPanel.Click += new System.EventHandler(this.logPanel_Click);
            // 
            // loginIdPanel
            // 
            this.loginIdPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginIdPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.loginIdPanel.Controls.Add(this.accederBtn);
            this.loginIdPanel.Controls.Add(this.usuarioLb);
            this.loginIdPanel.Controls.Add(this.passwordTbx);
            this.loginIdPanel.Controls.Add(this.usuarioTbx);
            this.loginIdPanel.Controls.Add(this.passwordLb);
            this.loginIdPanel.Location = new System.Drawing.Point(520, 63);
            this.loginIdPanel.Name = "loginIdPanel";
            this.loginIdPanel.Size = new System.Drawing.Size(349, 221);
            this.loginIdPanel.TabIndex = 4;
            // 
            // accederBtn
            // 
            this.accederBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.accederBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.accederBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(61)))));
            this.accederBtn.FlatAppearance.BorderSize = 0;
            this.accederBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(1)))));
            this.accederBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accederBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accederBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.accederBtn.Location = new System.Drawing.Point(172, 143);
            this.accederBtn.Name = "accederBtn";
            this.accederBtn.Size = new System.Drawing.Size(130, 46);
            this.accederBtn.TabIndex = 3;
            this.accederBtn.Text = "Acceder";
            this.accederBtn.UseVisualStyleBackColor = false;
            this.accederBtn.Click += new System.EventHandler(this.accederBtn_Click);
            // 
            // usuarioLb
            // 
            this.usuarioLb.AutoSize = true;
            this.usuarioLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.usuarioLb.Location = new System.Drawing.Point(34, 38);
            this.usuarioLb.Name = "usuarioLb";
            this.usuarioLb.Size = new System.Drawing.Size(96, 24);
            this.usuarioLb.TabIndex = 0;
            this.usuarioLb.Text = "ID Usuario";
            // 
            // passwordTbx
            // 
            this.passwordTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.passwordTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTbx.Location = new System.Drawing.Point(146, 95);
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.Size = new System.Drawing.Size(156, 29);
            this.passwordTbx.TabIndex = 2;
            this.passwordTbx.UseSystemPasswordChar = true;
            this.passwordTbx.TextChanged += new System.EventHandler(this.passwordTbx_TextChanged);
            // 
            // usuarioTbx
            // 
            this.usuarioTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.usuarioTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuarioTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTbx.ForeColor = System.Drawing.Color.Black;
            this.usuarioTbx.Location = new System.Drawing.Point(146, 38);
            this.usuarioTbx.Mask = "99999";
            this.usuarioTbx.Name = "usuarioTbx";
            this.usuarioTbx.Size = new System.Drawing.Size(156, 29);
            this.usuarioTbx.TabIndex = 1;
            this.usuarioTbx.ValidatingType = typeof(int);
            this.usuarioTbx.TextChanged += new System.EventHandler(this.usuarioTbx_TextChanged);
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.passwordLb.Location = new System.Drawing.Point(34, 95);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(106, 24);
            this.passwordLb.TabIndex = 1;
            this.passwordLb.Text = "Contraseña";
            // 
            // regUsuarioPanel
            // 
            this.regUsuarioPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regUsuarioPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.regUsuarioPanel.Controls.Add(this.registrarBtn);
            this.regUsuarioPanel.Controls.Add(this.nPasswordTb);
            this.regUsuarioPanel.Controls.Add(this.nPasswordLb);
            this.regUsuarioPanel.Controls.Add(this.nTelefonoTb);
            this.regUsuarioPanel.Controls.Add(this.nTelefonoLb);
            this.regUsuarioPanel.Controls.Add(this.nNombreTb);
            this.regUsuarioPanel.Controls.Add(this.nNombreLb);
            this.regUsuarioPanel.Controls.Add(this.UsuarioIdLb);
            this.regUsuarioPanel.Controls.Add(this.UsuarioIdMskTb);
            this.regUsuarioPanel.Location = new System.Drawing.Point(466, 62);
            this.regUsuarioPanel.Name = "regUsuarioPanel";
            this.regUsuarioPanel.Size = new System.Drawing.Size(404, 365);
            this.regUsuarioPanel.TabIndex = 5;
            this.regUsuarioPanel.Visible = false;
            // 
            // registrarBtn
            // 
            this.registrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registrarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.registrarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(61)))));
            this.registrarBtn.FlatAppearance.BorderSize = 0;
            this.registrarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(1)))));
            this.registrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.registrarBtn.Location = new System.Drawing.Point(224, 283);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(130, 46);
            this.registrarBtn.TabIndex = 31;
            this.registrarBtn.Text = "Registrar";
            this.registrarBtn.UseVisualStyleBackColor = false;
            this.registrarBtn.Click += new System.EventHandler(this.RegistrarBtn_Click);
            // 
            // nPasswordTb
            // 
            this.nPasswordTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.nPasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nPasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPasswordTb.Location = new System.Drawing.Point(179, 98);
            this.nPasswordTb.Name = "nPasswordTb";
            this.nPasswordTb.Size = new System.Drawing.Size(175, 35);
            this.nPasswordTb.TabIndex = 25;
            this.nPasswordTb.UseSystemPasswordChar = true;
            this.nPasswordTb.TextChanged += new System.EventHandler(this.nPasswordTb_TextChanged);
            // 
            // nPasswordLb
            // 
            this.nPasswordLb.AutoSize = true;
            this.nPasswordLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPasswordLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.nPasswordLb.Location = new System.Drawing.Point(36, 100);
            this.nPasswordLb.Name = "nPasswordLb";
            this.nPasswordLb.Size = new System.Drawing.Size(124, 26);
            this.nPasswordLb.TabIndex = 30;
            this.nPasswordLb.Text = "Contraseña";
            // 
            // nTelefonoTb
            // 
            this.nTelefonoTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.nTelefonoTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nTelefonoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTelefonoTb.Location = new System.Drawing.Point(179, 221);
            this.nTelefonoTb.Name = "nTelefonoTb";
            this.nTelefonoTb.Size = new System.Drawing.Size(175, 35);
            this.nTelefonoTb.TabIndex = 27;
            this.nTelefonoTb.TextChanged += new System.EventHandler(this.nTelefonoTb_TextChanged);
            // 
            // nTelefonoLb
            // 
            this.nTelefonoLb.AutoSize = true;
            this.nTelefonoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTelefonoLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.nTelefonoLb.Location = new System.Drawing.Point(36, 223);
            this.nTelefonoLb.Name = "nTelefonoLb";
            this.nTelefonoLb.Size = new System.Drawing.Size(95, 26);
            this.nTelefonoLb.TabIndex = 29;
            this.nTelefonoLb.Text = "Telefono";
            // 
            // nNombreTb
            // 
            this.nNombreTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.nNombreTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nNombreTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNombreTb.Location = new System.Drawing.Point(179, 158);
            this.nNombreTb.Name = "nNombreTb";
            this.nNombreTb.Size = new System.Drawing.Size(175, 35);
            this.nNombreTb.TabIndex = 26;
            this.nNombreTb.TextChanged += new System.EventHandler(this.nNombreTb_TextChanged);
            // 
            // nNombreLb
            // 
            this.nNombreLb.AutoSize = true;
            this.nNombreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNombreLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.nNombreLb.Location = new System.Drawing.Point(36, 160);
            this.nNombreLb.Name = "nNombreLb";
            this.nNombreLb.Size = new System.Drawing.Size(90, 26);
            this.nNombreLb.TabIndex = 28;
            this.nNombreLb.Text = "Nombre";
            // 
            // UsuarioIdLb
            // 
            this.UsuarioIdLb.AutoSize = true;
            this.UsuarioIdLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioIdLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.UsuarioIdLb.Location = new System.Drawing.Point(36, 36);
            this.UsuarioIdLb.Name = "UsuarioIdLb";
            this.UsuarioIdLb.Size = new System.Drawing.Size(115, 26);
            this.UsuarioIdLb.TabIndex = 2;
            this.UsuarioIdLb.Text = "ID Usuario";
            // 
            // UsuarioIdMskTb
            // 
            this.UsuarioIdMskTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.UsuarioIdMskTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuarioIdMskTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioIdMskTb.Location = new System.Drawing.Point(179, 36);
            this.UsuarioIdMskTb.Mask = "99999";
            this.UsuarioIdMskTb.Name = "UsuarioIdMskTb";
            this.UsuarioIdMskTb.Size = new System.Drawing.Size(175, 29);
            this.UsuarioIdMskTb.TabIndex = 3;
            this.UsuarioIdMskTb.ValidatingType = typeof(int);
            this.UsuarioIdMskTb.TextChanged += new System.EventHandler(this.UsuarioIdMskTb_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoLb});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(891, 30);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // estadoLb
            // 
            this.estadoLb.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.estadoLb.ForeColor = System.Drawing.Color.Red;
            this.estadoLb.Name = "estadoLb";
            this.estadoLb.Size = new System.Drawing.Size(229, 25);
            this.estadoLb.Text = "Aún no ha iniciado sesión";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.menuPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPrincipal.BackgroundImage")));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.datosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(891, 40);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSecciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cerrarSecciónToolStripMenuItem
            // 
            this.cerrarSecciónToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.cerrarSecciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSecciónToolStripMenuItem.Image")));
            this.cerrarSecciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cerrarSecciónToolStripMenuItem.Name = "cerrarSecciónToolStripMenuItem";
            this.cerrarSecciónToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.cerrarSecciónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSecciónToolStripMenuItem.Visible = false;
            this.cerrarSecciónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSecciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProductosToolStripMenuItem,
            this.actualizarInventarioToolStripMenuItem,
            this.consultarInventarioToolStripMenuItem});
            this.inventarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(134, 36);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Visible = false;
            // 
            // registrarProductosToolStripMenuItem
            // 
            this.registrarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarProductosToolStripMenuItem.Image")));
            this.registrarProductosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registrarProductosToolStripMenuItem.Name = "registrarProductosToolStripMenuItem";
            this.registrarProductosToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.registrarProductosToolStripMenuItem.Text = "Nuevo producto";
            this.registrarProductosToolStripMenuItem.Click += new System.EventHandler(this.registrarProductosToolStripMenuItem_Click);
            // 
            // actualizarInventarioToolStripMenuItem
            // 
            this.actualizarInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.devolucionesDeVentasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.devolucionesDeComprasToolStripMenuItem});
            this.actualizarInventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarInventarioToolStripMenuItem.Image")));
            this.actualizarInventarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.actualizarInventarioToolStripMenuItem.Name = "actualizarInventarioToolStripMenuItem";
            this.actualizarInventarioToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.actualizarInventarioToolStripMenuItem.Text = "Actualizar inventario";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasToolStripMenuItem.Image")));
            this.ventasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(377, 36);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comprasToolStripMenuItem.Image")));
            this.comprasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(377, 36);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // devolucionesDeComprasToolStripMenuItem
            // 
            this.devolucionesDeComprasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("devolucionesDeComprasToolStripMenuItem.Image")));
            this.devolucionesDeComprasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.devolucionesDeComprasToolStripMenuItem.Name = "devolucionesDeComprasToolStripMenuItem";
            this.devolucionesDeComprasToolStripMenuItem.Size = new System.Drawing.Size(377, 36);
            this.devolucionesDeComprasToolStripMenuItem.Text = "Devoluciones de compras";
            this.devolucionesDeComprasToolStripMenuItem.Click += new System.EventHandler(this.devolucionesDeComprasToolStripMenuItem_Click);
            // 
            // devolucionesDeVentasToolStripMenuItem
            // 
            this.devolucionesDeVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("devolucionesDeVentasToolStripMenuItem.Image")));
            this.devolucionesDeVentasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.devolucionesDeVentasToolStripMenuItem.Name = "devolucionesDeVentasToolStripMenuItem";
            this.devolucionesDeVentasToolStripMenuItem.Size = new System.Drawing.Size(377, 36);
            this.devolucionesDeVentasToolStripMenuItem.Text = "Devoluciones de ventas";
            this.devolucionesDeVentasToolStripMenuItem.Click += new System.EventHandler(this.devolucionesDeVentasToolStripMenuItem_Click);
            // 
            // consultarInventarioToolStripMenuItem
            // 
            this.consultarInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem1,
            this.consultarUnProductoToolStripMenuItem,
            this.productosEnBajaToolStripMenuItem});
            this.consultarInventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarInventarioToolStripMenuItem.Image")));
            this.consultarInventarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultarInventarioToolStripMenuItem.Name = "consultarInventarioToolStripMenuItem";
            this.consultarInventarioToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.consultarInventarioToolStripMenuItem.Text = "Consultar inventario";
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("inventarioToolStripMenuItem1.Image")));
            this.inventarioToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(340, 36);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
            // 
            // consultarUnProductoToolStripMenuItem
            // 
            this.consultarUnProductoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarUnProductoToolStripMenuItem.Image")));
            this.consultarUnProductoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultarUnProductoToolStripMenuItem.Name = "consultarUnProductoToolStripMenuItem";
            this.consultarUnProductoToolStripMenuItem.Size = new System.Drawing.Size(340, 36);
            this.consultarUnProductoToolStripMenuItem.Text = "Productos en baja";
            this.consultarUnProductoToolStripMenuItem.Click += new System.EventHandler(this.consultarUnProductoToolStripMenuItem_Click);
            // 
            // productosEnBajaToolStripMenuItem
            // 
            this.productosEnBajaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productosEnBajaToolStripMenuItem.Image")));
            this.productosEnBajaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productosEnBajaToolStripMenuItem.Name = "productosEnBajaToolStripMenuItem";
            this.productosEnBajaToolStripMenuItem.Size = new System.Drawing.Size(340, 36);
            this.productosEnBajaToolStripMenuItem.Text = "Consultar un producto";
            this.productosEnBajaToolStripMenuItem.Click += new System.EventHandler(this.productosEnBajaToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmInventarioToolStripMenuItem,
            this.AdmUsuariosToolStripMenuItem,
            this.recursosToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.opcionesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(149, 36);
            this.opcionesToolStripMenuItem.Text = "Administrar";
            this.opcionesToolStripMenuItem.Visible = false;
            // 
            // AdmInventarioToolStripMenuItem
            // 
            this.AdmInventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AdmInventarioToolStripMenuItem.Image")));
            this.AdmInventarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AdmInventarioToolStripMenuItem.Name = "AdmInventarioToolStripMenuItem";
            this.AdmInventarioToolStripMenuItem.Size = new System.Drawing.Size(214, 36);
            this.AdmInventarioToolStripMenuItem.Text = "Inventario";
            this.AdmInventarioToolStripMenuItem.Click += new System.EventHandler(this.AdmInventarioToolStripMenuItem_Click);
            // 
            // AdmUsuariosToolStripMenuItem
            // 
            this.AdmUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AdmUsuariosToolStripMenuItem.Image")));
            this.AdmUsuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AdmUsuariosToolStripMenuItem.Name = "AdmUsuariosToolStripMenuItem";
            this.AdmUsuariosToolStripMenuItem.Size = new System.Drawing.Size(214, 36);
            this.AdmUsuariosToolStripMenuItem.Text = "Usuarios";
            this.AdmUsuariosToolStripMenuItem.Click += new System.EventHandler(this.AdmUsuariosToolStripMenuItem_Click);
            // 
            // recursosToolStripMenuItem
            // 
            this.recursosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recursosToolStripMenuItem.Image")));
            this.recursosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.recursosToolStripMenuItem.Name = "recursosToolStripMenuItem";
            this.recursosToolStripMenuItem.Size = new System.Drawing.Size(214, 36);
            this.recursosToolStripMenuItem.Text = "Recursos";
            this.recursosToolStripMenuItem.Click += new System.EventHandler(this.recursosToolStripMenuItem_Click);
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaDeSeguridadToolStripMenuItem,
            this.restaurarDatosToolStripMenuItem});
            this.datosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.datosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.datosToolStripMenuItem.Text = "Datos";
            this.datosToolStripMenuItem.Visible = false;
            // 
            // copiaDeSeguridadToolStripMenuItem
            // 
            this.copiaDeSeguridadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiaDeSeguridadToolStripMenuItem.Image")));
            this.copiaDeSeguridadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copiaDeSeguridadToolStripMenuItem.Name = "copiaDeSeguridadToolStripMenuItem";
            this.copiaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.copiaDeSeguridadToolStripMenuItem.Text = "Respaldar datos";
            this.copiaDeSeguridadToolStripMenuItem.Click += new System.EventHandler(this.copiaDeSeguridadToolStripMenuItem_Click);
            // 
            // restaurarDatosToolStripMenuItem
            // 
            this.restaurarDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restaurarDatosToolStripMenuItem.Image")));
            this.restaurarDatosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.restaurarDatosToolStripMenuItem.Name = "restaurarDatosToolStripMenuItem";
            this.restaurarDatosToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.restaurarDatosToolStripMenuItem.Text = "Restaurar datos";
            this.restaurarDatosToolStripMenuItem.Click += new System.EventHandler(this.restaurarDatosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDelSistemaToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(94, 36);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDelSistemaToolStripMenuItem
            // 
            this.manualDelSistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manualDelSistemaToolStripMenuItem.Image")));
            this.manualDelSistemaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manualDelSistemaToolStripMenuItem.Name = "manualDelSistemaToolStripMenuItem";
            this.manualDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.manualDelSistemaToolStripMenuItem.Text = "Manual del sistema";
            this.manualDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.manualDelSistemaToolStripMenuItem_Click);
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("creditosToolStripMenuItem.Image")));
            this.creditosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.creditosToolStripMenuItem.Text = "Creditos";
            this.creditosToolStripMenuItem.Click += new System.EventHandler(this.creditosToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.accederBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 537);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.logPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(907, 576);
            this.Name = "mainForm";
            this.Text = "Sistema de inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.logPanel.ResumeLayout(false);
            this.loginIdPanel.ResumeLayout(false);
            this.loginIdPanel.PerformLayout();
            this.regUsuarioPanel.ResumeLayout(false);
            this.regUsuarioPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdmInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdmUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Label usuarioLb;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.MaskedTextBox usuarioTbx;
        private System.Windows.Forms.Button accederBtn;
        private System.Windows.Forms.Panel loginIdPanel;
        private System.Windows.Forms.Panel regUsuarioPanel;
        private System.Windows.Forms.Button registrarBtn;
        private System.Windows.Forms.TextBox nPasswordTb;
        private System.Windows.Forms.Label nPasswordLb;
        private System.Windows.Forms.TextBox nTelefonoTb;
        private System.Windows.Forms.Label nTelefonoLb;
        private System.Windows.Forms.TextBox nNombreTb;
        private System.Windows.Forms.Label nNombreLb;
        private System.Windows.Forms.Label UsuarioIdLb;
        private System.Windows.Forms.MaskedTextBox UsuarioIdMskTb;
        private System.Windows.Forms.Button nuevoProductoBtn;
        private System.Windows.Forms.Button consultarInventarioBtn;
        private System.Windows.Forms.Button actualizarInventarioBtn;
        private System.Windows.Forms.Button manualBtn;
        private System.Windows.Forms.Button opcionesBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel estadoLb;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarUnProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosEnBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaDeSeguridadToolStripMenuItem;

    }
}

