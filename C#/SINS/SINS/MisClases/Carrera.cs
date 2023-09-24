using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public string Observaciones { get; set; }

        //******METODOS MIEMBROS********************************************************************************************************
        /// <summary>
        /// Meetetodo que registra la carrera en la base de datos
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public bool Registrar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("INSERT INTO tblCarrera(Nombre,Creditos,Observaciones) ");
            sql.AppendFormat("VALUES ('{0}',{1},'{2}');",this.Nombre,this.Creditos,this.Observaciones);
            return sqlman.insertar(sql.ToString());
        }
        /// <summary>
        /// Busca todos los datos de la carrera relacionados al Id del objeto Carrera
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
                    sql.AppendFormat("SELECT Nombre FROM tblCarrera WHERE Id = {0} AND Activo = 1", this.Id);
                }
                else if (opcion == Utiles.DbOptionSelect.Todo)
                {
                    sql.AppendFormat("SELECT Nombre, Creditos, Observaciones FROM tblCarrera WHERE Id = {0} AND Activo = 1", this.Id);
                }
                
                //
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        if (sqlman.reader.Read())
                        {
                            this.Nombre = sqlman.reader["Nombre"].ToString();
                            if (opcion == Utiles.DbOptionSelect.Todo)
                            {
                                this.Creditos = Convert.ToInt32(sqlman.reader["Creditos"].ToString());
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
        /// Meetetodo que busca y devuelve una lista de carreras 
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public List<Carrera> Buscar(string palabra_clave)
        {
            StringBuilder sql = new StringBuilder();
            List<Carrera> liCarreras = new List<Carrera>();
            sql.AppendFormat("SELECT DISTINCT Id,Nombre,Creditos FROM tblCarrera WHERE Nombre LIKE '%{0}%' AND Activo = 1 ", palabra_clave);
            SqlMan sqlman = new SqlMan();
            if (sqlman.cargarReader(sql.ToString()))
            {
                while (sqlman.reader.HasRows)
                {
                    while (sqlman.reader.Read())
                    {
                        Carrera carr = new Carrera();
                        carr.Id = Convert.ToInt32(sqlman.reader["Id"].ToString());
                        carr.Nombre = sqlman.reader["Nombre"].ToString();
                        carr.Creditos = Convert.ToInt32(sqlman.reader["Creditos"].ToString());
                        liCarreras.Add(carr);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return liCarreras;
        }
        /// <summary>
        /// Metod para actualizar los datos de la carrera en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Actualizar()
        {
            if (!string.IsNullOrEmpty(this.Nombre))
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                sql.AppendFormat("UPDATE tblCarrera SET Nombre = '{0}',Creditos = {1},Observaciones = '{2}' WHERE Id = {3}",this.Nombre,this.Creditos,this.Observaciones,this.Id);
                return sqlman.actualizar(sql.ToString());
            }
            else return false;
        }
    }

}
