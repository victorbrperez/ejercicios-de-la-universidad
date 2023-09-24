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
    public partial class frmDatosCentro : Form
    {
        public frmDatosCentro(Utiles.DbItem v_modo, int v_id)
        {
            InitializeComponent();
            modo = v_modo;
            switch(modo)
            {
                case Utiles.DbItem.Nuevo:
                    prepararParaNuevo();
                    break;
                case Utiles.DbItem.Actualizar:
                    centroActual = new CentroEducativo();
                    centroActual.Id = v_id;
                    prepararParaModificar();
                    cargarInformacion(centroActual.Id);
                    break;
            }
        }
        Utiles.DbItem modo;
        CentroEducativo centroActual;
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
            centroActual = new CentroEducativo();
            gbxCentroEducativo.Text = "Datos del nuevo centro";
            reestablecerCampos(ref gbxCentroEducativo);
            lblTitulo.Text = "Nuevo centro";
            modo = Utiles.DbItem.Nuevo;
        }
        /// <summary>
        /// Metodo que asigna los valores de los campos al objeto centroActual;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void asignarDatos()
        {
            centroActual.NombreCorto = tbxNombreCortoCentro.Text;
            centroActual.NombreLargo = tbxNombreLargoCentro.Text;
            centroActual.Telefono = mskTbxTelefonoCentro.Text;
            centroActual.Direccion = tbxDireccionCentro.Text;
            centroActual.Correo = tbxCorreoCentro.Text;
            centroActual.Observaciones = tbxObservacionesCentro.Text;
            centroActual.Web = tbxWebCentro.Text;
        }
        /// <summary>
        /// Metodo que prepara el formulario para modificar los datos de un centro educativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void prepararParaModificar()
        {
            gbxCentroEducativo.Text = "Datos del centro";
            modo = Utiles.DbItem.Actualizar;
            lblTitulo.Text = "Edición de datos del Centro";         
        }
        /// <summary>
        /// Metodo que asigna los valores a los campos tomados del objeto centorActual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void cargarInformacion(int Id)
        {
            centroActual = new CentroEducativo();
            if (Id > 0)
            {
                centroActual.Id = Id;
                if (centroActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo))
                {
                    tbxId.Text = centroActual.Id.ToString();
                    tbxNombreCortoCentro.Text = centroActual.NombreCorto;
                    tbxNombreLargoCentro.Text = centroActual.NombreLargo;
                    mskTbxTelefonoCentro.Text = centroActual.Telefono;
                    tbxDireccionCentro.Text = centroActual.Direccion;
                    tbxObservacionesCentro.Text = centroActual.Observaciones;
                    tbxCorreoCentro.Text = centroActual.Correo;
                    tbxWebCentro.Text = centroActual.Web;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (0 == validarCamposVacios(ref gbxCentroEducativo))
            {
                asignarDatos();
                if (modo == Utiles.DbItem.Nuevo)
                {
                    if (centroActual.registrar())
                    {
                        MessageBox.Show("Se ha registrado el centro con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: No se ha podido registrar el centro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (modo == Utiles.DbItem.Actualizar)
                {
                    if (centroActual.Actualizar())
                    {
                        MessageBox.Show("Los datos del centro se han actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: No se han podido actualizar los datos  del centro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxNombreCortoCentro_TextChanged(object sender, EventArgs e)
        {
            tbxNombreCortoCentro.BackColor = Color.White;
        }

        private void tbxNombreLargoCentro_TextChanged(object sender, EventArgs e)
        {
            tbxNombreLargoCentro.BackColor = Color.White;
        }
    }
}
