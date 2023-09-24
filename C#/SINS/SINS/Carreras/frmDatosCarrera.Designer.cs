namespace SINS
{
    partial class frmDatosCarrera
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.gbxCarrera = new System.Windows.Forms.GroupBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCreditosCarrera = new System.Windows.Forms.NumericUpDown();
            this.tbxObservacionesCarrera = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxNombreCarrera = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxCentro = new System.Windows.Forms.PictureBox();
            this.pnlDatos.SuspendLayout();
            this.gbxCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditosCarrera)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCentro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.gbxCarrera);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 53);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDatos.Size = new System.Drawing.Size(528, 250);
            this.pnlDatos.TabIndex = 5;
            // 
            // gbxCarrera
            // 
            this.gbxCarrera.Controls.Add(this.tbxId);
            this.gbxCarrera.Controls.Add(this.label1);
            this.gbxCarrera.Controls.Add(this.nudCreditosCarrera);
            this.gbxCarrera.Controls.Add(this.tbxObservacionesCarrera);
            this.gbxCarrera.Controls.Add(this.label6);
            this.gbxCarrera.Controls.Add(this.label13);
            this.gbxCarrera.Controls.Add(this.tbxNombreCarrera);
            this.gbxCarrera.Controls.Add(this.label14);
            this.gbxCarrera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCarrera.Location = new System.Drawing.Point(5, 5);
            this.gbxCarrera.Name = "gbxCarrera";
            this.gbxCarrera.Size = new System.Drawing.Size(518, 240);
            this.gbxCarrera.TabIndex = 3;
            this.gbxCarrera.TabStop = false;
            this.gbxCarrera.Text = "Datos de la nueva carrera";
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
            // nudCreditosCarrera
            // 
            this.nudCreditosCarrera.Location = new System.Drawing.Point(22, 133);
            this.nudCreditosCarrera.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCreditosCarrera.Name = "nudCreditosCarrera";
            this.nudCreditosCarrera.Size = new System.Drawing.Size(120, 21);
            this.nudCreditosCarrera.TabIndex = 2;
            // 
            // tbxObservacionesCarrera
            // 
            this.tbxObservacionesCarrera.BackColor = System.Drawing.Color.White;
            this.tbxObservacionesCarrera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxObservacionesCarrera.Location = new System.Drawing.Point(22, 176);
            this.tbxObservacionesCarrera.MaxLength = 256;
            this.tbxObservacionesCarrera.Multiline = true;
            this.tbxObservacionesCarrera.Name = "tbxObservacionesCarrera";
            this.tbxObservacionesCarrera.Size = new System.Drawing.Size(293, 46);
            this.tbxObservacionesCarrera.TabIndex = 3;
            this.tbxObservacionesCarrera.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 157);
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
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Creditos:";
            // 
            // tbxNombreCarrera
            // 
            this.tbxNombreCarrera.BackColor = System.Drawing.Color.White;
            this.tbxNombreCarrera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombreCarrera.Location = new System.Drawing.Point(22, 90);
            this.tbxNombreCarrera.MaxLength = 80;
            this.tbxNombreCarrera.Name = "tbxNombreCarrera";
            this.tbxNombreCarrera.Size = new System.Drawing.Size(208, 21);
            this.tbxNombreCarrera.TabIndex = 1;
            this.tbxNombreCarrera.Tag = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Nombre:";
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
            this.panel1.Size = new System.Drawing.Size(528, 53);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnGuardar.Location = new System.Drawing.Point(322, 10);
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
            this.btnCerrar.Location = new System.Drawing.Point(431, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = " Cerrrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbxCentro
            // 
            this.pbxCentro.Image = global::SINS.Properties.Resources.graduate_cap32;
            this.pbxCentro.Location = new System.Drawing.Point(12, 12);
            this.pbxCentro.Name = "pbxCentro";
            this.pbxCentro.Size = new System.Drawing.Size(32, 32);
            this.pbxCentro.TabIndex = 1;
            this.pbxCentro.TabStop = false;
            // 
            // frmDatosCarrera
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(528, 303);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDatosCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrera";
            this.pnlDatos.ResumeLayout(false);
            this.gbxCarrera.ResumeLayout(false);
            this.gbxCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditosCarrera)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCentro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxCarrera;
        private System.Windows.Forms.NumericUpDown nudCreditosCarrera;
        private System.Windows.Forms.TextBox tbxObservacionesCarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxNombreCarrera;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxCentro;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
    }
}