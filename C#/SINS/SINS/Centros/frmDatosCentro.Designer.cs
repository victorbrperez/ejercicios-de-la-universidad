namespace SINS
{
    partial class frmDatosCentro
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
            this.pbxCentro = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.gbxCentroEducativo = new System.Windows.Forms.GroupBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxObservacionesCentro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxWebCentro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDireccionCentro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxCorreoCentro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTbxTelefonoCentro = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNombreLargoCentro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNombreCortoCentro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCentro)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.gbxCentroEducativo.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(672, 53);
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
            this.btnGuardar.Location = new System.Drawing.Point(468, 10);
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
            this.btnCerrar.Location = new System.Drawing.Point(574, 10);
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
            this.pbxCentro.Image = global::SINS.Properties.Resources.university_campus32;
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
            this.lblTitulo.Location = new System.Drawing.Point(50, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.gbxCentroEducativo);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 53);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDatos.Size = new System.Drawing.Size(672, 337);
            this.pnlDatos.TabIndex = 4;
            // 
            // gbxCentroEducativo
            // 
            this.gbxCentroEducativo.Controls.Add(this.tbxId);
            this.gbxCentroEducativo.Controls.Add(this.label6);
            this.gbxCentroEducativo.Controls.Add(this.tbxObservacionesCentro);
            this.gbxCentroEducativo.Controls.Add(this.label5);
            this.gbxCentroEducativo.Controls.Add(this.tbxWebCentro);
            this.gbxCentroEducativo.Controls.Add(this.label4);
            this.gbxCentroEducativo.Controls.Add(this.tbxDireccionCentro);
            this.gbxCentroEducativo.Controls.Add(this.label7);
            this.gbxCentroEducativo.Controls.Add(this.tbxCorreoCentro);
            this.gbxCentroEducativo.Controls.Add(this.label8);
            this.gbxCentroEducativo.Controls.Add(this.mskTbxTelefonoCentro);
            this.gbxCentroEducativo.Controls.Add(this.label3);
            this.gbxCentroEducativo.Controls.Add(this.tbxNombreLargoCentro);
            this.gbxCentroEducativo.Controls.Add(this.label1);
            this.gbxCentroEducativo.Controls.Add(this.tbxNombreCortoCentro);
            this.gbxCentroEducativo.Controls.Add(this.label2);
            this.gbxCentroEducativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCentroEducativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCentroEducativo.Location = new System.Drawing.Point(5, 5);
            this.gbxCentroEducativo.Name = "gbxCentroEducativo";
            this.gbxCentroEducativo.Size = new System.Drawing.Size(662, 327);
            this.gbxCentroEducativo.TabIndex = 2;
            this.gbxCentroEducativo.TabStop = false;
            this.gbxCentroEducativo.Text = "Datos del nuevo centro educativo";
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
            this.tbxId.TabIndex = 40;
            this.tbxId.Tag = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Id:";
            // 
            // tbxObservacionesCentro
            // 
            this.tbxObservacionesCentro.BackColor = System.Drawing.Color.White;
            this.tbxObservacionesCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxObservacionesCentro.Location = new System.Drawing.Point(350, 90);
            this.tbxObservacionesCentro.MaxLength = 256;
            this.tbxObservacionesCentro.Multiline = true;
            this.tbxObservacionesCentro.Name = "tbxObservacionesCentro";
            this.tbxObservacionesCentro.Size = new System.Drawing.Size(293, 46);
            this.tbxObservacionesCentro.TabIndex = 7;
            this.tbxObservacionesCentro.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Observaciones:";
            // 
            // tbxWebCentro
            // 
            this.tbxWebCentro.BackColor = System.Drawing.Color.White;
            this.tbxWebCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxWebCentro.Location = new System.Drawing.Point(350, 47);
            this.tbxWebCentro.MaxLength = 256;
            this.tbxWebCentro.Name = "tbxWebCentro";
            this.tbxWebCentro.Size = new System.Drawing.Size(293, 21);
            this.tbxWebCentro.TabIndex = 6;
            this.tbxWebCentro.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Sitio Web:";
            // 
            // tbxDireccionCentro
            // 
            this.tbxDireccionCentro.BackColor = System.Drawing.Color.White;
            this.tbxDireccionCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDireccionCentro.Location = new System.Drawing.Point(22, 262);
            this.tbxDireccionCentro.MaxLength = 80;
            this.tbxDireccionCentro.Multiline = true;
            this.tbxDireccionCentro.Name = "tbxDireccionCentro";
            this.tbxDireccionCentro.Size = new System.Drawing.Size(293, 46);
            this.tbxDireccionCentro.TabIndex = 5;
            this.tbxDireccionCentro.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Dirección:";
            // 
            // tbxCorreoCentro
            // 
            this.tbxCorreoCentro.BackColor = System.Drawing.Color.White;
            this.tbxCorreoCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCorreoCentro.Location = new System.Drawing.Point(22, 219);
            this.tbxCorreoCentro.MaxLength = 80;
            this.tbxCorreoCentro.Name = "tbxCorreoCentro";
            this.tbxCorreoCentro.Size = new System.Drawing.Size(293, 21);
            this.tbxCorreoCentro.TabIndex = 4;
            this.tbxCorreoCentro.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Correo electrónico:";
            // 
            // mskTbxTelefonoCentro
            // 
            this.mskTbxTelefonoCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTbxTelefonoCentro.Location = new System.Drawing.Point(22, 176);
            this.mskTbxTelefonoCentro.Mask = "(999)000-0000";
            this.mskTbxTelefonoCentro.Name = "mskTbxTelefonoCentro";
            this.mskTbxTelefonoCentro.Size = new System.Drawing.Size(208, 21);
            this.mskTbxTelefonoCentro.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefono:";
            // 
            // tbxNombreLargoCentro
            // 
            this.tbxNombreLargoCentro.BackColor = System.Drawing.Color.White;
            this.tbxNombreLargoCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombreLargoCentro.Location = new System.Drawing.Point(20, 133);
            this.tbxNombreLargoCentro.MaxLength = 75;
            this.tbxNombreLargoCentro.Name = "tbxNombreLargoCentro";
            this.tbxNombreLargoCentro.Size = new System.Drawing.Size(295, 21);
            this.tbxNombreLargoCentro.TabIndex = 2;
            this.tbxNombreLargoCentro.Tag = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre completo:";
            // 
            // tbxNombreCortoCentro
            // 
            this.tbxNombreCortoCentro.BackColor = System.Drawing.Color.White;
            this.tbxNombreCortoCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombreCortoCentro.Location = new System.Drawing.Point(22, 90);
            this.tbxNombreCortoCentro.MaxLength = 15;
            this.tbxNombreCortoCentro.Name = "tbxNombreCortoCentro";
            this.tbxNombreCortoCentro.Size = new System.Drawing.Size(208, 21);
            this.tbxNombreCortoCentro.TabIndex = 1;
            this.tbxNombreCortoCentro.Tag = "*";
            this.tbxNombreCortoCentro.TextChanged += new System.EventHandler(this.tbxNombreCortoCentro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre corto:";
            // 
            // frmDatosCentro
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(672, 390);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDatosCentro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCentro)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.gbxCentroEducativo.ResumeLayout(false);
            this.gbxCentroEducativo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxCentro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxCentroEducativo;
        private System.Windows.Forms.TextBox tbxObservacionesCentro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxWebCentro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDireccionCentro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxCorreoCentro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTbxTelefonoCentro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNombreLargoCentro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNombreCortoCentro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label6;
    }
}