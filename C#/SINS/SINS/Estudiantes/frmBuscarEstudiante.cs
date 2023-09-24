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
    public partial class frmBuscarEstudiante : Form
    {
        public frmBuscarEstudiante(Utiles.OpcionBusqueda ob)
        {
            InitializeComponent();
            opcionBusqueda = ob;
        }
        //****VARIABLES MIEMBRO*********************************************************************************************
        Utiles.OpcionBusqueda opcionBusqueda;
        public int IdEstudianteSeleccionado { get; set; }
        //
        void ejecutarBusqueda()
        {
            Estudiante est = new Estudiante();
            List<Par> liPar = new List<Par>();
            List<Estudiante> listEstudiantes;
            dgvEstudiantes.Rows.Clear();
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
                liPar.Add(new Par("Matricula", tbxBusqueda.Text));
                liPar.Add(new Par("Nombre", tbxBusqueda.Text));
                liPar.Add(new Par("Apellidos", tbxBusqueda.Text));
                liPar.Add(new Par("Cedula", tbxBusqueda.Text));
            }
            listEstudiantes = est.buscarPorFiltro(liPar);

            dgvEstudiantes.Rows.Clear();
            foreach (Estudiante item in listEstudiantes)
            {
                dgvEstudiantes.Rows.Add(item.Id, "Detalle", item.Matricula.ToString(), item.Nombre, item.Apellidos, item.Cedula);
            }
            tbxTotalElementos.Text = dgvEstudiantes.RowCount.ToString();
        }
        //*******************************************************************************************************************
        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlFiltro.Visible)
            {
                pnlFiltro.Visible = false;
                chkApellidos.Checked = false;
                chkCedula.Checked = false;
                chkNombre.Checked = false;
                chkMatricula.Checked = false;
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

        private void frmBuscarEstudiante_Load(object sender, EventArgs e)
        {
            btnCerrar.Visible = true;
            btnEnviar.Visible = false;
        }

        private void dgvEstudiantes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (opcionBusqueda == Utiles.OpcionBusqueda.BusquedaYEnvio)
            {
                btnCerrar.Visible = false;
                btnEnviar.Visible = true ;
            }
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ejecutarBusqueda();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.RowCount > 0)
            {
                IdEstudianteSeleccionado = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["Id"].Value.ToString());
                this.Close();
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatosEstudiante frm = new frmDatosEstudiante(Utiles.DbItem.Nuevo,0);
            frm.ShowDialog();
            ejecutarBusqueda();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.RowCount > 0)
            {
                try
                {
                    frmDatosEstudiante frm = new frmDatosEstudiante(Utiles.DbItem.Actualizar, Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["Id"].Value.ToString()));
                    frm.ShowDialog();
                    frm.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            ejecutarBusqueda();
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Text = string.Empty;
        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEstudiantes.Columns["accion"].Index && e.RowIndex >= 0)
            {
                if (dgvEstudiantes.RowCount > 0)
                {
                    try
                    {
                        frmDatosEstudiante frm = new frmDatosEstudiante(Utiles.DbItem.Detalle, Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["Id"].Value.ToString()));
                        frm.ShowDialog();
                        frm.Dispose();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        private void dgvEstudiantes_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (opcionBusqueda == Utiles.OpcionBusqueda.BusquedaYEnvio)
            {
                btnEnviar.Visible = true;
                btnCerrar.Visible = false;
            }
           
        }
    }
}
