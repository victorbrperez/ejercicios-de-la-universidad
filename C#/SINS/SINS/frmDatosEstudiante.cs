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
    public partial class frmDatosEstudiante : Form
    {
        public frmDatosEstudiante(Utiles.DbItem tarea, int id_estudiante)
        {
            InitializeComponent();
            estudianteActual = new Estudiante();
            estudianteActual.Id = id_estudiante;
            Tarea = tarea;
        }
        //******PROPIEDADES Y VARIABLES MIEMBRO****************************************************************
        Estudiante estudianteActual;
        List<TipoEstudiante> tiposEstudiantes;
        bool cambios_realizados;
        Utiles.DbItem Tarea;
        //*****************************************************************************************************
        //*****METODOS MIEMBRO*********************************************************************************
        /// <summary>
        /// Comprueba si hay algun campo con datos en los formularios
        /// </summary>
        /// <returns></returns>
        short validarCamposVacios(ref GroupBox gbx)
        {
            short r = 0;
            foreach (Control ctrl in gbx.Controls)
            {
                if(ctrl.GetType()== typeof(TextBox))
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
            if (!mskTbxCedula.MaskFull)
            {
                r++;
                mskTbxCedula.BackColor = Color.FromArgb(255, 204, 188);
            }
            if (rbtnHombre.Checked == false && rbtnMujer.Checked == false)
            {
                r++;
                gbxSexo.BackColor = Color.FromArgb(255, 204, 188);
            }
            foreach (Control item in gbx.Controls)
            {
                if(item.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)item).SelectedIndex == 0)
                    {
                        r++;
                        item.BackColor = Color.FromArgb(255, 204, 188);
                    }
                        
                }
            }
            return r;
        }
        /// <summary>
        /// Establece el valor predeterminado de los campos
        /// </summary>
        /// <param name="gbx"></param>
        void limpiarCampos(ref GroupBox gbx)
        {
            foreach (Control item in gbx.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(MaskedTextBox))
                {
                    item.Text = string.Empty;
                }
                dtpkFechaNacimiento.ResetText();
                rbtnHombre.Checked = false;
                rbtnMujer.Checked = false;
                tbxMatricula.Text = "N.I.";
            }
            cbbTipoEstudiante.SelectedIndex = 0;
            cbbEstadoCivil.SelectedIndex = 0;
            tbxNombre.BackColor = Color.White;
            tbxCarrera.BackColor = Color.White;
            tbxCentroEducativo.BackColor = Color.White;
            cbbEstadoCivil.BackColor = Color.White;
            cbbTipoEstudiante.BackColor = Color.White;
            gbxSexo.BackColor = Color.WhiteSmoke;
            mskTbxCedula.BackColor = Color.White;
        }
        /// <summary>
        /// Prepara el formulario para inscribir un nuevo estudiante
        /// </summary>
        void prepararParaNuevo()
        {
            estudianteActual = new Estudiante();
            lblTitulo.Text = "Nuevo estudiante";
            Tarea = Utiles.DbItem.Nuevo;
            limpiarCampos(ref gbxDatosPersonales);
            cambios_realizados = false;
        }
        /// <summary>
        /// Prepara el formulario para modificar un estudiante
        /// </summary>
        void prepararParaModificar()
        {
            lblTitulo.Text = "Modificar estudiante";
            Tarea = Utiles.DbItem.Actualizar;
            if (estudianteActual.Id > 0)
            {
                cargarDatos(estudianteActual.Id);
            }
            
        }
        /// <summary>
        /// Prepara el formulario para vel los datos del elemento en forma de solo lectura
        /// </summary>
        void prepararParaSoloVer()
        {
            lblTitulo.Text = "Detalle estudiante";
            Tarea = Utiles.DbItem.Detalle;
            cambios_realizados = false;
            btnGuardar.Enabled = false;
            btnBuscarCentroEducativo.Visible = false;
            btnBuscarCarrera.Visible = false;
            gbxDatosPersonales.BackColor = Color.White;
            gbxSexo.BackColor = Color.White;
            rbtnHombre.BackColor = Color.White;
            rbtnHombre.ForeColor = Color.FromArgb(67, 158, 220);
            rbtnMujer.BackColor = Color.White;
            rbtnMujer.Enabled = false;
            rbtnHombre.Enabled = false;
            dtpkFechaNacimiento.Enabled = false;
            //
            if (estudianteActual.Id > 0)
            {
                cargarDatos(estudianteActual.Id);
            }
            foreach (Control ctrl in gbxDatosPersonales.Controls)
            {
                if (ctrl.GetType() != typeof(Label))
                {
                    ctrl.BackColor = Color.White;
                    ctrl.ForeColor = Color.FromArgb(67, 158, 220);
                }
                //
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).ReadOnly = true;
                }
                if (ctrl.GetType() == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox)ctrl).ReadOnly = true;
                }
                if (ctrl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctrl).Enabled = false;
                }
            }
            
        }
        /// <summary>
        /// Llena los controles con los datos del objeto estudianteActual
        /// </summary>
        /// <param name="Id"></param>
        void cargarDatos(int Id)
        {
            Carrera carrera = new Carrera();
            CentroEducativo ce = new CentroEducativo();
            estudianteActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo);
            //
            tbxMatricula.Text = estudianteActual.Matricula.ToString();
            tbxNombre.Text = estudianteActual.Nombre;
            tbxApellidos.Text = estudianteActual.Apellidos;
            mskTbxCedula.Text = estudianteActual.Cedula;
            mskTbxTelefonoCasa.Text = estudianteActual.TelefonoCasa;
            mskTbxTelefonoMovil.Text = estudianteActual.TelefonoMovil;
            //
            if (estudianteActual.Sexo == rbtnHombre.Text)
            {
                rbtnHombre.Checked = true;
                rbtnMujer.Checked = false;
            }
            else if (estudianteActual.Sexo == rbtnMujer.Text)
            {
                rbtnMujer.Checked = true;
                rbtnHombre.Checked = false;
            }
            //
            tbxCorreo.Text = estudianteActual.Correo;
            tbxDireccion.Text = estudianteActual.Direccion;
            cbbEstadoCivil.Text = estudianteActual.EstadoCivil;
            //
            foreach (TipoEstudiante item in tiposEstudiantes)
            {
                if (item.Id == estudianteActual.TipoEstudiante)
                {
                    cbbTipoEstudiante.Text = item.Titulo;
                }
            }
            //
            carrera.Id = estudianteActual.Carrera;
            ce.Id = estudianteActual.CentroEducativo;
            if (carrera.buscarDatosPorId(Utiles.DbOptionSelect.Basico))
            {
                tbxCarrera.Text = carrera.Nombre;
            }
            //
            if (ce.buscarDatosPorId(Utiles.DbOptionSelect.Basico))
            {
                tbxCentroEducativo.Text = ce.NombreCorto;
            }
            dtpkFechaNacimiento.Value = estudianteActual.FechaNacimiento.Date;
            tbxObservaciones.Text = estudianteActual.Observaciones;

        }
        /// <summary>
        /// Inicializa los controles ComboBox del formulario
        /// </summary>
        void inicializarComboBoxes()
        {
            TipoEstudiante te = new TipoEstudiante();
            tiposEstudiantes = te.Buscar("");
            foreach (TipoEstudiante item in tiposEstudiantes)
            {
                cbbTipoEstudiante.Items.Add(item.Titulo);
            }
            cambios_realizados = false;

            cbbEstadoCivil.Items.Insert(0, "Seleccionar");
            cbbEstadoCivil.SelectedIndex = 0;
            cbbTipoEstudiante.Items.Insert(0, "Seleccionar");
            cbbTipoEstudiante.SelectedIndex = 0;
        }
        /// <summary>
        /// Asigna los datos de los campos del formulario al objeto estudianteActual
        /// </summary>
        void asignarDatos()
        {
            estudianteActual.Nombre = tbxNombre.Text;
            estudianteActual.Apellidos = tbxApellidos.Text;
            estudianteActual.Cedula = mskTbxCedula.Text;
            estudianteActual.TelefonoMovil = mskTbxTelefonoMovil.Text;
            estudianteActual.TelefonoCasa = mskTbxTelefonoCasa.Text;
            //
            if (rbtnHombre.Checked)
                estudianteActual.Sexo = rbtnHombre.Text;
            else if (rbtnMujer.Checked)
                estudianteActual.Sexo = rbtnMujer.Text;
            //
            estudianteActual.Direccion = tbxDireccion.Text;
            estudianteActual.Correo = tbxCorreo.Text;
            //
            foreach (TipoEstudiante item in tiposEstudiantes)
            {
                if (item.Titulo == cbbTipoEstudiante.Text)
                {
                    estudianteActual.TipoEstudiante = item.Id;
                }
            }
            estudianteActual.FechaNacimiento = dtpkFechaNacimiento.Value.Date;
            estudianteActual.EstadoCivil = cbbEstadoCivil.Text;
            estudianteActual.Observaciones = tbxObservaciones.Text;
        }

        private void btnInscribir_Click_1(object sender, EventArgs e)
        {
            asignarDatos();
            if (0 == validarCamposVacios(ref gbxDatosPersonales))
            {
                asignarDatos();
                if (Tarea == Utiles.DbItem.Nuevo)
                {
                    AsignadorMatriculaEstudiante asignador = new AsignadorMatriculaEstudiante();
                    if (asignador.BloquearYAsignar())
                    {
                        if (asignador.MatriculaNueva > 0)
                        {
                            estudianteActual.Matricula = asignador.MatriculaNueva;
                            if (estudianteActual.Registrar())
                            {
                                MessageBox.Show("El estudiante ha sido registrado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarCampos(ref gbxDatosPersonales);
                                asignador.Actualizar();
                                cambios_realizados = false;
                                this.Close();
                            }
                            else MessageBox.Show("Error: no se ha podido registrar el estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    asignador.Desbloquear();
                }
                else if (Tarea == Utiles.DbItem.Actualizar)
                {
                    if (estudianteActual.Actualizar())
                    {
                        MessageBox.Show("Los datos del estudiantes han sido actualizados con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos(ref gbxDatosPersonales);
                        cambios_realizados = false;
                        this.Close();
                    }
                    else MessageBox.Show("Error: no se han podido actualizar los datos del estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            inicializarComboBoxes();
            switch (Tarea)
            {
                case Utiles.DbItem.Nuevo:
                    prepararParaNuevo();
                    break;
                case Utiles.DbItem.Actualizar:
                    prepararParaModificar();
                    break;
                case Utiles.DbItem.Detalle:
                    prepararParaSoloVer();
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rbtnHombre_CheckedChanged(object sender, EventArgs e)
        {
            gbxSexo.BackColor = Color.WhiteSmoke;
            if(Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
        }

        private void cbbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbEstadoCivil.BackColor = Color.White;
        }

        private void cbbTipoEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTipoEstudiante.BackColor = Color.White;
        }

        private void frmEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Tarea != Utiles.DbItem.Detalle)
            {
                if (cambios_realizados)
                {
                    if (MessageBox.Show("¿Desea descartar los cambios realizados en el formulario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }                
        }

        private void rbtnMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
            gbxSexo.BackColor = Color.WhiteSmoke;
        }

        private void btnBuscarCentroEducativo_Click_1(object sender, EventArgs e)
        {
            frmBuscarCentro frm = new frmBuscarCentro(Utiles.OpcionBusqueda.BusquedaYEnvio);
            CentroEducativo centro = new CentroEducativo();
            frm.ShowDialog();
            if (frm.IdCentroSeleccionado > 0)
            {
                centro.Id = frm.IdCentroSeleccionado;
                centro.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxCentroEducativo.Text = centro.NombreCorto;
                estudianteActual.CentroEducativo = frm.IdCentroSeleccionado;
            }
            frm.Dispose();
        }

        private void bntBuscarCarrera_Click(object sender, EventArgs e)
        {
            frmBuscarCarrera frm = new frmBuscarCarrera(Utiles.OpcionBusqueda.BusquedaYEnvio);
            Carrera carr = new Carrera();
            frm.ShowDialog();
            if (frm.IdCarreraSeleccionada > 0)
            {
                carr.Id = frm.IdCarreraSeleccionada;
                carr.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxCarrera.Text = carr.Nombre;
                estudianteActual.Carrera = frm.IdCarreraSeleccionada;
            }
            frm.Dispose();
        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
            tbxNombre.BackColor = Color.White;
        }

        private void tbxApellidos_TextChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
        }

        private void mskTbxCedula_TextChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
            mskTbxCedula.BackColor = Color.White;
        }

        private void rbtnHombre_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
            gbxSexo.BackColor = Color.WhiteSmoke;
        }

        private void rbtnMujer_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
            gbxSexo.BackColor = Color.WhiteSmoke;
        }

        private void mskTbxTelefonoMovil_TextChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
        }

        private void mskTbxTelefonoCasa_TextChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
        }

        private void tbxDireccion_TextChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
        }

        private void tbxCorreo_TextChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
        }

        private void dtpkFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
        }

        private void cbbEstadoCivil_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
            cbbEstadoCivil.BackColor = Color.White;
        }

        private void tbxCentroEducativo_TextChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
            tbxCentroEducativo.BackColor = Color.WhiteSmoke;
        }

        private void tbxCarrera_TextChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
            tbxCarrera.BackColor = Color.WhiteSmoke;
        }

        private void cbbTipoEstudiante_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbbTipoEstudiante.BackColor = Color.White;
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
        }

        private void tbxObservaciones_TextChanged(object sender, EventArgs e)
        {
            if (Tarea == Utiles.DbItem.Nuevo || Tarea == Utiles.DbItem.Actualizar)
                cambios_realizados = true;
        }
    }
}

