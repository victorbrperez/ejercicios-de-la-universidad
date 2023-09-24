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

namespace SINS.Otros
{
    public partial class frmSeleccionarTipoUsuario : Form
    {
        public frmSeleccionarTipoUsuario()
        {
            InitializeComponent();
            id_tipo_usuario = 0;
            TipoUsuario tu = new TipoUsuario();
            TiposUsuarios = tu.ObtenerUsuarios();
            foreach (TipoUsuario item in TiposUsuarios)
            {
                cbbxTipoUsuario.Items.Add(item.Titulo);
            }
        }
        //
        List<TipoUsuario> TiposUsuarios = new List<TipoUsuario>();
        int id_tipo_usuario;

        public int IdeTipoUsuarioSeleccionado { get { return id_tipo_usuario; } }


        private void frmSeleccionarEstudianteProrTipo_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            id_tipo_usuario = 0;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            foreach (TipoUsuario item in TiposUsuarios)
            {
                if (item.Titulo == cbbxTipoUsuario.Text)
                {
                    id_tipo_usuario = item.Id;
                    break;
                }
                else
                {
                    id_tipo_usuario = 0;
                }
            }
            this.Close();
            
        }
    }
}
