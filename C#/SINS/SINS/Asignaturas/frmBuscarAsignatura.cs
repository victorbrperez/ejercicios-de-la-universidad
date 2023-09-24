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
    public partial class frmBuscarAsignatura : Form
    {
        public frmBuscarAsignatura(Utiles.OpcionBusqueda ob)
        {
            InitializeComponent();
            opcionBusqueda = ob;
            restaurarCuadroDeBussqueda();
            switch (opcionBusqueda)
            {
                case Utiles.OpcionBusqueda.Busqueda:
                    restaurarCuadroDeBussqueda();
                    break;
            }
        }
        Utiles.OpcionBusqueda opcionBusqueda;
        public int IdAsignaturaSeleccionada { get; set; }
        /// <summary
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
            dgvDatos.Rows.Clear();
            Asignatura asign = new Asignatura();
            List<Asignatura> liAsignaturas;
            liAsignaturas = asign.Buscar(tbxBusqueda.Text);
            if (liAsignaturas.Count > 0)
            {
                foreach (Asignatura item in liAsignaturas)
                {
                    dgvDatos.Rows.Add(item.Id.ToString(), item.Clave,item.Descripcion, item.Creditos);
                }
            }
        }

        private void dgvDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (opcionBusqueda == Utiles.OpcionBusqueda.BusquedaYEnvio)
            {
                papararParaEnviar();
            }
            tbxTotalElementos.Text = dgvDatos.RowCount.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatosAsignatura frm = new frmDatosAsignatura(Utiles.DbItem.Nuevo,0);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.RowCount > 0)
            {
                try
                {
                    frmDatosAsignatura frm = new frmDatosAsignatura(Utiles.DbItem.Actualizar, Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString()));
                    frm.ShowDialog();
                    frm.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            IdAsignaturaSeleccionada = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
            this.Close();

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Text = string.Empty;
        }
    }
}
