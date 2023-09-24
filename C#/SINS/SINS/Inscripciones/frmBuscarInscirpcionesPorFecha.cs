using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINS.Inscripciones
{
    public partial class frmBuscarInscirpcionesPorFecha : Form
    {
        public frmBuscarInscirpcionesPorFecha()
        {
            InitializeComponent();
            fecha_incial = string.Empty;
            fecha_final = string.Empty;

        }
        string fecha_incial;
        string fecha_final;
        //
        public string FechaInicial
        {
            get { return fecha_incial; }
        }
        public string FechaFinal
        {
            get { return fecha_final; }
        }
        //
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscarInscirpcionesPorFecha_Load(object sender, EventArgs e)
        {

        }

        private void dtpkFinal_ValueChanged(object sender, EventArgs e)
        {
            dtpkInicial.MaxDate = dtpkFinal.Value;
        }

        private void dtpkInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpkFinal.MinDate = dtpkInicial.Value;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            fecha_final = dtpkFinal.Value.ToShortDateString();
            fecha_incial = dtpkInicial.Value.ToShortDateString();
            this.Close();
        }
    }
}
