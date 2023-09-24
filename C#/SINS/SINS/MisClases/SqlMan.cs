using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SINS.MisClases
{
    public class SqlMan
    {
        public SqlMan()
        {
            cnn = new SqlConnection(@"Data Source=HDBOWSER\SQLEXPRESS;Initial Catalog=SINS;User ID=sa;Password=mdav4000");
            cmd = new SqlCommand("", cnn);
        }
        public SqlConnection cnn { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataReader reader { get; set; }
        public SqlDataAdapter adapter;
        /// <summary>
        /// Ejecuta el Querry de INSERT
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool insertar(string sql)
        {
            bool r = false;
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = CommandType.Text;
                if (cmd.ExecuteNonQuery() > 0)
                    r = true;
            }
            catch (SqlException)
            {
                r = false;
            }
            finally
            {
                cnn.Close();
            }
            return r;
        }
        /// <summary>
        /// Inicializa el Reader para cargar los datos
        /// </summary>
        /// <returns></returns>
        public bool cargarReader(string sql)
        {
            bool r = false;
            try
            {
                cnn.Open();
                cmd.CommandText = sql.ToString();
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    r = true;
                }
            }
            catch (Exception)
            {
                r = false;
            }
            return r;
        }
        public bool actualizar(string sql)
        {
            bool r = false;
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = sql.ToString();
                cmd.CommandType = CommandType.Text;
                if (cmd.ExecuteNonQuery() > 0)
                    r = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return r;
        }
        public DataTable ObtenerTabla(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                cnn.Open();
                cmd.CommandText = sql.ToString();
                cmd.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dt;
        }
        /// <summary>
        /// Ejecuta el Querry de DELETE
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool Borrar(string sql)
        {
            bool r = false;
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = CommandType.Text;
                if (cmd.ExecuteNonQuery() > 0)
                    r = true;
            }
            catch (SqlException)
            {
                r = false;
            }
            finally
            {
                cnn.Close();
            }
            return r;
        }
        public void cerrar()
        {
            cnn.Close();
        }
    }
}
