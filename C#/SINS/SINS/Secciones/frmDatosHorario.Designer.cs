namespace SINS
{
    partial class frmDatosHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosHorario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxNuevo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarAula = new System.Windows.Forms.Button();
            this.tbxAula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarCentroEducativo = new System.Windows.Forms.Button();
            this.tbxCentroEducativo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudMinutosFIn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHoraFin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMinutosInicio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHoraInicio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutosFIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraFin)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutosInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.pbxNuevo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 53);
            this.panel1.TabIndex = 6;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Image = global::SINS.Properties.Resources.send24;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(204, 10);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(83, 32);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(298, 10);
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
            this.pbxNuevo.Image = global::SINS.Properties.Resources.calendar32;
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
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Elegir hoario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(394, 247);
            this.panel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnBuscarAula);
            this.groupBox1.Controls.Add(this.tbxAula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBuscarCentroEducativo);
            this.groupBox1.Controls.Add(this.tbxCentroEducativo);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbbDias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscarAula
            // 
            this.btnBuscarAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAula.Enabled = false;
            this.btnBuscarAula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnBuscarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAula.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAula.Image")));
            this.btnBuscarAula.Location = new System.Drawing.Point(227, 74);
            this.btnBuscarAula.Name = "btnBuscarAula";
            this.btnBuscarAula.Size = new System.Drawing.Size(30, 22);
            this.btnBuscarAula.TabIndex = 56;
            this.btnBuscarAula.UseVisualStyleBackColor = true;
            this.btnBuscarAula.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxAula
            // 
            this.tbxAula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxAula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAula.Location = new System.Drawing.Point(16, 74);
            this.tbxAula.MaxLength = 75;
            this.tbxAula.Name = "tbxAula";
            this.tbxAula.ReadOnly = true;
            this.tbxAula.Size = new System.Drawing.Size(207, 21);
            this.tbxAula.TabIndex = 57;
            this.tbxAula.Tag = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 58;
            this.label6.Text = "Aula:";
            // 
            // btnBuscarCentroEducativo
            // 
            this.btnBuscarCentroEducativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCentroEducativo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(158)))), ((int)(((byte)(220)))));
            this.btnBuscarCentroEducativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCentroEducativo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCentroEducativo.Image")));
            this.btnBuscarCentroEducativo.Location = new System.Drawing.Point(227, 33);
            this.btnBuscarCentroEducativo.Name = "btnBuscarCentroEducativo";
            this.btnBuscarCentroEducativo.Size = new System.Drawing.Size(30, 22);
            this.btnBuscarCentroEducativo.TabIndex = 53;
            this.btnBuscarCentroEducativo.UseVisualStyleBackColor = true;
            this.btnBuscarCentroEducativo.Click += new System.EventHandler(this.btnBuscarCentroEducativo_Click);
            // 
            // tbxCentroEducativo
            // 
            this.tbxCentroEducativo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxCentroEducativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCentroEducativo.Location = new System.Drawing.Point(16, 34);
            this.tbxCentroEducativo.MaxLength = 75;
            this.tbxCentroEducativo.Name = "tbxCentroEducativo";
            this.tbxCentroEducativo.ReadOnly = true;
            this.tbxCentroEducativo.Size = new System.Drawing.Size(207, 21);
            this.tbxCentroEducativo.TabIndex = 54;
            this.tbxCentroEducativo.Tag = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 15);
            this.label16.TabIndex = 55;
            this.label16.Text = "Centro educativo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudMinutosFIn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nudHoraFin);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(201, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(163, 68);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hora de fin ( 24h )";
            // 
            // nudMinutosFIn
            // 
            this.nudMinutosFIn.Enabled = false;
            this.nudMinutosFIn.Location = new System.Drawing.Point(68, 35);
            this.nudMinutosFIn.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutosFIn.Name = "nudMinutosFIn";
            this.nudMinutosFIn.Size = new System.Drawing.Size(53, 21);
            this.nudMinutosFIn.TabIndex = 5;
            this.nudMinutosFIn.Click += new System.EventHandler(this.nudMinutosFIn_Click);
            this.nudMinutosFIn.Enter += new System.EventHandler(this.nudMinutosFIn_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minutos:";
            // 
            // nudHoraFin
            // 
            this.nudHoraFin.Enabled = false;
            this.nudHoraFin.Location = new System.Drawing.Point(9, 35);
            this.nudHoraFin.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nudHoraFin.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudHoraFin.Name = "nudHoraFin";
            this.nudHoraFin.Size = new System.Drawing.Size(53, 21);
            this.nudHoraFin.TabIndex = 3;
            this.nudHoraFin.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudHoraFin.ValueChanged += new System.EventHandler(this.nudHoraFin_ValueChanged);
            this.nudHoraFin.Click += new System.EventHandler(this.nudHoraFin_Click);
            this.nudHoraFin.Enter += new System.EventHandler(this.nudHoraFin_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hora:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMinutosInicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudHoraInicio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(16, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(163, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hora de inicio ( 24h )";
            // 
            // nudMinutosInicio
            // 
            this.nudMinutosInicio.Enabled = false;
            this.nudMinutosInicio.Location = new System.Drawing.Point(68, 35);
            this.nudMinutosInicio.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutosInicio.Name = "nudMinutosInicio";
            this.nudMinutosInicio.Size = new System.Drawing.Size(53, 21);
            this.nudMinutosInicio.TabIndex = 5;
            this.nudMinutosInicio.ValueChanged += new System.EventHandler(this.nudMinutosInicio_ValueChanged);
            this.nudMinutosInicio.Click += new System.EventHandler(this.nudMinutosInicio_Click);
            this.nudMinutosInicio.Enter += new System.EventHandler(this.nudMinutosInicio_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minutos:";
            // 
            // nudHoraInicio
            // 
            this.nudHoraInicio.Enabled = false;
            this.nudHoraInicio.Location = new System.Drawing.Point(9, 35);
            this.nudHoraInicio.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nudHoraInicio.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudHoraInicio.Name = "nudHoraInicio";
            this.nudHoraInicio.Size = new System.Drawing.Size(53, 21);
            this.nudHoraInicio.TabIndex = 3;
            this.nudHoraInicio.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudHoraInicio.ValueChanged += new System.EventHandler(this.nudHoraInicio_ValueChanged);
            this.nudHoraInicio.Click += new System.EventHandler(this.nudHoraInicio_Click);
            this.nudHoraInicio.Enter += new System.EventHandler(this.nudHoraInicio_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora:";
            // 
            // cbbDias
            // 
            this.cbbDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDias.Enabled = false;
            this.cbbDias.FormattingEnabled = true;
            this.cbbDias.Items.AddRange(new object[] {
            "Domingo",
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.cbbDias.Location = new System.Drawing.Point(16, 117);
            this.cbbDias.Name = "cbbDias";
            this.cbbDias.Size = new System.Drawing.Size(105, 23);
            this.cbbDias.TabIndex = 2;
            this.cbbDias.SelectedIndexChanged += new System.EventHandler(this.cbbDias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dia:";
            // 
            // frmDatosHorario
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(394, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDatosHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutosFIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraFin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutosInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudMinutosFIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHoraFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudMinutosInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHoraInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarAula;
        private System.Windows.Forms.TextBox tbxAula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarCentroEducativo;
        private System.Windows.Forms.TextBox tbxCentroEducativo;
        private System.Windows.Forms.Label label16;
    }
}