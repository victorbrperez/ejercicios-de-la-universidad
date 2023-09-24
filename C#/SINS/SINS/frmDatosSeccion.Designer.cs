namespace SINS
{
    partial class frmDatosSeccion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosSeccion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxNuevo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxHorario = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Centro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lnkLbVerConflictos = new System.Windows.Forms.LinkLabel();
            this.btnEliminarHoario = new System.Windows.Forms.Button();
            this.btnSeleccionarHorario = new System.Windows.Forms.Button();
            this.tbxObservaciones = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBuscarAsignatura = new System.Windows.Forms.Button();
            this.tbxAsignatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscarProfesor = new System.Windows.Forms.Button();
            this.tbxProfesor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxHorario.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.pbxNuevo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 53);
            this.panel1.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::SINS.Properties.Resources.write24;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(452, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 32);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(557, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = " Cerrrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxNuevo
            // 
            this.pbxNuevo.Image = global::SINS.Properties.Resources.group32;
            this.pbxNuevo.InitialImage = null;
            this.pbxNuevo.Location = new System.Drawing.Point(12, 12);
            this.pbxNuevo.Name = "pbxNuevo";
            this.pbxNuevo.Size = new System.Drawing.Size(32, 32);
            this.pbxNuevo.TabIndex = 1;
            this.pbxNuevo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(48, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDatos.Controls.Add(this.gbxDatos);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDatos.Location = new System.Drawing.Point(0, 53);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDatos.Size = new System.Drawing.Size(653, 367);
            this.pnlDatos.TabIndex = 6;
            // 
            // gbxDatos
            // 
            this.gbxDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxDatos.Controls.Add(this.tbxId);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.gbxHorario);
            this.gbxDatos.Controls.Add(this.tbxObservaciones);
            this.gbxDatos.Controls.Add(this.label17);
            this.gbxDatos.Controls.Add(this.btnBuscarAsignatura);
            this.gbxDatos.Controls.Add(this.tbxAsignatura);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.Add(this.nudNumero);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.nudCapacidad);
            this.gbxDatos.Controls.Add(this.label13);
            this.gbxDatos.Controls.Add(this.btnBuscarProfesor);
            this.gbxDatos.Controls.Add(this.tbxProfesor);
            this.gbxDatos.Controls.Add(this.label16);
            this.gbxDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDatos.Location = new System.Drawing.Point(5, 5);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(643, 357);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos de la sección";
            // 
            // tbxId
            // 
            this.tbxId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId.Location = new System.Drawing.Point(12, 47);
            this.tbxId.MaxLength = 15;
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(187, 21);
            this.tbxId.TabIndex = 61;
            this.tbxId.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Id:";
            // 
            // gbxHorario
            // 
            this.gbxHorario.Controls.Add(this.panel2);
            this.gbxHorario.Location = new System.Drawing.Point(7, 172);
            this.gbxHorario.Name = "gbxHorario";
            this.gbxHorario.Padding = new System.Windows.Forms.Padding(5);
            this.gbxHorario.Size = new System.Drawing.Size(627, 171);
            this.gbxHorario.TabIndex = 5;
            this.gbxHorario.TabStop = false;
            this.gbxHorario.Text = "Horarios";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 147);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvHorarios);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(617, 116);
            this.panel4.TabIndex = 4;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.HoraInicio,
            this.HoraFin,
            this.Centro,
            this.Aula});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorarios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHorarios.Location = new System.Drawing.Point(0, 0);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.RowHeadersWidth = 20;
            this.dgvHorarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.ShowEditingIcon = false;
            this.dgvHorarios.Size = new System.Drawing.Size(617, 116);
            this.dgvHorarios.TabIndex = 4;
            this.dgvHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarios_CellContentClick);
            this.dgvHorarios.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvHorarios_RowsAdded);
            this.dgvHorarios.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvHorarios_RowsRemoved);
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora de inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora de fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            // 
            // Centro
            // 
            this.Centro.HeaderText = "Centro";
            this.Centro.Name = "Centro";
            this.Centro.ReadOnly = true;
            // 
            // Aula
            // 
            this.Aula.HeaderText = "Aula";
            this.Aula.Name = "Aula";
            this.Aula.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lnkLbVerConflictos);
            this.panel3.Controls.Add(this.btnEliminarHoario);
            this.panel3.Controls.Add(this.btnSeleccionarHorario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(617, 31);
            this.panel3.TabIndex = 6;
            // 
            // lnkLbVerConflictos
            // 
            this.lnkLbVerConflictos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLbVerConflictos.AutoSize = true;
            this.lnkLbVerConflictos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLbVerConflictos.LinkColor = System.Drawing.Color.Red;
            this.lnkLbVerConflictos.Location = new System.Drawing.Point(356, 8);
            this.lnkLbVerConflictos.Name = "lnkLbVerConflictos";
            this.lnkLbVerConflictos.Size = new System.Drawing.Size(88, 16);
            this.lnkLbVerConflictos.TabIndex = 3;
            this.lnkLbVerConflictos.TabStop = true;
            this.lnkLbVerConflictos.Text = "Ver conflictos";
            this.lnkLbVerConflictos.Visible = false;
            this.lnkLbVerConflictos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbVerConflictos_LinkClicked);
            // 
            // btnEliminarHoario
            // 
            this.btnEliminarHoario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarHoario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarHoario.Enabled = false;
            this.btnEliminarHoario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnEliminarHoario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHoario.Image = global::SINS.Properties.Resources.close16;
            this.btnEliminarHoario.Location = new System.Drawing.Point(459, 6);
            this.btnEliminarHoario.Name = "btnEliminarHoario";
            this.btnEliminarHoario.Size = new System.Drawing.Size(72, 22);
            this.btnEliminarHoario.TabIndex = 2;
            this.btnEliminarHoario.UseVisualStyleBackColor = true;
            this.btnEliminarHoario.Click += new System.EventHandler(this.btnEliminarHoario_Click);
            // 
            // btnSeleccionarHorario
            // 
            this.btnSeleccionarHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarHorario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnSeleccionarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarHorario.Image = global::SINS.Properties.Resources.select16;
            this.btnSeleccionarHorario.Location = new System.Drawing.Point(538, 5);
            this.btnSeleccionarHorario.Name = "btnSeleccionarHorario";
            this.btnSeleccionarHorario.Size = new System.Drawing.Size(72, 22);
            this.btnSeleccionarHorario.TabIndex = 1;
            this.btnSeleccionarHorario.UseVisualStyleBackColor = true;
            this.btnSeleccionarHorario.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbxObservaciones
            // 
            this.tbxObservaciones.BackColor = System.Drawing.Color.White;
            this.tbxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxObservaciones.Location = new System.Drawing.Point(266, 131);
            this.tbxObservaciones.MaxLength = 256;
            this.tbxObservaciones.Multiline = true;
            this.tbxObservaciones.Name = "tbxObservaciones";
            this.tbxObservaciones.Size = new System.Drawing.Size(270, 38);
            this.tbxObservaciones.TabIndex = 6;
            this.tbxObservaciones.Tag = "";
            this.tbxObservaciones.TextChanged += new System.EventHandler(this.tbxObservaciones_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(263, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 15);
            this.label17.TabIndex = 60;
            this.label17.Text = "Observaciones:";
            // 
            // btnBuscarAsignatura
            // 
            this.btnBuscarAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAsignatura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnBuscarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAsignatura.Image")));
            this.btnBuscarAsignatura.Location = new System.Drawing.Point(205, 125);
            this.btnBuscarAsignatura.Name = "btnBuscarAsignatura";
            this.btnBuscarAsignatura.Size = new System.Drawing.Size(30, 22);
            this.btnBuscarAsignatura.TabIndex = 4;
            this.btnBuscarAsignatura.UseVisualStyleBackColor = true;
            this.btnBuscarAsignatura.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxAsignatura
            // 
            this.tbxAsignatura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxAsignatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAsignatura.Location = new System.Drawing.Point(12, 126);
            this.tbxAsignatura.MaxLength = 75;
            this.tbxAsignatura.Name = "tbxAsignatura";
            this.tbxAsignatura.ReadOnly = true;
            this.tbxAsignatura.Size = new System.Drawing.Size(187, 21);
            this.tbxAsignatura.TabIndex = 57;
            this.tbxAsignatura.Tag = "*";
            this.tbxAsignatura.TextChanged += new System.EventHandler(this.tbxAsignatura_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Asignatura:";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(266, 47);
            this.nudNumero.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudNumero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(120, 21);
            this.nudNumero.TabIndex = 3;
            this.nudNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumero.ValueChanged += new System.EventHandler(this.nudNumero_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Número de sección:";
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(266, 90);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(120, 21);
            this.nudCapacidad.TabIndex = 2;
            this.nudCapacidad.ValueChanged += new System.EventHandler(this.nudCapacidad_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(263, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 50;
            this.label13.Text = "Capacidad";
            // 
            // btnBuscarProfesor
            // 
            this.btnBuscarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProfesor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnBuscarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProfesor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProfesor.Image")));
            this.btnBuscarProfesor.Location = new System.Drawing.Point(205, 88);
            this.btnBuscarProfesor.Name = "btnBuscarProfesor";
            this.btnBuscarProfesor.Size = new System.Drawing.Size(30, 22);
            this.btnBuscarProfesor.TabIndex = 1;
            this.btnBuscarProfesor.UseVisualStyleBackColor = true;
            this.btnBuscarProfesor.Click += new System.EventHandler(this.btnBuscarProfesor_Click);
            // 
            // tbxProfesor
            // 
            this.tbxProfesor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxProfesor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProfesor.Location = new System.Drawing.Point(12, 88);
            this.tbxProfesor.MaxLength = 75;
            this.tbxProfesor.Name = "tbxProfesor";
            this.tbxProfesor.ReadOnly = true;
            this.tbxProfesor.Size = new System.Drawing.Size(187, 21);
            this.tbxProfesor.TabIndex = 47;
            this.tbxProfesor.Tag = "*";
            this.tbxProfesor.TextChanged += new System.EventHandler(this.tbxProfesor_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 15);
            this.label16.TabIndex = 48;
            this.label16.Text = "Profesor:";
            // 
            // frmDatosSeccion
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(653, 420);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDatosSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sección";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDatosSeccion_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxHorario.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnBuscarProfesor;
        private System.Windows.Forms.TextBox tbxProfesor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBuscarAsignatura;
        private System.Windows.Forms.TextBox tbxAsignatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxObservaciones;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbxHorario;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Centro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminarHoario;
        private System.Windows.Forms.Button btnSeleccionarHorario;
        private System.Windows.Forms.LinkLabel lnkLbVerConflictos;
    }
}