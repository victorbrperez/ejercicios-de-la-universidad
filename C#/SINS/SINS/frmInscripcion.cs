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
    public partial class frmInscripcion : Form
    {
        public frmInscripcion(Utiles.DbItem v_modo,int v_id_inscripcion)
        {
            InitializeComponent();
            modo = v_modo;
            listadoSecciones = new List<Seccion>();
            switch(modo)
            {
                case Utiles.DbItem.Nuevo:
                    preparaParaNuevo();
                    break;
            }
        }
        Utiles.DbItem modo;
        List<Seccion> listadoSecciones;
        int id_estudiante;

        //*************MIS METODOS*****************************************************************************************************************
        /// <summary>
        /// Prepara el formulario para hacer una nueva inscripcion
        /// </summary>
        void preparaParaNuevo()
        {
            lblTitulo.Text = "Neva inscripción";
        }
        /// <summary>
        /// Verifica si hay conflictos en los horarios
        /// </summary>
        bool verificarConflictosdeHorarios(Seccion p_nuevaSeccion)
        {
            bool r = false;
            foreach (Seccion sec in listadoSecciones)
            {
                if (sec.Id != p_nuevaSeccion.Id)
                {
                    foreach (Horario item in sec.Horarios)
                    {
                        if (sec.Horarios.Count > 0 && p_nuevaSeccion.Horarios.Count > 0)
                        {
                            foreach (Horario h in p_nuevaSeccion.Horarios)
                            {
                                if (item.Dia == h.Dia)
                                {
                                    if (Utiles.hayConflictos(item, h))
                                    {
                                        r = true;
                                    }
                                } 
                            }
                        }
                    }
                }
            }
            return r;
        }
        /// <summary>
        /// Verifica si la seccion que se intenta agregar ya está en el listado
        /// </summary>
        /// <param name="p_nuevaSeccion"></param>
        /// <returns></returns>
        bool verificarSeccionEnListado(Seccion p_nuevaSeccion)
        {
            bool r = false;
            if (listadoSecciones.Count > 0)
            {
                foreach (Seccion item in listadoSecciones)
                {
                    if (item.IdAsignatura == p_nuevaSeccion.IdAsignatura)
                    {
                        r = true;
                    }
                }
            }
            return r;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiante frm = new frmBuscarEstudiante(Utiles.OpcionBusqueda.BusquedaYEnvio);
            Estudiante est = new Estudiante();
            frm.ShowDialog();
            if (frm.IdEstudianteSeleccionado > 0)
            {
                est.Id = frm.IdEstudianteSeleccionado;
                est.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxMatricula.Text = est.Matricula.ToString();
                tbxNombreEstudiante.Text = est.Nombre + " " + est.Apellidos;
                id_estudiante = frm.IdEstudianteSeleccionado;
            }
            frm.Dispose();
        }

        private void btnSeleccionarHorario_Click(object sender, EventArgs e)
        {
            frmBuscarSecciones frm = new frmBuscarSecciones(Utiles.OpcionBusqueda.BusquedaYEnvio);
            frm.ShowDialog();
            if (frm.IdSeccionSelecconada > 0)
            {
                Asignatura asign = new Asignatura();
                Seccion sec = new Seccion();
                sec.Id = frm.IdSeccionSelecconada;
                sec.buscarPorId(Utiles.DbOptionSelect.Basico);
                sec.ObtenerHorarios();
                asign.buscarAsignaturaPorSeccion(frm.IdSeccionSelecconada);
                //
                if (!verificarSeccionEnListado(sec))
                {
                    if (!verificarConflictosdeHorarios(sec))
                    {
                        dgvSeleccion.Rows.Add(asign.Clave, asign.Descripcion, frm.IdSeccionSelecconada.ToString(), asign.Creditos.ToString(), "Horario", sec.Id.ToString());
                        listadoSecciones.Add(sec);

                    }
                    else
                    {
                        MessageBox.Show("No sa a podido agregar la asignatura porque hay conflicto de horario con la selección actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }  
                else
                {
                    MessageBox.Show("La asignatura que intenta agregar ya está en el listado de seleción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }       
            }
            frm.Dispose();
        }

        private void dgvDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnEliminarAsignatura.Enabled = true;
        }

        private void btnEliminarAsignatura_Click(object sender, EventArgs e)
        {
            int id_seccion = Convert.ToInt32(dgvSeleccion.CurrentRow.Cells["IdSeccion"].Value.ToString());
            foreach (DataGridViewRow row in dgvSeleccion.Rows)
            {
                dgvSeleccion.Rows.RemoveAt(dgvSeleccion.CurrentRow.Index);
            }
            //
            for (int i = 0; i < listadoSecciones.Count; i++)
            {
                if (listadoSecciones[i].Id == id_seccion)
                {
                    listadoSecciones.RemoveAt(i);
                }
            }
        }
        private void dgvSeleccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSeleccion.Columns["accion"].Index && e.RowIndex >= 0)
            {
                if (dgvSeleccion.RowCount > 0)
                {
                    try
                    {
                        frmDatosSeccion frm = new frmDatosSeccion(Utiles.DbItem.Detalle, Convert.ToInt32(dgvSeleccion.CurrentRow.Cells["IdSeccion"].Value.ToString()));
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
    }
}