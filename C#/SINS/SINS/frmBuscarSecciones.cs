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
    public partial class frmBuscarSecciones : Form
    {
        public frmBuscarSecciones(Utiles.OpcionBusqueda ob)
        {
            InitializeComponent();
            filaSeleccionada = new DataGridViewRow();
            opcionBusqueda = ob;
            btnEnviar.Visible = false;
            btnCerrar.Visible = true;
        }
        Utiles.OpcionBusqueda opcionBusqueda;
        public int IdSeccionSelecconada { get; set; }
        public DataGridViewRow filaSeleccionada;
        //***************MIS METODOS**********************************************************************************************************
        /// <summary>
        /// Metodo que prepara el cuadro de busqueda para enviar un dato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void papararParaEnviar()
        {
            btnCerrar.Visible = false;
            btnEnviar.Visible = true;
        }
        //**************************************************************************************************************************************
        //
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
            Seccion sec = new Seccion();
            DataTable dt = sec.buscarAsignaturas(tbxBusqueda.Text);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvDatos.Rows.Add(row["Clave"].ToString(), row["Descripcion"].ToString(), row["Seccion"].ToString(), row["Creditos"].ToString(), "Horario", row["IdSeccion"].ToString());
                    }
                }
            }
            tbxTotalElementos.Text = dgvDatos.RowCount.ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatosSeccion frm = new frmDatosSeccion(Utiles.DbItem.Nuevo, 0);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Text = string.Empty;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            IdSeccionSelecconada = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdSeccion"].Value.ToString());
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.RowCount > 0)
            {
                try
                {
                    frmDatosSeccion frm = new frmDatosSeccion(Utiles.DbItem.Actualizar, Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdSeccion"].Value.ToString()));
                    frm.ShowDialog();
                    frm.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDatos.Columns["accion"].Index && e.RowIndex >= 0)
            {
                if (dgvDatos.RowCount > 0)
                {
                    try
                    {
                        frmDatosSeccion frm = new frmDatosSeccion(Utiles.DbItem.Detalle, Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdSeccion"].Value.ToString()));
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

        private void dgvDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (opcionBusqueda == Utiles.OpcionBusqueda.BusquedaYEnvio)
            {
                btnCerrar.Visible = false;
                btnEnviar.Visible = true;
            }
        }
    }
}
