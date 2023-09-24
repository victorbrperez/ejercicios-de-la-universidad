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
    public partial class frmBuscarCentro : Form
    {
        public frmBuscarCentro(Utiles.OpcionBusqueda ob)
        {
            InitializeComponent();
            restaurarCuadroDeBussqueda();
            opcionBusqueda = ob;
        }
        Utiles.OpcionBusqueda opcionBusqueda;
        public int IdCentroSeleccionado { get; set; }
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
        /// <summary>
        /// Devuelve el cuadro de busqueda a su estado normal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void restaurarCuadroDeBussqueda()
        {
            btnCerrar.Visible = true;
            btnEnviar.Visible = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCentros.Rows.Clear();
            CentroEducativo ce = new CentroEducativo();
            List<CentroEducativo> liCentro = new List<CentroEducativo>();
            liCentro = ce.buscar(tbxBusqueda.Text);
            if (liCentro.Count > 0)
            {
                foreach (CentroEducativo item in liCentro)
                {
                    dgvCentros.Rows.Add(item.Id.ToString(),item.NombreCorto,item.NombreLargo);
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            IdCentroSeleccionado = Convert.ToInt32(dgvCentros.CurrentRow.Cells["Id"].Value.ToString());
            this.Close();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatosCentro frm = new frmDatosCentro(Utiles.DbItem.Nuevo,0);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void dgvCentros_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (opcionBusqueda == Utiles.OpcionBusqueda.BusquedaYEnvio)
            {
                papararParaEnviar();
            }
            tbxTotalElementos.Text = dgvCentros.RowCount.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCentros.RowCount > 0)
            {
                try
                {
                    frmDatosCentro frm = new frmDatosCentro(Utiles.DbItem.Actualizar, Convert.ToInt32(dgvCentros.CurrentRow.Cells["Id"].Value.ToString()));
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
    }
}
