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
using SINS.Secciones;

namespace SINS
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion(Utiles.DbItem v_modo,int v_id_inscripcion)
        {
            InitializeComponent();
            modo = v_modo;
            cambios_realizados = false;
            listadoSecciones = new List<Seccion>();
            inscripcionActual = new Inscripcion();
            switch(modo)
            {
                case Utiles.DbItem.Nuevo:
                    preparaParaNuevo();
                    break;
            }
        }
        bool cambios_realizados;
        Inscripcion inscripcionActual;
        Utiles.DbItem modo;
        List<Seccion> listadoSecciones;
        int id_estudiante;
        double deuda;

        //*************MIS METODOS*****************************************************************************************************************
        /// <summary>
        /// Prepara el formulario para hacer una nueva inscripcion
        /// </summary>
        void preparaParaNuevo()
        {
            lblTitulo.Text = "Inscripción de asignaturas";
        }
        /// <summary>
        /// Comprueba que los controles tengan los datos adecuados para proceder al registro
        /// </summary>
        /// <returns></returns>
        bool validarControles()
        {
            bool r = true;
            //
            if (string.IsNullOrEmpty(tbxMatricula.Text) && id_estudiante == 0)
            {
                r = false;
                tbxMatricula.BackColor = Color.FromArgb(255, 204, 188);
                tbxNombreEstudiante.BackColor =  Color.FromArgb(255, 204, 188);
            }
            //    
            if (listadoSecciones.Count == 0 && dgvSeleccion.RowCount == 0)
            {
                r = false;
                dgvSeleccion.BackgroundColor = Color.FromArgb(255, 204, 188);
            }         
            return r;
        }
        /// <summary>
        /// 
        /// </summary>
        void actualizarTotales()
        {
            int total_cerditos = 0;
            foreach (DataGridViewRow row in dgvSeleccion.Rows)
            {
                total_cerditos += Convert.ToInt32(row.Cells["Creditos"].Value.ToString());
            }
            tbxTotalCreditos.Text = total_cerditos.ToString();
            tbxTotalElementos.Text = dgvSeleccion.RowCount.ToString();
        }
        /// <summary>
        /// Asigna los datos tomados de los controles a la inscripcion actual
        /// </summary>
        void asignarDatos()
        {
            inscripcionActual.IdEstudiante = id_estudiante;
            List<DetalleInscripcion> liDinsc = new List<DetalleInscripcion>();
            foreach (Seccion item in listadoSecciones)
            {
                DetalleInscripcion di = new DetalleInscripcion();
                di.IdSeccion = item.Id;
                liDinsc.Add(di);
            }
            inscripcionActual.DetallesDeInscripcion = liDinsc;
            if (modo ==  Utiles.DbItem.Actualizar)
            {
                inscripcionActual.Id = id_estudiante;
                inscripcionActual.buscarIdPorEstudiante();
            }
        }
        /// <summary>
        /// Verifica si hay conflictos en los horarios
        /// </summary>
        /// <param name="p_nuevaSeccion"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Verifica si hay alguna seccion llena en la seleccion
        /// </summary>
        /// <returns></returns>
        bool verificarSeccionesLlenas()
        {
            List<Seccion> liSeccionesLlenas = new List<Seccion>();
            //
            bool r = false;
            if (listadoSecciones.Count > 0)
            {
                foreach (Seccion item in listadoSecciones)
                {
                    int cant_inscritos = item.ObtenerCantidadInscritos();
                    if (!(cant_inscritos < item.Capacidad))
                    {
                        liSeccionesLlenas.Add(item);
                        r = true;
                    }
                }
            }
            //
            if (liSeccionesLlenas.Count > 0)
            {
                frmSeccionesLlenas frm = new frmSeccionesLlenas(liSeccionesLlenas);
                frm.ShowDialog();
                frm.Dispose();
            }
            return r;
        }
        /// <summary>
        /// Calcula la cantidad de dinero que debe pagar el estudiante por la inscripcion.
        /// </summary>
        void calcularCantidadAPagar()
        {
            Estudiante e = new Estudiante();
            TipoEstudiante te = new TipoEstudiante();
            
            if (id_estudiante >0)
            {
                e.Id = id_estudiante;
                e.buscarDatosPorId(Utiles.DbOptionSelect.Todo);
                te.Id = e.TipoEstudiante;
                te.buscarDatosPorId(Utiles.DbOptionSelect.Todo);
                deuda = (double)te.CostoInscripcion;
                foreach (DataGridViewRow row in dgvSeleccion.Rows)
                {
                    deuda += Convert.ToDouble(row.Cells["Creditos"].Value.ToString()) * te.CostoCredito;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_seccion"></param>
        void agregarSecciones(int id_seccion)
        {
            if (id_seccion > 0)
            {
                Asignatura asign = new Asignatura();
                Seccion sec = new Seccion();
                sec.Id = id_seccion;
                sec.buscarPorId(Utiles.DbOptionSelect.Basico);
                sec.ObtenerHorarios();
                asign.buscarAsignaturaPorSeccion(id_seccion);
                //
                if (!verificarSeccionEnListado(sec))
                {
                    if (!verificarConflictosdeHorarios(sec))
                    {
                        dgvSeleccion.Rows.Add(asign.Clave, asign.Descripcion,id_seccion.ToString(), asign.Creditos.ToString(), "Ver horario", sec.Id.ToString());
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
        }
        void cargarEstudiante(int v_id_estudiante)
        {
            Estudiante est = new Estudiante();
            dgvSeleccion.Rows.Clear();
            listadoSecciones.Clear();
            //
            if (v_id_estudiante > 0)
            {
                est.Id = v_id_estudiante;
                est.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxMatricula.Text = est.Matricula.ToString();
                tbxNombreEstudiante.Text = est.Nombre + " " + est.Apellidos;
                id_estudiante = v_id_estudiante;

                List<Seccion> liSecciones = new List<MisClases.Seccion>();
                inscripcionActual.IdEstudiante = v_id_estudiante;
                liSecciones = inscripcionActual.buscarSeccionesPorEstudiante();
                //
                if (est.Balance != 0)
                {
                    if (liSecciones.Count > 0)
                    {
                        foreach (Seccion item in liSecciones)
                        {
                            agregarSecciones(item.Id);
                        }
                        cambios_realizados = false;
                        modo = Utiles.DbItem.Actualizar;
                        lblTitulo.Text = "Inscripción de asignaturas";
                    }
                }
            }
        }
        //************************************************************************************************************************
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        cargarEstudiante(est.Id);
                    }
                }
                else
                {
                    frmBuscarEstudiante frm = new frmBuscarEstudiante(Utiles.OpcionBusqueda.BusquedaYEnvio);
                    frm.ShowDialog();
                    cargarEstudiante(frm.IdEstudianteSeleccionado);
                    frm.Dispose();
                }
                tbxMatricula.Focus();
            }
            else
            {
                frmBuscarEstudiante frm = new frmBuscarEstudiante(Utiles.OpcionBusqueda.BusquedaYEnvio);
                frm.ShowDialog();
                cargarEstudiante(frm.IdEstudianteSeleccionado);
                frm.Dispose();
            }
        }

        private void btnSeleccionarHorario_Click(object sender, EventArgs e)
        {
            frmBuscarSecciones frm = new frmBuscarSecciones(Utiles.OpcionBusqueda.BusquedaYEnvio);
            frm.ShowDialog();
            agregarSecciones(frm.IdSeccionSelecconada);
            frm.Dispose();
            calcularCantidadAPagar();
        }

        private void dgvDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnEliminarAsignatura.Enabled = true;
            dgvSeleccion.BackgroundColor = Color.White;
            actualizarTotales();
            cambios_realizados = true;
            this.AcceptButton = this.btnGuardar;
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarControles())
            {
                ParError log = new ParError();
                asignarDatos();
                calcularCantidadAPagar();
                if (modo == Utiles.DbItem.Nuevo)
                {
                    if (!verificarSeccionesLlenas())
                    {
                        log = inscripcionActual.Registrar();
                        if (!log.Error)
                        {
                            Estudiante est = new Estudiante();
                            est.Id = id_estudiante;
                            est.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                            est.Balance = deuda;
                            est.ActualizarBalance();
                            //
                            MessageBox.Show("Se ha realizado la inscripción con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cambios_realizados = false;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(log.Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } 
                }
                else if (modo == Utiles.DbItem.Actualizar)
                {
                    log = inscripcionActual.Actualizar();
                    if (!log.Error)
                    {
                        Estudiante est = new Estudiante();
                        est.Id = id_estudiante;
                        est.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                        est.Balance = deuda;
                        est.ActualizarBalance();
                        //
                        MessageBox.Show("Se han actualizado los horarios de la inscripción con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cambios_realizados = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(log.Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
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
            tbxMatricula.BackColor = Color.White;
            tbxNombreEstudiante.BackColor = Color.WhiteSmoke;
            cambios_realizados = true;
        }

        private void dgvSeleccion_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            actualizarTotales();
            cambios_realizados = true;
        }

        private void frmInscripcion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambios_realizados)
            {
                if (DialogResult.No == MessageBox.Show("Ha hecho modificaciones en el formulario actual, ¿Desea descartarlas ?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    e.Cancel = true;
                }
            }
        }
    }
}