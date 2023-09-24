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
    public partial class frmDatosHorario : Form
    {
        public frmDatosHorario()
        {
            InitializeComponent();
            cbbDias.Items.Insert(0, "Seleccionar");
            cbbDias.SelectedIndex = 0;
        }
        public Horario horarioSeleccionado;
        int id_aula;
        int id_centro;
        //
        public bool validarCampos()
        {
            int c = 0;
            if (string.IsNullOrEmpty(tbxAula.Text) || id_aula == 0)
            {
                c++;
                tbxAula.BackColor = Color.FromArgb(255, 204, 188);
            }
            if (string.IsNullOrEmpty(tbxCentroEducativo.Text) || id_centro == 0)
            {
                c++;
                tbxCentroEducativo.BackColor = Color.FromArgb(255, 204, 188);
            }
            if (cbbDias.SelectedIndex == 0)
            {
                c++;
                cbbDias.BackColor = Color.FromArgb(255, 204, 188); 
            }
            if (c > 0)
            {
                return false;
            }
            else
             return true;
        }
        //
        void asignarDatos()
        {
            Reloj r1 = new Reloj(Convert.ToUInt16(nudHoraInicio.Value),Convert.ToUInt16(nudMinutosInicio.Value));
            Reloj r2 = new Reloj(Convert.ToUInt16(nudHoraFin.Value), Convert.ToUInt16(nudMinutosFIn.Value));
            //
            horarioSeleccionado = new Horario(r1, r2);
            horarioSeleccionado.IdAula = id_aula;
            horarioSeleccionado.IdCentro = id_centro;
            horarioSeleccionado.Dia = cbbDias.SelectedIndex;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (nudHoraFin.Value == nudHoraInicio.Value && nudMinutosFIn.Value == nudMinutosInicio.Value)
                {
                    MessageBox.Show("La hora de inicio no puede ser igual a la hora de finalizar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    asignarDatos();
                    this.Close();
                } 
            }
            else
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnBuscarCentroEducativo_Click(object sender, EventArgs e)
        {
            frmBuscarCentro frm = new frmBuscarCentro(Utiles.OpcionBusqueda.BusquedaYEnvio);
            CentroEducativo centro = new CentroEducativo();
            id_aula = 0;
            tbxAula.Text = string.Empty;
            cbbDias.Enabled = false;
            cbbDias.SelectedIndex = 0;
            frm.ShowDialog();
            if (frm.IdCentroSeleccionado > 0)
            {
                centro.Id = frm.IdCentroSeleccionado;
                centro.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxCentroEducativo.Text = centro.NombreCorto;
                id_centro = frm.IdCentroSeleccionado;
                btnBuscarAula.Enabled = true;
            }
            frm.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            horarioSeleccionado = null;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarAulas frm = new frmBuscarAulas(Utiles.OpcionBusqueda.BusquedaYEnvio);
            Aula aula = new Aula();
            if (id_centro > 0)
            {
                frm.TipoBusqueda = Utiles.OpcionBusqueda.Condicional;
                frm.IdCentro = id_centro;
            }
            frm.ShowDialog();
            if (frm.IdAulaSeleccionada > 0)
            {
                aula.Id = frm.IdAulaSeleccionada;
                aula.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxAula.Text = aula.Codigo;
                id_aula = frm.IdAulaSeleccionada;
                cbbDias.Enabled = true;
            }
            frm.Dispose();
        }

        private void nudHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            nudHoraFin.Minimum = nudHoraInicio.Value;
        }

        private void nudMinutosInicio_ValueChanged(object sender, EventArgs e)
        {
            if (nudHoraInicio.Value == nudHoraFin.Value)
            {
                nudMinutosFIn.Minimum = nudMinutosInicio.Value;
            }
            else
                nudMinutosFIn.Minimum = 0;
        }

        private void nudHoraFin_ValueChanged(object sender, EventArgs e)
        {
            if (nudHoraInicio.Value == nudHoraFin.Value)
            {
                nudMinutosFIn.Minimum = nudMinutosInicio.Value;
            }
            else
                nudMinutosFIn.Minimum = 0;
        }

        private void cbbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDias.SelectedIndex > 0)
            {
                nudHoraInicio.Enabled = true;
                nudHoraFin.Enabled = true;
                nudMinutosFIn.Enabled = true;
                nudMinutosInicio.Enabled = true;
            }
            else
            {
                nudHoraInicio.Enabled = false;
                nudHoraFin.Enabled = false;
                nudMinutosFIn.Enabled = false;
                nudMinutosInicio.Enabled = false;
            }
        }
        //
    }
}
