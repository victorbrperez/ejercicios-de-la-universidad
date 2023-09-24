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
using SINS.Otros;
using SINS.Inscripciones;
namespace SINS
{
    public partial class MainForm : Form
    {
        public MainForm(int v_id_usuario)
        {
            InitializeComponent();
            inicializarUsuario(v_id_usuario);
        }
        Usuario usuarioActual;
        /// <summary>
        /// Carga el usuario que va a usar el sistema
        /// </summary>
        /// <param name="id_usuario"></param>
        void inicializarUsuario(int id_usuario)
        {
            usuarioActual = new Usuario();
            if (id_usuario > 0)
            {
                usuarioActual.Id = id_usuario;
                usuarioActual.buscarDatos(Utiles.DbOptionSelect.Basico);
                tsslUsuario.Text = usuarioActual.Nombre;
            }
            usuarioActual.Id = id_usuario;
            MenuPrincipal mnu = new MisClases.MenuPrincipal(this.mainMenuStrip, this.toolStrip1);
            mnu.UpdateMenuItems(usuarioActual.Permisos);
            timerMyTimer.Start();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(245, 245, 245);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerMyTimer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTimer.Text = DateTime.Now.ToLongTimeString();
        }
        private void inscribirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosEstudiante frm = new frmDatosEstudiante(Utiles.DbItem.Nuevo, 0);
            frm.MdiParent = this;
            frm.Show();
        }


        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscarCentro frm = new frmBuscarCentro(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }
        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBuscarCarrera frm = new frmBuscarCarrera(Utiles.OpcionBusqueda.Busqueda);
            frm.Show();
        }
        private void listadoDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Estudiante est = new Estudiante();
            dt = est.ObtenerListado();
            frmReport frm = new frmReport();
            //
            ReportParameter[] paramCollection = new ReportParameter[4];
            paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
            paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
            paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
            paramCollection[3] = new ReportParameter("Total", dt.Rows.Count.ToString());
            //
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSEstudiantes", dt));
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptListadoEstudiantes.rdlc";
            frm.reportViewer1.LocalReport.SetParameters(paramCollection);
            frm.reportViewer1.RefreshReport();
            frm.ShowDialog();
            frm.Dispose();

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosProfesor frm = new frmDatosProfesor(Utiles.DbItem.Nuevo, 0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void buscarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmBuscarAulas frm = new frmBuscarAulas(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }
        private void inscribirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDatosEstudiante frm = new frmDatosEstudiante(Utiles.DbItem.Nuevo, 0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmBuscarEstudiante frmBuscar = new frmBuscarEstudiante(Utiles.OpcionBusqueda.Busqueda);
            frmBuscar.MdiParent = this;
            frmBuscar.Show();*/
            //
            FormCollection fc = Application.OpenForms;
            bool form_abierto_encontrado = false;
            //
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmBuscarEstudiante")
                {
                    frm.Focus();
                    form_abierto_encontrado = true;
                }
            }
            //
            if (form_abierto_encontrado == false)
            {
                frmBuscarEstudiante frmBuscar = new frmBuscarEstudiante(Utiles.OpcionBusqueda.Busqueda);
                frmBuscar.MdiParent = this;
                frmBuscar.Show();
            }
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarProfesor frmBuscar = new frmBuscarProfesor(Utiles.OpcionBusqueda.Busqueda);
            frmBuscar.MdiParent = this;
            frmBuscar.Show();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerUsuarios frm = new frmVerUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            frmBuscarProfesor frmBuscar = new frmBuscarProfesor(Utiles.OpcionBusqueda.Busqueda);
            frmBuscar.MdiParent = this;
            frmBuscar.Show();
        }

        private void centrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscarCentro frm = new frmBuscarCentro(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCarrera frm = new frmBuscarCarrera(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarAulas frm = new frmBuscarAulas(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tipoDeEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarTipoEstudiante frm = new frmBuscarTipoEstudiante(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }
        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarAsignatura frm = new frmBuscarAsignatura(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }

        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarSecciones frm = new frmBuscarSecciones(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }
        private void inscripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcion frm = new frmInscripcion(Utiles.DbItem.Nuevo, 0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmInscripcion frm = new frmInscripcion(Utiles.DbItem.Nuevo, 0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaja frm = new frmCaja();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmCaja frm = new frmCaja();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmBuscarSecciones frm = new frmBuscarSecciones(Utiles.OpcionBusqueda.Busqueda);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cambiarDeUsarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                inicializarUsuario(frm.IdUsuario);
                frm.Dispose();
            }
            this.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frm = new frmAcercaDe();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                inicializarUsuario(frm.IdUsuario);
                frm.Dispose();
            }
            this.Show();
        }

        private void asignaturasInscritasPorEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();
            frmBuscarEstudiante frmEstudiante = new frmBuscarEstudiante(Utiles.OpcionBusqueda.BusquedaYEnvio);
            frmEstudiante.ShowDialog();
            est.Id = frmEstudiante.IdEstudianteSeleccionado;
            est.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
            //
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT tblAsignatura.Clave, tblAsignatura.Descripcion ");
            sql.Append("FROM tblAsignatura, tblSeccion, tblInscripcion,tblDetalleInscripcion, tblEstudiante ");
            sql.Append("WHERE tblAsignatura.Id = tblSeccion.IdAsignatura ");
            sql.Append("AND tblSeccion.Id = tblDetalleInscripcion.IdSeccion ");
            sql.Append("AND tblInscripcion.Id = tblDetalleInscripcion.IdInscripcion ");
            sql.Append("AND tblInscripcion.IdEstudiante = tblEstudiante.Id ");
            sql.AppendFormat("AND tblEstudiante.Id = {0};", est.Id.ToString());
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (est.Id > 0)
            {
                if (dt.Rows.Count > 0)
                {
                    frmReport frm = new frmReport();
                    //
                    ReportParameter[] paramCollection = new ReportParameter[4];
                    paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                    paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                    paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                    paramCollection[3] = new ReportParameter("NombreEstudiante", est.Nombre + " " + est.Apellidos);
                    //
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsAsignaturasInscritas", dt));
                    frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptAsignaturasInscritasEstudiante.rdlc";
                    frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                    frm.reportViewer1.RefreshReport();
                    frm.ShowDialog();
                    frm.Dispose();
                }
                else
                    MessageBox.Show("No hay asignaturas inscritas para este estudiante", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void asignaturasInscritasPorElEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Estudiante est = new Estudiante();
            frmBuscarEstudiante frmEstudiante = new frmBuscarEstudiante(Utiles.OpcionBusqueda.BusquedaYEnvio);
            frmEstudiante.ShowDialog();
            est.Id = frmEstudiante.IdEstudianteSeleccionado;
            est.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
            //
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT distinct tblInscripcion.Id, tblInscripcion.Fecha ");
            sql.Append("FROM tblInscripcion, tblEstudiante ");
            sql.AppendFormat("WHERE tblInscripcion.IdEstudiante = {0};", est.Id.ToString());
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (est.Id > 0)
            {
                if (dt.Rows.Count > 0)
                {
                    frmReport frm = new frmReport();
                    //
                    ReportParameter[] paramCollection = new ReportParameter[4];
                    paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                    paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                    paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                    paramCollection[3] = new ReportParameter("NombreEstudiante", est.Nombre + " " + est.Apellidos);
                    //
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsInscripcionEstudiante", dt));
                    frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptInscripcionesPorEstudiante.rdlc";
                    frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                    frm.reportViewer1.RefreshReport();
                    frm.ShowDialog();
                    frm.Dispose();
                }
                else
                    MessageBox.Show("No hay inscripciones para este estudiante", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void informeDeEstudiantesPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarTipoEstudiante frmTipoEst = new frmBuscarTipoEstudiante(Utiles.OpcionBusqueda.BusquedaYEnvio);
            frmTipoEst.ShowDialog();
            if (frmTipoEst.IdTipoEstudianteSeleccionado > 0)
            {
                DataTable dt = new DataTable();
                SqlMan sqlman = new SqlMan();
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT tblTipoEstudiante.Titulo AS TipoEstudiante, tblEstudiante.Nombre, tblEstudiante.Apellidos ");
                sql.Append("FROM tblEstudiante, tblTipoEstudiante ");
                sql.AppendFormat("WHERE tblEstudiante.TipoEstudiante = tblTipoEstudiante.Id AND tblTipoEstudiante.Id = {0};", frmTipoEst.IdTipoEstudianteSeleccionado);
                dt = sqlman.ObtenerTabla(sql.ToString());
                //
                if (dt.Rows.Count > 0)
                {
                    frmReport frm = new frmReport();
                    //
                    ReportParameter[] paramCollection = new ReportParameter[3];
                    paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                    paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                    paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                    //
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsEstudiantesPorTipo", dt));
                    frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptEstudiantesPorTipo.rdlc";
                    frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                    frm.reportViewer1.RefreshReport();
                    frm.ShowDialog();
                    frm.Dispose();
                }
                else
                    MessageBox.Show("No hay datos para este estudiante", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frmTipoEst.Dispose();
            
        }

        private void listadoDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id, Nombre,Apellidos,Cedula FROM tblProfesor WHERE Activo = 1");
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (dt.Rows.Count > 0)
            {
                frmReport frm = new frmReport();
                //
                ReportParameter[] paramCollection = new ReportParameter[4];
                paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                paramCollection[3] = new ReportParameter("Total", dt.Rows.Count.ToString());
                //
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsListadoProfesores", dt));
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptListadoDeProfesores.rdlc";
                frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();
                frm.Dispose();
            }
            else
                MessageBox.Show("No hay se encontraron datos de profesores registrados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void informeAsignaturasImpartidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesor prof = new Profesor();
            frmBuscarProfesor frmEstudiante = new frmBuscarProfesor(Utiles.OpcionBusqueda.BusquedaYEnvio);
            frmEstudiante.ShowDialog();
            prof.Id = frmEstudiante.IdProfesorSeleccionado;
            prof.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
            //
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT DISTINCT tblAsignatura.Clave, tblAsignatura.Descripcion, tblAsignatura.Creditos ");
            sql.Append("FROM tblAsignatura, tblSeccion ");
            sql.Append("WHERE tblAsignatura.Id = tblSeccion.IdAsignatura ");
            sql.AppendFormat("AND tblSeccion.IdProfesor = {0};", prof.Id.ToString());
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (prof.Id > 0)
            {
                if (dt.Rows.Count > 0)
                {
                    frmReport frm = new frmReport();
                    //
                    ReportParameter[] paramCollection = new ReportParameter[4];
                    paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                    paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                    paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                    paramCollection[3] = new ReportParameter("NombreProfesor", prof.Nombre + " " + prof.Apellidos);
                    //
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsAsignaturasImpartidasPorProf", dt));
                    frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptAsignaturasImpartidasPorProf.rdlc";
                    frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                    frm.reportViewer1.RefreshReport();
                    frm.ShowDialog();
                    frm.Dispose();
                }
                else
                    MessageBox.Show("No hay inscripciones para este estudiante", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void informeDeSeccionesAsignadasAlProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesor prof = new Profesor();
            frmBuscarProfesor frmEstudiante = new frmBuscarProfesor(Utiles.OpcionBusqueda.BusquedaYEnvio);
            frmEstudiante.ShowDialog();
            prof.Id = frmEstudiante.IdProfesorSeleccionado;
            prof.buscarDatosPorId(Utiles.DbOptionSelect.Basico);
            //
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT  tblSeccion.Numero AS Seccion, tblAsignatura.Clave AS ClaveAsignatura, tblAsignatura.Descripcion ");
            sql.Append("FROM tblAsignatura, tblSeccion ");
            sql.Append("WHERE tblAsignatura.Id = tblSeccion.IdAsignatura ");
            sql.AppendFormat("AND tblSeccion.IdProfesor = {0};", prof.Id.ToString());
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (prof.Id > 0)
            {
                if (dt.Rows.Count > 0)
                {
                    frmReport frm = new frmReport();
                    //
                    ReportParameter[] paramCollection = new ReportParameter[4];
                    paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                    paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                    paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                    paramCollection[3] = new ReportParameter("NombreProfesor", prof.Nombre + " " + prof.Apellidos);
                    //
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsSeccionesProfesor", dt));
                    frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptSeccionesProfesor.rdlc";
                    frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                    frm.reportViewer1.RefreshReport();
                    frm.ShowDialog();
                    frm.Dispose();
                }
                else
                    MessageBox.Show("No hay secciones para este profesor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id,Usuario,Nombre, Apellidos, Telefono FROM tblUsuario WHERE Activo = 1");
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (dt.Rows.Count > 0)
            {
                frmReport frm = new frmReport();
                //
                ReportParameter[] paramCollection = new ReportParameter[4];
                paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                paramCollection[3] = new ReportParameter("Total", dt.Rows.Count.ToString());
                //
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsListadoUsuarios", dt));
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptListadoUsuarios.rdlc";
                frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();
                frm.Dispose();
            }
            else
                MessageBox.Show("No se encontraron datos de usuarios registrados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listadoDeUsuariosPorElTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeleccionarTipoUsuario frmTipoUsuario = new frmSeleccionarTipoUsuario();
            frmTipoUsuario.ShowDialog();
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            //
            sql.Append("SELECT tblTipoUsuario.Titulo AS TipoUsuario, tblUsuario.Usuario, Nombre, tblUsuario.Apellidos ");
            sql.Append("FROM tblUsuario, tblTipoUsuario ");
            sql.AppendFormat("WHERE tblTipoUsuario.Id = tblUsuario.Tipo_usuario AND tblTipoUsuario.Id = {0} AND tblTipoUsuario.Activo = 1", frmTipoUsuario.IdeTipoUsuarioSeleccionado);
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (frmTipoUsuario.IdeTipoUsuarioSeleccionado > 0)
            {
                if (dt.Rows.Count > 0)
                {
                    frmReport frm = new frmReport();
                    //
                    ReportParameter[] paramCollection = new ReportParameter[3];
                    paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                    paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                    paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                    //
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dtUsuariosPorTipo", dt));
                    frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptUsuariosPorTipo.rdlc";
                    frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                    frm.reportViewer1.RefreshReport();
                    frm.ShowDialog();
                    frm.Dispose();
                }
                else
                    MessageBox.Show("No hay se encontraron datos de usuarios registrados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            frmTipoUsuario.Dispose();
        }

        private void listadoDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Nombre_corto,Nombre_largo FROM tblCentroEducativo WHERE Activo = 1");
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (dt.Rows.Count > 0)
            {
                frmReport frm = new frmReport();
                //
                ReportParameter[] paramCollection = new ReportParameter[4];
                paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                paramCollection[3] = new ReportParameter("Total", dt.Rows.Count.ToString());
                //
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsListadoCentros", dt));
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptListadoCentros.rdlc";
                frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();
                frm.Dispose();
            }
            else
                MessageBox.Show("No se encontraron datos de centros registrados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listadoDeAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Clave,Descripcion, Creditos FROM tblAsignatura WHERE Activo = 1 order by Clave");
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (dt.Rows.Count > 0)
            {
                frmReport frm = new frmReport();
                //
                ReportParameter[] paramCollection = new ReportParameter[4];
                paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                paramCollection[3] = new ReportParameter("Total", dt.Rows.Count.ToString());
                //
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsListadoAsignaturas", dt));
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptListadoAsignaturas.rdlc";
                frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();
                frm.Dispose();
            }
            else
                MessageBox.Show("No se encontraron datos de usuarios registrados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listadoDeCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Nombre, Creditos FROM tblCarrera WHERE Activo = 1");
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (dt.Rows.Count > 0)
            {
                frmReport frm = new frmReport();
                //
                ReportParameter[] paramCollection = new ReportParameter[4];
                paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                paramCollection[3] = new ReportParameter("Total", dt.Rows.Count.ToString());
                //
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsListadoCarreras", dt));
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptListadoCarreras.rdlc";
                frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();
                frm.Dispose();
            }
            else
                MessageBox.Show("No se encontraron datos de carreras en los registrados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listadoDeSeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();          
            //
            sql.Append("SELECT tblSeccion.Numero AS Seccion, tblAsignatura.Clave AS ClaveAsignatura, tblProfesor.Nombre AS NombreProfesor,tblAula.Codigo AS Aula ");
            sql.Append("FROM tblSeccion, tblAsignatura, tblProfesor, tblHorario_Seccion, tblAula ");
            sql.Append("WHERE tblProfesor.Id = tblSeccion.IdProfesor ");
            sql.Append("AND tblAsignatura.Id = tblSeccion.IdAsignatura ");
            sql.Append("AND tblHorario_Seccion.IdSeccion = 1 ");
            sql.Append("AND tblHorario_Seccion.IdAula = tblAula.Id;");
            //
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (dt.Rows.Count > 0)
            {
                frmReport frm = new frmReport();
                //
                ReportParameter[] paramCollection = new ReportParameter[4];
                paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                paramCollection[3] = new ReportParameter("Total", dt.Rows.Count.ToString());
                //
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsListadoSeccion", dt));
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptListadoSecciones.rdlc";
                frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();
                frm.Dispose();
            }
            else
                MessageBox.Show("No se encontraron datos de secciones en los registrados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void seccionesPorAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlMan sqlman = new SqlMan();
            StringBuilder sql = new StringBuilder();
            //
            frmBuscarAsignatura frmAsignatura = new frmBuscarAsignatura(Utiles.OpcionBusqueda.BusquedaYEnvio);
            frmAsignatura.ShowDialog();
            Asignatura asing = new Asignatura();
            asing.Id = frmAsignatura.IdAsignaturaSeleccionada;
            asing.buscarDatosPorId(Utiles.DbOptionSelect.Todo);
            frmAsignatura.Dispose();
            //
            sql.Append("SELECT DISTINCT asignaturas.Id, asignaturas.Clave AS ClaveAsignatura, asignaturas.Descripcion, seccion.Numero AS Seccion ");
            sql.Append("FROM tblAsignatura asignaturas, tblSeccion seccion ");
            sql.AppendFormat("WHERE asignaturas.Id = {0};",frmAsignatura.IdAsignaturaSeleccionada);
            //
            dt = sqlman.ObtenerTabla(sql.ToString());
            //
            if (dt.Rows.Count > 0)
            {
                frmReport frm = new frmReport();
                //
                ReportParameter[] paramCollection = new ReportParameter[4];
                paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                paramCollection[3] = new ReportParameter("NombreAsignatura",asing.Descripcion);
                //
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsSeccionesAsignatura", dt));
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptSeccionesAsignatura.rdlc";
                frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();
                frm.Dispose();
            }
            else
                MessageBox.Show("No se encontraron datos de secciones en los registrados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void informeDeInscripcionesPorRangoDeFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarInscirpcionesPorFecha frmBI = new frmBuscarInscirpcionesPorFecha();
            frmBI.ShowDialog();
            if (!string.IsNullOrEmpty(frmBI.FechaInicial) && !string.IsNullOrEmpty(frmBI.FechaFinal))
            {
                DataTable dt = new DataTable();
                SqlMan sqlman = new SqlMan();
                StringBuilder sql = new StringBuilder();
                //
                sql.Append("SELECT inscripcion.Id AS NumeroInscripcion, estudiante.Matricula, (estudiante.Nombre + ' ' + estudiante.Apellidos) AS Nombre, inscripcion.Fecha ");
                sql.Append("FROM tblInscripcion inscripcion, tblEstudiante estudiante ");
                sql.Append("WHERE estudiante.id = inscripcion.IdEstudiante ");
                sql.AppendFormat("AND inscripcion.Fecha BETWEEN '{0}' AND '{1}';",frmBI.FechaInicial,frmBI.FechaFinal);
                //
                dt = sqlman.ObtenerTabla(sql.ToString());
                //
                if (dt.Rows.Count > 0)
                {
                    frmReport frm = new frmReport();
                    //
                    ReportParameter[] paramCollection = new ReportParameter[4];
                    paramCollection[0] = new ReportParameter("NombreEmpresa", "Universidad XA");
                    paramCollection[1] = new ReportParameter("Usuario", usuarioActual.Nombre);
                    paramCollection[2] = new ReportParameter("Direccion", "Calle X, #50, Sector No det.");
                    paramCollection[3] = new ReportParameter("RangoFecha", frmBI.FechaInicial + " - " + frmBI.FechaFinal);
                    //
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsInscripcionFecha", dt));
                    frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SINS.Reportes.rptInscripcionFecha.rdlc";
                    frm.reportViewer1.LocalReport.SetParameters(paramCollection);
                    frm.reportViewer1.RefreshReport();
                    frm.ShowDialog();
                    frm.Dispose();
                }
                else
                    MessageBox.Show("No se encontraron datos de secciones en los registrados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
