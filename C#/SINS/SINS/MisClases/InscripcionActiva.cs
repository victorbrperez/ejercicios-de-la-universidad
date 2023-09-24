using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class InscripcionActiva
    {
        public InscripcionActiva()
        {
            IdInscripcion = 0;
            IdEstudiante = 0;

        }
        public int IdInscripcion { get; set; }
        public int IdEstudiante { get; set; }
        //

        //******METODOS MIEMBROS********************************************************************************************************
        /// <summary>
        /// Meetetodo que registra en la base de datos
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public bool Registrar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("INSERT INTO tblInscripcionActiva (IdInscripcion,IdEstudiante)  ");
            sql.AppendFormat("VALUES ({0},{1});",this.IdInscripcion.ToString(),this.IdEstudiante.ToString());
            return sqlman.insertar(sql.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Registrado()
        {
            bool r = false;
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            //
            if (this.IdEstudiante > 0)
            {
                sql.AppendFormat("SELECT IdInscripcion FROM tblInscripcionActiva WHERE IdEstudiante = {0}",this.IdEstudiante);
                //
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        r = true;
                    }
                    sqlman.reader.Close();
                }
            }
            return r;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Actualizar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.AppendFormat("UPDATE tblInscripcionActiva SET IdInscripcion = {0} WHERE IdEstudiante = {1} ",this.IdInscripcion.ToString(), this.IdEstudiante.ToString());
            //
            return sqlman.actualizar(sql.ToString());
        }
    }
}
