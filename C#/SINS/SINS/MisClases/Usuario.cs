using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre_usuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public int Tipo_usuario { get; set; }
        public string Permisos { get; set; }
        public bool Activo { get; set; }

        public Usuario()
        {
            Id = 0;
            Activo = true;
        }
        /// <summary>
        /// Registra un Usuario en la base de datos;
        /// </summary>
        /// <returns></returns>
        public bool Registrar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("INSERT INTO tblUsuario(Usuario,Password,Nombre,Apellidos,Telefono,Tipo_usuario,Permisos) ");
            sql.AppendFormat("VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}')", this.Nombre_usuario, this.Password, this.Nombre, this.Apellidos, this.Telefono, this.Tipo_usuario.ToString(),this.Permisos);
            return sqlman.insertar(sql.ToString());
        }
        /// <summary>
        /// Meetetodo que busca usuarios mediante filtrado
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public List<Usuario> buscarPorFiltro(List<Par> liFiltros)
        {
            StringBuilder sql = new StringBuilder();
            List<Usuario> listUsuario = new List<Usuario>();
            if (liFiltros.Count > 0)
            {
                sql.Append("SELECT DISTINCT Id,Usuario,Nombre,Apellidos FROM tblUsuario WHERE 1 < 0 ");
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
                        Usuario u = new Usuario();
                        u.Id = Convert.ToInt32(sqlman.reader["Id"].ToString());
                        u.Nombre_usuario = sqlman.reader["Usuario"].ToString();
                        u.Nombre = sqlman.reader["Nombre"].ToString();
                        u.Apellidos = sqlman.reader["Apellidos"].ToString();
                        listUsuario.Add(u);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return listUsuario;
        }
        /// <summary>
        /// Buscar usuario por Id
        /// </summary>
        /// <returns></returns>
        public bool buscarDatos(Utiles.DbOptionSelect option)
        {
            bool r = false;
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            if (this.Id != 0)
            {
                if (option == Utiles.DbOptionSelect.Todo)
                {
                    sql.AppendFormat("SELECT Id,Usuario,Password,Nombre,Apellidos,Telefono,Permisos,Tipo_usuario FROM tblUsuario WHERE Id = {0} AND Activo = 1", this.Id);
                }
                else if (option == Utiles.DbOptionSelect.Basico)
                {
                    sql.AppendFormat("SELECT Id,Usuario,Password,Nombre,Apellidos, Permisos FROM tblUsuario WHERE Id = {0} AND Activo = 1", this.Id);
                }
                
            }
            else if (!string.IsNullOrEmpty(this.Nombre_usuario))
            {
                if (option == Utiles.DbOptionSelect.Todo)
                {
                    sql.AppendFormat("SELECT Id,Usuario,Password,Nombre,Apellidos,Telefono,Permisos,Tipo_usuario FROM tblUsuario WHERE Usuario = '{0}' AND Activo = 1", this.Nombre_usuario);
                }
                else if (option == Utiles.DbOptionSelect.Basico)
                {
                    sql.AppendFormat("SELECT Id,Usuario,Password,Nombre,Apellidos,Permisos FROM tblUsuario WHERE Usuario = '{0}' AND Activo = 1", this.Nombre_usuario);
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
                        this.Nombre_usuario = sqlman.reader["Usuario"].ToString();
                        this.Nombre = sqlman.reader["Nombre"].ToString();                     
                        this.Password = sqlman.reader["Password"].ToString();
                        this.Apellidos = sqlman.reader["Apellidos"].ToString();
                        this.Permisos = sqlman.reader["Permisos"].ToString();

                        if (option == Utiles.DbOptionSelect.Todo)
                        {
                            this.Tipo_usuario = Convert.ToInt16(sqlman.reader["Tipo_usuario"].ToString());
                            this.Telefono = sqlman.reader["Telefono"].ToString();
                        }
                    }
                    r = true;
                }
            }
            sqlman.reader.Close();
            return r;
        }
        public bool Actualizar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.AppendFormat("UPDATE tblUsuario SET Usuario = '{0}',Password = '{1}',Nombre = '{2}',Apellidos = '{3}',Telefono = '{4}',Tipo_usuario = {5}, Permisos = '{6}'WHERE Id = {7}",this.Nombre_usuario,this.Password,this.Nombre,this.Apellidos,this.Telefono,this.Tipo_usuario,this.Permisos,this.Id);
            return sqlman.actualizar(sql.ToString());

        }
    }
}
