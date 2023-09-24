using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Inventario_SC
{
    public partial class manualFrm : Form
    {
        public manualFrm()
        {
            InitializeComponent();
        }

        private void ManualFrm_Load(object sender, EventArgs e)
        {
            string urlStr = Directory.GetCurrentDirectory() + @"\Web\index.html";//URL del archivo local
            this.webBrowser.Url = new Uri(urlStr);
        }

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
