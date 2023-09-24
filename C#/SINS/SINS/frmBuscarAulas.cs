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
    public partial class frmBuscarAulas : Form
    {
        public frmBuscarAulas(Utiles.OpcionBusqueda ob)
        {
            InitializeComponent();
            opcionBusqueda = ob;
            restaurarCuadroDeBussqueda();
            IdCentro = 0;
            TipoBusqueda = Utiles.OpcionBusqueda.Normal;
        }
        //
        Utiles.OpcionBusqueda opcionBusqueda;
        public Utiles.OpcionBusqueda TipoBusqueda { get; set; }
        public int IdAulaSeleccionada { get; set; }
        public int IdCentro { get; set; }
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

        private void dgvAulas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (opcionBusqueda == Utiles.OpcionBusqueda.BusquedaYEnvio)
            {
                papararParaEnviar();
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            IdAulaSeleccionada = Convert.ToInt32(dgvAulas.CurrentRow.Cells["Id"].Value.ToString());
            this.Close();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAulas.Rows.Clear();
            Aula aula = new Aula();
            List<Aula> liAulas = new List<Aula>();
            //
            if (TipoBusqueda == Utiles.OpcionBusqueda.Condicional)
            {
                if(IdCentro > 0)
                    liAulas = aula.BuscarPorCentro(tbxBusqueda.Text, IdCentro);
            }
            else if (TipoBusqueda == Utiles.OpcionBusqueda.Normal)
            {
                liAulas = aula.Buscar(tbxBusqueda.Text);
            }
            //               
            if (liAulas.Count > 0)
            {
                foreach (Aula item in liAulas)
                {
                    dgvAulas.Rows.Add(item.Id.ToString(),item.Codigo,item.Descripcion,item.Capacidad.ToString());
                }
            }
        }

        private void dgvAulas_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (opcionBusqueda == Utiles.OpcionBusqueda.BusquedaYEnvio)
            {
                papararParaEnviar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatosAula frm = new frmDatosAula(Utiles.DbItem.Nuevo,0);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAulas.RowCount > 0)
            {
                try
                {
                    frmDatosAula frm = new frmDatosAula(Utiles.DbItem.Actualizar, Convert.ToInt32(dgvAulas.CurrentRow.Cells["Id"].Value.ToString()));
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
