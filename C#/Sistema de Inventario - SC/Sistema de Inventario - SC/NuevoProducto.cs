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
    public partial class NuevoProductoForm : Form,IForm,IForm2
    {
        public NuevoProductoForm()
        {
            InitializeComponent();
        }
        //
        //======== METODOS DEFINIDOS POR EL USUARIO ==========================================================================================================================
        //
        private void InicializarControles()
        //Metodo que establece los valores predeterminados de los controles del formulario.
        {
            //Limpieza de los controles del formulario
            foreach (Control tempControl in this.Controls)
            {
                if (tempControl.GetType() == typeof(TextBox))
                {
                    if (tempControl.Name != "tbItebis") { tempControl.Text = ""; }
                }
            }
            //Valores preestablecidos de los controles del formuario.
            tbItbis.Text = "18";
            cantidadNUD.Value = 0;
            minimoExistenciaNUD.Value = 0;
            DataSet miDataset = new DataSet();
            Producto miProducto = new Producto();
            miDataset = miProducto.Buscar("mayor");
            if (Convert.ToInt32(miDataset.Tables["productos"].Rows[0]["codigo"].ToString()) != 0)
            {
                int codigo_tmp = Convert.ToInt32(miDataset.Tables["productos"].Rows[0]["codigo"].ToString());
                mskCodigo.Text = Convert.ToString(codigo_tmp + 1);
            }
            else { mskCodigo.Text = "1000"; }
            CargarRecursos("todos");
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void CargarRecursos(string recursoValue)
        //Se cargan los valores de recursos (Unidad, Marca, Ubicacion) dentro de los ComboBox correspondietes.
        {
            DataSet dsTemp = new DataSet();
            if (recursoValue == "unidad" || recursoValue == "todos")
            {
                BindingSource bdsUnidad = new BindingSource();
                Unidad miUnidad = new Unidad();
                dsTemp = miUnidad.Buscar();
                bdsUnidad.DataSource = dsTemp;
                bdsUnidad.DataMember = "unidades";
                unidadCbx.DataSource = bdsUnidad;
                unidadCbx.DisplayMember = "nombre";
                dsTemp.Dispose();
            }
            if (recursoValue == "marca" || recursoValue == "todos")
            {
                BindingSource bdsMarca = new BindingSource();
                Marca miMarca = new Marca();
                dsTemp = miMarca.Buscar();
                bdsMarca.DataSource = dsTemp;
                bdsMarca.DataMember = "marcas";
                marcaCbx.DataSource = bdsMarca;
                marcaCbx.DisplayMember = "nombre";
                dsTemp.Dispose();
            }
            if (recursoValue == "ubicacion" || recursoValue == "todos")
            {
                BindingSource bdsUbicacion = new BindingSource();
                Ubicacion miUbicacion = new Ubicacion();
                dsTemp = miUbicacion.Buscar();
                bdsUbicacion.DataSource = dsTemp;
                bdsUbicacion.DataMember = "ubicaciones";
                ubicacionCbx.DataSource = bdsUbicacion;
                ubicacionCbx.DisplayMember = "nombre";
                dsTemp.Dispose();
                mskCodigo.Focus();
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private bool ValidarFormulario()
        {
            bool validacion = true;//Variable con el valor que sera devuelto por el metodo.
            //Analizar si hay controles vacios y le da el valor a la variable "validacion".
            foreach (Control tempControl in this.Controls)
            {
                if (tempControl.GetType() == typeof(TextBox) || tempControl.GetType() == typeof(MaskedTextBox))
                {
                    if (tempControl.Text == string.Empty)
                    {
                        validacion = false;
                    }
                }
            }
            //Comprovar que no haya un producto con el mismo codigo que se intenta registrar guardado en la base de datos y da valor  la variable "validacion".
            if (validacion)
            {
                Producto miProducto = new Producto();
                DataSet tempDs = new DataSet();
                miProducto.Codigo = Convert.ToInt32(mskCodigo.Text);
                tempDs = miProducto.Buscar("uno");
                if (tempDs.Tables["productos"].Rows.Count != 0)
                {
                    if (Int32.Parse(tempDs.Tables["productos"].Rows[0]["codigo"].ToString()) != Convert.ToInt32(mskCodigo.Text))
                    {
                        validacion = true;
                    }
                    else
                    {
                        MessageForm.Show("Ya existe un producto con ese codigo", "Error al registrar");
                        validacion = false;
                    }
                }
            }
            else
            {
                MessageForm.Show("Por favor llene todos los campos", "Error de registro");
            }

            return validacion;
        }
        //
        //========= INTERFACES ==========================================================================================================================
        //
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
        //
        #endregion
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        #region
        //
        public void RefrescarFormulario(string txtValue)
        {
            CargarRecursos(txtValue);
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        #endregion
        //
        //======== EVENTOS ==========================================================================================================================
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbPrecioCosto_TextChanged(object sender, EventArgs e)
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
        //---------------------------------------------------------------------------------------------------------------------------------------
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
            costo -= ((costo * descuento)/ 100);
            double pvpBruto = costo / (1 - mgp / 100);
            double pvp = pvpBruto + (pvpBruto * itbis / 100);
            //
            tbPrecioVentaPred.Text = pvp.ToString("0.00");
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbMGM_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(tbMGM.Text);
            }
            catch
            {
                tbMGM.Text = "";
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
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
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(tbPrecioVentaPred.Text);
            }
            catch
            {
                tbPrecioVentaPred.Text = "";
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbItebis_TextChanged(object sender, EventArgs e)
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
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbPrecioVentaPred_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(tbPrecioVentaPred.Text);
            }
            catch
            {
                tbPrecioVentaPred.Text = "";
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void registrarBtn_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Producto miProducto = new Producto();
                miProducto.Codigo = Convert.ToInt32(mskCodigo.Text);
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
                if (miProducto.Registrar())
                {
                    MessageForm.Show("Producto registrado satisfactoriamente", "Mensage del sistema");
                }
                else { MessageForm.Show("No se ha podido registrar el producot", "Error con la base de datos"); }
                InicializarControles();
            }   
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void SugerirPreciosLkLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool formularioAbierto = false;
            //
            try
            {
                SugerirPrecios miSugerirPrecios = new SugerirPrecios(Convert.ToDouble(tbItbis.Text), Convert.ToDouble(tbCosto.Text), Convert.ToDouble(tbDescuento.Text),"nuevo_producto");
                foreach (Form fmTemp in Application.OpenForms)
                {
                    if (fmTemp.GetType() == typeof(SugerirPrecios))
                    {
                        formularioAbierto = true;
                    }
                    else { formularioAbierto = false; }
                }

                if (formularioAbierto == false) { miSugerirPrecios.ShowDialog(this); }
            }
            catch
            {
                MessageForm.Show(@"Primero llene el campo ""Costo""", "Advertencia");
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
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
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void NuevoProductoForm_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnAgregarUDS_Click(object sender, EventArgs e)
        {
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
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button2_Click(object sender, EventArgs e)
        {
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
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button3_Click(object sender, EventArgs e)
        {
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
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
    }
 }

