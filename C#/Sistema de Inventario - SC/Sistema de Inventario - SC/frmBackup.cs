using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MisClases;
using MySql.Data.MySqlClient;
namespace Sistema_de_Inventario_SC
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbRuta.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            try
            {
                string archivo = tbRuta.Text + "\\data.sql";
                ConfigurarcionSQL miSqlConf = new ConfigurarcionSQL();
                MySqlBackup mBkp = new MySqlBackup(miSqlConf.GetConexionStr());
                mBkp.ExportInfo.FileName = archivo;
                mBkp.Export();
                MessageForm.Show("Datos guradados correctamente","Mensaje");
            }
            catch
            {
                MessageForm.Show("Problema con la base de datos no se han podido guardar los datos", "Error");
            }
        }
    }
}
