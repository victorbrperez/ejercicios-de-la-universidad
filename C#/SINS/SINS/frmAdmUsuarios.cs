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
    public partial class frmAdmusuarios : Form
    {
        public frmAdmusuarios(Utiles.DbItem tarea, int userId)
        {
            InitializeComponent();
            Mantenimiento mant = new Mantenimiento();
            tiposUsuairos = mant.traerTiposUsuarios();
            usuarioActual = new Usuario();
            usuarioActual.Id = userId;
            modo = tarea;
            //
            if (tarea == Utiles.DbItem.Nuevo)
            {
                prepararParaNuevo();

            }
            else if (tarea == Utiles.DbItem.Actualizar)
            {
                prepararParaEditar();
            }
        }
        Usuario usuarioActual;
        List<TipoUsuario> tiposUsuairos;
        Utiles.DbItem modo;
        /// <summary>
        /// Prepara el formulario para modificar los datos del usuario
        /// </summary>
        void prepararParaEditar()
        {
            lblTitulo.Text = "Actualización de datos del usuario";
            gbxNuevoUsuario.Text = "Datos del usuario";
            pbxActualizar.Visible = true;
            cargarInformacionDelUsuario();
            pbxNuevo.Visible = false;
        }
        /// <summary>
        /// Prepara el formulario para registrar un nuevo usuario
        /// </summary>
        void prepararParaNuevo()
        {
            lblTitulo.Text = "Creación de usuario nuevo";
            pbxActualizar.Visible = false;
            pbxNuevo.Visible = true;
        }
        /// <summary>
        /// Establece los datos del usuario actual
        /// </summary>
        void asignarDatosUsuarioActual()
        {
            if(modo == Utiles.DbItem.Nuevo)
                usuarioActual = new Usuario();

            usuarioActual.Nombre_usuario = tbxNombreUsuario.Text;
            usuarioActual.Nombre = tbxNombre.Text;
            usuarioActual.Password = Utilidades.encriptar(tbxPassword.Text);
            usuarioActual.Apellidos = tbxApellidos.Text;
            usuarioActual.Telefono = tbxTelefono.Text;
            foreach (TipoUsuario tu in tiposUsuairos)
            {
                if (tu.Titulo == cbbxTipoUsuario.Text)
                {
                    usuarioActual.Tipo_usuario = tu.Id;
                }
            }
        }

        /// <summary>
        /// Carga la informacion del usuario seleccionado en los campos para su edicion
        /// </summary>
        void cargarInformacionDelUsuario()
        {
            if (usuarioActual.Id != 0)
            {
                if (usuarioActual.buscarDatos(Utiles.DbOptionSelect.Todo))
                {
                    tbxNombreUsuario.Text = usuarioActual.Nombre_usuario;
                    tbxNombre.Text = usuarioActual.Nombre;
                    tbxApellidos.Text = usuarioActual.Apellidos;
                    tbxTelefono.Text = usuarioActual.Telefono;
                    foreach (TipoUsuario tUs in tiposUsuairos)
                    {
                        if (tUs.Id == usuarioActual.Tipo_usuario)
                        {
                            cbbxTipoUsuario.Text = tUs.Titulo;
                            break;
                        }
                    }
                }
            }
            
        }
        /// <summary>
        /// Metod para validar que las contrasenas sean las mismas
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        bool validadPassword(ref TextBox p1, ref TextBox p2)
        {
            bool r = false;

            if (p1.Text == p2.Text)
            {
                if (!(string.IsNullOrEmpty(p1.Text) || string.IsNullOrEmpty(p2.Text)))
                {
                    p1.BackColor = Color.LightGreen;
                    p2.BackColor = Color.LightGreen;
                }
                r = true;
            }
            else
            {
                r = false;
                p1.BackColor = Color.FromArgb(255, 204, 188);
                p2.BackColor = Color.FromArgb(255, 204, 188);
            }

            return r;
        }

        /// <summary>
        /// METODO QUE VALIDA SI LOS CAMPOS ESTAN VACIOS DESDE UN TabPage
        /// </summary>
        /// <returns>int</returns>
        int validarCamposVacios(ref GroupBox gbx)
        {
            int r = 0;
            //
            foreach(Control ctrl in gbx.Controls)
            {
                if (ctrl.GetType().Equals(typeof(TextBox)))
                {
                    if (ctrl.Tag.ToString() == "*")
                    {
                        if (string.IsNullOrEmpty(ctrl.Text))
                        {
                            ctrl.BackColor = Color.FromArgb(255, 204, 188);
                            r++;
                        }
                    }
                }
            }
            if(cbbxTipoUsuario.SelectedIndex == 0)
            {
                cbbxTipoUsuario.BackColor = Color.FromArgb(255, 204, 188);
                r++;
            }
            return r;
        }
        /// <summary>
        /// Limpia los campos de un groupbox
        /// </summary>
        /// <param name="gbx"></param>
        void limpiarDatosGroupBox(ref GroupBox gbx)
        {
            foreach (Control ctrl in gbx.Controls)
            {
                if (ctrl.GetType().Equals(typeof(TextBox)) || (ctrl.GetType().Equals(typeof(MaskedTextBox))))
                {
                    ctrl.Text = "";
                }
            }
        }
        /// <summary>
        /// Metodo para llenar los ComboBox de tipo de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbxNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            tbxNombreUsuario.BackColor = Color.White;
        }

        private void tbxPassword1_TextChanged(object sender, EventArgs e)
        {
            tbxPassword.BackColor = Color.White;
        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {
            tbxNombre.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (0 == validarCamposVacios(ref gbxNuevoUsuario))
            {
                if (validadPassword(ref tbxPassword,ref tbxConfirmarPassword))
                {
                    asignarDatosUsuarioActual();
                    if (modo == Utiles.DbItem.Nuevo)
                    {
                        if (usuarioActual.Registrar())
                        {
                            MessageBox.Show("El usuario ha sido creado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else MessageBox.Show("Error: no se ha podido crear el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (modo == Utiles.DbItem.Actualizar)
                    {
                        if (usuarioActual.Actualizar())
                        {
                            MessageBox.Show("La información del usuario se ha actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else MessageBox.Show("Error: no se ha podido actualizar la información del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else MessageBox.Show("Las contraseñas no coinciden ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Hay campos que requieren se llenados antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tbxNombreUsuario_TextChanged_1(object sender, EventArgs e)
        {
            tbxNombreUsuario.BackColor = Color.White;
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            tbxPassword.BackColor = Color.White;
        }

        private void tbxConfirmarPassword_TextChanged(object sender, EventArgs e)
        {
            tbxConfirmarPassword.BackColor = Color.White;
        }

        private void tbxNombre_TextChanged_1(object sender, EventArgs e)
        {
            tbxNombre.BackColor = Color.White;
        }

        private void frmConfiguracionSistema_Load(object sender, EventArgs e)
        {
            foreach (TipoUsuario tUsuario in tiposUsuairos)
            {
                cbbxTipoUsuario.Items.Add(tUsuario.Titulo);
            }
            cbbxTipoUsuario.Items.Insert(0,"Seleccionar");
            cbbxTipoUsuario.SelectedIndex = 0;
        }

        private void tbxConfirmarPassword_Leave(object sender, EventArgs e)
        {
            validadPassword(ref tbxPassword, ref tbxConfirmarPassword);
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            validadPassword(ref tbxPassword, ref tbxConfirmarPassword);
        }

        private void cbbxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbxTipoUsuario.BackColor = Color.White;
        }
    }
}
