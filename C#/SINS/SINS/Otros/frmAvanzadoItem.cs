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

namespace SINS.Otros
{
    public partial class frmAvanzadoItem : Form
    {
        public frmAvanzadoItem(AvanzadoOpcionesItem av)
        {
            InitializeComponent();
            Accion = av;
            tbxId.Text = Accion.IdItem.ToString();
            tbxDetalle.Text = Accion.DescripcionItem;
            lblTitulo.Text += (" " + Accion.TipoItem);
        }
        AvanzadoOpcionesItem Accion;
        //
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rdbtnInhabilitar.Checked)
            {
                if (DialogResult.Yes == MessageBox.Show("Seguro que desea inhabilitar este elemento","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
                {
                    if (Accion.InhabilitarItemSQL())
                    {
                        MessageBox.Show("El elemento seleccionado ha sido inhabilitado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Hubo un problema al inabilitar el elemento seleccionado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rdbtnHabilitar.Checked)
            {
                if (Accion.HabilitarItemSQL())
                {
                    MessageBox.Show("El elemento seleccionado ha sido habilitado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Hubo un problema al habilitar el elemento seleccionado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
