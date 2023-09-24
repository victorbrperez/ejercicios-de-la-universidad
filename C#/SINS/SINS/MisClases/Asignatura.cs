using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class Asignatura
    {
        public Asignatura()
        {
            Id = 0;
        }
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public int Creditos { get; set; }
        public string Observaciones { get; set; }
        //******METODOS MIEMBROS********************************************************************************************************
        /// <summary>
        /// Meetetodo que registra la asignatura en la base de datos
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public bool Registrar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("INSERT INTO tblAsignatura (Clave,Descripcion,Creditos,Observaciones) ");
            sql.AppendFormat("VALUES ('{0}','{1}',{2},'{3}');",this.Clave,this.Descripcion, this.Creditos, this.Observaciones);
            return sqlman.insertar(sql.ToString());
        }
        /// <summary>
        /// Busca todos los datos de la carrera relacionados al Id del objeto Asignatura
        /// </summary>
        /// <returns></returns>
        public bool buscarDatosPorId(Utiles.DbOptionSelect opcion)
        {
            bool r = false;
            if (Id > 0)
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                //
                if (opcion == Utiles.DbOptionSelect.Basico)
                {
                    sql.AppendFormat("SELECT Clave,Creditos FROM tblAsignatura WHERE Id = {0} AND Activo = 1", this.Id);
                }
                else if (opcion == Utiles.DbOptionSelect.Todo)
                {
                    sql.AppendFormat("SELECT Clave,Descripcion, Creditos, Observaciones FROM tblAsignatura WHERE Id = {0} AND Activo = 1", this.Id);
                }
                //
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        if (sqlman.reader.Read())
                        {
                            this.Clave = sqlman.reader["Clave"].ToString();
                            this.Creditos = Convert.ToInt32(sqlman.reader["Creditos"].ToString());
                            //
                            if (opcion == Utiles.DbOptionSelect.Todo)
                            {
                                this.Descripcion = sqlman.reader["Descripcion"].ToString();
                                this.Observaciones = sqlman.reader["Observaciones"].ToString();
                            }
                            //
                        }
                        r = true;
                    }
                    sqlman.reader.Close();
                }
            }
            return r;
        }
        public bool buscarAsignaturaPorSeccion(int id_seccion)
        {
            bool r = false;
            if (id_seccion > 0)
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                sql.AppendFormat("SELECT Id,Clave,Descripcion, Creditos FROM tblAsignatura WHERE Id IN (SELECT IdAsignatura FROM tblSeccion WHERE Id = {0})", id_seccion);
                //
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        if (sqlman.reader.Read())
                        {
                            this.Creditos = Convert.ToInt32(sqlman.reader["Id"].ToString());
                            this.Clave = sqlman.reader["Clave"].ToString();
                            this.Creditos = Convert.ToInt32(sqlman.reader["Creditos"].ToString());
                            this.Descripcion = sqlman.reader["Descripcion"].ToString();                      
                        }
                        r = true;
                    }
                    sqlman.reader.Close();
                }
            }
            return r;
        }
        /// <summary>
        /// Devuelve una lista de asignaturas 
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public List<Asignatura> Buscar(string palabra_clave)
        {
            StringBuilder sql = new StringBuilder();
            List<Asignatura> liAsignaturas = new List<Asignatura>();
            sql.AppendFormat("SELECT DISTINCT Id,Clave,Descripcion,Creditos FROM tblAsignatura WHERE Clave LIKE '%{0}%' OR Descripcion LIKE '%{0}%' AND Activo = 1 ", palabra_clave);
            SqlMan sqlman = new SqlMan();
            //
            if (sqlman.cargarReader(sql.ToString()))
            {
                while (sqlman.reader.HasRows)
                {
                    while (sqlman.reader.Read())
                    {
                        Asignatura asign = new Asignatura();
                        asign.Id = Convert.ToInt32(sqlman.reader["Id"].ToString());
                        asign.Clave = sqlman.reader["Clave"].ToString();
                        asign.Descripcion = sqlman.reader["Descripcion"].ToString();
                        asign.Creditos = Convert.ToInt32(sqlman.reader["Creditos"].ToString());
                        liAsignaturas.Add(asign);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return liAsignaturas;
        }
        /// <summary>
        /// Actualiza los datos de la asignatura en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Actualizar()
        {
            if (!string.IsNullOrEmpty(this.Descripcion)|| !string.IsNullOrEmpty(this.Clave))
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                sql.AppendFormat("UPDATE tblAsignatura SET Clave = '{0}', Descripcion = '{1}',Creditos = {2},Observaciones = '{3}' WHERE Id = {4}", this.Clave,this.Descripcion, this.Creditos, this.Observaciones, this.Id);
                return sqlman.actualizar(sql.ToString());
            }
            else return false;
        }
    }
}
