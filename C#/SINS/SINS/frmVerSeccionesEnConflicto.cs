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
    public partial class frmVerSeccionesEnConflicto : Form
    {
        public frmVerSeccionesEnConflicto(List<Horario> liHorarios)
        {
            InitializeComponent();
            if (liHorarios.Count > 0)
            {
                foreach (Horario item in liHorarios)
                {
                    Seccion sec = new Seccion();
                    Asignatura asig = new Asignatura();
                    Aula a = new Aula();
                    CentroEducativo ce = new CentroEducativo();
                    a.Id = item.IdAula;
                    a.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                    sec.Id = item.IdSeccion;
                    sec.buscarPorId(Utiles.DbOptionSelect.Basico);
                    asig.Id = sec.IdAsignatura;
                    asig.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                    ce.Id = item.IdCentro;
                    ce.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                    //
                    dgvHorarios.Rows.Add(asig.Clave, sec.Numero, ce.NombreCorto, a.Codigo, Utiles.obtenerDia(item.Dia), item.HoraInicio.toAmPm(), item.HoraFin.toAmPm());
                }
            }         
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSeleccionarHorario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
