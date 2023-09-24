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
    public partial class frmDatosAsignatura : Form
    {
        public frmDatosAsignatura(Utiles.DbItem v_modo, int v_id)
        {
            InitializeComponent();
            modo = v_modo;
            switch (modo)
            {
                case Utiles.DbItem.Nuevo:
                    asignaturaActual = new Asignatura();
                    prepararParaNuevo();
                    break;
                case Utiles.DbItem.Actualizar:
                    prepararParaEditar();
                    asignaturaActual = new Asignatura();
                    asignaturaActual.Id = v_id;
                    cargarInformacion(asignaturaActual.Id);

                    break;
            }
        }
        //
        Utiles.DbItem modo;
        Asignatura asignaturaActual;
        //
        //*****METODOS MIEMBRO****************************************************************************************************************
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
            nudCreditos.Value = 0;
            tbxId.Text = "NUEVA";
        }
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
                if (!mskTbxClave.MaskFull)
                {
                    mskTbxClave.BackColor = Color.FromArgb(255, 204, 188);
                    r++;
                }
            }
            return r;
        }
        /// <summary>
        /// Metodo que asigna los valores de los campos al objeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void asignarDatos()
        {
            asignaturaActual.Clave = mskTbxClave.Text.ToUpper();
            asignaturaActual.Descripcion = tbxDescripcion.Text.ToUpper();
            asignaturaActual.Observaciones = tbxObservacionesCarrera.Text;
            asignaturaActual.Creditos = Convert.ToInt32(nudCreditos.Value);
        }
        /// <summary>
        /// Metodo que prepara el formulario para registrar un nuevo elemento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name=""></param>
        /// 
        void prepararParaNuevo()
        {
            gbxDatos.Text = "Datos de la nueva asignatura";
            lblTitulo.Text = "Nueva asignatura";
            reestablecerCampos(ref gbxDatos);
            modo = Utiles.DbItem.Nuevo;
            reestablecerCampos(ref gbxDatos);
        }
        /// <summary>
        /// Metodo que prepara el formulario para modificar los datos del objeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void prepararParaEditar()
        {
            reestablecerCampos(ref gbxDatos);
            gbxDatos.Text = "Datos de la asignatura";
            modo = Utiles.DbItem.Actualizar;
            lblTitulo.Text = "Modificar datos de la asignatura";
        }
        /// <summary>
        /// Asigna los valores a los campos tomados de las propiedades del objeto asignaturaActual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void cargarInformacion(int Id)
        {
            if (asignaturaActual != null)
            {
                if (Id > 0)
                {
                    asignaturaActual.Id = Id;
                    if (asignaturaActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo))
                    {
                        if (modo == Utiles.DbItem.Actualizar)
                        {
                            tbxId.Text = asignaturaActual.Id.ToString();
                        }
                        tbxDescripcion.Text = asignaturaActual.Descripcion;
                        nudCreditos.Value = Convert.ToDecimal(asignaturaActual.Creditos);
                        tbxObservacionesCarrera.Text = asignaturaActual.Observaciones;
                        mskTbxClave.Text = asignaturaActual.Clave;
                    }
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (0 == validarCamposVacios(ref gbxDatos))
            {
                asignarDatos();
                if (modo == Utiles.DbItem.Nuevo)
                {
                    if (asignaturaActual.Registrar())
                    {
                        MessageBox.Show("Se ha registrado la asignatura con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: No se ha podido registrar la asignatura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (modo == Utiles.DbItem.Actualizar)
                {
                    if (asignaturaActual.Actualizar())
                    {
                        MessageBox.Show("Los datos de la asignatura se han actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: No se han podido actualizar los datos  de la asignatura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
