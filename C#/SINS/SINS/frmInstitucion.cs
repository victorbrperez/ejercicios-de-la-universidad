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
    public partial class frmInstitucion : Form
    {
        public frmInstitucion()
        {
            InitializeComponent();
            tareaAula = Utiles.DbItem.Nuevo;
            tareaCarrera = Utiles.DbItem.Nuevo;
            tareaCentroEducativo = Utiles.DbItem.Nuevo;
        }
        public frmInstitucion(CentroEducativo centro, Utiles.DbItem tareaItem)
        {
            InitializeComponent();
            tbctrlInstitucion.SelectedTab = tabPage1;
            centroEducativoActual = centro;
            tareaCentroEducativo = tareaItem;
            if (tareaItem == Utiles.DbItem.Nuevo)
            {
                prepararParaNuevoCentroEducativo();

            }
            else if (tareaItem == Utiles.DbItem.Actualizar)
            {
                prepararParaModificar();
                if (centroEducativoActual.Id > 0)
                {
                    cargarInformacionCentro(centroEducativoActual.Id);
                }
            }
        }
        public frmInstitucion(Carrera carrera, Utiles.DbItem tareaItem)
        {
            InitializeComponent();
            tbctrlInstitucion.SelectedTab = tabPage2;
            carreraActual = carrera;
            tareaCarrera = tareaItem;
            tbxNombreCarrera.Focus();
            if (tareaItem == Utiles.DbItem.Nuevo)
            {
                prepararParaNuevaCarrera();
            }
            else if (tareaItem == Utiles.DbItem.Actualizar)
            {
                prepararParaModificarCarrera();
                if (carreraActual.Id > 0)
                {
                    cargarInformacionCarrera(carreraActual.Id);
                }
            }
        }
        public frmInstitucion(Aula aula, Utiles.DbItem tareaItem)
        {
            InitializeComponent();
            tbctrlInstitucion.SelectedTab = tabPage3;
            aulaActual = aula;
            tareaAula = tareaItem;
            tbxDescripcionAula.Focus();
            if (tareaItem == Utiles.DbItem.Nuevo)
            {
                prepararParaNuevaAula();
            }
            else if (tareaItem == Utiles.DbItem.Actualizar)
            {
               prepararParaModificarAula();
               if (aulaActual.Id > 0)
               {
                    cargarInformacionAula(aulaActual.Id);
               }
            }
        }
        //*****VARIABLES U OBJETOS MIEMBRO*********************************************************************************
        CentroEducativo centroEducativoActual;
        Carrera carreraActual;
        Aula aulaActual;
        Utiles.DbItem tareaCarrera;
        Utiles.DbItem tareaCentroEducativo;
        Utiles.DbItem tareaAula;
        int id_centro_aula;

        //*****METODOS MIEMBRO***************************************************************************************
        void limpiarCampos(ref GroupBox gbx)
        {
            foreach (Control ctrl in gbx.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox)|| ctrl.GetType() == typeof(MaskedTextBox))
                {
                    ctrl.Text = string.Empty;
                }
            }
        }
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

            return r;
        }
        //****CENTRO EDUCATIVO****************************************************************************************************************
        /// <summary>
        /// Metodo que asigna los valores de los campos al objeto centroEducativoActual;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void asignarDatosCentorEducativo()
        {
            if (tareaCentroEducativo == Utiles.DbItem.Nuevo)
            {
                centroEducativoActual = new CentroEducativo();
            }
            centroEducativoActual.NombreCorto = tbxNombreCortoCentro.Text;
            centroEducativoActual.NombreLargo = tbxNombreLargoCentro.Text;
            centroEducativoActual.Telefono = mskTbxTelefonoCentro.Text;
            centroEducativoActual.Direccion = tbxDireccionCentro.Text;
            centroEducativoActual.Correo = tbxCorreoCentro.Text;
            centroEducativoActual.Observaciones = tbxObservacionesCentro.Text;
            centroEducativoActual.Web = tbxWebCentro.Text;
        }
        /// <summary>
        /// Metodo que prepara el formulario para registrar un nuevo centro educativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name=""></param>
        /// 
        void prepararParaNuevoCentroEducativo()
        {
            gbxCentroEducativo.Text = "Datos del nuevo centro educativo";
            limpiarCampos(ref gbxCentroEducativo);
            tareaCentroEducativo = Utiles.DbItem.Nuevo;
        }
        /// <summary>
        /// Metodo que prepara el formulario para modificar los datos de un centro educativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void prepararParaModificar()
        {
            gbxCentroEducativo.Text = "Datos del centro educativo";
            tareaCentroEducativo = Utiles.DbItem.Actualizar;
        }
        /// <summary>
        /// Metodo que asigna los valores a los campos tomados del objeto usuarioActual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void cargarInformacionCentro(int Id)
        {
            centroEducativoActual = new CentroEducativo();
            if (Id > 0)
            {
                centroEducativoActual.Id = Id;
                if (centroEducativoActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo))
                {
                    tbxNombreCortoCentro.Text = centroEducativoActual.NombreCorto;
                    tbxNombreLargoCentro.Text = centroEducativoActual.NombreLargo;
                    mskTbxTelefonoCentro.Text = centroEducativoActual.Telefono;
                    tbxDireccionCentro.Text = centroEducativoActual.Direccion;
                    tbxObservacionesCentro.Text = centroEducativoActual.Observaciones;
                    tbxCorreoCentro.Text = centroEducativoActual.Correo;
                    tbxWebCentro.Text = centroEducativoActual.Web;
                }
            }
        }
        //****CARRERA****************************************************************************************************************
        /// <summary>
        /// Metodo que asigna los valores de los campos al objeto carreraActual;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void asignarDatosCarrera()
        {
            if (tareaCarrera == Utiles.DbItem.Nuevo)
            {
                carreraActual = new Carrera();
            }
            carreraActual.Nombre = tbxNombreCarrera.Text;
            carreraActual.Observaciones = tbxObservacionesCarrera.Text;
            carreraActual.Creditos = Convert.ToInt32(nudCreditosCarrera.Value);
        }
        /// <summary>
        /// Metodo que prepara el formulario para registrar una neva carrera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name=""></param>
        /// 
        void prepararParaNuevaCarrera()
        {
            gbxCarrera.Text = "Datos de la nueva carrera";
            limpiarCampos(ref gbxCarrera);
            tareaCarrera = Utiles.DbItem.Nuevo;
            nudCreditosCarrera.Value = 0;
        }
        /// <summary>
        /// Metodo que prepara el formulario para modificar los datos de la carrera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void prepararParaModificarCarrera()
        {
            gbxCarrera.Text = "Datos de la carrera";
            tareaCarrera = Utiles.DbItem.Actualizar;
        }
        /// <summary>
        /// Metodo que asigna los valores a los campos tomados del objeto usuarioActual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void cargarInformacionCarrera(int Id)
        {
            carreraActual = new Carrera();
            if (Id > 0)
            {
                carreraActual.Id = Id;
                if (carreraActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo))
                {
                    tbxNombreCarrera.Text = carreraActual.Nombre;
                    nudCreditosCarrera.Value = Convert.ToDecimal(carreraActual.Creditos);
                    tbxObservacionesCarrera.Text = carreraActual.Observaciones;
                }
            }
        }
        //**********AULA******************************************************************************************************
        /// <summary>
        /// Metodo que prepara el formulario para registrar una neva aula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name=""></param>
        /// 
        void prepararParaNuevaAula()
        {
            gbxAula.Text = "Datos del aula nueva";
            limpiarCampos(ref gbxAula);
            tareaAula = Utiles.DbItem.Nuevo;
            nudCapacidadAula.Value = 0;
        }
        /// <summary>
        /// Metodo que asigna los valores de los campos al objeto centroEducativoActual;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void asignarDatosAula()
        {
            if (tareaAula == Utiles.DbItem.Nuevo)
            {
                aulaActual = new Aula();
            }
            aulaActual.Descripcion = tbxDescripcionAula.Text;
            aulaActual.Codigo = tbxCodigoAula.Text;
            aulaActual.Capacidad = Convert.ToInt32(nudCapacidadAula.Value);
            aulaActual.Observaciones = tbxObservacionesAula.Text;
            aulaActual.Centro = id_centro_aula;
        }
        void prepararParaModificarAula()
        {
            gbxAula.Text = "Datos del aula";
            tareaAula = Utiles.DbItem.Actualizar;
        }
        /// <summary>
        /// Metodo que asigna los valores a los campos tomados del objeto aulaActual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void cargarInformacionAula(int Id)
        {
            aulaActual = new Aula();
            if (Id > 0)
            {
                aulaActual.Id = Id;
                if (aulaActual.buscarDatosPorId(Utiles.DbOptionSelect.Todo))
                {
                    tbxCodigoAula.Text = aulaActual.Codigo;
                    nudCapacidadAula.Value = Convert.ToDecimal(aulaActual.Capacidad);
                    tbxDescripcionAula.Text = aulaActual.Descripcion;
                    tbxObservacionesAula.Text = aulaActual.Observaciones;
                    id_centro_aula = aulaActual.Centro;
                    //
                    CentroEducativo centro = new CentroEducativo();
                    centro.Id = aulaActual.Centro;
                    if(centro.buscarDatosPorId(Utiles.DbOptionSelect.Basico))
                    {
                        tbxCentroEducativoAula.Text = centro.NombreCorto;
                    }
                }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCentro_Click(object sender, EventArgs e)
        {
            if (0 == validarCamposVacios(ref gbxCentroEducativo))
            {
                asignarDatosCentorEducativo();
                if (tareaCentroEducativo == Utiles.DbItem.Nuevo)
                {
                    if (centroEducativoActual.registrar())
                    {
                        MessageBox.Show("Se registrado el centro educativo con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error: No se ha podido registrar el centro educativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tareaCentroEducativo == Utiles.DbItem.Actualizar)
                {
                    if (centroEducativoActual.Actualizar())
                    {
                        MessageBox.Show("Los datos del centro educativo se han actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error: No se han podido actualizar los datos  del centro educativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void btnBuscarCentro_Click(object sender, EventArgs e)
        {
            prepararParaModificar();
            frmBuscarCentro frm = new frmBuscarCentro(Utiles.OpcionBusqueda.BusqedaYEnvio);
            frm.ShowDialog();
            if (frm.IdCentroSeleccionado > 0)
            {
                cargarInformacionCentro(frm.IdCentroSeleccionado);
            }
            
        }

        private void btnNuevoCentro_Click(object sender, EventArgs e)
        {
            prepararParaNuevoCentroEducativo();
        }

        private void gbxCentroEducativo_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (0 == validarCamposVacios(ref gbxCarrera))
            {
                asignarDatosCarrera();
                if (tareaCarrera == Utiles.DbItem.Nuevo)
                {
                    if (carreraActual.Registrar())
                    {
                        MessageBox.Show("Se registrado la nueva carrera con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error: No se ha podido registrar la carrera en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tareaCentroEducativo == Utiles.DbItem.Actualizar)
                {
                    if (centroEducativoActual.Actualizar())
                    {
                        MessageBox.Show("Los datos de la carrera se han actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error: No se han podido actualizar los datos la carrera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //
            prepararParaNuevaCarrera();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prepararParaNuevaCarrera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prepararParaModificarCarrera();
            frmBuscarCarrera frm = new frmBuscarCarrera(Utiles.OpcionBusqueda.BusqedaYEnvio);
            frm.ShowDialog();
            if (frm.IdCarreraSeleccionada > 0)
            {
                cargarInformacionCarrera(frm.IdCarreraSeleccionada);
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarAula_Click(object sender, EventArgs e)
        {
            if (0 == validarCamposVacios(ref gbxAula))
            {
                asignarDatosAula();
                if (tareaAula == Utiles.DbItem.Nuevo)
                {
                    if (aulaActual.Registrar())
                    {
                        MessageBox.Show("Se registrado la nueva aula con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        prepararParaNuevaCarrera();
                    }
                    else
                        MessageBox.Show("Error: No se ha podido registrar el aula en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tareaAula == Utiles.DbItem.Actualizar)
                {
                    if (aulaActual.Actualizar())
                    {
                        MessageBox.Show("Los datos del aula se han actualizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnBuscarCentroEducativo_Click(object sender, EventArgs e)
        {
            frmBuscarCentro frm = new frmBuscarCentro(Utiles.OpcionBusqueda.BusqedaYEnvio);
            CentroEducativo centro = new CentroEducativo();
            frm.ShowDialog();
            if (frm.IdCentroSeleccionado > 0)
            {
                id_centro_aula = frm.IdCentroSeleccionado;
                centro.Id = frm.IdCentroSeleccionado;
                centro.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                tbxCentroEducativoAula.Text = centro.NombreCorto;
            }
            frm.Dispose();
        }

        private void btnBuscarAula_Click(object sender, EventArgs e)
        {
            prepararParaModificarAula();
            frmBuscarAulas frm = new frmBuscarAulas(Utiles.OpcionBusqueda.BusqedaYEnvio);
            frm.ShowDialog();
            if (frm.IdAulaSeleccionada > 0)
            {
                cargarInformacionAula(frm.IdAulaSeleccionada);
            }
        }

        private void btnNuevaAula_Click(object sender, EventArgs e)
        {
            prepararParaNuevaAula();
        }
    }
}