using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINS
{
    static class Program
    {
        [STAThread]
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frm = new frmLogin();
            Application.Run(frm);
            if(frm.DialogResult == DialogResult.OK)
            {
                Application.Run(new MainForm(frm.IdUsuario));
            }
        }
    }
}
