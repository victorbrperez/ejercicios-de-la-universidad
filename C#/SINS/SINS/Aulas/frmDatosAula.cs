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
    public partial class frmDatosAula : Form
    {
        public frmDatosAula(Utiles.DbItem tarea, int v_id)
        {
            InitializeComponent();
            this.modo = tarea;
            aulaActual = new Aula();
            switch(tarea)
            {
                case Utiles.DbItem.Nuevo:
                    prepararParaNuevo();
                    break;
                case Utiles.DbItem.Actualizar:
                    aulaActual = new Aula();
                    aulaActual.Id = v_id;
                    prepararParaModificar();
                    cargarInformacion(aulaActual.Id);
                    break;
            }

        }
        //*******VARIABLES MIEMBRO********************************************************************************
        Utiles.DbItem modo;
        Aula aulaActual;
        int id_centro;
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
            id_centro = 0;
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
            aulaActual = new Aula();
            gbxAula.Text = "Datos de la nueva aula";
            reestablecerCampos(ref gbxAula);
            lblTitulo.Text = "Nueva aula";
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
            aulaActual.Descripcion = tbxDescripcion.Text;
            aulaActual.Codigo = tbxCodigo.Text;
            aulaActual.Centro = id_centro;
            aulaActual.Capacidad = Convert.ToInt32(nudCapacidad.Value);
            aulaActual.Observaciones = tbxObservaciones.Text;
            
        }
        /// <summary>
        /// Metodo que prepara el formulario para modificar los datos del aula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void prepararParaModificar()
        {
            gbxAula.Text = "Datos del aula";
            modo = Utiles.DbItem.Actualizar;
            lblTitulo.Text = "Edición de datos del aula";
        }
        /// <summary>
        /// Metodo que asigna los valores a los campos tomados del objeto centorActual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void cargarInformacion(int Id)
        {
            aulaActual = new Aula();
            if (Id > 0)
            {
                aulaActual.Id = Id;
                if (aulaActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo))
                {
                    tbxId.Text = aulaActual.Id.ToString();
                    tbxDescripcion.Text = aulaActual.Descripcion;
                    tbxObservaciones.Text = aulaActual.Observaciones;
                    tbxCodigo.Text = aulaActual.Codigo;
                    nudCapacidad.Value = Convert.ToDecimal(aulaActual.Capacidad);
                    id_centro = aulaActual.Centro;
                    //
                    CentroEducativo ce = new CentroEducativo();
                    ce.Id = aulaActual.Centro;
                    if (ce.buscarDatosPorId(Utiles.DbOptionSelect.Basico))
                    {
                        tbxCentroEducativo.Text = ce.NombreCorto;
                    }
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (0 == validarCamposVacios(ref gbxAula))
            {
                asignarDatos();
                if (modo == Utiles.DbItem.Nuevo)
                {
                    if (!aulaActual.comprobarCodigoRepetido())
                    {
                        if (aulaActual.Registrar())
                        {
                            MessageBox.Show("Se ha registrado una nueva aula", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Error: No se ha podido registrar el aula", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Esta intentando registrar un aula con el codigo duplicado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        tbxCodigo.BackColor = Color.FromArgb(255, 204, 188);
                    }
                }
                else if (modo == Utiles.DbItem.Actualizar)
                {
                    if (aulaActual.Actualizar())
                    {
                        MessageBox.Show("Los datos del aula se han actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: No se han podido actualizar los datos  del aula", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnBuscarCentroEducativo_Click(object sender, EventArgs e)
        {
            frmBuscarCentro frm = new frmBuscarCentro(Utiles.OpcionBusqueda.BusquedaYEnvio);
            CentroEducativo centro = new CentroEducativo();
            frm.ShowDialog();
            if (frm.IdCentroSeleccionado > 0)
            {
                centro.Id = frm.IdCentroSeleccionado;
                centro.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxCentroEducativo.Text = centro.NombreCorto;
                id_centro = frm.IdCentroSeleccionado;
            }
            frm.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
