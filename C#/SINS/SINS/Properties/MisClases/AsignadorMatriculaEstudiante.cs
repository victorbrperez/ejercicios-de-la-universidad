using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    class AsignadorMatriculaEstudiante
    {
        public AsignadorMatriculaEstudiante()
        {
            id = 1;
            bloqueado = true;
            MatriculaNueva = 0;
        }

        public int id;
        public long ultima_matricula;
        public bool bloqueado;
        public long MatriculaNueva { get; set; }
        /// <summary>
        /// Comprueba si el campo Bloqueado de la tabla tblAsignacionMatriculaEsutidante esta en 1 o 0
        /// </summary>
        /// <returns></returns>
        bool comprobarBloqueo()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.AppendFormat("SELECT Bloqueado FROM tblAsignadorMatriculaEstudiante WHERE Id = {0};", this.id);
            //
            if (sqlman.cargarReader(sql.ToString()))
            {
                if (sqlman.reader.HasRows)
                {
                    if (sqlman.reader.Read())
                    {
                        this.bloqueado = Convert.ToBoolean(sqlman.reader["Bloqueado"].ToString());
                    }
                }
                sqlman.reader.Close();
            }
            sqlman.cerrar();
            return this.bloqueado;
        }
        public bool BloquearYAsignar()
        {
            bool r = false;
            if (!comprobarBloqueo())
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                sql.AppendFormat("UPDATE tblAsignadorMatriculaEstudiante SET Bloqueado = 1 WHERE  Id = {0};", this.id);
                sqlman.actualizar(sql.ToString());
                sql.Clear();
                sqlman.cerrar();
                sql.AppendFormat("SELECT UltimaMatricula FROM tblAsignadorMatriculaEstudiante WHERE Id = {0};", this.id);
                //
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        if (sqlman.reader.Read())
                        {
                            this.ultima_matricula = Convert.ToInt64(sqlman.reader["UltimaMatricula"].ToString());
                            MatriculaNueva = ultima_matricula + 1;
                            r = true;
                        }
                    }
                    sqlman.reader.Close();
                }
            }
            return r;
        }
        public void Actualizar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Clear();
            sqlman.cerrar();
            if (ultima_matricula > 0)
            {
                sql.AppendFormat("UPDATE tblAsignadorMatriculaEstudiante SET UltimaMatricula = {0} WHERE  Id = {1};", MatriculaNueva.ToString(), this.id);
                sqlman.actualizar(sql.ToString());
            }
        }
        public void Desbloquear()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Clear();
            sqlman.cerrar();
            sql.AppendFormat("UPDATE tblAsignadorMatriculaEstudiante SET Bloqueado = 0 WHERE  Id = {0};", this.id);
            sqlman.actualizar(sql.ToString());
        }
    }
}
