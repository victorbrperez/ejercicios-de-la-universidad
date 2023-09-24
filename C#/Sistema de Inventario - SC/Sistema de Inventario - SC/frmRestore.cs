using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MisClases;

namespace Sistema_de_Inventario_SC
{
    public partial class frmRestore : Form
    {
        public frmRestore()
        {
            InitializeComponent();
        }
        private void btnRuta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbRuta.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                string archivo = tbRuta.Text + "\\data.sql";
                ConfigurarcionSQL miSqlConf = new ConfigurarcionSQL();
                MySqlBackup mBkp = new MySqlBackup(miSqlConf.GetConexionStr());
                mBkp.ImportInfo.FileName = archivo;
                mBkp.Import();
                MessageForm.Show("Datos respaldados correctamente", "Mensaje");
            }
            catch
            {
                MessageForm.Show("Problema con la base de datos no se han podido respaldar los datos", "Error");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
