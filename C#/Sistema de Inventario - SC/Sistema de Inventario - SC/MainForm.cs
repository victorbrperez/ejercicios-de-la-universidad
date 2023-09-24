using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClases; //Nombre de espacio que contiene las classes creadas por el/los programador/es de este sistema y que no pertenecen a la biblioteca de clases de .NET

namespace Sistema_de_Inventario_SC
{
    struct UsuarioActivo
    {
        public Int32 id;
        public string nombre;
        public bool administrador;
    }

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            Usuario miUsuario = new Usuario();

        }
        //
        UsuarioActivo MiUsarioActivo;
        DataTable dttUsuario = new DataTable();
        //
        //======= METODOS DEFINIDOS POR EL PROGRAMADOR ===========================================================================================================================================
        //
        private void InterControles(string valor)//Metodo que intercambia la visivilidad de los controles en el formulario.
        {
            switch (valor)
            {
                case "user_reg":
                    if (loginIdPanel.Visible == true && regUsuarioPanel.Visible == false)
                    {
                        loginIdPanel.Visible = false;
                        regUsuarioPanel.Visible = true;
                    }
                    else if (loginIdPanel.Visible == false && regUsuarioPanel.Visible == true)
                    {
                        loginIdPanel.Visible = true;
                        regUsuarioPanel.Visible = false;
                    }
                    break;
                case "login":
                    if (logPanel.Visible == true && mainPanel.Visible == false)
                    {
                        logPanel.Visible = false;
                        mainPanel.Visible = true;
                    }
                    else if (logPanel.Visible == false && mainPanel.Visible == true)
                    {
                        logPanel.Visible = true;
                        mainPanel.Visible = false;
                    }
                    break;
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void IniciarSesion()
        {
            InterControles("login");
            //
            Usuario MiUsuario = new Usuario();
            DataSet UsuarioDs = new DataSet();
            MiUsuario.Id = Convert.ToInt32(usuarioTbx.Text);
            UsuarioDs = MiUsuario.Buscar("uno");
            //
            MiUsarioActivo.id = Convert.ToInt32(UsuarioDs.Tables["usuarios"].Rows[0]["id"].ToString());
            MiUsarioActivo.nombre = UsuarioDs.Tables["usuarios"].Rows[0]["nombre"].ToString();
            //
            if (Convert.ToInt32(UsuarioDs.Tables["usuarios"].Rows[0]["administrador"].ToString()) == 1) { MiUsarioActivo.administrador = true; }
            else { MiUsarioActivo.administrador = false; }
            //Se almacenan los datos del usuario que ha iniciado sesion en una estructura en la estructura MiUsuarioActivo.
            //
            estadoLb.Text = "Sesión iniciada para:  " + MiUsarioActivo.nombre;
            estadoLb.ForeColor = Color.White;
            inventarioToolStripMenuItem.Visible = true;
            //
            if (MiUsarioActivo.administrador)
            {
                estadoLb.Text += " - Usuario administrador";
                //Etiqueta del panel inferior que da informacion sobre quien ha iniciado sesion o si aun no se ha iniciado.
                
            }
            opcionesToolStripMenuItem.Visible = true;
            cerrarSecciónToolStripMenuItem.Visible = true;
            datosToolStripMenuItem.Visible = true;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void CerrarSesion()
        {
            InterControles("login");
            inventarioToolStripMenuItem.Visible = false;
            opcionesToolStripMenuItem.Visible = false;
            cerrarSecciónToolStripMenuItem.Visible = false;
            datosToolStripMenuItem.Visible = false;
            usuarioTbx.Text = "";
            passwordTbx.Text = "";
            estadoLb.Text = "Aún no ha iniciado sesión";
            estadoLb.ForeColor = Color.OrangeRed;
            usuarioTbx.Focus();
        }
        //
        //=======EVENTOS=============================================================================================================================================================
        //
        private void mainForm_Load(object sender, EventArgs e)//Cuando se carga el formulario.
        {
            Usuario Usuario = new Usuario();
            logPanel.Visible = true;
            mainPanel.Visible = false;

            if (Usuario.Existen())
            {
                loginIdPanel.Visible = true;
                regUsuarioPanel.Visible = false;
                this.AcceptButton = accederBtn;
            }
            else
            {
                loginIdPanel.Visible = false;
                regUsuarioPanel.Visible = true;
                this.AcceptButton = registrarBtn;
                estadoLb.Text = "No hay usuario administrador registrado";
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)//Cuando se cierra el formulario.
        {
            if (Application.OpenForms.Count == 1)
            {
                {
                    DialogResult miDialogResult = MessageForm.Show("¿Seguro que desea salir del sistema?", "Saliendo del sistema", enumMessageIcon.Question, enumMessageButton.YesNo);
                    if (miDialogResult == DialogResult.Yes) { }
                    else { e.Cancel = true; }
                    //Estas instrucciones controlan el cierre del formulario principal (Muestran un mesaje de confirmacion antes de cerrar el formulario)
                }
            }
            else 
            {
                MessageForm.Show("No se puede salir porque hay uno o mas modulos ejecutandose", "Atención", enumMessageIcon.Question, enumMessageButton.OK);
                e.Cancel = true;
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            if (UsuarioIdMskTb.Text != "" && nPasswordTb.Text != "" && nTelefonoTb.Text != "" && nNombreTb.Text != "")
            {
                Usuario miUsuario = new Usuario();
                miUsuario.Id = Convert.ToInt32(UsuarioIdMskTb.Text);
                miUsuario.Nombre = nNombreTb.Text;
                miUsuario.Password = nPasswordTb.Text;
                miUsuario.Telefono = nTelefonoTb.Text;
                miUsuario.Administrador = true;
                if (miUsuario.Registrar())
                {
                    MessageForm.Show("Usuario registrado satisfactoriamente","Mensaje");
                    InterControles("user_reg");
                    estadoLb.Text = "Aún no ha iniciado sesión";
                    AcceptButton = accederBtn;
                    usuarioTbx.Focus();
                }
                else MessageForm.Show("Usuario no se pudo registrar error en la base de datos", "Atención");
                
            }
            else { MessageForm.Show("Debe llenar todos los campos","Campos vacíos");}
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void accederBtn_Click(object sender, EventArgs e)
        {
            Usuario miUsuario = new Usuario();
            DataSet usuarioDs = new DataSet();

            if (usuarioTbx.Text != "")
            {
                miUsuario.Id = Convert.ToInt32(usuarioTbx.Text);//Necesario para traer el usuario y compararlo o averiguar si esta registrado.
            }

            usuarioDs = miUsuario.Buscar("uno");

            if (usuarioTbx.Text != "" && passwordTbx.Text != "")
            {
                if (miUsuario.EstaRegistrado)
                {
                    if (usuarioTbx.Text == usuarioDs.Tables["usuarios"].Rows[0]["Id"].ToString() && passwordTbx.Text == usuarioDs.Tables["usuarios"].Rows[0]["Password"].ToString())
                    {
                        IniciarSesion();
                    }
                    else
                    {
                        MessageForm.Show("ID y Contraseña no coinciden", "No se puede acceder");
                    }
                }
                else
                {
                    MessageForm.Show("El usuario introducido no esta registrado", "No se puede acceder");
                }
            }
            else
            {
                MessageForm.Show("Por favor introduzca ID y Contraseñaa (Ambos)", "No se puede acceder");
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void cerrarSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                if (MessageForm.Show("¿Seguro que desear cerrar sesión?", "Cerrando sesión", enumMessageIcon.Question, enumMessageButton.YesNo) == DialogResult.Yes)
                {
                    CerrarSesion();
                }
            }
            else { MessageForm.Show("No se puede cerrar sesión porque hay uno o mas modulos ejecutandose", "Atención", enumMessageIcon.Question, enumMessageButton.OK); }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void manualDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            manualFrm miManualFrm = new manualFrm();

            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(manualFrm)){formularioAbierto = true;}
                else { formularioAbierto = false; }

            }

            if (formularioAbierto == false)
            {
                miManualFrm.Show();
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void manualBtn_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            manualFrm miManualFrm = new manualFrm();

            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(manualFrm)) { formularioAbierto = true; }
                else { formularioAbierto = false; }

            }

            if (formularioAbierto == false)
            {
                miManualFrm.Show();
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            NuevoProductoForm miNuevoProductoForm = new NuevoProductoForm();

            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(NuevoProductoForm))
                {
                    formularioAbierto = true;
                }
                else { formularioAbierto = false; }

            }

            if (formularioAbierto == false)
            {
                miNuevoProductoForm.Show();
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void nuevoProductoBtn_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            NuevoProductoForm miNuevoProductoForm = new NuevoProductoForm();

            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(NuevoProductoForm))
                {
                    formularioAbierto = true;
                }
                else { formularioAbierto = false; }
            }

            if (formularioAbierto == false)
            {
                miNuevoProductoForm.Show();
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void actualizarInventarioBtn_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            ActualizarInventario miActualizarInventario = new ActualizarInventario("ventas");
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(ActualizarInventario))
                {
                    formularioAbierto = true;
                }
                else { formularioAbierto = false; }
            }

            if (formularioAbierto == false)
            {
                miActualizarInventario.Show();
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void usuarioTbx_TextChanged(object sender, EventArgs e)
        {
            if (usuarioTbx.Text == "") usuarioTbx.BackColor = Color.FromArgb(81, 81, 81);
            else usuarioTbx.BackColor = Color.White;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void passwordTbx_TextChanged(object sender, EventArgs e)
        {
            if (passwordTbx.Text == "") passwordTbx.BackColor = Color.FromArgb(81, 81, 81);
            else passwordTbx.BackColor = Color.White;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void UsuarioIdMskTb_TextChanged(object sender, EventArgs e)
        {
            if (UsuarioIdMskTb.Text == "") UsuarioIdMskTb.BackColor = Color.FromArgb(81, 81, 81);
            else UsuarioIdMskTb.BackColor = Color.White;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void nPasswordTb_TextChanged(object sender, EventArgs e)
        {
            if (nPasswordTb.Text == "") nPasswordTb.BackColor = Color.FromArgb(81, 81, 81);
            else nPasswordTb.BackColor = Color.White;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void nNombreTb_TextChanged(object sender, EventArgs e)
        {
            if (nNombreTb.Text == "") nNombreTb.BackColor = Color.FromArgb(81, 81, 81);
            else nNombreTb.BackColor = Color.White;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void nTelefonoTb_TextChanged(object sender, EventArgs e)
        {
            if (nTelefonoTb.Text == "") nTelefonoTb.BackColor = Color.FromArgb(81, 81, 81);
            else nTelefonoTb.BackColor = Color.White;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void logPanel_Click(object sender, EventArgs e)
        {
            usuarioTbx.Focus();
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void consultarInventarioBtn_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            ConsutarInventario consultarInventario = new ConsutarInventario("inventario");
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(ConsutarInventario))
                {
                    formularioAbierto = true;
                }
                else { formularioAbierto = false; }
            }

            if (formularioAbierto == false)
            {
                consultarInventario.Show();
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void opcionesBtn_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            frmAdministrar miAdministrar = new frmAdministrar("adm_inventario");
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(frmAdministrar))
                {
                    formularioAbierto = true;
                }
                else { formularioAbierto = false; }
            }
            //
            if (formularioAbierto == false)
            {
                if (MiUsarioActivo.administrador) miAdministrar.Show();
                else
                {
                    frmAutenticate miAutenticate = new frmAutenticate();
                    if (miAutenticate.ShowDialog() == DialogResult.OK) miAdministrar.Show();
                }
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            ActualizarInventario miActualizarInventario = new ActualizarInventario("ventas");
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(ActualizarInventario))
                {
                    formularioAbierto = true;
                }
                else formularioAbierto = false; 
            }

            if (formularioAbierto == false) miActualizarInventario.Show();
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            ActualizarInventario miActualizarInventario = new ActualizarInventario("compras");
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(ActualizarInventario))
                {
                    formularioAbierto = true;
                }
                else formularioAbierto = false;
            }

            if (formularioAbierto == false) miActualizarInventario.Show();
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void devolucionesDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            ActualizarInventario miActualizarInventario = new ActualizarInventario("dev_compras");
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(ActualizarInventario))
                {
                    formularioAbierto = true;
                }
                else formularioAbierto = false;
            }

            if (formularioAbierto == false) miActualizarInventario.Show();
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void devolucionesDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            ActualizarInventario miActualizarInventario = new ActualizarInventario("dev_ventas");
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(ActualizarInventario))
                {
                    formularioAbierto = true;
                }
                else formularioAbierto = false;
            }

            if (formularioAbierto == false) miActualizarInventario.Show();
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void AdmInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MiUsarioActivo.administrador)
            {
                frmAdministrar miOpciones = new frmAdministrar("adm_inventario");
                miOpciones.Show();
            }
            else
            {
                frmAutenticate miAutenticate = new frmAutenticate();
                if (miAutenticate.ShowDialog() == DialogResult.OK)
                {
                    frmAdministrar miOpciones = new frmAdministrar("adm_inventario");
                    miOpciones.Show();
                }
            }

        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void AdmUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MiUsarioActivo.administrador)
            {
                frmAdministrar miOpciones = new frmAdministrar("adm_usuarios");
                miOpciones.Show();
            }
            else
            {
                frmAutenticate miAutenticate = new frmAutenticate();
                if (miAutenticate.ShowDialog() == DialogResult.OK)
                {
                    frmAdministrar miOpciones = new frmAdministrar("adm_usuarios");
                    miOpciones.Show();
                }
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void recursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MiUsarioActivo.administrador)
            {
                frmAdministrar miOpciones = new frmAdministrar("adm_elementos");
                miOpciones.Show();
            }
            else
            {
                frmAutenticate miAutenticate = new frmAutenticate();
                if (miAutenticate.ShowDialog() == DialogResult.OK)
                {
                    frmAdministrar miOpciones = new frmAdministrar("adm_elementos");
                    miOpciones.Show();
                }
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void copiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            frmBackup respaldarDatos = new frmBackup();
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(frmBackup))
                {
                    formularioAbierto = true;
                }
                else { formularioAbierto = false; }
            }
            //
            if (formularioAbierto == false)
            {
                if (MiUsarioActivo.administrador) respaldarDatos.Show();
                else
                {
                    frmAutenticate miAutenticate = new frmAutenticate();
                    if (DialogResult.OK == miAutenticate.ShowDialog()) respaldarDatos.Show();
                }
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void restaurarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            frmRestore restaurarDatos = new frmRestore();
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(frmRestore))
                {
                    formularioAbierto = true;
                }
                else { formularioAbierto = false; }
            }
            //
            if (formularioAbierto == false)
            {
                if (MiUsarioActivo.administrador) restaurarDatos.Show();
                else
                {
                    frmAutenticate miAutenticate = new frmAutenticate();
                    if (DialogResult.OK == miAutenticate.ShowDialog()) restaurarDatos.Show();
                }
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            ConsutarInventario consultarInventario = new ConsutarInventario("inventario");
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(ConsutarInventario))
                {
                    formularioAbierto = true;
                }
                else { formularioAbierto = false; }
            }

            if (formularioAbierto == false)
            {
                consultarInventario.Show();
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void consultarUnProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            ConsutarInventario consultarInventario = new ConsutarInventario("en_baja");
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(ConsutarInventario))
                {
                    formularioAbierto = true;
                }
                else { formularioAbierto = false; }
            }

            if (formularioAbierto == false)
            {
                consultarInventario.Show();
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void productosEnBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;
            ConsutarInventario consultarInventario = new ConsutarInventario("cons_producto");
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(ConsutarInventario))
                {
                    formularioAbierto = true;
                }
                else { formularioAbierto = false; }
            }

            if (formularioAbierto == false)
            {
                consultarInventario.Show();
            }
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreditos miCreditos = new frmCreditos();
            miCreditos.ShowDialog();
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
    }
}