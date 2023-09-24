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
    public partial class BuscarProductos : Form
    {
        public BuscarProductos(string invocadorValue)
        {
            InitializeComponent();
            invocador = invocadorValue;
        }
        string invocador;
        DataSet dsProductos = new DataSet();
        DataView dtvProductos = new DataView();
        //
        //===============METODOS DEFINIDOS POR EL PROGRAMADOR===========================================================================================================================
        //
        private void EnviarDatos()
        {
            string codigo = "";
            for (int i = 0; i < dgvBuscar.Rows.Count; i++)
            {
                if (dgvBuscar.Rows[i].Selected)
                {
                    codigo = dgvBuscar.Rows[i].Cells[0].Value.ToString();
                    break;
                }
            }
            //
            IBuscar frmInterface = this.Owner as IBuscar;
            if (frmInterface != null)
            {
                switch (invocador)
                {
                    case "compras" :
                        frmInterface.PonerCodigoCompras(codigo);
                        break;
                    case "ventas" :
                        frmInterface.PonerCodigoVentas(codigo);
                        break;
                    case "dev_ventas" :
                        frmInterface.PonerCodigoDevVentas(codigo);
                        break;
                    case "dev_compras" :
                        frmInterface.PonerCodigoDevCompras(codigo);
                        break;
                }
            }
            //
            if (invocador == "datos_prducto")
            {
                IBuscar2 frmInterface2 = this.Owner as IBuscar2;
                if (frmInterface2 != null)
                {
                    frmInterface2.PonerCodigo(codigo);
                }
            }
            //
            switch (invocador)
            {
                case "editar_producto" :
                    IBuscar3 frmInterface2 = this.Owner as IBuscar3;
                    if (frmInterface2 != null)
                    {
                        frmInterface2.PonerCodigoEditar(codigo);
                    }
                    break;
                case "eliminar_producto" :
                    IBuscar3 frmInterface3 = this.Owner as IBuscar3;
                    if (frmInterface3 != null)
                    {
                        frmInterface3.PonerCodigoEliminar(codigo);
                    }
                    break;
            }
        }
        //==============================================================================================================================================================================
        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            Producto miProducto = new Producto();
            dsProductos = miProducto.Buscar("todos");
            this.dtvProductos = ((DataTable)dsProductos.Tables["productos"]).DefaultView;
            dgvBuscar.DataSource = dtvProductos;
        }
        //
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbBusquedaStr_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] key_words = tbBusquedaStr.Text.Split(' ');
            foreach (string word in key_words)
            {
                if (0 == salida_datos.Length)
                {
                    salida_datos = ("Referencia LIKE '%" + word + "%' OR Descripcion LIKE '%" + word + "%' ");
                }
                else
                {
                    salida_datos += "AND (Referencia LIKE '%" + word + "%' OR Descripcion LIKE '%" + word + "%')";
                }
                dtvProductos.RowFilter = salida_datos;
            } 
        }
        //
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            EnviarDatos();
            this.Close();
        }
        //
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
    }
}
