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
    public partial class frmBuscarTipoEstudiante : Form
    {
        public frmBuscarTipoEstudiante(Utiles.OpcionBusqueda ob)
        {
            InitializeComponent();
            opcionBusqueda = ob;
            //restaurarCuadroDeBussqueda();
            switch (opcionBusqueda)
            {
                case Utiles.OpcionBusqueda.BusquedaYEnvio:
                    btnNuevo.Visible = false;
                    btnEditar.Visible = false;
                    break;
                case Utiles.OpcionBusqueda.Busqueda:
                   // restaurarCuadroDeBussqueda();
                    break;
            }
        }
        Utiles.OpcionBusqueda opcionBusqueda;
        public int IdTipoEstudianteSeleccionado { get; set; }
        //**********************************************************************************************************
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvTiposEstudiantes.Rows.Clear();
            TipoEstudiante te = new TipoEstudiante();
            List<TipoEstudiante> liTiposEstudiantes;
            liTiposEstudiantes = te.Buscar(tbxBusqueda.Text);
            if (liTiposEstudiantes.Count > 0)
            {
                foreach (TipoEstudiante item in liTiposEstudiantes)
                {
                    dgvTiposEstudiantes.Rows.Add(item.Id,item.Titulo,item.CostoCredito.ToString(),item.CostoInscripcion.ToString());
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatosTipoEstudiante frm = new frmDatosTipoEstudiante(Utiles.DbItem.Nuevo,0);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvTiposEstudiantes.RowCount > 0)
            {
                try
                {
                    frmDatosCarrera frm = new frmDatosCarrera(Utiles.DbItem.Actualizar, Convert.ToInt32(dgvTiposEstudiantes.CurrentRow.Cells["Id"].Value.ToString()));
                    frm.ShowDialog();
                    frm.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void dgvTiposEstudiantes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tbxTotalElementos.Text = dgvTiposEstudiantes.RowCount.ToString();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Text = string.Empty;
        }
    }
}
