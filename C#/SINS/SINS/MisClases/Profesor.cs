using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class Profesor
    {
        //
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string TelefonoMovil { get; set; }
        public string TelefonoCasa { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Observaciones { get; set; }
        //
        //****METODOS MIEMBROS**************************************************************************************************************
        /// <summary>
        /// Registra un profesor en la base de datos;
        /// </summary>
        /// <returns></returns>
        public bool Registrar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("INSERT INTO tblProfesor (Nombre,Apellidos,Cedula,TelefonoMovil,TelefonoCasa,Sexo,Direccion,Correo,FechaNacimiento,EstadoCivil,Observaciones) ");
            sql.AppendFormat("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}');", this.Nombre, this.Apellidos, this.Cedula, this.TelefonoMovil, this.TelefonoCasa, this.Sexo, this.Direccion, this.Correo, this.FechaNacimiento.ToShortDateString(), this.EstadoCivil, this.Observaciones);
            return sqlman.insertar(sql.ToString());
        }
        /// <summary>
        /// Meetetodo que busca profesores mediante filtrado
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public List<Profesor> buscarPorFiltro(List<Par> liFiltros)
        {
            StringBuilder sql = new StringBuilder();
            List<Profesor> listProfesores = new List<Profesor>();
            if (liFiltros.Count > 0)
            {
                sql.Append("SELECT DISTINCT Id,Nombre,Apellidos,Cedula FROM tblProfesor WHERE 1 < 0 ");
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
                        Profesor prof = new Profesor();
                        prof.Id = Convert.ToInt32(sqlman.reader["Id"].ToString());
                        prof.Nombre = sqlman.reader["Nombre"].ToString();
                        prof.Apellidos = sqlman.reader["Apellidos"].ToString();
                        prof.Cedula = sqlman.reader["Cedula"].ToString();
                        listProfesores.Add(prof);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return listProfesores;
        }
        /// <summary>
        /// Buscar profesor por Id
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
                    sql.AppendFormat("SELECT Nombre,Apellidos,Cedula,TelefonoMovil,TelefonoCasa,Sexo,Direccion,Correo,FechaNacimiento,EstadoCivil,Observaciones FROM tblProfesor WHERE Id = {0} AND Activo = 1; ", this.Id);
                }
                else if (option == Utiles.DbOptionSelect.Basico)
                {
                    sql.AppendFormat("SELECT Nombre,Apellidos,Cedula FROM tblProfesor WHERE Id = {0} AND Activo = 1", this.Id);
                }

            }
            else r = false;
            if (!string.IsNullOrEmpty(sql.ToString()))
            {
                if (sqlman.cargarReader(sql.ToString()))
                {

                    if (sqlman.reader.Read())
                    {
                        this.Nombre = sqlman.reader["Nombre"].ToString();
                        this.Apellidos = sqlman.reader["Apellidos"].ToString();
                        this.Cedula = sqlman.reader["Cedula"].ToString();
                        //
                        if (option == Utiles.DbOptionSelect.Todo)
                        {
                            this.TelefonoCasa = sqlman.reader["TelefonoCasa"].ToString();
                            this.TelefonoMovil = sqlman.reader["TelefonoMovil"].ToString();
                            this.Correo = sqlman.reader["Correo"].ToString();
                            this.Sexo = sqlman.reader["Sexo"].ToString();
                            this.Direccion = sqlman.reader["Direccion"].ToString();
                            this.FechaNacimiento = Convert.ToDateTime(sqlman.reader["FechaNacimiento"].ToString());
                            this.EstadoCivil = sqlman.reader["EstadoCivil"].ToString();
                            this.Observaciones = sqlman.reader["Observaciones"].ToString();
                        }
                    }
                    r = true;
                    sqlman.reader.Close();
                }
                
            }
            
            return r;
        }
        /// <summary>
        /// Actualiza los datos del profesor en la base de datos basados en el Id
        /// </summary>
        /// <returns></returns>
        public bool Actualizar()
        {
            if (!string.IsNullOrEmpty(this.Nombre) && !string.IsNullOrEmpty(this.Cedula))
            {
                StringBuilder sql = new StringBuilder();
                SqlMan sqlman = new SqlMan();
                sql.AppendFormat("UPDATE tblProfesor SET Nombre = '{0}',Apellidos = '{1}',Cedula = '{2}',TelefonoMovil = '{3}',TelefonoCasa = '{4}',Sexo = '{5}',Direccion ='{6}',Correo = '{7}',FechaNacimiento = '{8}',EstadoCivil = '{9}',Observaciones = '{10}' WHERE Id = {11}", this.Nombre, this.Apellidos, this.Cedula, this.TelefonoMovil, this.TelefonoCasa, this.Sexo, this.Direccion, this.Correo,this.FechaNacimiento.ToShortDateString(), this.EstadoCivil, this.Observaciones, this.Id);
                return sqlman.actualizar(sql.ToString());
            }
            else return false;

        }
    }
}
