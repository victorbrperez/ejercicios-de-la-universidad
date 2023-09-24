using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClases;

namespace Sistema_de_Inventario_SC
{
    public partial class frmAutenticate : Form
    {
        public frmAutenticate()
        {
            InitializeComponent();
        }
        const string tabla = "usuarios";
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario miUsuario = new Usuario();
            DataSet dsUsuario = new DataSet();
            if (tbId.Text != "") miUsuario.Id = Convert.ToInt32(tbId.Text);
            dsUsuario = miUsuario.Buscar("uno");
            if (dsUsuario.Tables[tabla].Rows.Count != 0)
            {
                if (dsUsuario.Tables[tabla].Rows[0]["id"].ToString() == tbId.Text && dsUsuario.Tables[tabla].Rows[0]["password"].ToString() == tbPassword.Text)
                {
                    if (Convert.ToInt32(dsUsuario.Tables[tabla].Rows[0]["administrador"].ToString()) == 1)
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else MessageForm.Show("Este usuario no tiene permitido realizar esta operación", "Atencion");

                }
                else MessageForm.Show("Id y Contraseña no coinciden", "Atencion");

            }
            else MessageForm.Show("Usuario no encontrado","Atencion");
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
    }
}
