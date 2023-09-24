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
    public partial class frmProfesor : Form
    {
        public frmProfesor(Utiles.DbItem tarea, int id_profesor)
        {
            InitializeComponent();
            profesorActual = new Profesor();
            profesorActual.Id = id_profesor;
            Tarea = tarea;
        }
        //******PROPIEDADES Y VARIABLES MIEMBRO****************************************************************
        Profesor profesorActual;
        bool cambios_realizados;
        Utiles.DbItem Tarea;
        //*****METODOS MIEMBRO*********************************************************************************
        /// <summary>
        /// Comprueba si hay algun campo con datos en los formularios
        /// </summary>
        /// <returns></returns>
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
                if (item.GetType() == typeof(ComboBox))
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
                tbxId.Text = "N.I.";
            }
            cbbEstadoCivil.SelectedIndex = 0;
            tbxNombre.BackColor = Color.White;
            cbbEstadoCivil.BackColor = Color.White;
            gbxSexo.BackColor = Color.WhiteSmoke;
            mskTbxCedula.BackColor = Color.White;
        }
        /// <summary>
        /// Prepara el formulario para inscribir un nuevo profesor
        /// </summary>
        void prepararParaNuevo()
        {
            profesorActual = new Profesor();
            lblTitulo.Text = "Nuevo profesor";
            Tarea = Utiles.DbItem.Nuevo;
            limpiarCampos(ref gbxDatosPersonales);
            cambios_realizados = false;
            inicializarComboBoxes();
        }
        /// <summary>
        /// Inicializa los controles ComboBox del formulario
        /// </summary>
        void inicializarComboBoxes()
        {
            cambios_realizados = false;
            cbbEstadoCivil.SelectedIndex = 0;
        }
        /// <summary>
        /// Asigna los datos de los campos del formulario al objeto profesorActual
        /// </summary>
        /// 
        void asignarDatos()
        {
            profesorActual.Nombre = tbxNombre.Text;
            profesorActual.Apellidos = tbxApellidos.Text;
            profesorActual.Cedula = mskTbxCedula.Text;
            profesorActual.TelefonoMovil = mskTbxTelefonoMovil.Text;
            profesorActual.TelefonoCasa = mskTbxTelefonoCasa.Text;
            //
            if (rbtnHombre.Checked)
                profesorActual.Sexo = rbtnHombre.Text;
            else if (rbtnMujer.Checked)
                profesorActual.Sexo = rbtnMujer.Text;
            //
            profesorActual.Direccion = tbxDireccion.Text;
            profesorActual.Correo = tbxCorreo.Text;
            //
            profesorActual.FechaNacimiento = dtpkFechaNacimiento.Value.Date;
            profesorActual.EstadoCivil = cbbEstadoCivil.Text;
            profesorActual.Observaciones = tbxObservaciones.Text;
        }
        void cargarDatos(int Id)
        {
            profesorActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo);
            //
            tbxNombre.Text = profesorActual.Nombre;
            tbxApellidos.Text = profesorActual.Apellidos;
            mskTbxCedula.Text = profesorActual.Cedula;
            mskTbxTelefonoCasa.Text = profesorActual.TelefonoCasa;
            mskTbxTelefonoMovil.Text = profesorActual.TelefonoMovil;
            //
            if (profesorActual.Sexo == rbtnHombre.Text)
            {
                rbtnHombre.Checked = true;
                rbtnMujer.Checked = false;
            }
            else if (profesorActual.Sexo == rbtnMujer.Text)
            {
                rbtnMujer.Checked = true;
                rbtnHombre.Checked = false;
            }
            //
            tbxCorreo.Text = profesorActual.Correo;
            tbxDireccion.Text = profesorActual.Direccion;
            cbbEstadoCivil.Text = profesorActual.EstadoCivil;
            tbxObservaciones.Text = profesorActual.Observaciones;
            dtpkFechaNacimiento.Value = profesorActual.FechaNacimiento.Date;
        }
        /// <summary>
        /// Prepara el formulario para modificar los datos de un profesor
        /// </summary>
        void prepararParaModificar()
        {
            lblTitulo.Text = "Modificar profesor";
            Tarea = Utiles.DbItem.Actualizar;
            if (profesorActual.Id > 0)
            {
                cargarDatos(profesorActual.Id);
            }

        }
        //******ESPACIO PARA LOS EVENTOS***********************************************************************************************************************
        private void frmProfesor_Load(object sender, EventArgs e)
        {
            cbbEstadoCivil.Items.Insert(0, "Seleccionar");
            switch (Tarea)
            {
                case Utiles.DbItem.Nuevo:
                    prepararParaNuevo();
                    break;
                case Utiles.DbItem.Actualizar:
                    prepararParaModificar();
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (0 == validarCamposVacios(ref gbxDatosPersonales))
            {
                if (Tarea == Utiles.DbItem.Nuevo)
                {
                    asignarDatos();
                    if (profesorActual.Registrar())
                    {
                        MessageBox.Show("El profesor ha sido registrado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos(ref gbxDatosPersonales);
                        prepararParaNuevo();
                    }
                    else MessageBox.Show("Error: no se ha podido registrar el nuevo profesor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (Tarea == Utiles.DbItem.Actualizar)
                {
                    asignarDatos();
                    if (profesorActual.Actualizar())
                    {
                        MessageBox.Show("Los datos del profesor han sido actualizados con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        prepararParaNuevo();
                    }
                    else MessageBox.Show("Error: no se han podido actualizar los datos del profesor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {
            tbxNombre.BackColor = Color.White;
            cambios_realizados = true;
        }

        private void mskTbxCedula_TextChanged(object sender, EventArgs e)
        {
            mskTbxCedula.BackColor = Color.White;
            cambios_realizados = true;
        }

        private void rbtnHombre_CheckedChanged(object sender, EventArgs e)
        {
            gbxSexo.BackColor = Color.WhiteSmoke;
            cambios_realizados = true;
        }

        private void rbtnMujer_CheckedChanged(object sender, EventArgs e)
        {
            gbxSexo.BackColor = Color.WhiteSmoke;
        }

        private void cbbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbEstadoCivil.BackColor = Color.White;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxApellidos_TextChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
        }

        private void mskTbxTelefonoMovil_TextAlignChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
        }

        private void tbxDireccion_TextChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
        }

        private void tbxCorreo_TextChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
        }

        private void dtpkFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
        }

        private void cbbEstadoCivil_TextChanged(object sender, EventArgs e)
        {
            cambios_realizados = true;
        }

        private void frmProfesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambios_realizados)
            {
                if (MessageBox.Show("¿Desea descartar los cambios realizados en el formulario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (cambios_realizados)
            {
                if (MessageBox.Show("¿Desea descartar los cambios realizados en el formulario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prepararParaNuevo();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            prepararParaModificar();
            frmBuscarProfesor frmBuscar = new frmBuscarProfesor(Utiles.OpcionBusqueda.BusqedaYEnvio);
            frmBuscar.ShowDialog();
            if (frmBuscar.IdProfesorSeleccionado > 0)
            {
                profesorActual.Id = frmBuscar.IdProfesorSeleccionado;
                cargarDatos(profesorActual.Id);
            }
            frmBuscar.Dispose();
        }
    }
}
