namespace SINS
{
    partial class frmEstudiante
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
            this.pnlGuardarDatosEstudiante = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbxDatosCentro = new System.Windows.Forms.GroupBox();
            this.cbbTipoEstudiante = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bntBuscarCarrera = new System.Windows.Forms.Button();
            this.tbxCarrera = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBuscarCentroEducativo = new System.Windows.Forms.Button();
            this.tbxCentroEducativo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxObservaciones = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxNuevo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlGuardarDatosEstudiante.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxDatosPersonales.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbxDatosCentro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGuardarDatosEstudiante
            // 
            this.pnlGuardarDatosEstudiante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGuardarDatosEstudiante.Controls.Add(this.pnlDatos);
            this.pnlGuardarDatosEstudiante.Controls.Add(this.panel1);
            this.pnlGuardarDatosEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGuardarDatosEstudiante.Location = new System.Drawing.Point(0, 0);
            this.pnlGuardarDatosEstudiante.Name = "pnlGuardarDatosEstudiante";
            this.pnlGuardarDatosEstudiante.Size = new System.Drawing.Size(784, 432);
            this.pnlGuardarDatosEstudiante.TabIndex = 0;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.tabControl1);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 57);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(784, 375);
            this.pnlDatos.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 375);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.gbxDatosPersonales);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(776, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos  personales";
            // 
            // gbxDatosPersonales
            // 
            this.gbxDatosPersonales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxDatosPersonales.Controls.Add(this.tbxMatricula);
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
            this.gbxDatosPersonales.Size = new System.Drawing.Size(756, 327);
            this.gbxDatosPersonales.TabIndex = 6;
            this.gbxDatosPersonales.TabStop = false;
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMatricula.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMatricula.Location = new System.Drawing.Point(20, 37);
            this.tbxMatricula.MaxLength = 50;
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(208, 22);
            this.tbxMatricula.TabIndex = 39;
            this.tbxMatricula.Tag = "";
            this.tbxMatricula.Text = "N.I.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "Matricula";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMujer);
            this.gbxSexo.Controls.Add(this.rbtnHombre);
            this.gbxSexo.Location = new System.Drawing.Point(20, 208);
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
            "Solotero",
            "Casado"});
            this.cbbEstadoCivil.Location = new System.Drawing.Point(288, 248);
            this.cbbEstadoCivil.Name = "cbbEstadoCivil";
            this.cbbEstadoCivil.Size = new System.Drawing.Size(208, 22);
            this.cbbEstadoCivil.TabIndex = 10;
            this.cbbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.cbbEstadoCivil_SelectedIndexChanged);
            this.cbbEstadoCivil.TextChanged += new System.EventHandler(this.cbbEstadoCivil_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 35;
            this.label10.Text = "Estado civil:";
            // 
            // dtpkFechaNacimiento
            // 
            this.dtpkFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFechaNacimiento.Location = new System.Drawing.Point(288, 202);
            this.dtpkFechaNacimiento.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.dtpkFechaNacimiento.Name = "dtpkFechaNacimiento";
            this.dtpkFechaNacimiento.Size = new System.Drawing.Size(208, 22);
            this.dtpkFechaNacimiento.TabIndex = 9;
            this.dtpkFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpkFechaNacimiento_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 14);
            this.label9.TabIndex = 33;
            this.label9.Text = "Fecha de nacimiento:";
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.BackColor = System.Drawing.Color.White;
            this.tbxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCorreo.Location = new System.Drawing.Point(288, 155);
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
            this.label8.Location = new System.Drawing.Point(285, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 14);
            this.label8.TabIndex = 31;
            this.label8.Text = "Correo electrónico:";
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.BackColor = System.Drawing.Color.White;
            this.tbxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDireccion.Location = new System.Drawing.Point(288, 84);
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
            this.label7.Location = new System.Drawing.Point(285, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 14);
            this.label7.TabIndex = 29;
            this.label7.Text = "Dirección:";
            // 
            // mskTbxTelefonoCasa
            // 
            this.mskTbxTelefonoCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTbxTelefonoCasa.Location = new System.Drawing.Point(288, 36);
            this.mskTbxTelefonoCasa.Mask = "(999)000-0000";
            this.mskTbxTelefonoCasa.Name = "mskTbxTelefonoCasa";
            this.mskTbxTelefonoCasa.Size = new System.Drawing.Size(208, 22);
            this.mskTbxTelefonoCasa.TabIndex = 6;
            this.mskTbxTelefonoCasa.TextChanged += new System.EventHandler(this.mskTbxTelefonoCasa_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 14);
            this.label6.TabIndex = 26;
            this.label6.Text = "Telefono casa:";
            // 
            // mskTbxTelefonoMovil
            // 
            this.mskTbxTelefonoMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTbxTelefonoMovil.Location = new System.Drawing.Point(20, 278);
            this.mskTbxTelefonoMovil.Mask = "(999)000-0000";
            this.mskTbxTelefonoMovil.Name = "mskTbxTelefonoMovil";
            this.mskTbxTelefonoMovil.Size = new System.Drawing.Size(208, 22);
            this.mskTbxTelefonoMovil.TabIndex = 5;
            this.mskTbxTelefonoMovil.TextChanged += new System.EventHandler(this.mskTbxTelefonoMovil_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefono movil:";
            // 
            // mskTbxCedula
            // 
            this.mskTbxCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTbxCedula.Location = new System.Drawing.Point(20, 176);
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
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cedula";
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.BackColor = System.Drawing.Color.White;
            this.tbxApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxApellidos.Location = new System.Drawing.Point(20, 130);
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
            this.label1.Location = new System.Drawing.Point(17, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Apellidos:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.White;
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombre.Location = new System.Drawing.Point(20, 84);
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
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.gbxDatosCentro);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(776, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Centro educativo";
            // 
            // gbxDatosCentro
            // 
            this.gbxDatosCentro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxDatosCentro.Controls.Add(this.cbbTipoEstudiante);
            this.gbxDatosCentro.Controls.Add(this.label11);
            this.gbxDatosCentro.Controls.Add(this.bntBuscarCarrera);
            this.gbxDatosCentro.Controls.Add(this.tbxCarrera);
            this.gbxDatosCentro.Controls.Add(this.label15);
            this.gbxDatosCentro.Controls.Add(this.btnBuscarCentroEducativo);
            this.gbxDatosCentro.Controls.Add(this.tbxCentroEducativo);
            this.gbxDatosCentro.Controls.Add(this.label16);
            this.gbxDatosCentro.Controls.Add(this.tbxObservaciones);
            this.gbxDatosCentro.Controls.Add(this.label17);
            this.gbxDatosCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDatosCentro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosCentro.Location = new System.Drawing.Point(10, 10);
            this.gbxDatosCentro.Name = "gbxDatosCentro";
            this.gbxDatosCentro.Size = new System.Drawing.Size(756, 327);
            this.gbxDatosCentro.TabIndex = 7;
            this.gbxDatosCentro.TabStop = false;
            // 
            // cbbTipoEstudiante
            // 
            this.cbbTipoEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoEstudiante.FormattingEnabled = true;
            this.cbbTipoEstudiante.Location = new System.Drawing.Point(21, 127);
            this.cbbTipoEstudiante.MaxLength = 30;
            this.cbbTipoEstudiante.Name = "cbbTipoEstudiante";
            this.cbbTipoEstudiante.Size = new System.Drawing.Size(208, 22);
            this.cbbTipoEstudiante.TabIndex = 3;
            this.cbbTipoEstudiante.Tag = "*";
            this.cbbTipoEstudiante.SelectedIndexChanged += new System.EventHandler(this.cbbTipoEstudiante_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 14);
            this.label11.TabIndex = 47;
            this.label11.Text = "Tipo de estudiante:";
            // 
            // bntBuscarCarrera
            // 
            this.bntBuscarCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntBuscarCarrera.FlatAppearance.BorderSize = 0;
            this.bntBuscarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntBuscarCarrera.Image = global::SINS.Properties.Resources.search16;
            this.bntBuscarCarrera.Location = new System.Drawing.Point(234, 79);
            this.bntBuscarCarrera.Name = "bntBuscarCarrera";
            this.bntBuscarCarrera.Size = new System.Drawing.Size(30, 22);
            this.bntBuscarCarrera.TabIndex = 46;
            this.bntBuscarCarrera.UseVisualStyleBackColor = true;
            this.bntBuscarCarrera.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxCarrera
            // 
            this.tbxCarrera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxCarrera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCarrera.Location = new System.Drawing.Point(21, 80);
            this.tbxCarrera.MaxLength = 50;
            this.tbxCarrera.Name = "tbxCarrera";
            this.tbxCarrera.ReadOnly = true;
            this.tbxCarrera.Size = new System.Drawing.Size(207, 22);
            this.tbxCarrera.TabIndex = 2;
            this.tbxCarrera.Tag = "*";
            this.tbxCarrera.TextChanged += new System.EventHandler(this.tbxCarrera_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 14);
            this.label15.TabIndex = 45;
            this.label15.Text = "Carrera:";
            // 
            // btnBuscarCentroEducativo
            // 
            this.btnBuscarCentroEducativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCentroEducativo.FlatAppearance.BorderSize = 0;
            this.btnBuscarCentroEducativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCentroEducativo.Image = global::SINS.Properties.Resources.search16;
            this.btnBuscarCentroEducativo.Location = new System.Drawing.Point(234, 33);
            this.btnBuscarCentroEducativo.Name = "btnBuscarCentroEducativo";
            this.btnBuscarCentroEducativo.Size = new System.Drawing.Size(30, 22);
            this.btnBuscarCentroEducativo.TabIndex = 43;
            this.btnBuscarCentroEducativo.UseVisualStyleBackColor = true;
            this.btnBuscarCentroEducativo.Click += new System.EventHandler(this.btnBuscarCentroEducativo_Click);
            // 
            // tbxCentroEducativo
            // 
            this.tbxCentroEducativo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxCentroEducativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCentroEducativo.Location = new System.Drawing.Point(21, 34);
            this.tbxCentroEducativo.MaxLength = 75;
            this.tbxCentroEducativo.Name = "tbxCentroEducativo";
            this.tbxCentroEducativo.ReadOnly = true;
            this.tbxCentroEducativo.Size = new System.Drawing.Size(207, 22);
            this.tbxCentroEducativo.TabIndex = 1;
            this.tbxCentroEducativo.Tag = "*";
            this.tbxCentroEducativo.TextChanged += new System.EventHandler(this.tbxCentroEducativo_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 14);
            this.label16.TabIndex = 42;
            this.label16.Text = "Centro educativo:";
            // 
            // tbxObservaciones
            // 
            this.tbxObservaciones.BackColor = System.Drawing.Color.White;
            this.tbxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxObservaciones.Location = new System.Drawing.Point(21, 173);
            this.tbxObservaciones.MaxLength = 256;
            this.tbxObservaciones.Multiline = true;
            this.tbxObservaciones.Name = "tbxObservaciones";
            this.tbxObservaciones.Size = new System.Drawing.Size(489, 92);
            this.tbxObservaciones.TabIndex = 4;
            this.tbxObservaciones.Tag = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 14);
            this.label17.TabIndex = 40;
            this.label17.Text = "Observaciones:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.pbxNuevo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 57);
            this.panel1.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::SINS.Properties.Resources.search24;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(489, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 39);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = global::SINS.Properties.Resources.add24;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(393, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(84, 39);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::SINS.Properties.Resources.write24;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(584, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 39);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnInscribir_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Image = global::SINS.Properties.Resources.close16;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(689, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(83, 39);
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
            this.lblTitulo.Location = new System.Drawing.Point(50, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 432);
            this.Controls.Add(this.pnlGuardarDatosEstudiante);
            this.Name = "frmEstudiante";
            this.Text = "Estudiantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEstudiante_FormClosing);
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            this.pnlGuardarDatosEstudiante.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbxDatosPersonales.ResumeLayout(false);
            this.gbxDatosPersonales.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbxDatosCentro.ResumeLayout(false);
            this.gbxDatosCentro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGuardarDatosEstudiante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbxDatosPersonales;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbxDatosCentro;
        private System.Windows.Forms.ComboBox cbbTipoEstudiante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bntBuscarCarrera;
        private System.Windows.Forms.TextBox tbxCarrera;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnBuscarCentroEducativo;
        private System.Windows.Forms.TextBox tbxCentroEducativo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxObservaciones;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.TextBox tbxMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
    }
}