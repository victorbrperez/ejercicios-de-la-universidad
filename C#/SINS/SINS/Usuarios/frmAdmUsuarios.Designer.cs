namespace SINS
{
    partial class frmAdmusuarios
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
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.gbxNuevoUsuario = new System.Windows.Forms.GroupBox();
            this.lklblPermisos = new System.Windows.Forms.LinkLabel();
            this.tbxConfirmarPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.tbxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbxNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxActualizar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxNuevo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlUsuarios.SuspendLayout();
            this.gbxNuevoUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUsuarios.Controls.Add(this.gbxNuevoUsuario);
            this.pnlUsuarios.Controls.Add(this.panel1);
            this.pnlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(506, 325);
            this.pnlUsuarios.TabIndex = 1;
            // 
            // gbxNuevoUsuario
            // 
            this.gbxNuevoUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxNuevoUsuario.Controls.Add(this.lklblPermisos);
            this.gbxNuevoUsuario.Controls.Add(this.tbxConfirmarPassword);
            this.gbxNuevoUsuario.Controls.Add(this.label7);
            this.gbxNuevoUsuario.Controls.Add(this.label6);
            this.gbxNuevoUsuario.Controls.Add(this.cbbxTipoUsuario);
            this.gbxNuevoUsuario.Controls.Add(this.tbxTelefono);
            this.gbxNuevoUsuario.Controls.Add(this.label5);
            this.gbxNuevoUsuario.Controls.Add(this.tbxApellidos);
            this.gbxNuevoUsuario.Controls.Add(this.label4);
            this.gbxNuevoUsuario.Controls.Add(this.tbxNombre);
            this.gbxNuevoUsuario.Controls.Add(this.label3);
            this.gbxNuevoUsuario.Controls.Add(this.tbxPassword);
            this.gbxNuevoUsuario.Controls.Add(this.lblPass);
            this.gbxNuevoUsuario.Controls.Add(this.tbxNombreUsuario);
            this.gbxNuevoUsuario.Controls.Add(this.label2);
            this.gbxNuevoUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxNuevoUsuario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNuevoUsuario.Location = new System.Drawing.Point(0, 53);
            this.gbxNuevoUsuario.Name = "gbxNuevoUsuario";
            this.gbxNuevoUsuario.Size = new System.Drawing.Size(506, 272);
            this.gbxNuevoUsuario.TabIndex = 1;
            this.gbxNuevoUsuario.TabStop = false;
            this.gbxNuevoUsuario.Text = "Datos del nuevo usuario";
            // 
            // lklblPermisos
            // 
            this.lklblPermisos.AutoSize = true;
            this.lklblPermisos.Enabled = false;
            this.lklblPermisos.LinkColor = System.Drawing.Color.Gray;
            this.lklblPermisos.Location = new System.Drawing.Point(423, 238);
            this.lklblPermisos.Name = "lklblPermisos";
            this.lklblPermisos.Size = new System.Drawing.Size(60, 16);
            this.lklblPermisos.TabIndex = 55;
            this.lklblPermisos.TabStop = true;
            this.lklblPermisos.Text = "Permisos";
            this.lklblPermisos.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lklblPermisos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblPermisos_LinkClicked);
            // 
            // tbxConfirmarPassword
            // 
            this.tbxConfirmarPassword.BackColor = System.Drawing.Color.White;
            this.tbxConfirmarPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxConfirmarPassword.Location = new System.Drawing.Point(20, 139);
            this.tbxConfirmarPassword.Name = "tbxConfirmarPassword";
            this.tbxConfirmarPassword.Size = new System.Drawing.Size(208, 23);
            this.tbxConfirmarPassword.TabIndex = 3;
            this.tbxConfirmarPassword.Tag = "*";
            this.tbxConfirmarPassword.UseSystemPasswordChar = true;
            this.tbxConfirmarPassword.TextChanged += new System.EventHandler(this.tbxConfirmarPassword_TextChanged);
            this.tbxConfirmarPassword.Leave += new System.EventHandler(this.tbxConfirmarPassword_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Confirmar contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tipo de Usuario:";
            // 
            // cbbxTipoUsuario
            // 
            this.cbbxTipoUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbxTipoUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxTipoUsuario.FormattingEnabled = true;
            this.cbbxTipoUsuario.Location = new System.Drawing.Point(275, 148);
            this.cbbxTipoUsuario.Name = "cbbxTipoUsuario";
            this.cbbxTipoUsuario.Size = new System.Drawing.Size(208, 24);
            this.cbbxTipoUsuario.TabIndex = 7;
            this.cbbxTipoUsuario.Tag = "nu";
            this.cbbxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cbbxTipoUsuario_SelectedIndexChanged);
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTelefono.Location = new System.Drawing.Point(276, 103);
            this.tbxTelefono.Mask = "(999)000-0000";
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(208, 23);
            this.tbxTelefono.TabIndex = 6;
            this.tbxTelefono.Tag = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefono:";
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.BackColor = System.Drawing.Color.White;
            this.tbxApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxApellidos.Location = new System.Drawing.Point(275, 58);
            this.tbxApellidos.Name = "tbxApellidos";
            this.tbxApellidos.Size = new System.Drawing.Size(208, 23);
            this.tbxApellidos.TabIndex = 5;
            this.tbxApellidos.Tag = "nuevo_usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Apellidos:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.White;
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombre.Location = new System.Drawing.Point(20, 185);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(208, 23);
            this.tbxNombre.TabIndex = 4;
            this.tbxNombre.Tag = "*";
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.White;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassword.Location = new System.Drawing.Point(19, 94);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(208, 23);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.Tag = "*";
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(16, 75);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 16);
            this.lblPass.TabIndex = 17;
            this.lblPass.Text = "Contraseña:";
            // 
            // tbxNombreUsuario
            // 
            this.tbxNombreUsuario.BackColor = System.Drawing.Color.White;
            this.tbxNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombreUsuario.Location = new System.Drawing.Point(20, 50);
            this.tbxNombreUsuario.Name = "tbxNombreUsuario";
            this.tbxNombreUsuario.Size = new System.Drawing.Size(208, 23);
            this.tbxNombreUsuario.TabIndex = 1;
            this.tbxNombreUsuario.Tag = "*";
            this.tbxNombreUsuario.TextChanged += new System.EventHandler(this.tbxNombreUsuario_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre de usuario: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.pbxActualizar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.pbxNuevo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 53);
            this.panel1.TabIndex = 2;
            // 
            // pbxActualizar
            // 
            this.pbxActualizar.Image = global::SINS.Properties.Resources.user_edit32;
            this.pbxActualizar.Location = new System.Drawing.Point(12, 12);
            this.pbxActualizar.Name = "pbxActualizar";
            this.pbxActualizar.Size = new System.Drawing.Size(32, 32);
            this.pbxActualizar.TabIndex = 4;
            this.pbxActualizar.TabStop = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(290, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 32);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarNuevo_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(401, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = " Cerrrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbxNuevo
            // 
            this.pbxNuevo.Image = global::SINS.Properties.Resources.new_user32;
            this.pbxNuevo.Location = new System.Drawing.Point(12, 12);
            this.pbxNuevo.Name = "pbxNuevo";
            this.pbxNuevo.Size = new System.Drawing.Size(32, 32);
            this.pbxNuevo.TabIndex = 1;
            this.pbxNuevo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // frmAdmusuarios
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(506, 325);
            this.Controls.Add(this.pnlUsuarios);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAdmusuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de usuarios";
            this.Load += new System.EventHandler(this.frmConfiguracionSistema_Load);
            this.pnlUsuarios.ResumeLayout(false);
            this.gbxNuevoUsuario.ResumeLayout(false);
            this.gbxNuevoUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbxNuevoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbxTipoUsuario;
        private System.Windows.Forms.MaskedTextBox tbxTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbxNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxConfirmarPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbxActualizar;
        private System.Windows.Forms.LinkLabel lklblPermisos;
    }
}