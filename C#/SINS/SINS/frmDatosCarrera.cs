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
    public partial class frmDatosCarrera : Form
    {
        public frmDatosCarrera(Utiles.DbItem v_modo, int v_id)
        {
            InitializeComponent();
            modo = v_modo;
            switch(modo)
            {
                case Utiles.DbItem.Nuevo:
                    carreraActual = new Carrera();
                    prepararParaNuevo();
                    break;
                case Utiles.DbItem.Actualizar:
                    prepararParaEditar();
                    carreraActual = new Carrera();
                    carreraActual.Id = v_id;
                    cargarInformacion(carreraActual.Id);
                    
                    break;
            }
        }
        Utiles.DbItem modo;
        Carrera carreraActual;
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
            nudCreditosCarrera.Value = 0;
            tbxId.Text = "NUEVA";
        }
        /// <summary>
        ///Valida que no hayan campos vacios
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
        /// Metodo que asigna los valores de los campos al objeto carreraActual;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void asignarDatos()
        {
            carreraActual.Nombre = tbxNombreCarrera.Text.ToUpper() ;
            carreraActual.Observaciones = tbxObservacionesCarrera.Text;
            carreraActual.Creditos = Convert.ToInt32(nudCreditosCarrera.Value);
        }
        /// <summary>
        /// Metodo que prepara el formulario para registrar una neva carrera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name=""></param>
        /// 
        void prepararParaNuevo()
        {
            gbxCarrera.Text = "Datos de la nueva carrera";
            lblTitulo.Text = "Carrera nueva";
            reestablecerCampos(ref gbxCarrera);
            modo = Utiles.DbItem.Nuevo;
            reestablecerCampos(ref gbxCarrera);
        }
        /// <summary>
        /// Metodo que prepara el formulario para modificar los datos de la carrera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void prepararParaEditar()
        {
            reestablecerCampos(ref gbxCarrera);
            gbxCarrera.Text = "Datos de la carrera";
            modo = Utiles.DbItem.Actualizar;
            lblTitulo.Text = "Edición de datos de la carrera";
        }
        /// <summary>
        /// Metodo que asigna los valores a los campos tomados del objeto usuarioActual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void cargarInformacion(int Id)
        {
            if (carreraActual != null)
            {
                if (Id > 0)
                {
                    carreraActual.Id = Id;
                    if (carreraActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo))
                    {
                        if (modo == Utiles.DbItem.Actualizar)
                        {
                            tbxId.Text = carreraActual.Id.ToString();
                        }
                        tbxNombreCarrera.Text = carreraActual.Nombre;
                        nudCreditosCarrera.Value = Convert.ToDecimal(carreraActual.Creditos);
                        tbxObservacionesCarrera.Text = carreraActual.Observaciones;
                    }
                }
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (0 == validarCamposVacios(ref gbxCarrera))
            {
                asignarDatos();
                if (modo == Utiles.DbItem.Nuevo)
                {
                    if (carreraActual.Registrar())
                    {
                        MessageBox.Show("Se ha registrado la carrera con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: No se ha podido registrar la carrera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (modo == Utiles.DbItem.Actualizar)
                {
                    if (carreraActual.Actualizar())
                    {
                        MessageBox.Show("Los datos de la carrera se han actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: No se han podido actualizar los datos  de la carrera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
