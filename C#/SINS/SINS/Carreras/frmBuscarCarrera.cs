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
    public partial class frmBuscarCarrera : Form
    {
        public frmBuscarCarrera(Utiles.OpcionBusqueda ob)
        {
            InitializeComponent();
            opcionBusqueda = ob;
            restaurarCuadroDeBussqueda();
            switch(opcionBusqueda)
            {
                case Utiles.OpcionBusqueda.BusquedaYEnvio:
                    btnNuevo.Visible = false;
                    btnEditar.Visible = false;
                    break;
                case Utiles.OpcionBusqueda.Busqueda:
                    restaurarCuadroDeBussqueda();
                    break;
            }

        }
        Utiles.OpcionBusqueda opcionBusqueda;
        public int IdCarreraSeleccionada { get; set; }
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
            dgvCarreras.Rows.Clear();
            Carrera carr = new Carrera();
            List<Carrera> liCarreras = new List<Carrera>();
            liCarreras = carr.Buscar(tbxBusqueda.Text);
            if (liCarreras.Count > 0)
            {
                foreach (Carrera item in liCarreras)
                {
                    dgvCarreras.Rows.Add(item.Id.ToString(),item.Nombre,item.Creditos);
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            IdCarreraSeleccionada = Convert.ToInt32(dgvCarreras.CurrentRow.Cells["Id"].Value.ToString());
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatosCarrera frm = new frmDatosCarrera(Utiles.DbItem.Nuevo, 0);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void dgvCarreras_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (opcionBusqueda == Utiles.OpcionBusqueda.BusquedaYEnvio)
            {
                papararParaEnviar();
            }
            tbxTotalElementos.Text = dgvCarreras.RowCount.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCarreras.RowCount > 0)
            {
                try
                {
                    frmDatosCarrera frm = new frmDatosCarrera(Utiles.DbItem.Actualizar, Convert.ToInt32(dgvCarreras.CurrentRow.Cells["Id"].Value.ToString()));
                    frm.ShowDialog();
                    frm.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Text = string.Empty;
        }
    }
}
