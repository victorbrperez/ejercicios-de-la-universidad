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
using Microsoft.Reporting.WinForms;
namespace SINS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            timerMyTimer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(245, 245,245);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmusuarios frm = new frmAdmusuarios(Utiles.DbItem.Nuevo,0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerUsuarios frm = new frmVerUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void timerMyTimer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frmVerUsuarios frmBuscar = new frmVerUsuarios(Utiles.DbItem.Actualizar);
            frmBuscar.ShowDialog();
            frmAdmusuarios frmAdm = new frmAdmusuarios(Utiles.DbItem.Actualizar, frmBuscar.IdUsuarioSeleccionado);
            frmAdm.MdiParent = this;
            frmAdm.Show();
        }

        private void inscribirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosEstudiante frm = new frmDatosEstudiante(Utiles.DbItem.Nuevo,0);
            frm.MdiParent = this;
            frm.Show();
        }
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CentroEducativo centro = new CentroEducativo();
            frmInstitucion frm = new frmInstitucion(centro,Utiles.DbItem.Nuevo);
            frm.MdiParent = this;
            frm.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscarCentro frm = new frmBuscarCentro(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CentroEducativo centro = new CentroEducativo();
            frmBuscarCentro frmBuscar = new frmBuscarCentro(Utiles.OpcionBusqueda.BusqedaYEnvio);
            //
            frmBuscar.ShowDialog();
            centro.Id = frmBuscar.IdCentroSeleccionado;
            frmBuscar.Dispose();
            //
            if (centro.Id > 0)
            {
                frmInstitucion frmInst = new frmInstitucion(centro, Utiles.DbItem.Actualizar);
                frmInst.MdiParent = this;
                frmInst.Show();
            }

        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carrera carr = new Carrera();
            frmInstitucion frm = new frmInstitucion(carr, Utiles.DbItem.Nuevo);
            frm.MdiParent = this;
            frm.Show();
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBuscarCarrera frm = new frmBuscarCarrera(Utiles.OpcionBusqueda.Busqueda);
            frm.Show();
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Carrera carr = new Carrera();
            frmBuscarCarrera frmBuscarCarr = new frmBuscarCarrera(Utiles.OpcionBusqueda.BusqedaYEnvio);
            frmBuscarCarr.ShowDialog();
            carr.Id = frmBuscarCarr.IdCarreraSeleccionada;
            frmBuscarCarr.Dispose();
            //
            if (carr.Id > 0)
            {
                frmInstitucion frmInst = new frmInstitucion(carr, Utiles.DbItem.Actualizar);
                frmInst.MdiParent = this;
                frmInst.Show();
            }
        }

        private void listadoDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Estudiante est = new Estudiante();
            dt = est.ObtenerListado() ;
            frmReport frm = new frmReport();
            //
            ReportParameter[] paramCollection = new ReportParameter[3];
            paramCollection[0] = new ReportParameter("NombreEmpresa","Cthrics");
            paramCollection[1] = new ReportParameter("Usuario", "User");
            paramCollection[2] = new ReportParameter("Direccion", "SFM");
            //

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSEstudiantes",dt));
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptListadoEstudiantes.rdlc";
            frm.reportViewer1.LocalReport.SetParameters(paramCollection);
            frm.reportViewer1.RefreshReport();
            frm.ShowDialog();
            frm.Dispose();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CentroEducativo centro = new CentroEducativo();
            frmInstitucion frm = new frmInstitucion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosProfesor frm = new frmDatosProfesor(Utiles.DbItem.Nuevo,0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void buscarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmBuscarAulas frm = new frmBuscarAulas(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Aula aula = new Aula();
            frmBuscarAulas frmBuscarA = new frmBuscarAulas(Utiles.OpcionBusqueda.BusqedaYEnvio);
            frmBuscarA.ShowDialog();
            aula.Id = frmBuscarA.IdAulaSeleccionada;
            frmBuscarA.Dispose();
            //
            if (aula.Id > 0)
            {
                frmInstitucion frmInst = new frmInstitucion(aula, Utiles.DbItem.Actualizar);
                frmInst.MdiParent = this;
                frmInst.Show();
            }
        }

        private void inscribirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDatosEstudiante frm = new frmDatosEstudiante(Utiles.DbItem.Nuevo, 0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarEstudiante frmBuscar = new frmBuscarEstudiante(Utiles.OpcionBusqueda.Busqueda);
            frmBuscar.MdiParent = this;
            frmBuscar.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarProfesor frmBuscar = new frmBuscarProfesor(Utiles.OpcionBusqueda.Busqueda);
            frmBuscar.MdiParent = this;
            frmBuscar.Show();
        }
    }
}
