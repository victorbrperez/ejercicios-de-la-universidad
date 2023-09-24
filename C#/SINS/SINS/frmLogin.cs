using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SINS.MisClases;

namespace SINS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public int IdUsuario { get; set; }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            if (tbxUsuario.Text != "" && tbxPasword.Text != "")
            {
                u.Nombre_usuario = tbxUsuario.Text;
                u.buscarDatos(Utiles.DbOptionSelect.Basico);
                if (u.Password != null)
                {
                    if (CryptorEngine.VerifyHash(tbxPasword.Text, "sha512", u.Password))
                    {
                        this.DialogResult = DialogResult.OK;
                        IdUsuario = u.Id;
                        this.Close();
                    }
                    else { MessageBox.Show("Usuario y Contraseña no coinciden o no son válidos", "Inicio de sesión",MessageBoxButtons.OK,MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Usuario y Contraseña no coinciden o no son válidos", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else{ MessageBox.Show("Usuario y Contraseña no coinciden o no son válidos", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnView_MouseDown(object sender, MouseEventArgs e)
        {
            tbxPasword.UseSystemPasswordChar = false;
        }

        private void btnView_MouseUp(object sender, MouseEventArgs e)
        {
            tbxPasword.UseSystemPasswordChar = true;
        }
    }
}
