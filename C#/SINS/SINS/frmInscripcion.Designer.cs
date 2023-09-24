namespace SINS
{
    partial class frmInscripcion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxNuevo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAreaDeTrabajo = new System.Windows.Forms.Panel();
            this.pnlMaterias = new System.Windows.Forms.Panel();
            this.gbxMaterias = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminarAsignatura = new System.Windows.Forms.Button();
            this.btnSeleccionarHorario = new System.Windows.Forms.Button();
            this.pnlListadoAsignaturas = new System.Windows.Forms.Panel();
            this.dgvSeleccion = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEstudiante = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).BeginInit();
            this.pnlAreaDeTrabajo.SuspendLayout();
            this.pnlMaterias.SuspendLayout();
            this.gbxMaterias.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlListadoAsignaturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).BeginInit();
            this.pnlEstudiante.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(784, 53);
            this.panel1.TabIndex = 3;
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
            this.btnGuardar.Location = new System.Drawing.Point(573, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 32);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Image = global::SINS.Properties.Resources.close16;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(681, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 32);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = " Cerrrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxNuevo
            // 
            this.pbxNuevo.Image = global::SINS.Properties.Resources.listwindow32;
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
            this.lblTitulo.Location = new System.Drawing.Point(50, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // pnlAreaDeTrabajo
            // 
            this.pnlAreaDeTrabajo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAreaDeTrabajo.Controls.Add(this.pnlMaterias);
            this.pnlAreaDeTrabajo.Controls.Add(this.pnlEstudiante);
            this.pnlAreaDeTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAreaDeTrabajo.Location = new System.Drawing.Point(0, 53);
            this.pnlAreaDeTrabajo.Name = "pnlAreaDeTrabajo";
            this.pnlAreaDeTrabajo.Size = new System.Drawing.Size(784, 408);
            this.pnlAreaDeTrabajo.TabIndex = 4;
            // 
            // pnlMaterias
            // 
            this.pnlMaterias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMaterias.Controls.Add(this.gbxMaterias);
            this.pnlMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMaterias.Location = new System.Drawing.Point(0, 155);
            this.pnlMaterias.Name = "pnlMaterias";
            this.pnlMaterias.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMaterias.Size = new System.Drawing.Size(784, 253);
            this.pnlMaterias.TabIndex = 1;
            // 
            // gbxMaterias
            // 
            this.gbxMaterias.Controls.Add(this.panel3);
            this.gbxMaterias.Controls.Add(this.pnlListadoAsignaturas);
            this.gbxMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMaterias.Location = new System.Drawing.Point(5, 5);
            this.gbxMaterias.Name = "gbxMaterias";
            this.gbxMaterias.Padding = new System.Windows.Forms.Padding(5);
            this.gbxMaterias.Size = new System.Drawing.Size(774, 243);
            this.gbxMaterias.TabIndex = 0;
            this.gbxMaterias.TabStop = false;
            this.gbxMaterias.Text = "Selección de asignaturas";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminarAsignatura);
            this.panel3.Controls.Add(this.btnSeleccionarHorario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 31);
            this.panel3.TabIndex = 7;
            // 
            // btnEliminarAsignatura
            // 
            this.btnEliminarAsignatura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAsignatura.Enabled = false;
            this.btnEliminarAsignatura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnEliminarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAsignatura.Image = global::SINS.Properties.Resources.close16;
            this.btnEliminarAsignatura.Location = new System.Drawing.Point(606, 6);
            this.btnEliminarAsignatura.Name = "btnEliminarAsignatura";
            this.btnEliminarAsignatura.Size = new System.Drawing.Size(72, 22);
            this.btnEliminarAsignatura.TabIndex = 2;
            this.btnEliminarAsignatura.UseVisualStyleBackColor = true;
            this.btnEliminarAsignatura.Click += new System.EventHandler(this.btnEliminarAsignatura_Click);
            // 
            // btnSeleccionarHorario
            // 
            this.btnSeleccionarHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarHorario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnSeleccionarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarHorario.Image = global::SINS.Properties.Resources.search16;
            this.btnSeleccionarHorario.Location = new System.Drawing.Point(685, 5);
            this.btnSeleccionarHorario.Name = "btnSeleccionarHorario";
            this.btnSeleccionarHorario.Size = new System.Drawing.Size(72, 22);
            this.btnSeleccionarHorario.TabIndex = 1;
            this.btnSeleccionarHorario.UseVisualStyleBackColor = true;
            this.btnSeleccionarHorario.Click += new System.EventHandler(this.btnSeleccionarHorario_Click);
            // 
            // pnlListadoAsignaturas
            // 
            this.pnlListadoAsignaturas.Controls.Add(this.dgvSeleccion);
            this.pnlListadoAsignaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListadoAsignaturas.Location = new System.Drawing.Point(5, 20);
            this.pnlListadoAsignaturas.Name = "pnlListadoAsignaturas";
            this.pnlListadoAsignaturas.Size = new System.Drawing.Size(764, 218);
            this.pnlListadoAsignaturas.TabIndex = 0;
            // 
            // dgvSeleccion
            // 
            this.dgvSeleccion.AllowUserToAddRows = false;
            this.dgvSeleccion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSeleccion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSeleccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeleccion.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSeleccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeleccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre,
            this.Seccion,
            this.Creditos,
            this.Accion,
            this.IdSeccion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeleccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSeleccion.Location = new System.Drawing.Point(0, 0);
            this.dgvSeleccion.Name = "dgvSeleccion";
            this.dgvSeleccion.ReadOnly = true;
            this.dgvSeleccion.RowHeadersWidth = 20;
            this.dgvSeleccion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSeleccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccion.ShowEditingIcon = false;
            this.dgvSeleccion.Size = new System.Drawing.Size(764, 218);
            this.dgvSeleccion.TabIndex = 4;
            this.dgvSeleccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeleccion_CellClick);
            this.dgvSeleccion.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDatos_RowsAdded);
            // 
            // Clave
            // 
            this.Clave.FillWeight = 40F;
            this.Clave.HeaderText = "Clave ";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 200F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Seccion
            // 
            this.Seccion.FillWeight = 35F;
            this.Seccion.HeaderText = "Sección";
            this.Seccion.Name = "Seccion";
            this.Seccion.ReadOnly = true;
            // 
            // Creditos
            // 
            this.Creditos.FillWeight = 35F;
            this.Creditos.HeaderText = "Creditos";
            this.Creditos.Name = "Creditos";
            this.Creditos.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.FillWeight = 60F;
            this.Accion.HeaderText = "Acción";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // IdSeccion
            // 
            this.IdSeccion.HeaderText = "IdSeccion";
            this.IdSeccion.Name = "IdSeccion";
            this.IdSeccion.ReadOnly = true;
            this.IdSeccion.Visible = false;
            // 
            // pnlEstudiante
            // 
            this.pnlEstudiante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEstudiante.Controls.Add(this.groupBox1);
            this.pnlEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEstudiante.Location = new System.Drawing.Point(0, 0);
            this.pnlEstudiante.Name = "pnlEstudiante";
            this.pnlEstudiante.Padding = new System.Windows.Forms.Padding(5);
            this.pnlEstudiante.Size = new System.Drawing.Size(784, 155);
            this.pnlEstudiante.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxNombreEstudiante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbxMatricula);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiante a inscribir asignaturas";
            // 
            // tbxNombreEstudiante
            // 
            this.tbxNombreEstudiante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxNombreEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombreEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombreEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.tbxNombreEstudiante.Location = new System.Drawing.Point(15, 100);
            this.tbxNombreEstudiante.MaxLength = 50;
            this.tbxNombreEstudiante.Name = "tbxNombreEstudiante";
            this.tbxNombreEstudiante.ReadOnly = true;
            this.tbxNombreEstudiante.Size = new System.Drawing.Size(262, 22);
            this.tbxNombreEstudiante.TabIndex = 16;
            this.tbxNombreEstudiante.Tag = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Matricula:";
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
            this.btnBuscar.Location = new System.Drawing.Point(288, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 32);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.tbxMatricula.Location = new System.Drawing.Point(15, 47);
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.ReadOnly = true;
            this.tbxMatricula.Size = new System.Drawing.Size(262, 31);
            this.tbxMatricula.TabIndex = 3;
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlAreaDeTrabajo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripción";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).EndInit();
            this.pnlAreaDeTrabajo.ResumeLayout(false);
            this.pnlMaterias.ResumeLayout(false);
            this.gbxMaterias.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlListadoAsignaturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).EndInit();
            this.pnlEstudiante.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAreaDeTrabajo;
        private System.Windows.Forms.Panel pnlEstudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbxMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNombreEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMaterias;
        private System.Windows.Forms.GroupBox gbxMaterias;
        private System.Windows.Forms.Panel pnlListadoAsignaturas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminarAsignatura;
        private System.Windows.Forms.Button btnSeleccionarHorario;
        private System.Windows.Forms.DataGridView dgvSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSeccion;
    }
}