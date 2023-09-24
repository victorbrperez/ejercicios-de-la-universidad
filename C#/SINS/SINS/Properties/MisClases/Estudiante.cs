using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SINS.MisClases
{
    public class Estudiante
    {
        public Estudiante()
        {
        }
        //
        public int Id { get; set; }
        public long Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string TelefonoMovil { get; set; }
        public string TelefonoCasa { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int TipoEstudiante { get; set; }
        public float Balance { get; set; }
        public int CentroEducativo { get; set; }
        public int Carrera { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Observaciones { get; set; }
        //
        //****METODOS MIEMBROS**************************************************************************************************************
        /// <summary>
        /// Registra un Estudiante en la base de datos;
        /// </summary>
        /// <returns></returns>
        public bool Registrar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("INSERT INTO tblEstudiante (Matricula,Nombre,Apellidos,Cedula,TelefonoMovil,TelefonoCasa,Sexo,Direccion,Correo,TipoEstudiante,IdCentroEducativo,IdCarrera,FechaNacimiento,EstadoCivil,Observaciones) ");
            sql.AppendFormat("VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9},{10},{11},'{12}','{13}','{14}');", this.Matricula, this.Nombre, this.Apellidos, this.Cedula, this.TelefonoMovil, this.TelefonoCasa, this.Sexo, this.Direccion, this.Correo, this.TipoEstudiante, this.CentroEducativo, this.Carrera, this.FechaNacimiento.ToShortDateString(), this.EstadoCivil, this.Observaciones);
            return sqlman.insertar(sql.ToString());
        }
        public DataTable ObtenerListado()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append(@"SELECT Id,Nombre,Apellidos FechaNacimiento,Cedula FROM tblEstudiante;");
            return sqlman.ObtenerTabla(sql.ToString());
        }
        /// <summary>
        /// Meetetodo que busca Estudiante mediante filtrado
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public List<Estudiante> buscarPorFiltro(List<Par> liFiltros)
        {
            StringBuilder sql = new StringBuilder();
            List<Estudiante> listEstudiantes = new List<Estudiante>();
            if (liFiltros.Count > 0)
            {
                sql.Append("SELECT DISTINCT Id,Matricula,Nombre,Apellidos,Cedula FROM tblEstudiante WHERE 1 < 0 ");
                foreach (Par item in liFiltros)
                {
                    sql.Append("OR ");
                    sql.AppendFormat("{0} LIKE '%{1}%' ", item.Primero, item.Segundo);
                }
            }
            SqlMan sqlman = new SqlMan();
            if (sqlman.cargarReader(sql.ToString()))
            {
                while (sqlman.reader.HasRows)
                {
                    while (sqlman.reader.Read())
                    {
                        Estudiante est = new Estudiante();
                        est.Id = Convert.ToInt32(sqlman.reader["Id"].ToString());
                        est.Matricula = Convert.ToInt64(sqlman.reader["Matricula"].ToString());
                        est.Nombre = sqlman.reader["Nombre"].ToString();
                        est.Apellidos = sqlman.reader["Apellidos"].ToString();
                        est.Cedula = sqlman.reader["Cedula"].ToString();
                        listEstudiantes.Add(est);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return listEstudiantes;
        }
        /// <summary>
        /// Buscar estudiante por Id
        /// </summary>
        /// <returns></returns>
        public bool buscarDatosPorId(Utiles.DbOptionSelect option)
        {
            bool r = false;
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            if (this.Id != 0)
            {
                if (option == Utiles.DbOptionSelect.Todo)
                {
                    sql.AppendFormat("SELECT Id,Matricula,Nombre,Apellidos,Cedula,TelefonoMovil,TelefonoCasa,Sexo,Direccion,Correo,TipoEstudiante,Balance,IdCentroEducativo,IdCarrera,FechaNacimiento,EstadoCivil,Observaciones FROM tblEstudiante WHERE Id = {0} AND Activo = 1; ", this.Id);
                }
                else if (option == Utiles.DbOptionSelect.Basico)
                {
                    sql.AppendFormat("SELECT SELECT Id,Matricula,Nombre,Apellidos,Cedula FROM tblUsuario WHERE Id = {0} AND Activo = 1", this.Id);
                }

            }
            else r = false;
            if (!string.IsNullOrEmpty(sql.ToString()))
            {
                if (sqlman.cargarReader(sql.ToString()))
                {

                    if (sqlman.reader.Read())
                    {
                        this.Id = Convert.ToInt16(sqlman.reader["Id"].ToString());
                        this.Matricula = Convert.ToInt16(sqlman.reader["Matricula"].ToString());
                        this.Nombre = sqlman.reader["Nombre"].ToString();
                        this.Apellidos = sqlman.reader["Apellidos"].ToString();
                        this.Cedula = sqlman.reader["Cedula"].ToString();


                        if (option == Utiles.DbOptionSelect.Todo)
                        {
                            this.TelefonoCasa = sqlman.reader["TelefonoCasa"].ToString();
                            this.TelefonoMovil = sqlman.reader["TelefonoMovil"].ToString();
                            this.Correo = sqlman.reader["Correo"].ToString();
                            this.Sexo = sqlman.reader["Sexo"].ToString();
                            this.Direccion = sqlman.reader["Direccion"].ToString();
                            this.TipoEstudiante = Convert.ToInt16(sqlman.reader["TipoEstudiante"].ToString());
                            this.CentroEducativo = Convert.ToInt16(sqlman.reader["IdCentroEducativo"].ToString());
                            this.Carrera = Convert.ToInt16(sqlman.reader["IdCarrera"].ToString());
                            this.FechaNacimiento = Convert.ToDateTime(sqlman.reader["FechaNacimiento"].ToString());
                            this.EstadoCivil = sqlman.reader["EstadoCivil"].ToString();
                            this.Observaciones = sqlman.reader["Observaciones"].ToString();
                        }
                    }
                    r = true;
                }
            }
            sqlman.reader.Close();
            return r;
        }
        /// <summary>
        /// Actualiza los datos del estudiante en la base de datos basados en el Id
        /// </summary>
        /// <returns></returns>
        public bool Actualizar()
        {
            if (!string.IsNullOrEmpty(this.Nombre) && this.CentroEducativo != 0 && this.Carrera != 0)
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                sql.AppendFormat("UPDATE tblEstudiante SET Nombre = '{0}',Apellidos = '{1}',Cedula = '{2}',TelefonoMovil = '{3}',TelefonoCasa = '{4}',Sexo = '{5}',Direccion ='{6}',Correo = '{7}',TipoEstudiante = {8},IdCentroEducativo = {9},IdCarrera = {10},FechaNacimiento = '{11}',EstadoCivil = '{12}',Observaciones = '{13}' WHERE Id = {14}", this.Nombre, this.Apellidos, this.Cedula, this.TelefonoMovil, this.TelefonoCasa, this.Sexo, this.Direccion, this.Correo, this.TipoEstudiante, this.CentroEducativo, this.Carrera, this.FechaNacimiento.ToShortDateString(), this.EstadoCivil, this.Observaciones, this.Id);
                return sqlman.actualizar(sql.ToString());
            }
            else return false;

        }
        //**********************************************************************************************************************************
    }
    

}
