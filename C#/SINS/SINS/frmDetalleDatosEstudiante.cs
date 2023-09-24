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
    public partial class frmDetalleDatosEstudiante : Form
    {
        public frmDetalleDatosEstudiante(int id_estudiante)
        {
            InitializeComponent();
            estudianteActual = new Estudiante();
            cargarDatos(id_estudiante);

        }
        Estudiante estudianteActual;
        void cargarDatos(int Id)
        {
            estudianteActual.Id = Id;
            Carrera carrera = new Carrera();
            CentroEducativo ce = new CentroEducativo();
            estudianteActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo);
            //
            lblMatricula.Text = estudianteActual.Matricula.ToString();
            lblNombre.Text = estudianteActual.Nombre;
            lblApellidos.Text = estudianteActual.Apellidos;
            lblCedula.Text = estudianteActual.Cedula;
            lblTelefonoCasa.Text = estudianteActual.TelefonoCasa;
            lblTelefonoMovil.Text = estudianteActual.TelefonoMovil;
            lblSexo.Text = estudianteActual.Sexo;
            //
            lblCorreo.Text = estudianteActual.Correo;
            lblDireccion.Text = estudianteActual.Direccion;
            lblEstadoCivil.Text = estudianteActual.EstadoCivil;
            //
            /*
            foreach (TipoEstudiante item in tiposEstudiantes)
            {
                if (item.Id == estudianteActual.TipoEstudiante)
                {
                    cbbTipoEstudiante.Text = item.Titulo;
                }
            }*/
            //
            carrera.Id = estudianteActual.Carrera;
            ce.Id = estudianteActual.CentroEducativo;
            if (carrera.buscarDatosPorId(Utiles.DbOptionSelect.Basico))
            {
                lblCarrera.Text = carrera.Nombre;
            }
            //
            if (ce.buscarDatosPorId(Utiles.DbOptionSelect.Basico))
            {
                lblCentroEducativo.Text = ce.NombreCorto;
            }
            lblFechaNacimiento.Text = estudianteActual.FechaNacimiento.Date.ToShortDateString();
            tbxObservaciones.Text = estudianteActual.Observaciones;

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
