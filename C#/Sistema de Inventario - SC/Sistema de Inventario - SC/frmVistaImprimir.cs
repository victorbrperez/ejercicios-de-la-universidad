using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MisClases;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace Sistema_de_Inventario_SC
{
    public partial class frmVistaImprimir : Form
    {
        public frmVistaImprimir(DataSet dsValues)
        {
            InitializeComponent();
            dsListaProductos = dsValues;
        }

        DataSet dsListaProductos = new DataSet();

        private void frmVistaImprimir_Load(object sender, EventArgs e)
        {
            DsInventario dsTemp = new DsInventario();
            DataTable dttTemp = dsTemp.productos;



            int total_productos = 0;
            double total_inventario = 0;


            for (int i = 0; i < dsListaProductos.Tables["productos"].Rows.Count; i++)
            {
                dttTemp.Rows.Add(dsListaProductos.Tables["productos"].Rows[i]["codigo"].ToString(), dsListaProductos.Tables["productos"].Rows[i]["referencia"].ToString(),
                    dsListaProductos.Tables["productos"].Rows[i]["descripcion"].ToString(), dsListaProductos.Tables["productos"].Rows[i]["marca"].ToString(), dsListaProductos.Tables["productos"].Rows[i]["cantidad"].ToString(),
                    dsListaProductos.Tables["productos"].Rows[i]["costo"].ToString(), dsListaProductos.Tables["productos"].Rows[i]["itbis"].ToString());
                //
                total_productos += Convert.ToInt32(dsListaProductos.Tables["productos"].Rows[i]["cantidad"].ToString());
                total_inventario += Convert.ToDouble(dsListaProductos.Tables["productos"].Rows[i]["costo"].ToString()) * Convert.ToDouble(dsListaProductos.Tables["productos"].Rows[i]["cantidad"].ToString());
            }
            dttTemp.Rows[0]["totalProductos"] = total_productos;
            dttTemp.Rows[0]["monto"] = total_inventario;
            ReportDataSource  miRepDataSource = new ReportDataSource("DataSet1",dttTemp);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(miRepDataSource);
            reportViewer1.RefreshReport();
        }
    }
}
