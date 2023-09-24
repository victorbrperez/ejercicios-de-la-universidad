using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class CentroEducativo
    {
        public int Id { get; set; }
        public string NombreCorto { get; set; }
        public string NombreLargo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Web { get; set; }
        public string Observaciones { get; set; }
        //
        //******METODOS MIEMBRO*****************************************************************************************************
        /// <summary>
        /// Meetetodo que registra en Centro Educativo en la base de datos
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public bool registrar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("INSERT INTO tblCentroEducativo(Nombre_corto,Nombre_largo,Telefono,Correo,Direccion,Web,Observaciones) ");
            sql.AppendFormat("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",this.NombreCorto,this.NombreLargo,this.Telefono,this.Correo,this.Direccion,this.Web,this.Observaciones);
            return sqlman.insertar(sql.ToString());
        }
          /// <summary>
        /// Meetetodo que busca centros educativos 
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public List<CentroEducativo> buscar(string palabra_clave)
        {
            StringBuilder sql = new StringBuilder();
            List<CentroEducativo> liCentro = new List<CentroEducativo>();
            sql.AppendFormat("SELECT DISTINCT Id,Nombre_corto,Nombre_largo FROM tblCentroEducativo WHERE Nombre_corto LIKE '%{0}%' OR Nombre_largo LIKE '%{0}%' AND Activo = 1 ", palabra_clave);
            SqlMan sqlman = new SqlMan();
            if (sqlman.cargarReader(sql.ToString()))
            {
                while (sqlman.reader.HasRows)
                {
                    while (sqlman.reader.Read())
                    {
                        CentroEducativo ce = new CentroEducativo();
                        ce.Id = Convert.ToInt32(sqlman.reader["Id"].ToString());
                        ce.NombreCorto = sqlman.reader["Nombre_corto"].ToString();
                        ce.NombreLargo = sqlman.reader["Nombre_largo"].ToString();
                        liCentro.Add(ce);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return liCentro;
        }
        /// <summary>
        /// Busca todos los datos del centro educativo relacionados al Id del objeto CentroEducativo
        /// </summary>
        /// <returns></returns>
        public bool buscarDatosPorId(Utiles.DbOptionSelect opcion)
        {
            bool r = false;
            if (Id > 0)
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                if (opcion == Utiles.DbOptionSelect.Todo)
                {
                    sql.AppendFormat("SELECT Nombre_corto,Nombre_largo,Telefono,Correo,Direccion,Web,Observaciones FROM tblCentroEducativo WHERE Id = {0} AND Activo = 1", this.Id);
                }
                else if (opcion == Utiles.DbOptionSelect.Basico)
                {
                    sql.AppendFormat("SELECT Nombre_corto,Nombre_largo FROM tblCentroEducativo WHERE Id = {0} AND Activo = 1", this.Id);
                }                
                //
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        if (sqlman.reader.Read())
                        {
                            this.NombreCorto = sqlman.reader["Nombre_corto"].ToString();
                            this.NombreLargo = sqlman.reader["Nombre_largo"].ToString();
                            //
                            if (opcion == Utiles.DbOptionSelect.Todo)
                            {
                                this.Telefono = sqlman.reader["Telefono"].ToString();
                                this.Correo = sqlman.reader["Correo"].ToString();
                                this.Direccion = sqlman.reader["Direccion"].ToString();
                                this.Web = sqlman.reader["Web"].ToString();
                                this.Observaciones = sqlman.reader["Observaciones"].ToString();
                            }
                   
                        }
                        r = true;
                    }
                    
                }
                sqlman.reader.Close();
            }
            return r;
        }
        public bool Actualizar()
        {
            if (!string.IsNullOrEmpty(this.NombreCorto) && !string.IsNullOrEmpty(this.NombreLargo))
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                sql.AppendFormat("UPDATE tblCentroEducativo SET Nombre_corto = '{0}',Nombre_largo = '{1}',Telefono = '{2}',Correo = '{3}',Direccion = '{4}',Web = '{5}', Observaciones = '{6}' WHERE Id = {7}", this.NombreCorto, this.NombreLargo, this.Telefono, this.Correo, this.Direccion, this.Web, this.Observaciones, this.Id);
                return sqlman.actualizar(sql.ToString());
            }
            else return false;
        }
    }
}
