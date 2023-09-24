namespace SINS
{
    partial class frmDatosTipoEstudiante
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.gbxTipoEstudiante = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxCostoCreditos = new System.Windows.Forms.TextBox();
            this.tbxCostoInscripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxCentro = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.gbxTipoEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCentro)).BeginInit();
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
            this.panel1.TabIndex = 6;
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
            this.pnlDatos.Controls.Add(this.gbxTipoEstudiante);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 53);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDatos.Size = new System.Drawing.Size(583, 245);
            this.pnlDatos.TabIndex = 7;
            // 
            // gbxTipoEstudiante
            // 
            this.gbxTipoEstudiante.Controls.Add(this.tbxCostoInscripcion);
            this.gbxTipoEstudiante.Controls.Add(this.tbxCostoCreditos);
            this.gbxTipoEstudiante.Controls.Add(this.label16);
            this.gbxTipoEstudiante.Controls.Add(this.tbxId);
            this.gbxTipoEstudiante.Controls.Add(this.label1);
            this.gbxTipoEstudiante.Controls.Add(this.tbxObservaciones);
            this.gbxTipoEstudiante.Controls.Add(this.label6);
            this.gbxTipoEstudiante.Controls.Add(this.label13);
            this.gbxTipoEstudiante.Controls.Add(this.tbxTitulo);
            this.gbxTipoEstudiante.Controls.Add(this.label14);
            this.gbxTipoEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxTipoEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTipoEstudiante.Location = new System.Drawing.Point(5, 5);
            this.gbxTipoEstudiante.Name = "gbxTipoEstudiante";
            this.gbxTipoEstudiante.Size = new System.Drawing.Size(573, 235);
            this.gbxTipoEstudiante.TabIndex = 3;
            this.gbxTipoEstudiante.TabStop = false;
            this.gbxTipoEstudiante.Text = "Datos de la nueva carrera";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 15);
            this.label16.TabIndex = 48;
            this.label16.Text = "Costo inscripción:";
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
            this.label13.Location = new System.Drawing.Point(19, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Costo creditos:";
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.BackColor = System.Drawing.Color.White;
            this.tbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTitulo.Location = new System.Drawing.Point(22, 90);
            this.tbxTitulo.MaxLength = 25;
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(208, 21);
            this.tbxTitulo.TabIndex = 1;
            this.tbxTitulo.Tag = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Título:";
            // 
            // tbxCostoCreditos
            // 
            this.tbxCostoCreditos.BackColor = System.Drawing.Color.White;
            this.tbxCostoCreditos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCostoCreditos.Location = new System.Drawing.Point(21, 133);
            this.tbxCostoCreditos.MaxLength = 7;
            this.tbxCostoCreditos.Name = "tbxCostoCreditos";
            this.tbxCostoCreditos.Size = new System.Drawing.Size(208, 21);
            this.tbxCostoCreditos.TabIndex = 3;
            this.tbxCostoCreditos.Tag = "*";
            this.tbxCostoCreditos.Text = "0.00";
            this.tbxCostoCreditos.TextChanged += new System.EventHandler(this.tbxCostoCreditos_TextChanged);
            this.tbxCostoCreditos.Enter += new System.EventHandler(this.tbxCostoCreditos_Enter);
            // 
            // tbxCostoInscripcion
            // 
            this.tbxCostoInscripcion.BackColor = System.Drawing.Color.White;
            this.tbxCostoInscripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCostoInscripcion.Location = new System.Drawing.Point(22, 175);
            this.tbxCostoInscripcion.MaxLength = 7;
            this.tbxCostoInscripcion.Name = "tbxCostoInscripcion";
            this.tbxCostoInscripcion.Size = new System.Drawing.Size(208, 21);
            this.tbxCostoInscripcion.TabIndex = 4;
            this.tbxCostoInscripcion.Tag = "*";
            this.tbxCostoInscripcion.Text = "0.00";
            this.tbxCostoInscripcion.TextChanged += new System.EventHandler(this.tbxCostoInscripcion_TextChanged);
            this.tbxCostoInscripcion.Enter += new System.EventHandler(this.tbxCostoInscripcion_Enter);
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
            this.pbxCentro.Image = global::SINS.Properties.Resources.tag32;
            this.pbxCentro.Location = new System.Drawing.Point(12, 12);
            this.pbxCentro.Name = "pbxCentro";
            this.pbxCentro.Size = new System.Drawing.Size(32, 32);
            this.pbxCentro.TabIndex = 1;
            this.pbxCentro.TabStop = false;
            // 
            // frmDatosTipoEstudiante
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(583, 298);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDatosTipoEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de estudiante";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.gbxTipoEstudiante.ResumeLayout(false);
            this.gbxTipoEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCentro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxCentro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxTipoEstudiante;
        private System.Windows.Forms.TextBox tbxCostoInscripcion;
        private System.Windows.Forms.TextBox tbxCostoCreditos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxObservaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Label label14;
    }
}