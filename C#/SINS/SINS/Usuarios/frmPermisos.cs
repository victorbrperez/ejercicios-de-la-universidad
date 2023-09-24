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

namespace SINS.Usuarios
{
    public partial class frmPermisos : Form
    {
        public frmPermisos(string v_permisos, int id_tu)
        {
            InitializeComponent();
            permisos = string.Empty;
            id_tipo_usuario_actual = id_tu;
            cargarTreeView();
            MarcharNodos(treeViewPermisos.Nodes, v_permisos.Split(';'));
        }
        //
        int id_tipo_usuario_actual;
        public string permisos;
        public string Permisos
        {
            get
            {
                return permisos;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodes"></param>
        private void LimpiarNodos(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = false;
                if (node.Nodes.Count > 0)
                    LimpiarNodos(node.Nodes);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodes"></param>
        private void MarcarTodos(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = true;
                if (node.Nodes.Count > 0)
                    LimpiarNodos(node.Nodes);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        void cargarTreeView()
        {
            Permisos perm = new Permisos();
            List<Permisos> liPadres = perm.obtenerPermisos(Utiles.Permisos.Padres);
            treeViewPermisos.CheckBoxes = true;
            TreeNode node = new TreeNode();
            int x = 0;
            if (liPadres.Count > 0)
            {
                foreach (Permisos padre in liPadres)
                {
                    node = new TreeNode();
                    List<Permisos> liHijos = padre.obtenerPermisos(Utiles.Permisos.Hijos);
                    int y = 0;
                    if (liHijos.Count > 0)
                    {
                        foreach (var hijo in liHijos)
                        {
                            node.Nodes.Add(hijo.Titulo);
                            node.Nodes[y].ImageKey = hijo.Permiso.ToString();
                            y++;

                        }
                    }
                    treeViewPermisos.Nodes.Add(node);
                    treeViewPermisos.Nodes[x].Text = padre.Titulo;
                    treeViewPermisos.Nodes[x].ImageKey = padre.Permiso.ToString();
                    x++;
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            permisos = string.Empty;
            this.Close();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
           
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodes"></param>
        /// <returns></returns>
        private string CheckTreeViewCheckedItems(TreeNodeCollection nodes)
        {
            StringBuilder s = new StringBuilder();
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    s.Append(node.ImageKey);
                    s.Append(";");
                }
                if (node.Nodes.Count > 0)
                    s.Append(CheckTreeViewCheckedItems(node.Nodes));
            }
            return s.ToString();
        }
        /// <summary>
        /// Marca los elementos de TreeView en base a los permisos del usuario acutal
        /// </summary>
        /// <param name="nodes"></param>
        /// <returns></returns>
        private void MarcharNodos(TreeNodeCollection nodes, string[] str_permisos)
        {
            foreach (TreeNode node in nodes)
            {
                foreach (string item in str_permisos)
                {
                    if (node.ImageKey == item)
                    {
                        node.Checked = true;
                    }
                }
                if (node.Nodes.Count > 0)
                    MarcharNodos(node.Nodes,str_permisos);
            }
        }
        private void treeViewPermisos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(";");
            strBuilder.Append(CheckTreeViewCheckedItems(treeViewPermisos.Nodes));
            permisos = strBuilder.ToString();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarNodos(treeViewPermisos.Nodes);
            TipoUsuario tu = new TipoUsuario();
            tu.Id = id_tipo_usuario_actual;
            tu.buscarDatosPorId();
            MarcharNodos(treeViewPermisos.Nodes, tu.Permisos.Split(';'));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarNodos(treeViewPermisos.Nodes);
        }

        private void btnMarcharTodo_Click(object sender, EventArgs e)
        {
            MarcarTodos(treeViewPermisos.Nodes);
        }
    }
}
