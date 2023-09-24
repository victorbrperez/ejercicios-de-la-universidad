namespace SINS
{
    partial class frmBuscarProfesor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlControlPrincipal = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbxBusqueda = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.chkCedula = new System.Windows.Forms.CheckBox();
            this.chkApellidos = new System.Windows.Forms.CheckBox();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxTotalElementos = new System.Windows.Forms.TextBox();
            this.lblCantidadElementos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControlPrincipal.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControlPrincipal
            // 
            this.pnlControlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pnlControlPrincipal.Controls.Add(this.btnClean);
            this.pnlControlPrincipal.Controls.Add(this.btnEditar);
            this.pnlControlPrincipal.Controls.Add(this.btnNuevo);
            this.pnlControlPrincipal.Controls.Add(this.btnCerrar);
            this.pnlControlPrincipal.Controls.Add(this.btnFiltro);
            this.pnlControlPrincipal.Controls.Add(this.btnBuscar);
            this.pnlControlPrincipal.Controls.Add(this.tbxBusqueda);
            this.pnlControlPrincipal.Controls.Add(this.btnEnviar);
            this.pnlControlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlControlPrincipal.Name = "pnlControlPrincipal";
            this.pnlControlPrincipal.Size = new System.Drawing.Size(784, 53);
            this.pnlControlPrincipal.TabIndex = 2;
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClean.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Image = global::SINS.Properties.Resources.clean_text16;
            this.btnClean.Location = new System.Drawing.Point(241, 13);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(31, 23);
            this.btnClean.TabIndex = 19;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = global::SINS.Properties.Resources.edit24;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(547, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 32);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = global::SINS.Properties.Resources.add24;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(461, 10);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(78, 32);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Image = global::SINS.Properties.Resources.close16;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(698, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(73, 32);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnFiltro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ForeColor = System.Drawing.Color.Black;
            this.btnFiltro.Image = global::SINS.Properties.Resources.filter24;
            this.btnFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltro.Location = new System.Drawing.Point(377, 10);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(78, 32);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::SINS.Properties.Resources.search241;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(285, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 32);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbxBusqueda
            // 
            this.tbxBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBusqueda.Location = new System.Drawing.Point(12, 12);
            this.tbxBusqueda.Name = "tbxBusqueda";
            this.tbxBusqueda.Size = new System.Drawing.Size(262, 31);
            this.tbxBusqueda.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Image = global::SINS.Properties.Resources.send24;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(688, 10);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(83, 32);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pnlFiltro.Controls.Add(this.gbxFilter);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 53);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(784, 78);
            this.pnlFiltro.TabIndex = 8;
            this.pnlFiltro.Visible = false;
            // 
            // gbxFilter
            // 
            this.gbxFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gbxFilter.Controls.Add(this.chkCedula);
            this.gbxFilter.Controls.Add(this.chkApellidos);
            this.gbxFilter.Controls.Add(this.chkNombre);
            this.gbxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFilter.Location = new System.Drawing.Point(0, 0);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(784, 78);
            this.gbxFilter.TabIndex = 7;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filtros disponibles";
            // 
            // chkCedula
            // 
            this.chkCedula.AutoSize = true;
            this.chkCedula.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.chkCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCedula.Location = new System.Drawing.Point(184, 34);
            this.chkCedula.Name = "chkCedula";
            this.chkCedula.Size = new System.Drawing.Size(67, 20);
            this.chkCedula.TabIndex = 8;
            this.chkCedula.Tag = "Cedula";
            this.chkCedula.Text = "Cedula";
            this.chkCedula.UseVisualStyleBackColor = true;
            // 
            // chkApellidos
            // 
            this.chkApellidos.AutoSize = true;
            this.chkApellidos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.chkApellidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApellidos.Location = new System.Drawing.Point(94, 34);
            this.chkApellidos.Name = "chkApellidos";
            this.chkApellidos.Size = new System.Drawing.Size(81, 20);
            this.chkApellidos.TabIndex = 7;
            this.chkApellidos.Tag = "Apellidos";
            this.chkApellidos.Text = "Apellidos";
            this.chkApellidos.UseVisualStyleBackColor = true;
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkNombre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.chkNombre.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.chkNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNombre.Location = new System.Drawing.Point(12, 34);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(73, 20);
            this.chkNombre.TabIndex = 6;
            this.chkNombre.Tag = "Nombre";
            this.chkNombre.Text = "Nombre";
            this.chkNombre.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.tbxTotalElementos);
            this.panel3.Controls.Add(this.lblCantidadElementos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 32);
            this.panel3.TabIndex = 13;
            // 
            // tbxTotalElementos
            // 
            this.tbxTotalElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTotalElementos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxTotalElementos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTotalElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalElementos.Location = new System.Drawing.Point(677, 5);
            this.tbxTotalElementos.Name = "tbxTotalElementos";
            this.tbxTotalElementos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxTotalElementos.Size = new System.Drawing.Size(100, 22);
            this.tbxTotalElementos.TabIndex = 1;
            // 
            // lblCantidadElementos
            // 
            this.lblCantidadElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadElementos.AutoSize = true;
            this.lblCantidadElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadElementos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCantidadElementos.Location = new System.Drawing.Point(625, 8);
            this.lblCantidadElementos.Name = "lblCantidadElementos";
            this.lblCantidadElementos.Size = new System.Drawing.Size(48, 16);
            this.lblCantidadElementos.TabIndex = 0;
            this.lblCantidadElementos.Text = "Total:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProfesores);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 238);
            this.panel2.TabIndex = 14;
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.AllowUserToAddRows = false;
            this.dgvProfesores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProfesores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfesores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProfesores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfesores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accion,
            this.Id,
            this.Nombre,
            this.Apellidos,
            this.Cedula});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfesores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfesores.Location = new System.Drawing.Point(0, 0);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.ReadOnly = true;
            this.dgvProfesores.RowHeadersWidth = 20;
            this.dgvProfesores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesores.ShowEditingIcon = false;
            this.dgvProfesores.Size = new System.Drawing.Size(784, 238);
            this.dgvProfesores.TabIndex = 10;
            this.dgvProfesores.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProfesores_RowsAdded);
            // 
            // accion
            // 
            this.accion.FillWeight = 47.7107F;
            this.accion.HeaderText = "Acción";
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.FillWeight = 77.42525F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 114.9382F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.FillWeight = 114.9382F;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.FillWeight = 114.9382F;
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // frmBuscarProfesor
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnlControlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuscarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.frmBuscarProfesor_Load);
            this.pnlControlPrincipal.ResumeLayout(false);
            this.pnlControlPrincipal.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControlPrincipal;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbxBusqueda;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.CheckBox chkCedula;
        private System.Windows.Forms.CheckBox chkApellidos;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxTotalElementos;
        private System.Windows.Forms.Label lblCantidadElementos;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.DataGridViewButtonColumn accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
    }
}