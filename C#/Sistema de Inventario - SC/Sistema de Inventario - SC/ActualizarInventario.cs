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
    public partial class ActualizarInventario : Form,IBuscar,IForm
    {
        public ActualizarInventario(string valor)
        {
            InitializeComponent();
            operacion_activa = valor;
        }
        //
        //Variables globales dentro del formulario.
        const string tabla = "productos";
        string operacion_activa;//Almacena el nombre de la oeracion que esta activa
        DataTable dttVentas = new DataTable();//Tabla que contendra temporalmente los datos de los productos vendidos a registrar.
        DataTable dttCompras = new DataTable();
        DataTable dttDevCompras = new DataTable();//Tabla que contendra temporalmente los datos de los productos comprados devueltos.
        DataTable dttDevVentas = new DataTable();
        DataSet dsProductosAll = new DataSet();//Dataset que almacenara los datos de todos los productos temporalmente.
        //
        //=========INTERFACES===============================================================================================================================================================================
        //
        #region IBuscar Members
        //
        public void PonerCodigoVentas(string txtValue)
        {
            codigoVentaMsk.Text = txtValue;
        }
        //
        public void PonerCodigoCompras(string txtValue)
        {
            mskCodigoCompras.Text = txtValue;
        }
        //
        public void PonerCodigoDevVentas(string txtValue)
        {
            msktbCodigoDevVentas.Text = txtValue;
        }
        //
        public void PonerCodigoDevCompras(string txtValue)
        {
            msktbCodigoDevCompras.Text = txtValue;
        }
        //
        #endregion
        //
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        #region IForm Members
        //
        public void ActualizarMGP(string txtValue)
        {
            tbMGPCompras.Text = txtValue;
        }
        public void ActualizarMGM(string txtValue)
        {
            tbMGMCompras.Text = txtValue;
        }
        #endregion
        //=========METODOS DEFINIDOS PRO EL USUARIO=========================================================================================================================================================

        public void InicializarDataTables()
        {
            //Se crean las columnas para la tabla "dttVentas"
            dttVentas.Columns.Add("codigo");
            dttVentas.Columns.Add("referencia");
            dttVentas.Columns.Add("descripcion");
            dttVentas.Columns.Add("marca");
            dttVentas.Columns.Add("cantidad");
            dttVentas.Columns.Add("unidad");
            dttVentas.Columns.Add("cantidad_inventario");
            //Se crean las columnas para la tabla "dttDevCompras"
            dttDevCompras.Columns.Add("codigo");
            dttDevCompras.Columns.Add("referencia");
            dttDevCompras.Columns.Add("descripcion");
            dttDevCompras.Columns.Add("marca");
            dttDevCompras.Columns.Add("cantidad");
            dttDevCompras.Columns.Add("unidad");
            dttDevCompras.Columns.Add("cantidad_inventario");
            //Se crean las columnas para la tabla "dttDevVentas"
            dttDevVentas.Columns.Add("codigo");
            dttDevVentas.Columns.Add("referencia");
            dttDevVentas.Columns.Add("descripcion");
            dttDevVentas.Columns.Add("marca");
            dttDevVentas.Columns.Add("cantidad");
            dttDevVentas.Columns.Add("unidad");
            dttDevVentas.Columns.Add("cantidad_inventario");
            //Se crean las columnas para la tabla "dttCompras"
            dttCompras.Columns.Add("codigo");
            dttCompras.Columns.Add("referencia");
            dttCompras.Columns.Add("descripcion");
            dttCompras.Columns.Add("marca");
            dttCompras.Columns.Add("cantidad");
            dttCompras.Columns.Add("unidad");
            dttCompras.Columns.Add("cantidad_inventario");
            dttCompras.Columns.Add("costo");
            dttCompras.Columns.Add("itbis");
            dttCompras.Columns.Add("mgp");
            dttCompras.Columns.Add("mgm");
            dttCompras.Columns.Add("pvp");
            dttCompras.Columns.Add("pvm");
            dttCompras.Columns.Add("fecha");
        }
        //
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void ActualizarInv(ref DataTable dttUpdate)
        {
            Producto miProducto = new Producto();
            DataTable tempDt = new DataTable();
            bool operacion_correcta = false;
            switch (operacion_activa)
            {
                case "ventas" : case "dev_compras" :
                    for (int i = 0; i < dttUpdate.Rows.Count; i++ )
                    {
                        miProducto.Codigo = Convert.ToInt32(dttUpdate.Rows[i]["codigo"].ToString());
                        miProducto.Cantidad = Convert.ToInt32(dttUpdate.Rows[i]["cantidad_inventario"].ToString()) - Convert.ToInt32(dttUpdate.Rows[i]["cantidad"].ToString());
                        if (miProducto.Actualizar(operacion_activa)) operacion_correcta = true;
                        else operacion_correcta = false;
                    }
                    if (operacion_correcta) MessageForm.Show("Inventario actualizado correctamente", "Actualización de inventario");
                    else MessageForm.Show("Hubo un problema al actualizar el inventario", "Actualización de inventario");
                    break;
                case "compras" :
                    for (int i = 0; i < dttUpdate.Rows.Count; i++)
                    {
                        miProducto.Codigo = Convert.ToInt32(dttUpdate.Rows[i]["codigo"].ToString());
                        miProducto.Cantidad = Convert.ToInt32(dttUpdate.Rows[i]["cantidad_inventario"].ToString()) + Convert.ToInt32(dttUpdate.Rows[i]["cantidad"].ToString());
                        miProducto.Costo = Convert.ToDouble(dttUpdate.Rows[i]["costo"].ToString());
                        miProducto.MGP = Convert.ToDouble(dttUpdate.Rows[i]["mgp"].ToString());
                        miProducto.MGM = Convert.ToDouble(dttUpdate.Rows[i]["mgm"].ToString());
                        miProducto.Fecha = Convert.ToDateTime(dttUpdate.Rows[i]["fecha"].ToString());
                        if (miProducto.Actualizar(operacion_activa)) operacion_correcta = true;
                        else operacion_correcta = false;
                    }
                    if (operacion_correcta) MessageForm.Show("Inventario actualizado correctamente", "Actualización de inventario");
                    else MessageForm.Show("Hubo un problema al actualizar el inventario", "Actualización de inventario");
                    break;
                case "dev_ventas" :
                    for (int i = 0; i < dttUpdate.Rows.Count; i++)
                    {
                        miProducto.Codigo = Convert.ToInt32(dttUpdate.Rows[i]["codigo"].ToString());
                        miProducto.Cantidad = Convert.ToInt32(dttUpdate.Rows[i]["cantidad_inventario"].ToString()) + Convert.ToInt32(dttUpdate.Rows[i]["cantidad"].ToString());
                        miProducto.Actualizar(operacion_activa);
                        if (miProducto.Actualizar(operacion_activa)) operacion_correcta = true;
                        else operacion_correcta = false;
                    }
                    if (operacion_correcta) MessageForm.Show("Inventario actualizado correctamente", "Actualización de inventario");
                    else MessageForm.Show("Hubo un problema al actualizar el inventario", "Actualización de inventario");
                    break;
            }
            
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void AgregarProducto(ref DataTable dttUpdate, ref DataGridView dgvUpdate, string codigo_producto, string cantidad,DataTable dttOtros = null)
        {
            //Se declaran los objetos necesarios
            Producto miProducto = new Producto();
            DataSet productoDs = new DataSet();
            bool existe = false;
            //Se analiza si el campo "Codigo" no esta vacio, Se asigna el valor codigo al objeto creado.
            if (codigo_producto != "") { miProducto.Codigo = Convert.ToInt32(codigo_producto); }
            else { MessageForm.Show("Por favor introduzca el código del producto", "Error al agregar"); }
            productoDs = miProducto.Buscar("uno");//Almacena los datos del Producto buscado en un Dataset.
            if (productoDs.Tables[tabla].Rows.Count != 0)//Primero se verifica si el producto buscado se encuentro
            {
                if (Convert.ToInt32(cantidad) != 0)//Se verifica que la cantidad de productos por agregar sea diferente de cero.
                {
                    //Se analiza si el producto por agregar se encuentra ya en la lista (si ha sido agregado anteriormente).
                    if (dttUpdate.Rows.Count != 0)
                    {
                        for (int i = 0; i < dttUpdate.Rows.Count; i++)
                        {
                            if (codigo_producto == dttUpdate.Rows[i]["codigo"].ToString())
                            {
                                existe = true;
                                break;
                            }
                            else { existe = false; }
                        }
                    }
                    //Si existe se busca el producto en la lista y solo se le suma la cantidad por agregar
                    if (existe)
                    {
                        for (int i = 0; i < dttUpdate.Rows.Count; i++)
                        {
                            if (dttUpdate.Rows[i]["codigo"].ToString() == codigo_producto)
                            {
                                switch(operacion_activa)//Se selecciona la operacion para la cual se van a agregar los productos
                                {
                                    case "ventas": case "dev_compras":
                                        //Se comprueva si la cantidad en inventario es mayor o igual que la cantidad que se quiere agregar.
                                        if ((Convert.ToInt32(dttUpdate.Rows[i]["cantidad"].ToString()) + Convert.ToInt32(cantidad)) <= Convert.ToInt32(productoDs.Tables[tabla].Rows[0]["cantidad"].ToString()))
                                        {
                                            dttUpdate.Rows[i]["cantidad"] = Convert.ToString(Convert.ToInt32(dttUpdate.Rows[i]["cantidad"].ToString()) + Convert.ToInt32(cantidad));
                                        }
                                         else { MessageForm.Show("Solo quedan " + productoDs.Tables[tabla].Rows[0]["cantidad"].ToString() + " productos disponibles en inventario", "Advertencia"); }
                                         break;
                                    case "dev_ventas": case "compras":
                                         dttUpdate.Rows[i]["cantidad"] = Convert.ToString(Convert.ToInt32(dttUpdate.Rows[i]["cantidad"].ToString()) + Convert.ToInt32(cantidad));
                                         break;
                                }
                            }
                        }
                    }
                    else //Si no existe se agrega una nueva fila con los datos del producto a la tabla.
                    {
                        switch (operacion_activa)//Se selecciona la operacion para la cual se van a agregar los productos
                        {

                            case "compras":
                                dttUpdate.Rows.Add(productoDs.Tables[tabla].Rows[0]["codigo"].ToString(), productoDs.Tables[tabla].Rows[0]["referencia"].ToString(), productoDs.Tables[tabla].Rows[0]["descripcion"].ToString(),
                                productoDs.Tables[tabla].Rows[0]["marca"], cantidad, productoDs.Tables[tabla].Rows[0]["unidad"], productoDs.Tables[tabla].Rows[0]["cantidad"],
                                tbCostoCompras.Text, productoDs.Tables[tabla].Rows[0]["itbis"].ToString(), tbMGPCompras.Text, tbMGMCompras.Text,tbPrecioVentaPredCompras.Text,tbPrecioVentaMayCompras.Text,dtTPkrFechaCompras.Value.ToShortDateString());
                                break;
                            default :
                                //primero se comprueva si la cantidad en inventario es mayor o igual a la cantidad por agregar.
                                if (Convert.ToInt32(cantidad) <= Convert.ToInt32(productoDs.Tables[tabla].Rows[0]["cantidad"].ToString()))
                                {
                                    dttUpdate.Rows.Add(productoDs.Tables["productos"].Rows[0]["codigo"], productoDs.Tables["productos"].Rows[0]["referencia"], productoDs.Tables["productos"].Rows[0]["descripcion"],
                                    productoDs.Tables["productos"].Rows[0]["marca"], cantidad, productoDs.Tables["productos"].Rows[0]["unidad"], productoDs.Tables["productos"].Rows[0]["cantidad"]);
                                }
                                else { MessageForm.Show("Solo quedan " + productoDs.Tables[tabla].Rows[0]["cantidad"].ToString() + " productos disponibles en inventario", "Advertencia"); }
                                break;
                        }
                    }
                }
                //Se limpia el DataGridView.
                dgvUpdate.Rows.Clear();
                //Se llena el DataGridView con los datos actualizados desde la tabla.
                switch(operacion_activa)//Compras no tiene los mismos campos que las demas operaciones por eso hay que saber si la operacion a realizar es una compra o no.
                {
                    case "compras" :
                        for (int i = 0; i < dttUpdate.Rows.Count; i++)
                        {
                            dgvUpdate.Rows.Add(dttUpdate.Rows[i]["codigo"].ToString(), dttUpdate.Rows[i]["referencia"].ToString(), dttUpdate.Rows[i]["descripcion"].ToString(),
                            dttUpdate.Rows[i]["marca"].ToString(), dttUpdate.Rows[i]["cantidad"].ToString(), dttUpdate.Rows[i]["unidad"].ToString(), dttUpdate.Rows[i]["cantidad_inventario"].ToString(),
                            dttUpdate.Rows[i]["costo"].ToString(), dttUpdate.Rows[i]["itbis"].ToString(), dttUpdate.Rows[i]["mgp"].ToString(), dttUpdate.Rows[i]["mgm"].ToString(), dttUpdate.Rows[i]["pvp"].ToString(), 
                            dttUpdate.Rows[i]["pvm"].ToString(), dttUpdate.Rows[i]["fecha"].ToString());
                        }
                        break;
                    default :
                        for (int i = 0; i < dttUpdate.Rows.Count; i++)
                        {
                            dgvUpdate.Rows.Add(dttUpdate.Rows[i]["codigo"].ToString(), dttUpdate.Rows[i]["referencia"].ToString(), dttUpdate.Rows[i]["descripcion"].ToString(), dttUpdate.Rows[i]["marca"].ToString(), dttUpdate.Rows[i]["cantidad"].ToString(), dttUpdate.Rows[i]["unidad"].ToString(), dttUpdate.Rows[i]["cantidad_inventario"].ToString());
                        }
                    break;
                }

            }
            else
            {
                if (codigo_producto != "")
                {
                    MessageForm.Show("Producto no encontrado", "No se puede agregar");
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void QuitarProducto(ref DataTable dttUpdate, ref DataGridView dgvUpdate)
        {
            string[] codigo_temp = new string[dgvUpdate.Rows.Count];
            for (int i = 0; i < dgvUpdate.Rows.Count; i++)
            {
                if (dgvUpdate.Rows[i].Selected)
                {
                    codigo_temp[i] = dgvUpdate.Rows[i].Cells[0].Value.ToString();
                }
            }

            for (int i = 0; i < dttUpdate.Rows.Count; i++)
            {
                if (dttUpdate.Rows[i]["codigo"].ToString() == codigo_temp[i])
                {
                    dttUpdate.Rows[i].Delete();
                }
            }

            dgvUpdate.Rows.Clear();

            for (int i = 0; i < dttUpdate.Rows.Count; i++)
            {
                dgvUpdate.Rows.Add(dttUpdate.Rows[i]["codigo"].ToString(), dttUpdate.Rows[i]["referencia"].ToString(), dttUpdate.Rows[i]["descripcion"].ToString(), dttUpdate.Rows[i]["marca"].ToString(), dttUpdate.Rows[i]["cantidad"].ToString(), dttUpdate.Rows[i]["unidad"].ToString(), dttUpdate.Rows[i]["cantidad_inventario"].ToString());
            } 
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public bool ComprovarTareas()
        //Metodo que comprueva si hay alguna tarea pendiente.
        {
            bool tareas_pendientes = false;

            if (dttVentas.Rows.Count != 0 || dttDevCompras.Rows.Count != 0 || dttDevVentas.Rows.Count != 0 || dgvCompras.Rows.Count != 0)
            {
                tareas_pendientes = true;
            }
            else tareas_pendientes = false;
            return tareas_pendientes;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------

        private void Seleccionar(string opcion,bool mantener)
        //Metodo que selecciona o muestra el panel de una operacion determinada y oculta los demas
        {
            switch (opcion)
            {
                case "ventas":
                    ventasBtn.BackColor = Color.FromArgb(193, 220, 34);
                   // ventasBtn.ForeColor = Color.White;
                    if (mantener)
                    {
                        operacion_activa = opcion;
                        ventasPanel.Visible = true;
                        comprasPanel.Visible = false;
                        devComprasPanel.Visible = false;
                        devVentasPanel.Visible = false;
                        codigoVentaMsk.Focus();
                        AcceptButton = agregarVentaBtn;
                    }
                    break;
                case "compras":
                    comprasBtn.BackColor = Color.FromArgb(193, 220, 34);
                    //comprasBtn.ForeColor = Color.White;
                    if (mantener)
                    {
                        operacion_activa = opcion;
                        ventasPanel.Visible = false;
                        comprasPanel.Visible = true;
                        devComprasPanel.Visible = false;
                        devVentasPanel.Visible = false;
                        Producto miProducto = new Producto();
                        DataSet dsProducto = new DataSet();
                        dsProductosAll =  miProducto.Buscar("todos");
                        mskCodigoCompras.Focus();
                        AcceptButton = btnAgregarCompras;

                    }

                    break;
                case "dev_compras":
                    devComprasBtn.BackColor = Color.FromArgb(193, 220, 34);
                    //devComprasBtn.ForeColor = Color.White;
                    if (mantener)
                    {
                        operacion_activa = opcion;
                        ventasPanel.Visible = false;
                        comprasPanel.Visible = false;
                        devComprasPanel.Visible = true;
                        devVentasPanel.Visible = false;
                        msktbCodigoDevCompras.Focus();
                        AcceptButton = btnAgregarDevCompras;
                    }
                    break;
                case "dev_ventas":
                    devVentasBtn.BackColor = Color.FromArgb(193, 220, 34);
                    //devVentasBtn.ForeColor = Color.White;
                    if (mantener)
                    {
                        operacion_activa = opcion;
                        ventasPanel.Visible = false;
                        comprasPanel.Visible = false;
                        devComprasPanel.Visible = false;
                        devVentasPanel.Visible = true;
                        msktbCodigoDevVentas.Focus();
                        AcceptButton = btnAgregarDevVentas;
                    }
                    break;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void Deseleccionar(string opcion)
        //Metodo que cambia el color de fondo del menu lateral mientras se va pasando el cursor.
        {
            switch (opcion)
            {
                case "ventas" :
                    
                    ventasBtn.BackColor = Color.FromArgb(242,241,241);
                   // ventasBtn.ForeColor = Color.FromArgb(154, 205, 61);
                    break;
                case "compras" :
                    comprasBtn.BackColor = Color.FromArgb(242, 241, 241);
                    //comprasBtn.ForeColor = Color.FromArgb(154, 205, 61);
                    break;
                case "dev_compras" :
                    devComprasBtn.BackColor = Color.FromArgb(242, 241, 241);
                   // devComprasBtn.ForeColor = Color.FromArgb(154, 205, 61);
                    break;
                case "dev_ventas":
                    devVentasBtn.BackColor = Color.FromArgb(242, 241, 241);
                   // devVentasBtn.ForeColor = Color.FromArgb(154, 205, 61);
                    break;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private bool ValidarDatosCompra()
        {
            bool validacion = false;
            if (tbCostoCompras.Text != "" && tbMGPCompras.Text != "" && tbItbisCompras.Text != "" && tbMGMCompras.Text != "")
            {
                validacion = true;
            }
            else
            {
                validacion = false;
            }
            return validacion;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------
            

        //=========EVENTOS========================================================================================================================

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void ventasBtn_Click(object sender, EventArgs e)
        {
            if (ComprovarTareas() != true)
            {
                Seleccionar("ventas", true);
                Deseleccionar("compras");
                Deseleccionar("dev_ventas");
                Deseleccionar("dev_compras");
            }
            else 
            {
                if (operacion_activa != "ventas") MessageForm.Show("Hay tareas pendientes, por favor terminelas primero", "Atencion");
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void ventasBtn_MouseEnter(object sender, EventArgs e)
        {
            Seleccionar("ventas", false);
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void ventasBtn_MouseLeave(object sender, EventArgs e)
        {
            if (operacion_activa != "ventas") { Deseleccionar("ventas"); }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void comprasBtn_MouseEnter(object sender, EventArgs e)
        {
            Seleccionar("compras",false);
        }

        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void comprasBtn_MouseLeave(object sender, EventArgs e)
        {
            if (operacion_activa != "compras") { Deseleccionar("compras"); }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void devComprasBtn_MouseEnter(object sender, EventArgs e)
        {
            Seleccionar("dev_compras",false);
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void devComprasBtn_MouseLeave(object sender, EventArgs e)
        {
            if (operacion_activa != "dev_compras") { Deseleccionar("dev_compras"); }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------

        private void devVentasBtn_MouseEnter(object sender, EventArgs e)
        {
            Seleccionar("dev_ventas",false);
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void devVentasBtn_MouseLeave(object sender, EventArgs e)
        {
            if (operacion_activa != "dev_ventas") { Deseleccionar("dev_ventas"); }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void comprasBtn_Click(object sender, EventArgs e)
        {
            if (ComprovarTareas() != true)
            {
                Seleccionar("compras", true);
                Deseleccionar("ventas");
                Deseleccionar("dev_compras");
                Deseleccionar("dev_ventas");
            }
            else 
            {
                if (operacion_activa != "compras") MessageForm.Show("Hay tareas pendientes, por favor terminelas primero", "Atencion"); 
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void ActualizarInventario_Load(object sender, EventArgs e)
        {
            Seleccionar(operacion_activa, true);
            InicializarDataTables();
           
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void devComprasBtn_Click(object sender, EventArgs e)
        {
            if (ComprovarTareas() != true)
            {
                Seleccionar("dev_compras", true);
                Deseleccionar("compras");
                Deseleccionar("dev_ventas");
                Deseleccionar("ventas");
            }
            else 
            {
                if (operacion_activa != "dev_compras")  MessageForm.Show("Hay tareas pendientes, por favor terminelas primero", "Atencion"); 
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void devVentasBtn_Click(object sender, EventArgs e)
        {
            if (ComprovarTareas() != true)
            {
                Seleccionar("dev_ventas", true);
                Deseleccionar("dev_compras");
                Deseleccionar("compras");
                Deseleccionar("ventas");
            }
            else 
            {
                if (operacion_activa != "dev_ventas")  MessageForm.Show("Hay tareas pendientes, por favor terminelas primero", "Atencion");
            }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void button1_Click(object sender, EventArgs e)
        {
            BuscarProductos miBuscarProductos = new BuscarProductos("compras");
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
        //
        private void agregarVentaBtn_Click(object sender, EventArgs e)
        {
            AgregarProducto(ref dttVentas, ref ventasDgv, codigoVentaMsk.Text, cantidadVendidaNUD.Value.ToString());
            codigoVentaMsk.Text = "";
            codigoVentaMsk.Focus();
            cantidadVendidaNUD.Value = 1;
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void quitarVentasBtn_Click(object sender, EventArgs e)
        {
            QuitarProducto(ref dttVentas, ref ventasDgv);
            codigoVentaMsk.Focus();
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void actualizarVentasBtn_Click(object sender, EventArgs e)
        {
            if (dttVentas.Rows.Count != 0)
            {
                ActualizarInv(ref dttVentas);
                codigoVentaMsk.Focus();
                ventasDgv.Rows.Clear();
                dttVentas.Rows.Clear();
                codigoVentaMsk.Focus();
            }
            else { MessageForm.Show("La lista esta vacía, por favor agrege uno o mas productos ", "Mensaje del sistema"); }
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnAgregarDevCompras_Click(object sender, EventArgs e)
        {
            AgregarProducto(ref dttDevCompras, ref dgvDevCompras, msktbCodigoDevCompras.Text, NUDCantidadDevCompras.Value.ToString());
            msktbCodigoDevCompras.Text = "";
            NUDCantidadDevCompras.Value = 1;
            msktbCodigoDevCompras.Focus();
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnQuitarDevCompras_Click(object sender, EventArgs e)
        {
            QuitarProducto(ref dttDevCompras, ref dgvDevCompras);
            msktbCodigoDevCompras.Focus();
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnAgregarDevVentas_Click(object sender, EventArgs e)
        {
            AgregarProducto(ref dttDevVentas, ref dgvDevVentas, msktbCodigoDevVentas.Text, NUDCantidadDevVentas.Value.ToString());
            msktbCodigoDevVentas.Text = "";
            msktbCodigoDevVentas.Focus();
            NUDCantidadDevVentas.Value = 1;
        }
        //
        //---------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnQuitarDevVentas_Click(object sender, EventArgs e)
        {
            QuitarProducto(ref dttDevVentas, ref dgvDevVentas);
            msktbCodigoDevVentas.Text = "";
            msktbCodigoDevVentas.Focus();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void mskCodigoCompras_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dsProductosAll.Tables[tabla].Rows.Count; i++)
            {
                if (dsProductosAll.Tables[tabla].Rows[i]["codigo"].ToString() == mskCodigoCompras.Text)
                {
                    tbCostoCompras.Text = dsProductosAll.Tables[tabla].Rows[i]["costo"].ToString();
                    tbMGPCompras.Text = dsProductosAll.Tables[tabla].Rows[i]["mgp"].ToString();
                    tbMGMCompras.Text = dsProductosAll.Tables[tabla].Rows[i]["mgm"].ToString();
                    tbItbisCompras.Text = dsProductosAll.Tables[tabla].Rows[i]["itbis"].ToString();
                }

            }
            if (mskCodigoCompras.Text == "")
            {
                tbCostoCompras.Text = "";
                tbMGPCompras.Text = "";
                tbMGMCompras.Text = "";
                tbPrecioVentaPredCompras.Text = "";
                tbPrecioVentaMayCompras.Text = "";
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void btnAgregarCompras_Click(object sender, EventArgs e)
        {
            DataTable dttDatosCompras = new DataTable();
            dttDatosCompras.Columns.Add("costo");
            dttDatosCompras.Columns.Add("mgp");
            dttDatosCompras.Columns.Add("mgm");
            dttDatosCompras.Columns.Add("pvp");
            dttDatosCompras.Columns.Add("pvm");
            dttDatosCompras.Columns.Add("fecha");
            dttDatosCompras.Rows.Add(tbCostoCompras.Text, tbMGPCompras.Text, tbMGMCompras.Text, tbPrecioVentaPredCompras.Text, tbPrecioVentaMayCompras.Text,dtTPkrFechaCompras.Value.ToString());
            AgregarProducto(ref dttCompras, ref dgvCompras, mskCodigoCompras.Text, nudCantidadCompras.Value.ToString(),dttDatosCompras);
            mskCodigoCompras.Text = "";
            mskCodigoCompras.Focus();
            nudCantidadCompras.Value = 0;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void btnQuitarCompras_Click(object sender, EventArgs e)
        {
            QuitarProducto(ref dttCompras, ref dgvCompras);
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void buscarVentaBtn_Click(object sender, EventArgs e)
        {
            BuscarProductos miBuscarProductos = new BuscarProductos("ventas");
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
            AcceptButton = agregarVentaBtn;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void btnActualizarDevCompras_Click(object sender, EventArgs e)
        {
            if (dttDevCompras.Rows.Count != 0)
            {
                ActualizarInv(ref dttDevCompras);
                msktbCodigoDevCompras.Focus();
                msktbCodigoDevCompras.Text = "";
                dgvDevCompras.Rows.Clear();
                dttDevCompras.Rows.Clear();
            }
            else { MessageForm.Show("La lista esta vacía, por favor agrege uno o mas productos ", "Mensaje del sistema"); }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void btnActualizarInventarioCompras_Click(object sender, EventArgs e)
        {
            if (dttCompras.Rows.Count != 0)
            {
                ActualizarInv(ref dttCompras);
                dttCompras.Rows.Clear();
                dgvCompras.Rows.Clear();
                devVentasPanel.Visible = false;
                Producto miProducto = new Producto();
                DataSet dsProducto = new DataSet();
                dsProductosAll = miProducto.Buscar("todos");
            }
            else { MessageForm.Show("La lista esta vacía, por favor agrege uno o mas productos ", "Mensaje del sistema"); }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void tbCostoCompras_TextChanged(object sender, EventArgs e)
        {
            double costo = 0;
            double mgp;
            double mgm;
            double itbis;
            try
            {
                if (tbCostoCompras.Text != "") costo = Convert.ToDouble(tbCostoCompras.Text);
                else costo = 0;
            }
            catch { tbCostoCompras.Text = ""; }
            if (tbMGPCompras.Text != "") mgp = Convert.ToDouble(tbMGPCompras.Text);
            else mgp = 0;
            if (tbMGMCompras.Text != "") mgm = Convert.ToDouble(tbMGMCompras.Text);
            else mgm = 0;
            if (tbItbisCompras.Text != "") itbis = Convert.ToDouble(tbItbisCompras.Text);
            else itbis = 0;
            //
            double pvpBruto = costo/(1- mgp/100);
            double pvp = pvpBruto + (pvpBruto * itbis / 100);
            double pvmBruto = costo / (1 - mgm / 100);
            double pvm = pvmBruto + (pvmBruto * itbis / 100);
            //
            tbDescuento.Text = "0";
            tbCostoNetoCompras.Text = costo.ToString("0.00");
            tbPrecioVentaPredCompras.Text = pvp.ToString("0.00");
            tbPrecioVentaMayCompras.Text = pvm.ToString("0.00");
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------


        private void tbMGPCompras_TextChanged(object sender, EventArgs e)
        {
            double costo;
            double mgp = 0;
            double itbis;
            double descuento;
            if (tbCostoCompras.Text != "") costo = Convert.ToDouble(tbCostoCompras.Text);
            else costo = 0;
            try
            {
                if (tbMGPCompras.Text != "") mgp = Convert.ToDouble(tbMGPCompras.Text);
                else mgp = 0;
            }
            catch { tbMGPCompras.Text = ""; }
            if (tbItbisCompras.Text != "") itbis = Convert.ToDouble(tbItbisCompras.Text);
            else itbis = 0;
            if (tbDescuento.Text != "") descuento = Convert.ToDouble(tbDescuento.Text);
            else descuento = 0;
            //
            costo -= ((costo * descuento) / 100);
            double pvpBruto = costo / (1 - mgp / 100);
            double pvp = pvpBruto + (pvpBruto * itbis / 100);;
            //
            tbPrecioVentaPredCompras.Text = pvp.ToString("0.00");
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void tbMGMCompras_TextChanged(object sender, EventArgs e)
        {
            double costo;
            double mgm = 0;
            double itbis;
            double descuento;
            if (tbCostoCompras.Text != "") costo = Convert.ToDouble(tbCostoCompras.Text);
            else costo = 0;
            try
            {
                if (tbMGMCompras.Text != "") mgm = Convert.ToDouble(tbMGMCompras.Text);
                else mgm = 0;
            }
            catch { tbMGMCompras.Text = ""; }
            if (tbItbisCompras.Text != "") itbis = Convert.ToDouble(tbItbisCompras.Text);
            else itbis = 0;
            if (tbDescuento.Text != "") descuento = Convert.ToDouble(tbDescuento.Text);
            else descuento = 0;
            //
            costo -= ((costo * descuento) / 100);
            double pvmBruto = costo / (1 - mgm / 100);
            double pvm = pvmBruto + (pvmBruto * itbis / 100);
            //
            tbPrecioVentaMayCompras.Text = pvm.ToString("0.00");
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void btnActualizarInventarioDevVentas_Click(object sender, EventArgs e)
        {
            if (dttDevVentas.Rows.Count != 0)
            {
                ActualizarInv(ref dttDevVentas);
                msktbCodigoDevVentas.Text = "";
                NUDCantidadDevVentas.Value = 1;
                dgvDevVentas.Rows.Clear();
                dttDevVentas.Rows.Clear();
                msktbCodigoDevVentas.Focus();
            }
            else { MessageForm.Show("La lista esta vacía, por favor agrege uno o mas productos ","Mensaje del sistema"); }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnBuscarDevCompras_Click(object sender, EventArgs e)
        {
            BuscarProductos miBuscarProductos = new BuscarProductos("dev_compras");
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

        //------------------------------------------------------------------------------------------------------------------------------------------------------

        private void agregarProductosTabCtrl_Click(object sender, EventArgs e)
        {
            mskCodigoCompras.Focus();
        }
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnBuscarDevVentas_Click(object sender, EventArgs e)
        {
            BuscarProductos miBuscarProductos = new BuscarProductos("dev_ventas");
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
            AcceptButton = devVentasBtn;
        }
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void ActualizarInventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ComprovarTareas() != true) { }
            else
            {
                MessageForm.Show("Hay tareas pendientes, por favor terminelas primero", "Atención"); 
                e.Cancel = true;
            }
        }
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbDescuento_TextChanged(object sender, EventArgs e)
        {
            double costo;
            double itbis;
            double mgp;
            double mgm;
            double descuento = 0;
            //
            if (tbCostoCompras.Text != "") costo = Convert.ToDouble(tbCostoCompras.Text);
            else costo = 0;
            try
            {
                if (tbDescuento.Text != "") descuento = Convert.ToDouble(tbDescuento.Text);
                else descuento = 0;
            }
            catch { tbDescuento.Text = ""; }
            if (tbMGPCompras.Text != "") mgp = Convert.ToDouble(tbMGPCompras.Text);
            else mgp = 0;
            if (tbMGMCompras.Text != "") mgm = Convert.ToDouble(tbMGMCompras.Text);
            else mgm = 0;
            if (tbItbisCompras.Text != "") itbis = Convert.ToDouble(tbItbisCompras.Text);
            else itbis = 0;
            //
            costo -= (costo * descuento / 100);
            double pvpBruto = costo / (1 - mgp / 100);
            double pvmBruto = costo / (1 - mgm / 100);
            double pvp = pvpBruto + (pvpBruto * itbis / 100);
            double pvm = pvmBruto + (pvmBruto * itbis / 100);
            //
            tbCostoNetoCompras.Text = costo.ToString("0.00");
            tbPrecioVentaPredCompras.Text = pvp.ToString("0.00");
            tbPrecioVentaMayCompras.Text = pvm.ToString("0.00");
        }
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //

        private void lkLbSugerirPrecios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool formularioAbierto = false;

            try
            {
                SugerirPrecios miSugerirPrecios = new SugerirPrecios(Convert.ToDouble(tbItbisCompras.Text), Convert.ToDouble(tbCostoCompras.Text), Convert.ToDouble(tbDescuento.Text), "nuevo_producto");
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
       //===================================================================================================================================================
    }

}
