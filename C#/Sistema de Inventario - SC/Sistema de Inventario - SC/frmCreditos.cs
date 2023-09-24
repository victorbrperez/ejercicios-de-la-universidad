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
    public partial class frmCreditos : Form
    {
        public frmCreditos()
        {
            InitializeComponent();
        }

        private void frmCreditos_Load(object sender, EventArgs e)
        {
            DataSet dsDatos = new DataSet();
            string archivoXml = "creditos.xml";
            try
            {
                dsDatos.ReadXml(archivoXml);
                tbCreditos.Text = dsDatos.Tables["texto"].Rows[0]["colaboradores"].ToString();
                tbAcerca.Text = dsDatos.Tables["texto"].Rows[0]["acercade"].ToString();
            }
            catch
            {
                MessageBox.Show("El archivo " + archivoXml + " no se ha encontrado o no es valido", "Error en archivo de configuración");
                Application.Exit();
            }
        }

        private void tbCreditos_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
