using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Inventario_SC
{
    public partial class SugerirPrecios : Form
    {
        public SugerirPrecios(double itbVal, double costoValue, double descValue,string procesoVal)
        {
            InitializeComponent();
            itbis = itbVal;
            costo = costoValue;
            descuento = descValue;
            tbItebis.Text = itbis.ToString();
            proceso = procesoVal;
        }
        //
        //=======VARIABLES LOCALES========================================================================================================
        //
        double itbis;
        double costo;
        double costo_neto;
        double descuento;
        string proceso;
        //
        //========METODOS DEL PROGRAMADOR====================================================================================================
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private string CalcularPrecio()
        {
            double pvp = 0;
            double mgp = 0;
            double pvpItebis = 0;
            double beneficio = 0;
            try
            {
                if (tbPrecioVentaPred.Text != "")
                {
                    pvpItebis = Convert.ToDouble(tbPrecioVentaPred.Text);
                    pvp = pvpItebis / (1 + (itbis / 100));
                }
                else pvp = 0;
            }
            catch { tbPrecioVentaPred.Text = ""; }

            if (pvp != 0)
            {
                costo_neto = costo - (costo * descuento / 100);
                mgp = (100 * (costo_neto - pvp) / pvp) * -1;
                beneficio = pvp - costo_neto;
                tbBeneficio.Text = beneficio.ToString("0.00");
            }
           return mgp.ToString("0.00");
        }
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private string CalcularPrecioMay()
        {
            double pvm = 0;
            double mgm = 0;
            double pvmItebis = 0;
            double beneficio = 0;
            try
            {
                if (tbPrecioVentaMay.Text != "")
                {
                    pvmItebis = Convert.ToDouble(tbPrecioVentaMay.Text);
                    pvm = pvmItebis / (1 + (itbis / 100));
                }
                else pvm = 0;
            }
            catch { tbPrecioVentaMay.Text = ""; }

            if (pvm != 0)
            {
                costo_neto = costo - (costo * descuento / 100);
                mgm = (100 * (costo_neto - pvm) / pvm) * -1;
                beneficio = pvm - costo_neto;
                tbBeneficioMay.Text = beneficio.ToString("0.00");
            }
            return mgm.ToString("0.00");
        }
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        //======EVENTOS======================================================================================================================
        //
        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbPrecioVentaPred_TextChanged(object sender, EventArgs e)
        {
            switch(proceso)
            {
                case "nuevo_producto" :
                    IForm formInterface = this.Owner as IForm;
                    if (formInterface != null)
                    {
                        formInterface.ActualizarMGP(CalcularPrecio());
                    }
                    break;
            }
        }
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void tbPrecioVentaMay_TextChanged(object sender, EventArgs e)
        {
            switch (proceso)
            {
                case "nuevo_producto" :
                    IForm formInterface = this.Owner as IForm;
                    if (formInterface != null)
                    {
                        formInterface.ActualizarMGM(CalcularPrecioMay());
                    }
                    break;
        }
        }
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void SugerirPrecios_Load(object sender, EventArgs e)
        {
            costo_neto = costo - (costo * descuento / 100);
            tbCostoNeto.Text = costo_neto.ToString("0.00"); 
        }
        //
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
    }
}
