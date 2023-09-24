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

namespace SINS.Secciones
{
    public partial class frmSeccionesLlenas : Form
    {
        public frmSeccionesLlenas(List<Seccion> liSecciones)
        {
            InitializeComponent();
            if (liSecciones.Count > 0)
            {
                foreach (Seccion item in liSecciones)
                {
                    Asignatura asign = new Asignatura();
                    asign.Id = item.IdAsignatura;
                    asign.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
                    dgvDatos.Rows.Add(asign.Clave, asign.Descripcion,item.Id.ToString(),item.Capacidad.ToString());
                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
