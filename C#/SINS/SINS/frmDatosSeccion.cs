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
    public partial class frmDatosSeccion : Form
    {
        public frmDatosSeccion(Utiles.DbItem v_modo,int v_id)
        {
            cambios_realizados = false;
            InitializeComponent();
            modo = v_modo;
            liHorarios = new List<Horario>();
            switch (modo)
            {
                case Utiles.DbItem.Nuevo:
                    prepararParaNuevo();
                    break;
                case Utiles.DbItem.Actualizar:
                    prepararParaModificar();
                    cargarDatos(v_id);
                    break;
                case Utiles.DbItem.Detalle:
                    cargarDatos(v_id);
                    prepararParaSoloVer();
                    break;
            }   
        }
        //
        bool cambios_realizados;
        Seccion seccionActual;
        Utiles.DbItem modo;
        int id_profesor;      
        int id_asignatura;
        List<Horario> liHorarios;
        List<Horario> horariosEnConflictos;

        //
        //****************METODOS MIEMBRO******************************************************************************
        /// <summary>
        /// Valida que no hayan campos vacios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name=""></param>
        /// 
        short validarCamposVacios(ref GroupBox gbx)
        {
            short r = 0;
            foreach (Control ctrl in gbx.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    if (ctrl.Tag.ToString() == "*")
                    {
                        if (string.IsNullOrEmpty(ctrl.Text))
                        {
                            r++;
                            ctrl.BackColor = Color.FromArgb(255, 204, 188);
                        }
                    }
                }            
            }
            //
            if (!(dgvHorarios.RowCount  > 0))
            {
                r++;
                dgvHorarios.BackgroundColor = Color.FromArgb(255, 204, 188);
            }
            return r;
        }
        /// <summary>
        /// Metodo que prepara el formulario para registrar un nuevo elemento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name=""></param>
        /// 
        void prepararParaNuevo()
        {
            seccionActual = new Seccion();
            tbxId.Text = "Nueva";
            lblTitulo.Text = "Nueva sección";
            modo = Utiles.DbItem.Nuevo;
        }
        /// <summary>
        /// Prepara el formulario para modificar datos
        /// </summary>
        void prepararParaModificar()
        {
            lblTitulo.Text = "Modificar datos de la sección";
            modo = Utiles.DbItem.Actualizar;
        }
        /// <summary>
        /// Prepara el formulario para ver los datos en modo solo lectura
        /// </summary>
        void prepararParaSoloVer()
        {
            lblTitulo.Text = "Datalle de la sección";
            btnGuardar.Enabled = false;
            btnBuscarProfesor.Enabled = false;
            btnEliminarHoario.Enabled = false;
            btnSeleccionarHorario.Enabled = false;
            btnBuscarAsignatura.Enabled = false;
            gbxDatos.BackColor = Color.White;
            gbxHorario.BackColor = Color.White;
            //
            foreach (Control item in gbxDatos.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.ForeColor = Color.FromArgb(67, 158, 220);
                    ((TextBox)item).ReadOnly = true;
                    ((TextBox)item).BackColor = Color.WhiteSmoke;
                }
                if (item.GetType() == typeof(NumericUpDown))
                {
                    item.ForeColor = Color.FromArgb(67, 158, 220);
                    item.Enabled = false;
                }
            }
            //
        }
        /// <summary>
        /// Carga todos los datos de la seccion en el formulario
        /// </summary>
        /// <param name="id_seccion"></param>
        void cargarDatos(int id_seccion)
        {
            seccionActual = new Seccion();
            Asignatura asign = new Asignatura();
            Profesor prof = new Profesor();
            //
            seccionActual.Id = id_seccion;
            if (seccionActual.buscarPorId(Utiles.DbOptionSelect.Todo))
            {
                prof.Id = seccionActual.IdProfesor;
                asign.Id = seccionActual.IdAsignatura;
                prof.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                asign.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                //
                tbxId.Text = seccionActual.Id.ToString();
                tbxAsignatura.Text = asign.Clave;
                tbxProfesor.Text = prof.Nombre + " " + prof.Apellidos;
                id_asignatura = seccionActual.IdAsignatura;
                id_profesor = seccionActual.IdProfesor;
                tbxObservaciones.Text = seccionActual.Observaciones;
                nudCapacidad.Value = Convert.ToDecimal(seccionActual.Capacidad);
                nudNumero.Value = Convert.ToDecimal(seccionActual.Numero);
                //
                seccionActual.ObtenerHorarios();
                liHorarios = seccionActual.Horarios;
                //
                if (seccionActual.Horarios.Count > 0)
                {
                    foreach (Horario item in seccionActual.Horarios)
                    {
                        Aula a = new Aula();
                        CentroEducativo ce = new CentroEducativo();
                        a.Id = item.IdAula;
                        ce.Id = item.IdCentro;
                        a.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                        ce.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                        //
                        dgvHorarios.Rows.Add(Utiles.obtenerDia(item.Dia), item.HoraInicio.toAmPm(), item.HoraFin.toAmPm(), ce.NombreCorto, a.Codigo);
                    }
                }
                //
                cambios_realizados = false;
            }    
        }
        /// <summary>
        /// Metodo que asigna los valores de los campos al objeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void asignarDatos()
        {
            if (id_profesor > 0 && id_asignatura > 0)
            {
                seccionActual.IdProfesor = id_profesor;
                seccionActual.Capacidad = Convert.ToInt32(nudCapacidad.Value);
                seccionActual.Numero = Convert.ToInt32(nudNumero.Value);
                seccionActual.IdAsignatura = id_asignatura;
                seccionActual.Observaciones = tbxObservaciones.Text;
                seccionActual.Horarios = liHorarios;
            } 
        }
        /// <summary>
        /// Verifica si han conflictos de horarios
        /// </summary>
        /// <param name="parmNuevoHorario"></param>
        /// <returns></returns>
        bool verificarConflictosHorarios(Horario parmNuevoHorario)
        {
            bool r = false;
            if (liHorarios.Count > 0 && parmNuevoHorario != null)
            {
                foreach (Horario item in liHorarios)
                {
                    if (item.Dia == parmNuevoHorario.Dia && item.IdAula == parmNuevoHorario.IdAula && item.IdCentro == parmNuevoHorario.IdCentro)
                    {
                        if (Utiles.hayConflictos(parmNuevoHorario,item))
                        {
                            r = true;
                        }
                    }
                }
            }    
            return r;
        }
        /// <summary>
        /// Verifica si han conflictos de horarios
        /// </summary>
        /// <param name="parmNuevoHorario"></param>
        /// <returns></returns>
        bool verificarDiaAulaProfesor(Horario parmNuevoHorario)
        {
            bool r = false;
            if (liHorarios.Count > 0 && parmNuevoHorario != null)
            {
                foreach (Horario item in liHorarios)
                {
                    if (item.Dia == parmNuevoHorario.Dia && item.IdAula != parmNuevoHorario.IdAula)
                    {
                        if (Utiles.hayConflictos(parmNuevoHorario, item))
                        {
                            r = true;
                        }
                    }
                }
            }
            return r;
        }
        /// <summary>
        /// Agregar un horario a la lista y al DatagridView siempre y cuando no haya conflictos
        /// </summary>
        /// <param name="vHorario"></param>
        bool agregarHorario(Horario vHorario)
        {
            bool r = false;
            if (vHorario != null)
            {
                Aula aula = new Aula();
                aula.Id = vHorario.IdAula;
                aula.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                //
                CentroEducativo centro = new CentroEducativo();
                centro.Id = vHorario.IdCentro;
                centro.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                //
                if (!verificarConflictosHorarios(vHorario))
                {
                    liHorarios.Add(vHorario);
                    dgvHorarios.Rows.Add(Utiles.obtenerDia(vHorario.Dia), vHorario.HoraInicio.toAmPm(), vHorario.HoraFin.toAmPm(), centro.NombreCorto, aula.Codigo);
                    r = true;
                }
                else
                    MessageBox.Show("No se ha podido agregar el horario porque existen conflictos", "Atencion");
            }
            return r;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool guardarTodo()
        {
            if (0 == validarCamposVacios(ref gbxDatos))
            {
                asignarDatos();

            }
            return true;
        }
        /// <summary>
        /// Limita la capacidad maxima de la seccion en base al la capacidad del aula de mayor capacidad de los horarios seleccionadas
        /// </summary>
        void determinarCapacidadMaxima()
        {
            int maximo = 0;
            if (liHorarios.Count > 0)
            {
                foreach (Horario item in liHorarios)
                {
                    Aula a = new Aula();
                    a.Id = item.IdAula;
                    a.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                    //
                    if (maximo == 0)
                        maximo = a.Capacidad;
                    //
                    if (a.Capacidad < maximo)
                        maximo = a.Capacidad;
                }
                nudCapacidad.Maximum = Convert.ToDecimal(maximo);
            }
            else
                nudCapacidad.Maximum = 150;
            
        }
        //**************************************************************************************************************
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool repetir = true;
            //
            while (repetir)
            {
                frmDatosHorario frm = new frmDatosHorario();
                frm.ShowDialog();
                if (frm.horarioSeleccionado != null)
                {
                    Aula aula = new Aula();
                    aula.Id = frm.horarioSeleccionado.IdAula;
                    aula.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                    //
                    CentroEducativo centro = new CentroEducativo();
                    centro.Id = frm.horarioSeleccionado.IdCentro;
                    centro.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                    //
                    if (aula.Capacidad >= Convert.ToInt32(nudCapacidad.Value))
                    {
                        if (!verificarConflictosHorarios(frm.horarioSeleccionado))
                        {
                            if (!verificarDiaAulaProfesor(frm.horarioSeleccionado))
                            {
                                liHorarios.Add(frm.horarioSeleccionado);
                                dgvHorarios.Rows.Add(Utiles.obtenerDia(frm.horarioSeleccionado.Dia), frm.horarioSeleccionado.HoraInicio.toAmPm(), frm.horarioSeleccionado.HoraFin.toAmPm(), centro.NombreCorto, aula.Codigo);
                                repetir = false;
                            }
                            else
                            {
                                MessageBox.Show("Está intentando asignar al mismo profesor diferentes aulas en horarios en conflictos", "Atención");
                                repetir = true;
                            }   
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido agregar el horario porque existen conflictos", "Atención");
                            repetir = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido agregar el horario, la capacidad actual de la sección \nes superior a la capacidad del aula selecionada.\nCambie el aula o ajuste la capacidad de la sección", "Atención");
                        repetir = true;
                    }
                }
                if (frm.horarioSeleccionado == null)
                    repetir = false;
                frm.Dispose();
            }
            determinarCapacidadMaxima();
        }

        private void dgvHorarios_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            cambios_realizados = true;
            btnEliminarHoario.Enabled = true;
            dgvHorarios.BackgroundColor = Color.White;
        }

        private void btnEliminarHoario_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Seguro que desea quitar este horario","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                if (dgvHorarios.Rows.Count > 0)
                {
                    for(int i = 0; i < liHorarios.Count;i++)
                    {
                        Aula aula = new Aula();
                        aula.Id = liHorarios[i].IdAula;
                        aula.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                        //
                        CentroEducativo centro = new CentroEducativo();
                        centro.Id = liHorarios[i].IdCentro;
                        centro.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                        //
                        if (Utiles.obtenerDia(liHorarios[i].Dia) == dgvHorarios.CurrentRow.Cells["Dia"].Value.ToString() && liHorarios[i].HoraInicio.toAmPm() == dgvHorarios.CurrentRow.Cells["HoraInicio"].Value.ToString()
                            && liHorarios[i].HoraFin.toAmPm() == dgvHorarios.CurrentRow.Cells["HoraFin"].Value.ToString() && centro.NombreCorto == dgvHorarios.CurrentRow.Cells["Centro"].Value.ToString() && aula.Codigo == dgvHorarios.CurrentRow.Cells["Aula"].Value.ToString())
                        {
                            liHorarios.RemoveAt(i);
                        }
                    }
                    dgvHorarios.Rows.RemoveAt(dgvHorarios.CurrentRow.Index);
                }
                if (dgvHorarios.Rows.Count == 0)
                {
                    btnEliminarHoario.Enabled = false;
                }
            }
            determinarCapacidadMaxima();  
        }
        //
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios(ref gbxDatos) == 0)
            {
                asignarDatos();
                ParError log = null;
                //
                if (modo == Utiles.DbItem.Nuevo)
                {
                    log = seccionActual.Registrar();
                    if (!log.Error)
                    {
                        MessageBox.Show("Se ha creado una nueva sección", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cambios_realizados = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(log.Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        horariosEnConflictos = seccionActual.HorariosEnConflictos;
                        if (horariosEnConflictos != null)
                            lnkLbVerConflictos.Visible = true;
                    }
                }
                else if (modo == Utiles.DbItem.Actualizar)
                {
                    log = seccionActual.Actualizar();
                    if (!log.Error)
                    {
                        MessageBox.Show("Se han actualizado los datos de la sección", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cambios_realizados = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(log.Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        horariosEnConflictos = seccionActual.HorariosEnConflictos;
                        if (horariosEnConflictos != null)
                            lnkLbVerConflictos.Visible = true;
                    }
                }                
            }
            else
            {
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        //
        private void btnBuscarProfesor_Click(object sender, EventArgs e)
        {
            frmBuscarProfesor frm = new frmBuscarProfesor(Utiles.OpcionBusqueda.BusquedaYEnvio);
            Profesor prof = new Profesor();
            frm.ShowDialog();
            if (frm.IdProfesorSeleccionado > 0)
            {
                prof.Id = frm.IdProfesorSeleccionado;
                prof.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxProfesor.Text = prof.Nombre + " " + prof.Apellidos;
                id_profesor = frm.IdProfesorSeleccionado;
            }
            frm.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscarAsignatura frm = new frmBuscarAsignatura(Utiles.OpcionBusqueda.BusquedaYEnvio);
            Asignatura asn = new Asignatura();
            frm.ShowDialog();
            if (frm.IdAsignaturaSeleccionada > 0)
            {
                asn.Id = frm.IdAsignaturaSeleccionada;
                asn.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxAsignatura.Text = asn.Clave;
                id_asignatura = frm.IdAsignaturaSeleccionada;
            }
            frm.Dispose();
        }
        private void nudCapacidad_ValueChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
        }

        private void tbxProfesor_TextChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
            tbxProfesor.BackColor = Color.WhiteSmoke;
        }

        private void tbxAsignatura_TextChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
            tbxAsignatura.BackColor = Color.WhiteSmoke;
        }

        private void dgvHorarios_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            cambios_realizados = true;
        }

        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
        }

        private void tbxObservaciones_TextChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
        }

        private void frmDatosSeccion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambios_realizados)
            {
                if (DialogResult.No == MessageBox.Show("Ha hecho modificaciones en el formulario actual, ¿Desea descartarlas ?","Atencion",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    e.Cancel = true;
                }
            }
        }

        private void dgvHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkLbVerConflictos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmVerSeccionesEnConflicto frm = new frmVerSeccionesEnConflicto(horariosEnConflictos);
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
