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
    public partial class frmCaja : Form
    {
        public frmCaja()
        {
            InitializeComponent();
            estudianteActual = new Estudiante();
        }
        Estudiante estudianteActual;
        /// <summary>
        /// 
        /// </summary>
        void reestablecerControles()
        {
            tbxDevuelta.Text = "$0.00";
            tbxMontoAPagar.Text = "$0.00";
            tbxPagarCon.Text = "0.00";
            tbxNombreEstudiante.Text = string.Empty;
            tbxMatricula.Text = string.Empty;
            estudianteActual = new Estudiante();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v_id_estudiante"></param>
        void cargarCuentaEstudiante(int v_id_estudiante)
        {
            if (v_id_estudiante > 0)
            {
                estudianteActual.Id = v_id_estudiante;
                estudianteActual.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxNombreEstudiante.Text = estudianteActual.Nombre + " " + estudianteActual.Apellidos;
                tbxMatricula.Text = estudianteActual.Matricula.ToString();
                tbxMontoAPagar.Text = estudianteActual.Balance.ToString("C");
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();
            if (!string.IsNullOrEmpty(tbxMatricula.Text))
            {
                est.Matricula = Convert.ToInt32(tbxMatricula.Text);
                if (est.buscarDatosPorMatricula())
                {
                    if (est.Id > 0)
                    {
                        cargarCuentaEstudiante(est.Id);
                    }
                }
                else
                {
                    frmBuscarEstudiante frm = new frmBuscarEstudiante(Utiles.OpcionBusqueda.BusquedaYEnvio);
                    frm.ShowDialog();
                    cargarCuentaEstudiante(frm.IdEstudianteSeleccionado);
                    frm.Dispose();
                }
                tbxMatricula.Focus();
            }
            else
            {
                frmBuscarEstudiante frm = new frmBuscarEstudiante(Utiles.OpcionBusqueda.BusquedaYEnvio);
                frm.ShowDialog();
                cargarCuentaEstudiante(frm.IdEstudianteSeleccionado);
                frm.Dispose();
            }
        }
        private void tbxPagarCon_MouseClick(object sender, MouseEventArgs e)
        {
            tbxPagarCon.SelectAll();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxPagarCon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double devuelta = 0;
                if (Convert.ToDouble(tbxPagarCon.Text) >= estudianteActual.Balance )
                {
                    devuelta = Convert.ToDouble(tbxPagarCon.Text) - estudianteActual.Balance;
                    tbxDevuelta.Text = devuelta.ToString("C");

                    btnCobrar.Enabled = true;
                }   
                else
                {
                    btnCobrar.Enabled = false;
                    tbxDevuelta.Text = "$0.00";
                }           
            }
            catch (FormatException)
            {
                btnCobrar.Enabled = false;
                tbxPagarCon.Text = "0.00";
                tbxDevuelta.Text = "0.00";
            }
        }

        private void tbxMontoAPagar_TextChanged(object sender, EventArgs e)
        {
            tbxPagarCon.ReadOnly = false;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Pago pg = new Pago();
            pg.IdEstudiante = estudianteActual.Id;
            estudianteActual.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
            pg.CantidadPagada = estudianteActual.Balance;
            estudianteActual.Balance = 0;
            //
            if (pg.Registrar() && estudianteActual.ActualizarBalance())
            {
                MessageBox.Show("Pago realizado con exito","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                reestablecerControles();
            }
            else
                MessageBox.Show("No se ha podido realizar el pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbxMatricula_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(tbxMatricula.Text);
            }
            catch (FormatException)
            {
                tbxMatricula.Text = string.Empty;
            }
        }
    }
}
