using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINS.MisClases;
using System.Windows.Forms;

namespace SINS
{
    public partial class frmBuscarProfesor : Form
    {
        public frmBuscarProfesor(Utiles.OpcionBusqueda ob)
        {
            InitializeComponent();
            opcionBusqueda = ob;
        }
        //****VARIABLES MIEMBRO*********************************************************************************************
        Utiles.OpcionBusqueda opcionBusqueda;
        public int IdProfesorSeleccionado { get; set; }
        //*******************************************************************************************************************
        //
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if(pnlFiltro.Visible)
            {
                pnlFiltro.Visible = false;
                chkApellidos.Checked = false;
                chkCedula.Checked = false;
                chkNombre.Checked = false;
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

        private void frmBuscarProfesor_Load(object sender, EventArgs e)
        {
            btnCerrar.Visible = true;
            btnEnviar.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Profesor prof = new Profesor();
            List<Par> liPar = new List<Par>();
            List<Profesor> listProfesores;
            dgvProfesores.Rows.Clear();
            //
            if (!string.IsNullOrEmpty(tbxBusqueda.Text))
            {
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
                //
                if (liPar.Count == 0)
                {
                    liPar.Add(new Par("Id", tbxBusqueda.Text));
                    liPar.Add(new Par("Nombre", tbxBusqueda.Text));
                    liPar.Add(new Par("Apellidos", tbxBusqueda.Text));
                    liPar.Add(new Par("Cedula", tbxBusqueda.Text));
                }
                //
                listProfesores = prof.buscarPorFiltro(liPar);
                //
                dgvProfesores.Rows.Clear();
                foreach (Profesor item in listProfesores)
                {
                    dgvProfesores.Rows.Add("Detalle", item.Id,item.Nombre, item.Apellidos, item.Cedula);
                }
                tbxTotalElementos.Text = dgvProfesores.RowCount.ToString();
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.RowCount > 0)
            {
                IdProfesorSeleccionado = Convert.ToInt32(dgvProfesores.CurrentRow.Cells["Id"].Value.ToString());
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatosProfesor frm = new frmDatosProfesor(Utiles.DbItem.Nuevo,0);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.RowCount > 0)
            {
                try
                {
                    frmDatosProfesor frm = new frmDatosProfesor(Utiles.DbItem.Actualizar, Convert.ToInt32(dgvProfesores.CurrentRow.Cells["Id"].Value.ToString()));
                    frm.ShowDialog();
                    frm.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Text = string.Empty;
        }

        private void dgvProfesores_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (opcionBusqueda == Utiles.OpcionBusqueda.BusquedaYEnvio)
            {
                btnCerrar.Visible = false;
                btnEnviar.Visible = true;
            }
        }
    }
}
