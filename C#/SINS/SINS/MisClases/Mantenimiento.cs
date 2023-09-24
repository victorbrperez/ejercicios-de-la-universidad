using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
namespace SINS.MisClases
{
    class Mantenimiento
    {
        public Mantenimiento()
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
            cmd = new SqlCommand("", cnn); ;
        }
        SqlConnection cnn;
        SqlCommand cmd;

//=========MANTENIMIENTOS DE TIPO_USUARIO===================================================================================================
        public List<TipoUsuario> traerTiposUsuarios()
        {
            List<TipoUsuario> listaUsuarios = new List<TipoUsuario>();
            TipoUsuario miTipoUsuario = new TipoUsuario();
            StringBuilder sql = new StringBuilder();
            SqlDataReader reader;
            sql.Append("SELECT Id,Titulo,Activo FROM tblTipoUsuario");
            try
            {
                cnn.Open();
                cmd.CommandText = sql.ToString();
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        miTipoUsuario.Id = int.Parse(reader["Id"].ToString());
                        miTipoUsuario.Titulo = reader["Titulo"].ToString();
                        miTipoUsuario.Activo = Convert.ToBoolean(reader["Activo"].ToString());
                        reader.NextResult();
                        listaUsuarios.Add(miTipoUsuario);
                    }
                }

            }
            catch (Exception) {; }
            finally
            {
                cnn.Close();
            }
            return listaUsuarios;
        }
    }
}
