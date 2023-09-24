namespace SINS
{
    partial class frmDatosAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosAula));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxCentro = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.gbxAula = new System.Windows.Forms.GroupBox();
            this.btnBuscarCentroEducativo = new System.Windows.Forms.Button();
            this.tbxCentroEducativo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.tbxObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCentro)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.gbxAula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.pbxCentro);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 53);
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
            this.btnGuardar.Location = new System.Drawing.Point(377, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 32);
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
            this.btnCerrar.Location = new System.Drawing.Point(486, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = " Cerrrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxCentro
            // 
            this.pbxCentro.Image = global::SINS.Properties.Resources.classroom32;
            this.pbxCentro.Location = new System.Drawing.Point(12, 12);
            this.pbxCentro.Name = "pbxCentro";
            this.pbxCentro.Size = new System.Drawing.Size(32, 32);
            this.pbxCentro.TabIndex = 1;
            this.pbxCentro.TabStop = false;
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
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.gbxAula);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 53);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDatos.Size = new System.Drawing.Size(583, 266);
            this.pnlDatos.TabIndex = 6;
            // 
            // gbxAula
            // 
            this.gbxAula.Controls.Add(this.btnBuscarCentroEducativo);
            this.gbxAula.Controls.Add(this.tbxCentroEducativo);
            this.gbxAula.Controls.Add(this.label16);
            this.gbxAula.Controls.Add(this.tbxCodigo);
            this.gbxAula.Controls.Add(this.label2);
            this.gbxAula.Controls.Add(this.tbxId);
            this.gbxAula.Controls.Add(this.label1);
            this.gbxAula.Controls.Add(this.nudCapacidad);
            this.gbxAula.Controls.Add(this.tbxObservaciones);
            this.gbxAula.Controls.Add(this.label6);
            this.gbxAula.Controls.Add(this.label13);
            this.gbxAula.Controls.Add(this.tbxDescripcion);
            this.gbxAula.Controls.Add(this.label14);
            this.gbxAula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAula.Location = new System.Drawing.Point(5, 5);
            this.gbxAula.Name = "gbxAula";
            this.gbxAula.Size = new System.Drawing.Size(573, 256);
            this.gbxAula.TabIndex = 3;
            this.gbxAula.TabStop = false;
            this.gbxAula.Text = "Datos de la nueva carrera";
            // 
            // btnBuscarCentroEducativo
            // 
            this.btnBuscarCentroEducativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCentroEducativo.FlatAppearance.BorderSize = 0;
            this.btnBuscarCentroEducativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCentroEducativo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCentroEducativo.Image")));
            this.btnBuscarCentroEducativo.Location = new System.Drawing.Point(231, 216);
            this.btnBuscarCentroEducativo.Name = "btnBuscarCentroEducativo";
            this.btnBuscarCentroEducativo.Size = new System.Drawing.Size(30, 22);
            this.btnBuscarCentroEducativo.TabIndex = 4;
            this.btnBuscarCentroEducativo.UseVisualStyleBackColor = true;
            this.btnBuscarCentroEducativo.Click += new System.EventHandler(this.btnBuscarCentroEducativo_Click);
            // 
            // tbxCentroEducativo
            // 
            this.tbxCentroEducativo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxCentroEducativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCentroEducativo.Location = new System.Drawing.Point(22, 217);
            this.tbxCentroEducativo.MaxLength = 75;
            this.tbxCentroEducativo.Name = "tbxCentroEducativo";
            this.tbxCentroEducativo.ReadOnly = true;
            this.tbxCentroEducativo.Size = new System.Drawing.Size(207, 21);
            this.tbxCentroEducativo.TabIndex = 47;
            this.tbxCentroEducativo.Tag = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 15);
            this.label16.TabIndex = 48;
            this.label16.Text = "Centro educativo:";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.BackColor = System.Drawing.Color.White;
            this.tbxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCodigo.Location = new System.Drawing.Point(22, 133);
            this.tbxCodigo.MaxLength = 7;
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(208, 21);
            this.tbxCodigo.TabIndex = 2;
            this.tbxCodigo.Tag = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Código";
            // 
            // tbxId
            // 
            this.tbxId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId.Location = new System.Drawing.Point(22, 47);
            this.tbxId.MaxLength = 15;
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(208, 21);
            this.tbxId.TabIndex = 42;
            this.tbxId.Tag = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Id:";
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(22, 176);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(120, 21);
            this.nudCapacidad.TabIndex = 3;
            // 
            // tbxObservaciones
            // 
            this.tbxObservaciones.BackColor = System.Drawing.Color.White;
            this.tbxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxObservaciones.Location = new System.Drawing.Point(260, 47);
            this.tbxObservaciones.MaxLength = 256;
            this.tbxObservaciones.Multiline = true;
            this.tbxObservaciones.Name = "tbxObservaciones";
            this.tbxObservaciones.Size = new System.Drawing.Size(293, 46);
            this.tbxObservaciones.TabIndex = 5;
            this.tbxObservaciones.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Observaciones:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Capacidad";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.BackColor = System.Drawing.Color.White;
            this.tbxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDescripcion.Location = new System.Drawing.Point(22, 90);
            this.tbxDescripcion.MaxLength = 100;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(208, 21);
            this.tbxDescripcion.TabIndex = 1;
            this.tbxDescripcion.Tag = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Descripción:";
            // 
            // frmDatosAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 319);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDatosAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCentro)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.gbxAula.ResumeLayout(false);
            this.gbxAula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxCentro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxAula;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.TextBox tbxObservaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCentroEducativo;
        private System.Windows.Forms.TextBox tbxCentroEducativo;
        private System.Windows.Forms.Label label16;
    }
}