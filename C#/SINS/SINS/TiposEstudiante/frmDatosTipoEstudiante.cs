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
    public partial class frmDatosTipoEstudiante : Form
    {
        public frmDatosTipoEstudiante(Utiles.DbItem tarea, int v_id)
        {
            InitializeComponent();
            this.modo = tarea;
            tipoEstudianteActual = new TipoEstudiante();
            switch (tarea)
            {
                case Utiles.DbItem.Nuevo:
                    prepararParaNuevo();
                    break;
                case Utiles.DbItem.Actualizar:
                    tipoEstudianteActual = new TipoEstudiante();
                    tipoEstudianteActual.Id = v_id;
                    prepararParaModificar();
                    cargarInformacion(tipoEstudianteActual.Id);
                    break;
            }
        }
        //*******VARIABLES MIEMBRO********************************************************************************
        Utiles.DbItem modo;
        TipoEstudiante tipoEstudianteActual;
        //******METODOS MIEMBRO**********************************************************************************************
        /// <summary>
        /// Limpia o reestablece los campos del formulario
        /// </summary>
        /// <param name="gbx"></param>
        void reestablecerCampos(ref GroupBox gbx)
        {
            foreach (Control ctrl in gbx.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(MaskedTextBox))
                {
                    ctrl.Text = string.Empty;
                }
            }
            tbxCostoInscripcion.Text = "0.00";
            tbxCostoCreditos.Text = "0.00";
            tbxId.Text = "NUEVO";
        }
        /// <summary>
        ///Valida los datos  en los controles de captura
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
            return r;
        }
        /// <summary>
        /// Prepara el formulario para registrar un Centro Educativo nuevo
        /// </summary>
        /// 
        void prepararParaNuevo()
        {
            tipoEstudianteActual = new TipoEstudiante();
            gbxTipoEstudiante.Text = "Datos del tipo de estudiante";
            reestablecerCampos(ref gbxTipoEstudiante);
            lblTitulo.Text = "Nuevo tipo de estudiante";
            modo = Utiles.DbItem.Nuevo;
        }
        /// <summary>
        /// Metodo que asigna los valores de los campos al objeto tipoEstudianteActual;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void asignarDatos()
        {
            tipoEstudianteActual.Titulo = tbxTitulo.Text;
            tipoEstudianteActual.Observaciones = tbxObservaciones.Text;
            //
            try
            {
                tipoEstudianteActual.CostoCredito = Convert.ToDouble(tbxCostoCreditos.Text);
                tipoEstudianteActual.CostoInscripcion = Convert.ToDouble(tbxCostoInscripcion.Text);
            }
            catch (FormatException)
            {
                throw;
            }
        }
        /// <summary>
        /// Metodo que prepara el formulario para modificar los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void prepararParaModificar()
        {
            gbxTipoEstudiante.Text = "Datos del nuevo tipo de estudiante";
            modo = Utiles.DbItem.Actualizar;
            lblTitulo.Text = "Modificar tipo de estudiante";
        }
        /// <summary>
        /// Metodo que asigna los valores a los campos tomados del objeto usuarioActual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void cargarInformacion(int Id)
        {
            if (tipoEstudianteActual != null)
            {
                if (Id > 0)
                {
                    tipoEstudianteActual.Id = Id;
                    if (tipoEstudianteActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo))
                    {
                        if (modo == Utiles.DbItem.Actualizar)
                        {
                            tbxId.Text = tipoEstudianteActual.Id.ToString();
                        }
                        tbxTitulo.Text = tipoEstudianteActual.Titulo;
                        tbxCostoCreditos.Text = tipoEstudianteActual.CostoCredito.ToString();
                        tbxCostoInscripcion.Text = tipoEstudianteActual.CostoInscripcion.ToString();
                        tbxObservaciones.Text = tipoEstudianteActual.Observaciones;
                    }
                }
            }
        }

        private void tbxCostoCreditos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbxCostoCreditos.Text))
                {
                    Convert.ToDecimal(tbxCostoCreditos.Text);
                }

            }
            catch (FormatException)
            {
                tbxCostoCreditos.Text = "0.00";
            }
        }

        private void tbxCostoInscripcion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbxCostoInscripcion.Text))
                {
                    Convert.ToDecimal(tbxCostoInscripcion.Text);
                }

            }
            catch (FormatException)
            {
                tbxCostoInscripcion.Text = "0.00";
            }
        }

        private void tbxCostoCreditos_Enter(object sender, EventArgs e)
        {
            tbxCostoCreditos.Text = string.Empty;
        }

        private void tbxCostoInscripcion_Enter(object sender, EventArgs e)
        {
            tbxCostoInscripcion.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (0 == validarCamposVacios(ref gbxTipoEstudiante))
            {
                asignarDatos();
                if (modo == Utiles.DbItem.Nuevo)
                {
                    if (tipoEstudianteActual.Registrar())
                    {
                        MessageBox.Show("Se ha registrado un nuevo tipo de estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: No se ha podido registrar el tipo de estudiante","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (modo == Utiles.DbItem.Actualizar)
                {
                    if (tipoEstudianteActual.Actualizar())
                    {
                        MessageBox.Show("Los datos del tipo de estudiante se han actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: No se han podido actualizar los datos del tipo de estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
