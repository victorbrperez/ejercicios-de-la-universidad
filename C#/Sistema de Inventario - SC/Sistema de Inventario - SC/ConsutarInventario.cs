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
    public partial class ConsutarInventario : Form,IBuscar2
    {
        public ConsutarInventario(string operacion)
        {
            InitializeComponent();
            operacion_activa = operacion;
        }

        //=========OBJETOS Y VARIABLES GLOBALES==============================================================================================
        const string tabla = "productos";
        DataSet dsListaProductos = new DataSet();
        DataTable dttListaMinimo = new DataTable();
        string operacion_activa = "";
        //
        //==============INTERFACES=========================================================================================================================
        //
        #region IBuscar2 Members
        //
        public void PonerCodigo(string txtValue)
        {
            mskCodigo.Text = txtValue;
        }
        //
        #endregion

        //=========METODOS DEFINIDOS POR EL USUARIO==========================================================================================
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void CalcularInventario()
        {
            int total_productos = 0;
            double total_inventario = 0;
            for (int i = 0; i < dsListaProductos.Tables[tabla].Rows.Count; i++)
            {
                total_productos += Convert.ToInt32(dsListaProductos.Tables[tabla].Rows[i]["cantidad"].ToString());
                total_inventario += Convert.ToDouble(dsListaProductos.Tables[tabla].Rows[i]["costo"].ToString()) * Convert.ToDouble(dsListaProductos.Tables[tabla].Rows[i]["cantidad"].ToString());
            }
            tbTotalProductos.Text = total_productos.ToString();
            tbTotaInventario.Text = total_inventario.ToString("###,###,###,0.00");
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void CalcularProdEnMinimo()
        {
            dgvEnMinimo.Rows.Clear();
            int[] temLista = new int[dsListaProductos.Tables[tabla].Rows.Count];
            for (int i = 0; i < temLista.Length; i++) temLista[i] = 0;
            for (int i = 0; i < dsListaProductos.Tables[tabla].Rows.Count; i++)
            {
                if (Convert.ToDouble(dsListaProductos.Tables[tabla].Rows[i]["cantidad"].ToString()) <= Convert.ToDouble(dsListaProductos.Tables[tabla].Rows[i]["minimo_existencia"].ToString()))
                {
                    dgvEnMinimo.Rows.Add(dsListaProductos.Tables[tabla].Rows[i]["codigo"].ToString(), dsListaProductos.Tables[tabla].Rows[i]["referencia"].ToString(),
                        dsListaProductos.Tables[tabla].Rows[i]["descripcion"].ToString(), dsListaProductos.Tables[tabla].Rows[i]["marca"].ToString(),
                        dsListaProductos.Tables[tabla].Rows[i]["unidad"].ToString(), dsListaProductos.Tables[tabla].Rows[i]["cantidad"].ToString(),
                        dsListaProductos.Tables[tabla].Rows[i]["costo"].ToString(), dsListaProductos.Tables[tabla].Rows[i]["ubicacion"].ToString(),
                        dsListaProductos.Tables[tabla].Rows[i]["fecha"].ToString(), dsListaProductos.Tables[tabla].Rows[i]["nota"].ToString());
                }
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void LLenarDatosProducto()
        {
            if (mskCodigo.Text != "")
            {
                for (int i = 0; i < dsListaProductos.Tables[tabla].Rows.Count; i++)
                {
                    if (mskCodigo.Text == dsListaProductos.Tables[tabla].Rows[i]["codigo"].ToString())
                    {

                        double costo;
                        double mgp;
                        double mgm;
                        double itbis;
                        //
                        if (dsListaProductos.Tables[tabla].Rows[i]["costo"].ToString() != "") costo = Convert.ToDouble(dsListaProductos.Tables[tabla].Rows[i]["costo"].ToString());
                        else costo = 0;
                        if (dsListaProductos.Tables[tabla].Rows[i]["mgp"].ToString() != "") mgp = Convert.ToDouble(dsListaProductos.Tables[tabla].Rows[i]["mgp"].ToString());
                        else mgp = 0;
                        if (dsListaProductos.Tables[tabla].Rows[i]["mgm"].ToString() != "") mgm = Convert.ToDouble(dsListaProductos.Tables[tabla].Rows[i]["mgm"].ToString());
                        else mgm = 0;
                        if (dsListaProductos.Tables[tabla].Rows[i]["itbis"].ToString() != "") itbis = Convert.ToDouble(dsListaProductos.Tables[tabla].Rows[i]["itbis"].ToString());
                        else itbis = 0;
                        //
                        double pvpBruto = costo / (1 - mgp / 100);
                        double pvmBruto = costo / (1 - mgm / 100);
                        double pvp = pvpBruto + (pvpBruto * itbis / 100);
                        double pvm = pvmBruto + (pvmBruto * itbis / 100);
                        //
                        tbPVP.Text = pvp.ToString("0.00");
                        tbPVM.Text = pvm.ToString("0.00");
                        tbReferencia.Text = dsListaProductos.Tables[tabla].Rows[i]["referencia"].ToString();
                        tbDescripcion.Text = dsListaProductos.Tables[tabla].Rows[i]["descripcion"].ToString();
                        tbUnidad.Text = dsListaProductos.Tables[tabla].Rows[i]["unidad"].ToString();
                        tbMarca.Text = dsListaProductos.Tables[tabla].Rows[i]["marca"].ToString();
                        tbCosto.Text = dsListaProductos.Tables[tabla].Rows[i]["costo"].ToString();
                        tbItbis.Text = dsListaProductos.Tables[tabla].Rows[i]["itbis"].ToString();
                        tbUbicacion.Text = dsListaProductos.Tables[tabla].Rows[i]["ubicacion"].ToString();
                        tbFecha.Text = dsListaProductos.Tables[tabla].Rows[i]["fecha"].ToString();
                        tbNota.Text = dsListaProductos.Tables[tabla].Rows[i]["nota"].ToString();
                        tbEnInventario.Text = dsListaProductos.Tables[tabla].Rows[i]["cantidad"].ToString();
                    }
                }
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void Seleccionar(string opcion, bool mantener)
        //Metodo que selecciona o muestra el panel de una operacion determinada y oculta los demas
        {
            switch (opcion)
            {
                case "inventario":
                    btnInventario.BackColor = Color.FromArgb(193, 220, 34);
                    if (mantener)
                    {
                        operacion_activa = opcion;
                        panelInventario.Visible = true;
                        panelConsProducto.Visible = false;
                        panelEnBaja.Visible = false;
                        Producto miProducto = new Producto();
                        dsListaProductos = miProducto.Buscar("todos");
                        dgvListaProductos.DataSource = dsListaProductos;
                        dgvListaProductos.DataMember = tabla;
                    }
                    break;
                case "cons_producto" :
                    btnConsProducto.BackColor = Color.FromArgb(193, 220, 34);
                    if (mantener)
                    {
                        operacion_activa = opcion;
                        panelInventario.Visible = false;
                        panelEnBaja.Visible = false;
                        panelConsProducto.Visible = true;
                        Producto miProducto = new Producto();
                        dsListaProductos = miProducto.Buscar("todos");
                        mskCodigo.Focus();
                    }
                    break;
                case "en_baja" :
                    btnEnBaja.BackColor = Color.FromArgb(193, 220, 34);
                    if (mantener)
                    {
                        panelInventario.Visible = false;
                        panelEnBaja.Visible = true;
                        panelConsProducto.Visible = false;
                        Producto miProducto = new Producto();
                        dsListaProductos = miProducto.Buscar("todos");
                        CalcularProdEnMinimo();
                    }
                    break;
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void Deseleccionar(string opcion)
        {
            switch (opcion)
            { 
                case "inventario" :
                    btnInventario.BackColor = Color.FromArgb(241, 241, 241);
                    break;
                case "cons_producto":
                    btnConsProducto.BackColor = Color.FromArgb(241,241,241);
                    break;
                case "en_baja":
                    btnEnBaja.BackColor = Color.FromArgb(241, 241, 241);
                    break;
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        //=========EVENTOS=======================================================================================================================

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Seleccionar("inventario", true);
            Deseleccionar("cons_producto");
            Deseleccionar("en_baja");
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnConsProducto_Click(object sender, EventArgs e)
        {
            Seleccionar("cons_producto", true);
            Deseleccionar("inventario");
            Deseleccionar("en_baja");
        }
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
        private void ConsutarInventario_Load(object sender, EventArgs e)
        {
            Seleccionar(operacion_activa,true);
            CalcularInventario();
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void mskCodigo_TextChanged(object sender, EventArgs e)
        {
            LLenarDatosProducto();
        }

        private void btnEnBaja_Click(object sender, EventArgs e)
        {
            Deseleccionar("cons_producto");
            Deseleccionar("inventario");
            Seleccionar("en_baja",true);
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button1_Click(object sender, EventArgs e)
        {
            frmVistaImprimir VistaImprimir = new frmVistaImprimir(dsListaProductos);
            VistaImprimir.Show();
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProductos miBuscarProductos = new BuscarProductos("datos_prducto");
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
        //---------------------------------------------------------------------------------------------------------------------------------------

    }
}
