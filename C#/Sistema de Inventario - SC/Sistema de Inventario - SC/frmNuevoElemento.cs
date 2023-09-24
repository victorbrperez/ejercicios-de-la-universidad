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
    public partial class frmNuevoElemento : Form
    {
        public frmNuevoElemento(string recursoValue)
        {
            InitializeComponent();
            recurso = recursoValue;
            lbTitulo.Text += recurso;
        }

        string recurso;
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool operacion_correcta = false;
            switch(recurso)
            {
                case "unidad" :
                    Unidad miUnidad = new Unidad();
                    if ("" != tbNombre.Text)
                    {
                        miUnidad.Nombre = tbNombre.Text;
                        if (miUnidad.Registrar())
                        {
                            MessageForm.Show("Unidad registrada correctamente", "Mensaje");
                            operacion_correcta = true;
                        }
                        else { MessageForm.Show("No se pudo registrar", "Mensaje"); }
                    }
                    else MessageForm.Show("Por favor introduzca el nombre","Atencion");
                    break;
                case "marca" :
                    Marca miMarca = new Marca();
                    if ("" != tbNombre.Text)
                    {
                        miMarca.Nombre = tbNombre.Text;
                        if (miMarca.Registrar())
                        {
                            MessageForm.Show("Marca registrada correctamente", "Mensaje");
                            operacion_correcta = true;
                        }
                        else { MessageForm.Show("No se pudo registrar", "Mensaje"); }
                    }
                    else MessageForm.Show("Por favor introduzca el nombre","Atencion");
                    break;
                case "ubicacion" :
                         Ubicacion miUbicacion = new Ubicacion();
                    if ("" != tbNombre.Text)
                    {
                        miUbicacion.Nombre = tbNombre.Text;
                        if (miUbicacion.Registrar())
                        {
                            MessageForm.Show("Ubicacion registrada correctamente", "Mensaje");
                            operacion_correcta = true;
                        }
                        else { MessageForm.Show("No se pudo registrar", "Mensaje"); }
                    }
                    else MessageForm.Show("Por favor introduzca el nombre","Atencion");
                    break;
            }
            //
            if (operacion_correcta)
            {
                IForm2 frmInterfaz = this.Owner as IForm2;
                if (frmInterfaz != null) frmInterfaz.RefrescarFormulario(recurso);
                this.Close();
            }
            tbNombre.Focus();
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
    }
}
