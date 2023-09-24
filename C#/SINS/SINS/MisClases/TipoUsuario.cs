using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class TipoUsuario
    {
        public TipoUsuario()
        {
            this.Id = 0;
        }
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Activo { get; set; }
        public string Permisos { get; set; }
        /// <summary>
        /// Optiene la lista de Tipo de usuarios disponible en la base de datos
        /// </summary>
        /// <param name="palabra_clave"></param>
        /// <returns></returns>
        public List<TipoUsuario> ObtenerUsuarios()
        {
            StringBuilder sql = new StringBuilder();
            List<TipoUsuario> liTipoUsuarios = new List<TipoUsuario>();
            sql.Append("SELECT Id, Titulo, Permisos FROM tblTipoUsuario;");
            //
            SqlMan sqlman = new SqlMan();
            if (sqlman.cargarReader(sql.ToString()))
            {
                while (sqlman.reader.HasRows)
                {
                    while (sqlman.reader.Read())
                    {
                        TipoUsuario tu = new TipoUsuario();
                        tu.Id = Convert.ToInt32(sqlman.reader["Id"].ToString());
                        tu.Titulo = sqlman.reader["Titulo"].ToString();
                        tu.Permisos = sqlman.reader["Permisos"].ToString();
                        liTipoUsuarios.Add(tu);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return liTipoUsuarios;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool buscarDatosPorId()
        {
            bool r = false;
            if (this.Id > 0)
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                sql.AppendFormat("SELECT Titulo, Permisos FROM tblTipoUsuario WHERE Id = {0} AND Activo = 1", this.Id);
                //
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        if (sqlman.reader.Read())
                        {
                            this.Titulo = sqlman.reader["Titulo"].ToString();
                            this.Permisos = sqlman.reader["Permisos"].ToString();
                        }
                        r = true;
                    }
                    sqlman.reader.Close();
                }
            }
            return r;
        }
    }
}
