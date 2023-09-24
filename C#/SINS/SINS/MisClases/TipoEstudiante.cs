using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class TipoEstudiante
    {
        public TipoEstudiante()
        {
            Id = 0;
        }
        public int Id { get; set; }
        public string Titulo { get; set; }
        public double CostoCredito { get; set; }
        public double CostoInscripcion { get; set; }
        public string Observaciones { get; set; }

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
            sql.Append("INSERT INTO tblTipoEstudiante (Titulo,CostoCredito,CostoInscripcion,Observaciones)");
            sql.AppendFormat("VALUES ('{0}',{1},{2},'{3}')",this.Titulo,this.CostoCredito,this.CostoInscripcion,this.Observaciones);
            return sqlman.insertar(sql.ToString());
        }
        /// <summary>
        /// Meetetodo que busca y devuelve una lista de los tipos de estudiantes 
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public List<TipoEstudiante> Buscar(string palabra_clave)
        {
            StringBuilder sql = new StringBuilder();
            List<TipoEstudiante> liTipoEstudiante = new List<TipoEstudiante>();
            sql.AppendFormat("SELECT DISTINCT Id,Titulo,CostoCredito,CostoInscripcion FROM tblTipoEstudiante WHERE Id LIKE '%{0}%' OR Titulo LIKE '%{0}%' AND Activo = 1 ", palabra_clave);
            SqlMan sqlman = new SqlMan();
            if (sqlman.cargarReader(sql.ToString()))
            {
                while (sqlman.reader.HasRows)
                {
                    while (sqlman.reader.Read())
                    {
                        TipoEstudiante te = new TipoEstudiante();
                        te.Id = Convert.ToInt32(sqlman.reader["Id"].ToString());
                        te.Titulo = sqlman.reader["Titulo"].ToString();
                        te.CostoCredito = Convert.ToDouble(sqlman.reader["CostoCredito"].ToString());
                        te.CostoInscripcion = Convert.ToDouble(sqlman.reader["CostoInscripcion"].ToString());
                        //
                        liTipoEstudiante.Add(te);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return liTipoEstudiante;
        }
        /// <summary>
        /// Busca todos los datos de la carrera relacionados al Id del objeto TipoEstudiante
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
                    sql.AppendFormat("SELECT Titulo from tblTipoEstudiante WHERE Id = {0} AND Activo = 1", this.Id);
                }
                else if (opcion == Utiles.DbOptionSelect.Todo)
                {
                    sql.AppendFormat("SELECT Titulo,CostoCredito,CostoInscripcion,Observaciones FROM tblTipoEstudiante WHERE Id = {0} AND Activo = 1", this.Id);
                }

                //
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        if (sqlman.reader.Read())
                        {
                            this.Titulo = sqlman.reader["Titulo"].ToString();
                            if (opcion == Utiles.DbOptionSelect.Todo)
                            {
                                this.CostoCredito = Convert.ToDouble(sqlman.reader["CostoCredito"].ToString());
                                this.CostoInscripcion = Convert.ToDouble(sqlman.reader["CostoInscripcion"].ToString());
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
        /// Actualiza los valores de la tabla tblTipoEstudiante en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Actualizar()
        {
            if (!string.IsNullOrEmpty(this.Titulo) && this.Id > 0)
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                sql.AppendFormat("UPDATE tblTipoEstudiante SET Titulo = '{0}',CostoCredito = {1},CostoInscripcion = {2},Observaciones = '{3}' WHERE Id = {4};", this.Titulo, this.CostoCredito, this.CostoInscripcion,this.Observaciones, this.Id);
                return sqlman.actualizar(sql.ToString());
            }
            else return false;
        }
    }
}
