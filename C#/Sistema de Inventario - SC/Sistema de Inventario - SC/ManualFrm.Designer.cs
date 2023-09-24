namespace Sistema_de_Inventario_SC
{
    partial class manualFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manualFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrarBtn = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.cerrarBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 58);
            this.panel1.TabIndex = 2;
            // 
            // cerrarBtn
            // 
            this.cerrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(34)))));
            this.cerrarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cerrarBtn.FlatAppearance.BorderSize = 0;
            this.cerrarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(112)))), ((int)(((byte)(1)))));
            this.cerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cerrarBtn.Location = new System.Drawing.Point(755, 9);
            this.cerrarBtn.Name = "cerrarBtn";
            this.cerrarBtn.Size = new System.Drawing.Size(120, 42);
            this.cerrarBtn.TabIndex = 0;
            this.cerrarBtn.Text = "Cerrar";
            this.cerrarBtn.UseVisualStyleBackColor = false;
            this.cerrarBtn.Click += new System.EventHandler(this.cerrarBtn_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(891, 442);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(891, 442);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // manualFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 500);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "manualFrm";
            this.Text = "Manual de Sistema de inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManualFrm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrarBtn;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}