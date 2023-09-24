using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINS.MisClases
{
    class MenuPrincipal
    {
        MenuStrip menu;
        ToolStrip toolBar;
        public MenuPrincipal(MenuStrip menu, ToolStrip tStrp)
        {
            this.menu = menu;
            toolBar = tStrp;
        }
        /// <summary>
        /// Actualiza las opciones del menu principal del sistema
        /// </summary>
        /// <param name="permisos">
        /// El listado de permisos separados por ; Ejemplo: 100;200;300;
        /// </param>
        public void UpdateMenuItems(string permisos)
        {
            this.UpdateDropDownItems(this.menu.Items, permisos);
        }
        /// <summary>
        /// Actualiza los sub menu
        /// </summary>
        /// <param name="permisos">
        /// Indica un string de permisos a usarse para el menu principal
        /// </param>
        private void UpdateDropDownItems(ToolStripItemCollection items, string permisos)
        {
            foreach (ToolStripItem item in items)
            {
                if (item.Tag != null)
                {

                    string key = ";" + item.Tag.ToString() + ";";

                    //-
                    // Para desactivar/activar los otros items
                    //--------------------------------------------------
                    if (permisos.IndexOf(key) < 0)
                    {
                        item.Enabled = false;
                    }
                    else
                    {
                        item.Enabled = true;
                    }
                    if (item.Tag.ToString().Trim().Length == 0)
                    {
                        item.Enabled = true;
                    }
                }
                ToolStripMenuItem mnu = new ToolStripMenuItem();
                try
                {
                    mnu = (ToolStripMenuItem)item;
                }
                catch { }
                finally
                {
                    if (mnu.HasDropDownItems && mnu.Enabled)
                        UpdateDropDownItems(mnu.DropDownItems, permisos);
                }
            }
            //Para controlar los permisos de la barra de herramientas
            foreach (ToolStripButton item in toolBar.Items)
            {

                if (item.Tag != null)
                {

                    string key = ";" + item.Tag.ToString() + ";";

                    //-
                    // Para desactivar/activar los otros items
                    //--------------------------------------------------
                    if (permisos.IndexOf(key) < 0)
                    {
                        item.Enabled = false;
                    }
                    else
                    {
                        item.Enabled = true;
                    }
                    if (item.Tag.ToString().Trim().Length == 0)
                    {
                        item.Enabled = true;
                    }
                }
            }
        }
    }
}
