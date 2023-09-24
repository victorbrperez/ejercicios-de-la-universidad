namespace SINS
{
    partial class frmDatosProfesor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxNuevo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.gbxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tbxObservaciones = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.cbbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpkFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskTbxTelefonoCasa = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTbxTelefonoMovil = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTbxCedula = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.gbxDatosPersonales.SuspendLayout();
            this.gbxSexo.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(657, 53);
            this.panel1.TabIndex = 4;
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
            this.btnGuardar.Location = new System.Drawing.Point(456, 10);
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
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Image = global::SINS.Properties.Resources.close16;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(561, 10);
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
            this.pbxNuevo.Image = global::SINS.Properties.Resources.student32;
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
            this.lblTitulo.Location = new System.Drawing.Point(48, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.gbxDatosPersonales);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 53);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDatos.Size = new System.Drawing.Size(657, 369);
            this.pnlDatos.TabIndex = 5;
            // 
            // gbxDatosPersonales
            // 
            this.gbxDatosPersonales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxDatosPersonales.Controls.Add(this.tbxObservaciones);
            this.gbxDatosPersonales.Controls.Add(this.label17);
            this.gbxDatosPersonales.Controls.Add(this.tbxId);
            this.gbxDatosPersonales.Controls.Add(this.label4);
            this.gbxDatosPersonales.Controls.Add(this.gbxSexo);
            this.gbxDatosPersonales.Controls.Add(this.cbbEstadoCivil);
            this.gbxDatosPersonales.Controls.Add(this.label10);
            this.gbxDatosPersonales.Controls.Add(this.dtpkFechaNacimiento);
            this.gbxDatosPersonales.Controls.Add(this.label9);
            this.gbxDatosPersonales.Controls.Add(this.tbxCorreo);
            this.gbxDatosPersonales.Controls.Add(this.label8);
            this.gbxDatosPersonales.Controls.Add(this.tbxDireccion);
            this.gbxDatosPersonales.Controls.Add(this.label7);
            this.gbxDatosPersonales.Controls.Add(this.mskTbxTelefonoCasa);
            this.gbxDatosPersonales.Controls.Add(this.label6);
            this.gbxDatosPersonales.Controls.Add(this.mskTbxTelefonoMovil);
            this.gbxDatosPersonales.Controls.Add(this.label5);
            this.gbxDatosPersonales.Controls.Add(this.mskTbxCedula);
            this.gbxDatosPersonales.Controls.Add(this.label3);
            this.gbxDatosPersonales.Controls.Add(this.tbxApellidos);
            this.gbxDatosPersonales.Controls.Add(this.label1);
            this.gbxDatosPersonales.Controls.Add(this.tbxNombre);
            this.gbxDatosPersonales.Controls.Add(this.label2);
            this.gbxDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDatosPersonales.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosPersonales.Location = new System.Drawing.Point(10, 10);
            this.gbxDatosPersonales.Name = "gbxDatosPersonales";
            this.gbxDatosPersonales.Size = new System.Drawing.Size(637, 349);
            this.gbxDatosPersonales.TabIndex = 7;
            this.gbxDatosPersonales.TabStop = false;
            this.gbxDatosPersonales.Text = "Datos del profesor";
            // 
            // tbxObservaciones
            // 
            this.tbxObservaciones.BackColor = System.Drawing.Color.White;
            this.tbxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxObservaciones.Location = new System.Drawing.Point(288, 234);
            this.tbxObservaciones.MaxLength = 256;
            this.tbxObservaciones.Multiline = true;
            this.tbxObservaciones.Name = "tbxObservaciones";
            this.tbxObservaciones.Size = new System.Drawing.Size(293, 92);
            this.tbxObservaciones.TabIndex = 41;
            this.tbxObservaciones.Tag = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(285, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 14);
            this.label17.TabIndex = 42;
            this.label17.Text = "Observaciones:";
            // 
            // tbxId
            // 
            this.tbxId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId.Location = new System.Drawing.Point(20, 37);
            this.tbxId.MaxLength = 50;
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(208, 22);
            this.tbxId.TabIndex = 39;
            this.tbxId.Tag = "";
            this.tbxId.Text = "N.I.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "Id";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMujer);
            this.gbxSexo.Controls.Add(this.rbtnHombre);
            this.gbxSexo.Location = new System.Drawing.Point(20, 193);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(208, 45);
            this.gbxSexo.TabIndex = 4;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMujer.Location = new System.Drawing.Point(83, 21);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(52, 17);
            this.rbtnMujer.TabIndex = 2;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            this.rbtnMujer.CheckedChanged += new System.EventHandler(this.rbtnMujer_CheckedChanged);
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHombre.Location = new System.Drawing.Point(6, 21);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnHombre.TabIndex = 4;
            this.rbtnHombre.Text = "Hombre";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            this.rbtnHombre.CheckedChanged += new System.EventHandler(this.rbtnHombre_CheckedChanged);
            // 
            // cbbEstadoCivil
            // 
            this.cbbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstadoCivil.FormattingEnabled = true;
            this.cbbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.cbbEstadoCivil.Location = new System.Drawing.Point(288, 190);
            this.cbbEstadoCivil.Name = "cbbEstadoCivil";
            this.cbbEstadoCivil.Size = new System.Drawing.Size(208, 22);
            this.cbbEstadoCivil.TabIndex = 10;
            this.cbbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.cbbEstadoCivil_SelectedIndexChanged);
            this.cbbEstadoCivil.TextChanged += new System.EventHandler(this.cbbEstadoCivil_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 35;
            this.label10.Text = "Estado civil:";
            // 
            // dtpkFechaNacimiento
            // 
            this.dtpkFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFechaNacimiento.Location = new System.Drawing.Point(288, 148);
            this.dtpkFechaNacimiento.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.dtpkFechaNacimiento.Name = "dtpkFechaNacimiento";
            this.dtpkFechaNacimiento.Size = new System.Drawing.Size(208, 22);
            this.dtpkFechaNacimiento.TabIndex = 9;
            this.dtpkFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpkFechaNacimiento_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 14);
            this.label9.TabIndex = 33;
            this.label9.Text = "Fecha de nacimiento:";
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.BackColor = System.Drawing.Color.White;
            this.tbxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCorreo.Location = new System.Drawing.Point(288, 105);
            this.tbxCorreo.MaxLength = 80;
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(293, 22);
            this.tbxCorreo.TabIndex = 8;
            this.tbxCorreo.Tag = "";
            this.tbxCorreo.TextChanged += new System.EventHandler(this.tbxCorreo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 14);
            this.label8.TabIndex = 31;
            this.label8.Text = "Correo electrónico:";
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.BackColor = System.Drawing.Color.White;
            this.tbxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDireccion.Location = new System.Drawing.Point(288, 37);
            this.tbxDireccion.MaxLength = 80;
            this.tbxDireccion.Multiline = true;
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(293, 46);
            this.tbxDireccion.TabIndex = 7;
            this.tbxDireccion.Tag = "";
            this.tbxDireccion.TextChanged += new System.EventHandler(this.tbxDireccion_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 14);
            this.label7.TabIndex = 29;
            this.label7.Text = "Dirección:";
            // 
            // mskTbxTelefonoCasa
            // 
            this.mskTbxTelefonoCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTbxTelefonoCasa.Location = new System.Drawing.Point(20, 302);
            this.mskTbxTelefonoCasa.Mask = "(999)000-0000";
            this.mskTbxTelefonoCasa.Name = "mskTbxTelefonoCasa";
            this.mskTbxTelefonoCasa.Size = new System.Drawing.Size(208, 22);
            this.mskTbxTelefonoCasa.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 14);
            this.label6.TabIndex = 26;
            this.label6.Text = "Telefono casa:";
            // 
            // mskTbxTelefonoMovil
            // 
            this.mskTbxTelefonoMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTbxTelefonoMovil.Location = new System.Drawing.Point(20, 259);
            this.mskTbxTelefonoMovil.Mask = "(999)000-0000";
            this.mskTbxTelefonoMovil.Name = "mskTbxTelefonoMovil";
            this.mskTbxTelefonoMovil.Size = new System.Drawing.Size(208, 22);
            this.mskTbxTelefonoMovil.TabIndex = 5;
            this.mskTbxTelefonoMovil.TextAlignChanged += new System.EventHandler(this.mskTbxTelefonoMovil_TextAlignChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefono movil:";
            // 
            // mskTbxCedula
            // 
            this.mskTbxCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTbxCedula.Location = new System.Drawing.Point(20, 165);
            this.mskTbxCedula.Mask = "000-0000000-0";
            this.mskTbxCedula.Name = "mskTbxCedula";
            this.mskTbxCedula.Size = new System.Drawing.Size(208, 22);
            this.mskTbxCedula.TabIndex = 3;
            this.mskTbxCedula.Tag = "*";
            this.mskTbxCedula.TextChanged += new System.EventHandler(this.mskTbxCedula_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cedula";
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.BackColor = System.Drawing.Color.White;
            this.tbxApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxApellidos.Location = new System.Drawing.Point(20, 123);
            this.tbxApellidos.MaxLength = 80;
            this.tbxApellidos.Name = "tbxApellidos";
            this.tbxApellidos.Size = new System.Drawing.Size(208, 22);
            this.tbxApellidos.TabIndex = 2;
            this.tbxApellidos.Tag = "";
            this.tbxApellidos.TextChanged += new System.EventHandler(this.tbxApellidos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Apellidos:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.White;
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombre.Location = new System.Drawing.Point(20, 81);
            this.tbxNombre.MaxLength = 50;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(208, 22);
            this.tbxNombre.TabIndex = 1;
            this.tbxNombre.Tag = "*";
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // frmDatosProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 422);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(673, 461);
            this.Name = "frmDatosProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProfesor_FormClosing);
            this.Load += new System.EventHandler(this.frmProfesor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.gbxDatosPersonales.ResumeLayout(false);
            this.gbxDatosPersonales.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxDatosPersonales;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.ComboBox cbbEstadoCivil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpkFechaNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTbxTelefonoCasa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTbxTelefonoMovil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTbxCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxObservaciones;
        private System.Windows.Forms.Label label17;
    }
}