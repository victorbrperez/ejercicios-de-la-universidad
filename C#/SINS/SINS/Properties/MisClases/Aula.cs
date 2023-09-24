using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class Aula
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public int Capacidad { get; set; }
        public int Centro { get; set; }
        public string Observaciones { get; set;}
        //

        //******METODOS MIEMBROS********************************************************************************************************
        /// <summary>
        /// Meetetodo que registra el aula en la base de datos
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public bool Registrar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("INSERT INTO tblAula (Descripcion,Codigo,Capacidad,IdCentro,Observaciones)  ");
            sql.AppendFormat("VALUES ('{0}','{1}',{2},{3},'{4}');", this.Descripcion, this.Codigo, this.Capacidad.ToString(), this.Centro.ToString(), this.Observaciones);
            return sqlman.insertar(sql.ToString());
        }
        /// <summary>
        /// Meetetodo que busca y devuelve una lista de aulas 
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public List<Aula> Buscar(string palabra_clave)
        {
            StringBuilder sql = new StringBuilder();
            List<Aula> liAulas = new List<Aula>();
            sql.AppendFormat("SELECT DISTINCT Id,Descripcion,Codigo FROM tblAula WHERE Codigo LIKE '%{0}%' OR Descripcion LIKE '%{0}%'AND Activo = 1 ", palabra_clave);
            SqlMan sqlman = new SqlMan();
            if (sqlman.cargarReader(sql.ToString()))
            {
                while (sqlman.reader.HasRows)
                {
                    while (sqlman.reader.Read())
                    {
                        Aula aula = new Aula();
                        aula.Id = Convert.ToInt32(sqlman.reader["Id"].ToString());
                        aula.Descripcion = sqlman.reader["Descripcion"].ToString();
                        aula.Codigo = sqlman.reader["Codigo"].ToString();
                        liAulas.Add(aula);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return liAulas;
        }
        /// <summary>
        /// Busca todos los datos de la carrera relacionados al Id del objeto Aula
        /// </summary>
        /// <returns></returns>
        public bool buscarDatosPorId(Utiles.DbOptionSelect opcion)
        {
            bool r = false;
            if (Id > 0)
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                if (opcion == Utiles.DbOptionSelect.Basico)
                {
                    sql.AppendFormat("SELECT Codigo,Descripcion FROM tblAula WHERE Id = {0} AND Activo = 1", this.Id);
                }
                else if (opcion == Utiles.DbOptionSelect.Todo)
                {
                    sql.AppendFormat("SELECT Codigo,Descripcion,Capacidad,IdCentro,Observaciones FROM tblAula WHERE Id = {0} AND Activo = 1", this.Id);
                }

                //
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        if (sqlman.reader.Read())
                        {
                            this.Codigo = sqlman.reader["Codigo"].ToString();
                            this.Descripcion = sqlman.reader["Descripcion"].ToString();
                            if (opcion == Utiles.DbOptionSelect.Todo)
                            {
                                this.Capacidad = Convert.ToInt32(sqlman.reader["Capacidad"].ToString());
                                this.Centro = Convert.ToInt32(sqlman.reader["IdCentro"].ToString());
                                this.Observaciones = sqlman.reader["Observaciones"].ToString();
                            }
                        }
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
            if (!string.IsNullOrEmpty(this.Codigo))
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                sql.AppendFormat("UPDATE tblAula SET Codigo = '{0}',Descripcion = '{1}',Capacidad = {2},IdCentro = {3},Observaciones = '{4}' WHERE Id = {5}", this.Codigo, this.Descripcion, this.Capacidad.ToString(), this.Centro.ToString(), this.Observaciones,this.Id);
                return sqlman.actualizar(sql.ToString());
            }
            else return false;
        }
    }
}
