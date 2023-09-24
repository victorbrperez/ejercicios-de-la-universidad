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
    public partial class frmVerUsuarios : Form
    {
        public frmVerUsuarios()
        {
            InitializeComponent();
            btnCerrar.Visible = true;
            btnEnviar.Visible = false;

        }
        public frmVerUsuarios(Utiles.DbItem actividad)
        {
            InitializeComponent();
            btnCerrar.Visible = false;
            btnEnviar.Visible = true;

        }
        public int IdUsuarioSeleccionado { get; set; }
        void ejecutarBusqueda()
        {
            Usuario u = new Usuario();
            List<Par> liPar = new List<Par>();
            List<Usuario> liUsuarios;
            dgvUsuarios.Rows.Clear();
            foreach (Control item in gbxFilter.Controls)
            {
                if (item.GetType().Equals(typeof(CheckBox)))
                {
                    if (((CheckBox)item).Checked)
                    {
                        liPar.Add(new Par(item.Tag.ToString(), tbxBusqueda.Text));
                    }
                }
            }
            if (liPar.Count == 0)
            {
                liPar.Add(new Par("Usuario", tbxBusqueda.Text));
                liPar.Add(new Par("Nombre", tbxBusqueda.Text));
                liPar.Add(new Par("Apellidos", tbxBusqueda.Text));
            }
            liUsuarios = u.buscarPorFiltro(liPar);

            dgvUsuarios.Rows.Clear();
            foreach (Usuario item in liUsuarios)
            {
                dgvUsuarios.Rows.Add(item.Id, item.Nombre_usuario, item.Nombre, item.Apellidos);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlFiltro.Visible)
            {
                pnlFiltro.Visible = false;
                chkApellidos.Checked = false;
                chkNombre.Checked = false;
                chkUsuario.Checked = false;
            }
            else if (pnlFiltro.Visible == false)
            {
                pnlFiltro.Visible = true;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ejecutarBusqueda();
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                IdUsuarioSeleccionado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value.ToString());
            }
            this.Close();
        }

        private void pnlDatosResultados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAdmusuarios frm = new frmAdmusuarios(Utiles.DbItem.Nuevo, 0);
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                try
                {
                    frmAdmusuarios frmAdm = new frmAdmusuarios(Utiles.DbItem.Actualizar, Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value.ToString()));
                    frmAdm.ShowDialog();
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
           
        }

        private void dgvUsuarios_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tbxTotalElementos.Text = dgvUsuarios.RowCount.ToString();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Text = string.Empty;
        }
    }
}
