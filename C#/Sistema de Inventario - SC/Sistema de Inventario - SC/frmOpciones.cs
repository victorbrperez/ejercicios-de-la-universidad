using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClases;

namespace Sistema_de_Inventario_SC
{
    public partial class frmAdministrar : Form,IForm,IBuscar3
    {
        public frmAdministrar(string operacionValule)
        {
            InitializeComponent();
            operacion_activa = operacionValule;
        }
        const string tabla_productos = "productos";
        DataSet dsProductosAll = new DataSet();
        DataSet dsUsuarios = new DataSet();
        string operacion_activa;
        //================ INTERFACES ================================================================================================================
        #region IForm Members
        //
        public void ActualizarMGP(string txtValue)
        {
            tbMGP.Text = txtValue;
        }
        public void ActualizarMGM(string txtValue)
        {
            tbMGM.Text = txtValue;
        }
        #endregion
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        #region IBuscar3 Members
        //
        public void PonerCodigoEditar(string txtValue)
        {
            mskCodigo.Text = txtValue;
        }
        public void PonerCodigoEliminar(string txtValue)
        {
            mskCodigoEliminar.Text = txtValue;
        }
        //
        #endregion
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        //===============METODOS DEFINIDOS POR EL PROGRAMADOR=========================================================================================
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void CargarUsuarios()
        {
            BindingSource bdsUsuarios = new BindingSource();
            DataSet dsTemp = new DataSet();
            Usuario miUsuario = new Usuario();
            dsTemp = miUsuario.Buscar("todos");
            dsUsuarios = dsTemp;
            bdsUsuarios.DataSource = dsTemp;
            bdsUsuarios.DataMember = "usuarios";
            //
            cbxUsuarioEditar.DataSource = bdsUsuarios;
            cbxUsuarioEditar.DisplayMember = "nombre";
            cbxUsuarioEliminar.DataSource = bdsUsuarios;
            cbxUsuarioEliminar.DisplayMember = "nombre";
            dsTemp.Dispose();
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private bool ValidarFormulario()
        {
            bool validacion = true;//Variable con el valor que sera devuelto por el metodo.
            if (tbReferencia.Text == "") validacion = false;
            if (tbDescripcion.Text == "") validacion = false;
            if (tbCosto.Text == "") validacion = false;
            if (tbMGP.Text == "") validacion = false;
            if (tbMGM.Text == "") validacion = false;
            if (tbItbis.Text == "") validacion = false;
            if (tbDescuento.Text == "") validacion = false;
            return validacion;
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void Seleccionar(string opcion)
        //Metodo que selecciona o muestra el panel de una operacion determinada y oculta los demas
        {
            switch (opcion)
            {
                case "adm_inventario":
                    btnAdmInventario.BackColor = Color.FromArgb(193, 220, 34);
                    operacion_activa = opcion;
                    panelAdmInventario.Visible = true;
                    panelAdmUsuarios.Visible = false;
                    panelAdmElementos.Visible = false;
                    Producto miProducto = new Producto();
                    dsProductosAll = miProducto.Buscar("todos");
                    mskCodigo.TabIndex = 1;
                    mskCodigo.Focus();
                    CargarRecursos(operacion_activa,"todos");
                    break;
                case "adm_usuarios":
                    btnAdmUsuarios.BackColor = Color.FromArgb(193, 220, 34);
                    operacion_activa = opcion;
                    panelAdmInventario.Visible = false;
                    panelAdmUsuarios.Visible = true;
                    panelAdmElementos.Visible = false;
                    AcceptButton = btnUsuariosGuardar;
                    CargarUsuarios();
                    break;
                case "adm_elementos":
                    operacion_activa = opcion;
                    btnAdmElementos.BackColor = Color.FromArgb(193, 220, 34);
                    panelAdmInventario.Visible = false;
                    panelAdmUsuarios.Visible = false;
                    panelAdmElementos.Visible = true;
                    CargarRecursos(operacion_activa, "todos");
                    tbNombreMarca.Focus();
                    break;
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void Deseleccionar(string opcion)
        {
            switch (opcion)
            {
                case "adm_inventario":
                    btnAdmInventario.BackColor = Color.FromArgb(241, 241, 241);
                    break;
                case "adm_usuarios":
                    btnAdmUsuarios.BackColor = Color.FromArgb(241, 241, 241);
                    break;
                case "adm_elementos":
                    btnAdmElementos.BackColor = Color.FromArgb(241, 241, 241);
                    break;
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnAdmInventario_Click(object sender, EventArgs e)
        {
            Seleccionar("adm_inventario");
            Deseleccionar("adm_usuarios");
            Deseleccionar("adm_elementos");
            mskCodigo.Focus();
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnAdmUsuarios_Click(object sender, EventArgs e)
        {
            Seleccionar("adm_usuarios");
            Deseleccionar("adm_inventario");
            Deseleccionar("adm_elementos");
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnAdmElementos_Click(object sender, EventArgs e)
        {
            Deseleccionar("adm_usuarios");
            Deseleccionar("adm_inventario");
            Seleccionar("adm_elementos");
            
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void CargarRecursos(string tarea,string recursos)
        {
            DataSet dsTemp = new DataSet();
            //
            if(recursos == "marcas" || recursos == "todos")
            {
                BindingSource bdsMarcas = new BindingSource();
                Marca miMarca = new Marca();
                dsTemp = miMarca.Buscar();
                bdsMarcas.DataSource = dsTemp;
                bdsMarcas.DataMember = "marcas";
                if (tarea == "adm_inventario")
                {
                    marcaCbx.DataSource = bdsMarcas;
                    marcaCbx.DisplayMember = "nombre";
                }   
                else if (tarea == "adm_elementos")
                {
                    
                    cbxMarcas.DataSource = bdsMarcas;
                    cbxMarcas.DisplayMember = "nombre";
                }
                dsTemp.Dispose();
            }
            if (recursos == "unidades" || recursos == "todos")
            {
                BindingSource bdsUnidades = new BindingSource();
                Unidad miUnidad = new Unidad();
                dsTemp = miUnidad.Buscar();
                bdsUnidades.DataSource = dsTemp;
                bdsUnidades.DataMember = "unidades";
                if (tarea == "adm_inventario")
                {
                    unidadCbx.DataSource = bdsUnidades;
                    unidadCbx.DisplayMember = "nombre";
                }
                else if (tarea == "adm_elementos")
                {
                    cbxUnidadEliminar.DataSource = bdsUnidades;
                    cbxUnidadEliminar.DisplayMember = "nombre";
                }
                dsTemp.Dispose();
            }
            if (recursos == "ubicaciones" || recursos == "todos")
            {
                BindingSource bdsUbicaciones = new BindingSource();
                Ubicacion miUbicacion = new Ubicacion();
                dsTemp = miUbicacion.Buscar();
                bdsUbicaciones.DataSource = dsTemp;
                bdsUbicaciones.DataMember = "ubicaciones";
                if (tarea == "adm_inventario")
                {
                    ubicacionCbx.DataSource = bdsUbicaciones;
                    ubicacionCbx.DisplayMember = "nombre";
                }
                else if (tarea == "adm_elementos")
                {

                    cbxUbicaciones.DataSource = bdsUbicaciones;
                    cbxUbicaciones.DisplayMember = "nombre";
                }
                dsTemp.Dispose();
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void mskCodigo_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dsProductosAll.Tables[tabla_productos].Rows.Count; i++)
            {
                if (dsProductosAll.Tables[tabla_productos].Rows[i]["codigo"].ToString() == mskCodigo.Text)
                {
                    tbReferencia.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["referencia"].ToString();
                    tbDescripcion.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["descripcion"].ToString();
                    unidadCbx.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["unidad"].ToString();
                    marcaCbx.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["marca"].ToString();
                    cantidadNUD.Value = Convert.ToDecimal(dsProductosAll.Tables[tabla_productos].Rows[i]["cantidad"].ToString());
                    tbCosto.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["costo"].ToString();
                    tbMGP.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["mgp"].ToString();
                    tbMGM.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["mgm"].ToString();
                    tbItbis.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["itbis"].ToString();
                    ubicacionCbx.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["ubicacion"].ToString();
                    minimoExistenciaNUD.Value = Convert.ToDecimal(dsProductosAll.Tables[tabla_productos].Rows[i]["minimo_existencia"].ToString());
                    fechaDtT.Value = Convert.ToDateTime(dsProductosAll.Tables[tabla_productos].Rows[i]["fecha"].ToString());
                    tbNota.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["nota"].ToString();
                    lbEncontrado1.Text = "si";
                    AcceptButton = btnProductoGuardar;
                    break;
                }
                else
                {
                tbCosto.Text = "";
                tbMGP.Text = "";
                tbMGM.Text = "";
                tbPrecioVentaPred.Text = "";
                tbPrecioVentaMay.Text = "";
                tbReferencia.Text = "";
                tbDescripcion.Text = "";
                tbItbis.Text = "";
                cantidadNUD.Value = 0;
                minimoExistenciaNUD.Value = 0;
                tbNota.Text = "";
                lbEncontrado1.Text = "no";
                }
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbCosto_TextChanged(object sender, EventArgs e)
        {
             double costo = 0;
            double itbis;
            double mgp;
            double mgm;
            //
            try
            {
                if (tbCosto.Text != "") costo = Convert.ToDouble(tbCosto.Text);
                else costo = 0;
            }
            catch { tbCosto.Text = ""; }
            if (tbMGP.Text != "") mgp = Convert.ToDouble(tbMGP.Text);
            else mgp = 0;
            if (tbMGM.Text != "") mgm = Convert.ToDouble(tbMGM.Text);
            else mgm = 0;
            if (tbItbis.Text != "") itbis = Convert.ToDouble(tbItbis.Text);
            else itbis = 0;
            //
            double pvpBruto = costo / (1 - mgp / 100);
            double pvmBruto = costo / (1 - mgm / 100);
            double pvp = pvpBruto + (pvpBruto * itbis / 100);
            double pvm = pvmBruto + (pvmBruto * itbis / 100);
            //
            tbDescuento.Text = "0";
            tbCostoNeto.Text = costo.ToString("0.00");
            tbPrecioVentaPred.Text = pvp.ToString("0.00");
            tbPrecioVentaMay.Text = pvm.ToString("0.00");
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbMGP_TextChanged(object sender, EventArgs e)
        {
            double costo;
            double itbis;
            double mgp = 0;
            double descuento;
            //
            if (tbCosto.Text != "") costo = Convert.ToDouble(tbCosto.Text);
            else costo = 0;
            try
            {
                if (tbMGP.Text != "") mgp = Convert.ToDouble(tbMGP.Text);
                else mgp = 0;
            }
            catch { tbMGP.Text = ""; }
            if (tbItbis.Text != "") itbis = Convert.ToDouble(tbItbis.Text);
            else itbis = 0;
            if (tbDescuento.Text != "") descuento = Convert.ToDouble(tbDescuento.Text);
            else descuento = 0;
            //
            costo -= ((costo * descuento) / 100);
            double pvpBruto = costo / (1 - mgp / 100);
            double pvp = pvpBruto + (pvpBruto * itbis / 100);
            //
            tbPrecioVentaPred.Text = pvp.ToString("0.00");
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbMGM_TextChanged(object sender, EventArgs e)
        {
            double costo;
            double itbis;
            double mgm = 0;
            double descuento;
            //
            if (tbCosto.Text != "") costo = Convert.ToDouble(tbCosto.Text);
            else costo = 0;
            try
            {
                if (tbMGM.Text != "") mgm = Convert.ToDouble(tbMGM.Text);
                else mgm = 0;
            }
            catch { tbMGM.Text = ""; }
            if (tbItbis.Text != "") itbis = Convert.ToDouble(tbItbis.Text);
            else itbis = 0;
            if (tbDescuento.Text != "") descuento = Convert.ToDouble(tbDescuento.Text);
            else descuento = 0;
            //
            costo -= ((costo * descuento) / 100);
            double pvmBruto = costo / (1 - mgm / 100);
            double pvm = pvmBruto + (pvmBruto * itbis / 100);
            //
            tbPrecioVentaMay.Text = pvm.ToString("0.00");
        }

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            Seleccionar(operacion_activa);
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbItbis_TextChanged(object sender, EventArgs e)
        {
            double costo;
            double itbis = 0;
            double mgp;
            double mgm;
            //
            if (tbCostoNeto.Text != "") costo = Convert.ToDouble(tbCostoNeto.Text);
            else costo = 0;
            if (tbMGP.Text != "") mgp = Convert.ToDouble(tbMGP.Text);
            else mgp = 0;
            if (tbMGM.Text != "") mgm = Convert.ToDouble(tbMGM.Text);
            else mgm = 0;
            try
            {
                if (tbItbis.Text != "") itbis = Convert.ToDouble(tbItbis.Text);
                else
                {
                    itbis = 0;
                    tbItbis.Text = "0";
                }
            }
            catch { tbItbis.Text = ""; }
            //
            double pvpBruto = costo / (1 - mgp / 100);
            double pvp = pvpBruto + (pvpBruto * itbis / 100);
            double pvmBruto = costo / (1 - mgm / 100);
            double pvm = pvmBruto + (pvmBruto * itbis / 100);
            //
            tbPrecioVentaPred.Text = pvp.ToString("0.00");
            tbPrecioVentaMay.Text = pvm.ToString("0.00");
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbDescuento_TextChanged(object sender, EventArgs e)
        {
            double costo;
            double itbis;
            double mgp;
            double mgm;
            double descuento = 0;
            //
            if (tbCosto.Text != "") costo = Convert.ToDouble(tbCosto.Text);
            else costo = 0;
            try
            {
                if (tbDescuento.Text != "") descuento = Convert.ToDouble(tbDescuento.Text);
                else descuento = 0;
            }
            catch { tbDescuento.Text = ""; }
            if (tbMGP.Text != "") mgp = Convert.ToDouble(tbMGP.Text);
            else mgp = 0;
            if (tbMGM.Text != "") mgm = Convert.ToDouble(tbMGM.Text);
            else mgm = 0;
            if (tbItbis.Text != "") itbis = Convert.ToDouble(tbItbis.Text);
            else itbis = 0;
            //
            costo -= (costo * descuento / 100);
            double pvpBruto = costo / (1 - mgp / 100);
            double pvmBruto = costo / (1 - mgm / 100);
            double pvp = pvpBruto + (pvpBruto * itbis / 100);
            double pvm = pvmBruto + (pvmBruto * itbis / 100);
            //
            tbCostoNeto.Text = costo.ToString("0.00");
            tbPrecioVentaPred.Text = pvp.ToString("0.00");
            tbPrecioVentaMay.Text = pvm.ToString("0.00");
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button1_Click(object sender, EventArgs e)
        {
            Producto miProducto = new Producto();
            if (mskCodigo.Text != "")
            {
                if (lbEncontrado1.Text == "si")
                {
                    miProducto.Codigo = Convert.ToInt32(mskCodigo.Text);
                    //
                    if (ValidarFormulario())
                    {
                        miProducto.Referencia = tbReferencia.Text;
                        miProducto.Descripcion = tbDescripcion.Text;
                        miProducto.Unidad = unidadCbx.Text;
                        miProducto.Marca = marcaCbx.Text;
                        miProducto.Cantidad = Convert.ToInt32(cantidadNUD.Value);
                        miProducto.MGP = Convert.ToDouble(tbMGP.Text);
                        miProducto.MGM = Convert.ToDouble(tbMGM.Text);
                        miProducto.Costo = Convert.ToDouble(tbCostoNeto.Text);
                        miProducto.Itbis = Convert.ToDouble(tbItbis.Text);
                        miProducto.Ubicacion = ubicacionCbx.Text;
                        miProducto.MinimoExistencia = Convert.ToInt32(minimoExistenciaNUD.Value);
                        miProducto.Fecha = fechaDtT.Value;
                        miProducto.Nota = tbNota.Text;
                        //
                        if (miProducto.Actualizar("cambios"))
                        {
                            MessageForm.Show("Cambios guardados satisfactoriamente", "Mensage del sistema");
                        }
                        else { MessageForm.Show("No se han podido guardar los cambios", "Error con la base de datos"); }
                        CargarRecursos(operacion_activa, "todos");
                    }
                    else MessageForm.Show("Porfavor llene todos los campos", "Atencion");
                }
                else MessageForm.Show("Este producto no se encuetra registrado", "Atención");
                    
            }
            else MessageForm.Show("Por favor seleccione un producto","Atencion");
            mskCodigo.Focus();
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void SugerirPreciosLkLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool formularioAbierto = false;
            //
            try
            {
                SugerirPrecios miSugerirPrecios = new SugerirPrecios(Convert.ToDouble(tbItbis.Text), Convert.ToDouble(tbCosto.Text), Convert.ToDouble(tbDescuento.Text), "nuevo_producto");
                foreach (Form fmTemp in Application.OpenForms)
                {
                    if (fmTemp.GetType() == typeof(SugerirPrecios))
                    {
                        formularioAbierto = true;
                    }
                    else { formularioAbierto = false; }
                }

                if (formularioAbierto == false) { miSugerirPrecios.Show(this); }
            }
            catch
            {
                MessageForm.Show(@"Primero llene el campo ""Costo""", "Advertencia");
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void mskCodigoEliminar_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dsProductosAll.Tables[tabla_productos].Rows.Count; i++)
            {
                if (dsProductosAll.Tables[tabla_productos].Rows[i]["codigo"].ToString() == mskCodigoEliminar.Text)
                {
                    tbReferenciaEliminar.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["referencia"].ToString();
                    tbDescripcionEliminar.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["descripcion"].ToString();
                    tbMarcaEliminar.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["marca"].ToString();
                    tbCantidadEliminar.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["cantidad"].ToString();
                    tbNotaEliminar.Text = dsProductosAll.Tables[tabla_productos].Rows[i]["nota"].ToString();
                    lbEncontrado.Text = "si";
                    AcceptButton = btnProductoEliminar;
                    break;
                }
                else
                {
                    tbMarcaEliminar.Text = "";
                    tbDescripcionEliminar.Text = "";
                    tbReferenciaEliminar.Text = "";
                    tbNotaEliminar.Text = "";
                    tbCantidadEliminar.Text = "0";
                    lbEncontrado.Text = "no";
                }
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tabPage2_Click(object sender, EventArgs e)
        {
            mskCodigoEliminar.Focus();
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button4_Click(object sender, EventArgs e)
        {
            Producto miProducto = new Producto();
            if (mskCodigoEliminar.Text != "")
            {
                if (lbEncontrado.Text == "si")
                {
                    miProducto.Codigo = Convert.ToInt32(mskCodigoEliminar.Text);
                    //
                    if (DialogResult.Yes == MessageForm.Show("Seguro que desea eliminar este producto?", "Advertencia", enumMessageIcon.Question, enumMessageButton.YesNo))
                    {
                        if (miProducto.Eliminar())
                        {
                            MessageForm.Show("Producto eliminado satisfactoriamente", "Mensaje");
                            //
                            tbMarcaEliminar.Text = "";
                            tbDescripcionEliminar.Text = "";
                            tbReferenciaEliminar.Text = "";
                            tbNotaEliminar.Text = "";
                            tbCantidadEliminar.Text = "0";
                        }
                    }
                }
                else MessageForm.Show("Este producto no se encuetra registrado", "Atención");
            }
            else MessageForm.Show("Por favor seleccione un producto","Atención");
            mskCodigoEliminar.Focus();
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbctrlAdmInventario_Click(object sender, EventArgs e)
        {
            if (tbctrlAdmInventario.SelectedTab.Name == "tabPageEditarProd")
            {
                mskCodigo.Focus();
            }
            else mskCodigoEliminar.Focus();
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbDescripcionEliminar_TextChanged(object sender, EventArgs e)
        {

        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnBuscarCompras_Click(object sender, EventArgs e)
        {
            BuscarProductos miBuscarProductos = new BuscarProductos("editar_producto");
            bool formulario_abierto = false;
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(BuscarProductos))
                {
                    formulario_abierto = true;
                }
                else { formulario_abierto = false; }
            }
            if (formulario_abierto == false)
            {
                miBuscarProductos.Show(this);
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button5_Click(object sender, EventArgs e)
        {
            BuscarProductos miBuscarProductos = new BuscarProductos("eliminar_producto");
            bool formulario_abierto = false;
            foreach (Form fmTemp in Application.OpenForms)
            {
                if (fmTemp.GetType() == typeof(BuscarProductos))
                {
                    formulario_abierto = true;
                }
                else { formulario_abierto = false; }
            }
            if (formulario_abierto == false)
            {
                miBuscarProductos.Show(this);
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnAgregarUDS_Click(object sender, EventArgs e)
        {
            CargarRecursos(operacion_activa, "todos");
            //
            frmNuevoElemento miRecurso = new frmNuevoElemento("unidad");
            bool form_abierto = false;
            foreach (Form frmTemp in Application.OpenForms)
            {
                if (frmTemp.GetType() == typeof(frmNuevoElemento))
                {
                    form_abierto = true;
                }
                else form_abierto = false;
            }
            if (form_abierto == false) miRecurso.Show(this);
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button2_Click(object sender, EventArgs e)
        {
            CargarRecursos(operacion_activa, "todos");
            //
            frmNuevoElemento miRecurso = new frmNuevoElemento("marca");
            bool form_abierto = false;
            foreach (Form frmTemp in Application.OpenForms)
            {
                if (frmTemp.GetType() == typeof(frmNuevoElemento))
                {
                    form_abierto = true;
                }
                else form_abierto = false;
            }
            if (form_abierto == false) miRecurso.Show(this);
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button3_Click(object sender, EventArgs e)
        {
            CargarRecursos(operacion_activa, "todos");
            //
            frmNuevoElemento miRecurso = new frmNuevoElemento("ubicacion");
            bool form_abierto = false;
            foreach (Form frmTemp in Application.OpenForms)
            {
                if (frmTemp.GetType() == typeof(frmNuevoElemento))
                {
                    form_abierto = true;
                }
                else form_abierto = false;
            }
            if (form_abierto == false) miRecurso.Show(this);
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void registrarBtn_Click(object sender, EventArgs e)
        {
            Usuario miUsuario = new Usuario();
            if (cbxUsuarioEditar.Text != "" || cbxUsuarioEditar.Text != "Seleccionar usuario")
            {
                miUsuario.Nombre = cbxUsuarioEditar.Text;
                if (tbPassword.Text != "" && tbTelefono.Text != "")
                {
                    miUsuario.Password = tbPassword.Text;
                    miUsuario.Telefono = tbTelefono.Text;
                    miUsuario.Id = Convert.ToInt32(mskId.Text);
                    if (miUsuario.Actualizar()) MessageForm.Show("Usuario actualizado correctamente","Mensaje");
                    else MessageForm.Show("Error con la base de datos no se ha podido actualizar usuario","Atención");
                }
            }
            else MessageForm.Show("Introduzca un nombre para el usuario", "Atención");
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (UsuarioIdMskTb.Text != "" && nPasswordTb.Text != "" && nTelefonoTb.Text != "" && nNombreTb.Text != "")
            {
                Usuario miUsuario = new Usuario();
                miUsuario.Id = Convert.ToInt32(UsuarioIdMskTb.Text);
                miUsuario.Nombre = nNombreTb.Text;
                miUsuario.Password = nPasswordTb.Text;
                miUsuario.Telefono = nTelefonoTb.Text;
                if (chkbxAdministrador.Checked) miUsuario.Administrador = true;
                else miUsuario.Administrador = false;
                if (miUsuario.Registrar()) MessageForm.Show("Usuario registrado satisfactoriamente", "Mensaje");
                else MessageForm.Show("Usuario no se pudo registrar error en la base de datos", "Atención");
            }
            else { MessageForm.Show("Debe llenar todos los campos", "Campos vacíos"); }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void cbxUsuarioEditar_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dsUsuarios.Tables["usuarios"].Rows.Count; i++)
            {
                if (dsUsuarios.Tables["usuarios"].Rows[i]["nombre"].ToString() == cbxUsuarioEditar.Text)
                {
                    mskId.Text = dsUsuarios.Tables["usuarios"].Rows[i]["id"].ToString();
                    tbTelefono.Text = dsUsuarios.Tables["usuarios"].Rows[i]["telefono"].ToString();
                    tbPassword.Text = dsUsuarios.Tables["usuarios"].Rows[i]["password"].ToString();
                    break;
                }
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbctrlAdmUsuarios_Click(object sender, EventArgs e)
        {
            if (tbctrlAdmUsuarios.SelectedTab.Name == "tbpUsuarioEditar")
            {
                cbxUsuarioEditar.Focus();
                AcceptButton = btnUsuariosGuardar;
            }
            else if (tbctrlAdmUsuarios.SelectedTab.Name == "tbpUsuarioRegistrar")
            {
                UsuarioIdMskTb.Focus();
                AcceptButton = btnRegistrarUsuario;
            }
            else if (tbctrlAdmUsuarios.SelectedTab.Name == "tbpUsuarioEliminar")
            {
                cbxUsuarioEliminar.Focus();
                cbxUsuarioEliminar.Text = "Seleccionar usuario";
                AcceptButton = btnUsuarioEliminar;
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void cbxUsuarioEliminar_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dsUsuarios.Tables["usuarios"].Rows.Count; i++)
            {
                if (dsUsuarios.Tables["usuarios"].Rows[i]["nombre"].ToString() == cbxUsuarioEliminar.Text)
                {
                    mskIdEliminar.Text = dsUsuarios.Tables["usuarios"].Rows[i]["id"].ToString();
                    tbTelefonoEliminar.Text = dsUsuarios.Tables["usuarios"].Rows[i]["telefono"].ToString();
                    tbPasswordEliminar.Text = dsUsuarios.Tables["usuarios"].Rows[i]["password"].ToString();
                    break;
                }
            }
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button6_Click(object sender, EventArgs e)
        {
            if (cbxUsuarioEliminar.Text != "" && cbxUsuarioEliminar.Text != "Seleccionar usuario")
            {
                Usuario miUsuario = new Usuario();
                miUsuario.Id = Convert.ToInt32(mskIdEliminar.Text);
                if (DialogResult.Yes == MessageForm.Show("Seguro desea eliminar este usuario", "Advertencia", enumMessageIcon.Question, enumMessageButton.YesNo))
                {
                    if (miUsuario.Eliminar()) MessageForm.Show("Usuario eliminado satisfactoriamente", "Mensaje");
                    else MessageForm.Show("Error con la base de datos no se ha podido eliminar usuario","Atención");
                }
            }
            else MessageForm.Show("Porfavor seleccione un usuario","Atención");
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca miMarca = new Marca();
            if ("" != tbNombreMarca.Text)
            {
                miMarca.Nombre = tbNombreMarca.Text;
                if (miMarca.Registrar())
                {
                    MessageForm.Show("Marca registrada correctamente", "Mensaje");
                 
                }
                else { MessageForm.Show("No se pudo registrar", "Mensaje"); }
            }
            else MessageForm.Show("Por favor introduzca el nombre", "Atencion");
            CargarRecursos(operacion_activa, "marcas");
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnMarcaEliminar_Click(object sender, EventArgs e)
        {
            Marca miMarca = new Marca();
            if ("" != cbxMarcas.Text)
            {
                miMarca.Nombre = cbxMarcas.Text;
                if (miMarca.Eliminar())
                {
                    MessageForm.Show("Marca eliminada correctamente", "Mensaje");
                }
                else { MessageForm.Show("No se pudo eliminar", "Mensaje"); }
            }
            else MessageForm.Show("Por favor introduzca el nombre", "Atencion");
            CargarRecursos(operacion_activa,"marcas");
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button7_Click(object sender, EventArgs e)
        {
            Unidad miUnidad = new Unidad();
            if ("" != tbUnidad.Text)
            {
                miUnidad.Nombre = tbUnidad.Text;
                if (miUnidad.Registrar())
                {
                    MessageForm.Show("Unidad registrada correctamente", "Mensaje");
                 
                }
                else { MessageForm.Show("No se pudo registrar", "Mensaje"); }
            }
            else MessageForm.Show("Por favor introduzca el nombre", "Atencion");
            CargarRecursos(operacion_activa, "unidades");
            tbUnidad.Text = "";
        }

        private void btnUbicacionAgregar_Click(object sender, EventArgs e)
        {
            Ubicacion miUbicacion = new Ubicacion();
            if ("" != tbUbicacionAgregar.Text)
            {
                miUbicacion.Nombre = tbUbicacionAgregar.Text;
                if (miUbicacion.Registrar())
                {
                    MessageForm.Show("Ubicación registrada correctamente", "Mensaje");

                }
                else { MessageForm.Show("No se pudo registrar", "Mensaje"); }
            }
            else MessageForm.Show("Por favor introduzca el nombre", "Atencion");
            CargarRecursos(operacion_activa, "ubicaciones");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Unidad miUnidad = new Unidad();
            if ("" != cbxUnidadEliminar.Text)
            {
                miUnidad.Nombre = cbxUnidadEliminar.Text;
                if (miUnidad.Eliminar())
                {
                    MessageForm.Show("Unidad eliminada correctamente", "Mensaje");

                }
                else { MessageForm.Show("No se pudo eliminar", "Mensaje"); }
            }
            else MessageForm.Show("Por favor introduzca el nombre", "Atencion");
            CargarRecursos(operacion_activa, "unidades");
            tbUnidad.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ubicacion miUbicacion = new Ubicacion();
            if ("" != cbxUbicaciones.Text)
            {
                miUbicacion.Nombre = cbxUbicaciones.Text;
                if (miUbicacion.Eliminar())
                {
                    MessageForm.Show("Ubicación eliminada rrectamente", "Mensaje");

                }
                else { MessageForm.Show("No se pudo eliminar", "Mensaje"); }
            }
            else MessageForm.Show("Por favor introduzca el nombre", "Atencion");
            CargarRecursos(operacion_activa, "ubicaciones");
        }

        private void tctrlAdmRecursos_Click(object sender, EventArgs e)
        {
            if (tctrlAdmRecursos.SelectedTab.Name == "tpMarcas") tbNombreMarca.Focus();
            else if (tctrlAdmRecursos.SelectedTab.Name == "tpUnidades") tbUnidad.Focus();
            else if (tctrlAdmRecursos.SelectedTab.Name == "tpUbicaciones") tbUbicacionAgregar.Focus();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------
        //
    }
}
