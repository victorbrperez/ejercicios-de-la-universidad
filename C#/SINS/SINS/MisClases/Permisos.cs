using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class Permisos
    {
        public Permisos()
        {
            Permiso = 0;
        }
        public int Tipo { get; set; }
        public int Permiso { get; set; }
        public string Titulo { get; set; }
        /// <summary>
        /// Devuelve una lista de objetos Permisos
        /// </summary>
        /// <returns></returns>
        public List<Permisos> obtenerPermisos(Utiles.Permisos tipo_permisos)
        {
            StringBuilder sql = new StringBuilder();
            List<Permisos> liPermisos = new List<Permisos>();
            //
            if (tipo_permisos == Utiles.Permisos.Padres)
            {
                sql.Append("SELECT Permiso, Titulo FROM tblPermisos WHERE Tipo = 1");
            }
            else if (tipo_permisos == Utiles.Permisos.Hijos)
            {
                sql.AppendFormat("SELECT Permiso, Titulo FROM tblPermisos WHERE Tipo = 2 AND Padre = {0} ",this.Permiso);
            }
            
            SqlMan sqlman = new SqlMan();
            if (sqlman.cargarReader(sql.ToString())) 
            {
                while (sqlman.reader.HasRows)
                {
                    while (sqlman.reader.Read())
                    {
                        Permisos perm = new Permisos();
                        perm.Permiso = Convert.ToInt32(sqlman.reader["Permiso"].ToString());
                        perm.Titulo = sqlman.reader["Titulo"].ToString();
                        liPermisos.Add(perm);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return liPermisos;
        }
    }
}
