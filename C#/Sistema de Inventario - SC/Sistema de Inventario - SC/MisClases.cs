using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;//Librerias necesarias para la conexion con MySql.

namespace MisClases
{
    //
    //=====CLASE CONFIGURACIONSQL========================================================================================================================================================
    //
    public class ConfigurarcionSQL
    //Esta clase construye un objeto que obtiene los datos de configuracion para gestionar la base de datos MySql desde un archivo XML.
    {
        public ConfigurarcionSQL() {}//Constructor.

        public string Server { get; set; }
        public string Port { get; set; }
        public string UserId { get; set; }
        public string Database { get; set; }
        public string Password { get; set; }

        public void LeerXmlConf()
        {
            DataSet configuracionDS = new DataSet();
            string archivoXml = "MySqlConf.xml";
            try
            {
                configuracionDS.ReadXml(archivoXml);
                Server = configuracionDS.Tables["parametros"].Rows[0]["server"].ToString();
                Port = configuracionDS.Tables["parametros"].Rows[0]["port"].ToString();
                UserId = configuracionDS.Tables["parametros"].Rows[0]["userid"].ToString();
                Database = configuracionDS.Tables["parametros"].Rows[0]["database"].ToString();
                Password = configuracionDS.Tables["parametros"].Rows[0]["password"].ToString();
            }
            catch
            {
                MessageBox.Show("El archivo " + archivoXml + " no se ha encontrado o no es valido", "Error en archivo de configuración");
                Application.Exit();
            }
        }

        public string GetConexionStr()
        //Metodo que devuelve una cadena con los parametros de conexion a la Base de Datos. 
        {
            LeerXmlConf();
            string conexionStr = "Server=" +Server + "; Port= " +Port + "; User id= " +UserId + "; Database= " +Database + "; Password= " +Password + "";
            return conexionStr;
        }
    }
    //
    // =====CLASE USUARIO=================================================================================================================================================================
    //
    public class Usuario
    //Clase que define la entidad USUARIO (tambien contiene los metodos para gestionar la Base de Datos)
    {
        public Usuario(){}//Constructor.

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public bool Administrador { get; set; }
        public string Password { get; set; }
        public bool EstaRegistrado { get; set; }
        //Atributos de la entidad Usuario
        //
        string tabla = "usuarios"; //Contiene el nombre de la tabla que almacena los usuarios
        //
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Existen() 
        //Metodo que verifica si hay usuarios registrados
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "select * from " + tabla + "";
            bool hayFilas = false;
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                MySqlDataReader myDataReader = myCmd.ExecuteReader();

                if (myDataReader.HasRows) { hayFilas = true; }
                else { hayFilas = false; }
            }
            catch (MySqlException errSelect) { MessageBox.Show(errSelect.Message); }
            finally { myConexion.Close();}
            return hayFilas;
        }
        //
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Registrar() //Metodo - REGISTRAR.
        //Metodo que registra un usuario nuevo en la base de datos
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            int es_administrador;
            if (Administrador) es_administrador = 1;
            else es_administrador = 0;
            bool operacion_correcta = false;
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "insert into " + tabla + "(id,nombre,telefono, administrador,password) values(" + Id + ",'" + Nombre + "','" + Telefono + "'," + es_administrador + ",'" + Password + "')";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }
            catch (MySqlException myError) 
            {
                MessageBox.Show(myError.Message, "MySql Error");
                operacion_correcta = false;
            }
            finally { myConexion.Close(); }
            return operacion_correcta;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //
        public DataSet Buscar(string opcion) //Metodo - BUSCAR.
        //Metodo que devuelve un DataSet con los datos del o los  usuarios y establece si el usuario buscado existe o no.
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            DataSet UsuarioDs = new DataSet();
            string cmdString;

            if (opcion == "uno") cmdString = "select * from " + tabla + " where Id=" + Id + "";
            else cmdString = "select * from " + tabla + "";
            //Dependiendo de los parametros del constructor va a guardar uno o varios usuarios en el DataSet

            try
            {
                myConexion.Open();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(cmdString, myConexion);
                myDataAdapter.Fill(UsuarioDs, tabla);
                myConexion.Close();
                //
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                MySqlDataReader myDataReader = myCmd.ExecuteReader();

                if (myDataReader.Read())
                {
                    EstaRegistrado = true;
                }
                else
                {
                    EstaRegistrado = false;
                }
            }
            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return UsuarioDs;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Actualizar()
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            bool operacion_correcta = false;
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "update "+tabla+" set nombre = '"+Nombre+"', password = '"+Password+"', telefono = '"+Telefono+"' where id = "+Id+"";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }
            catch
            {
                operacion_correcta = false;
            }
            finally
            {
                myConexion.Close();
            }

            return operacion_correcta;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Eliminar()
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            bool operacion_correcta = false;
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "delete from "+tabla+" where id = "+Id+"";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }
            catch
            {
                operacion_correcta = false;
            }
            finally
            {
                myConexion.Close();
            }
            return operacion_correcta;
        }
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //
    }
    //
    // =====CLASE PRODUCTO=================================================================================================================================================================
    //
    public class Producto
    {
        public Producto() { }
        //
        public int Codigo { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public double MGP { get; set; }
        public double MGM { get; set; }
        public double Costo { get; set; }
        public double Itbis { get; set; }
        public string Ubicacion { get; set; }
        public int MinimoExistencia { get; set; }
        public DateTime Fecha { get; set; }
        public string Nota { get; set; }
        //
        string tabla = "productos"; //Contiene el nombre de la tabla que almacena los usuarios
        //
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Registrar()
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            bool operacion_correcta = false;
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "insert into " + tabla + "(codigo,referencia,descripcion,unidad,marca,cantidad,mgp,mgm,costo,itbis,ubicacion,minimo_existencia,fecha,nota) " +
                "values(" + Codigo + ",'" + Referencia + "','" + Descripcion + "','" + Unidad + "','" + Marca + "'," + Cantidad + "," + MGP + "," + MGM + "," + Costo + "," + Itbis + ",'" + Ubicacion + "'," + MinimoExistencia + ",'" + Fecha.Date.ToShortDateString() + "','" + Nota + "')";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }

            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return operacion_correcta;
        }
        //
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //
        public DataSet Buscar(string opcion) //Metodo - BUSCAR.
        //Metodo que devuelve un DataSet con los datos del o los  usuarios y establece si el usuario buscado existe o no.
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            DataSet productosDs = new DataSet();
            string cmdString;

            switch (opcion)
            { 
                case "uno" :
                    cmdString = "select * from " + tabla + " where codigo = " + Codigo + "";
                    break;
                case "mayor": cmdString = "select if(max(codigo) is null,0,max(codigo)) as codigo from "+tabla+"";
                    break;
                
                case "act_inv":
                    cmdString = "select codigo,referencia,descripcion,marca,cantidad,unidad from " + tabla + " where codigo = " + Codigo + "";
                    break;
                default: cmdString = "select * from " + tabla + "";
                    break;
            }
            //Dependiendo de los parametros del constructor va a guardar uno o varios elementos en el DataSet
            //
            try
            {
                myConexion.Open();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(cmdString, myConexion);
                myDataAdapter.Fill(productosDs, tabla);
                myConexion.Close();
            }
            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }

            return productosDs;
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Actualizar(string operacion)
        {
            bool operacion_correcta = false;
            ConfigurarcionSQL myConf = new ConfigurarcionSQL();
            MySqlConnection myConexion = new MySqlConnection(myConf.GetConexionStr());
            string cmdString = "";
            try
            {
                switch (operacion)
                { 

                    case "compras" :
                        cmdString = "update " + tabla + " set cantidad = " + Cantidad + ", costo = "+Costo+", mgp = "+MGP+", mgm = "+MGM+", fecha = '"+Fecha.Date.ToShortDateString()+"' where codigo = " + Codigo + "";
                        break;
                    case "cambios" :
                        cmdString = "update " + tabla + " set referencia = '" + Referencia + "', descripcion = '" + Descripcion + "', unidad = '" + Unidad + "', marca = '" + Marca + "', cantidad = " + Cantidad + ", costo = " + Costo + "," +
                                    " mgp = " + MGP + ", mgm = " + MGM + ", itbis = " + Itbis + ", ubicacion = '" + Ubicacion + "', minimo_existencia = " + MinimoExistencia + ", fecha = '" + Fecha.Date.ToShortDateString() + "', nota = '" + Nota + "' where codigo = " + Codigo + "";
                        break;
                    default : 
                        cmdString = "update " + tabla + " set cantidad = " + Cantidad + " where codigo = " + Codigo + "";
                        break;
                }

                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }
            catch (MySqlException Error)
            {
                MessageBox.Show(Error.Message, "MySQL Error");
                operacion_correcta = false;
            }
            finally { myConexion.Close(); }
            return operacion_correcta;
        }
        //
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Eliminar()
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            bool operacion_correcta = false;
            string cmdString = "delete from "+tabla+" where codigo = "+Codigo+"";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString,myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }
            catch (MySqlException myError) 
            {
                MessageBox.Show(myError.Message, "MySql Error");
                operacion_correcta = false;
            }
            finally { myConexion.Close(); }
            return operacion_correcta;
        }
    }
    //
    //======CLASE UNIDAD========================================================================================================================================================================================================================
    //
    public class Unidad
    {
        public string Nombre{get;set;}
        //
        string tabla = "unidades";
        //
        public DataSet Buscar() //Metodo - BUSCAR.
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            DataSet miDataset = new DataSet();
            string cmdString = "select * from " +tabla+ "";
            //
            try
            {
                myConexion.Open();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(cmdString, myConexion);
                myDataAdapter.Fill(miDataset, tabla);
                myConexion.Close();
            }
            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return miDataset;
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Registrar()
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            bool operacion_correcta = false;
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "insert into " + tabla + "(nombre) values('"+Nombre+"')";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }

            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return operacion_correcta;
        }
        //
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Eliminar()
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            bool operacion_correcta = false;
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "delete from " + tabla + " where nombre = '" + Nombre + "'";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }
            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return operacion_correcta;
        }
    }
    //
    //======CLASE MARCA========================================================================================================================================================================================================================
    //
    public class Marca
    {
        public string Nombre { get; set; }

        string tabla = "marcas";

        public DataSet Buscar() //Metodo - BUSCAR.
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            DataSet miDataset = new DataSet();
            string cmdString = "select * from " + tabla + "";
            //
            try
            {
                myConexion.Open();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(cmdString, myConexion);
                myDataAdapter.Fill(miDataset, tabla);
                myConexion.Close();
            }
            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return miDataset;
        }
        //
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Registrar()
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            bool operacion_correcta = false;
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "insert into " + tabla + "(nombre) values('" + Nombre + "')";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }

            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return operacion_correcta;
        }
        //
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Eliminar()
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            bool operacion_correcta = false;
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "delete from " + tabla +" where nombre = '"+Nombre+"'";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }
            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return operacion_correcta;
        }
    }
    //
    //======CLASE UBICACION========================================================================================================================================================================================================================
    //
    public class Ubicacion
    {
        public string Nombre { get; set; }
        //
        string tabla = "ubicaciones";
        //
        public DataSet Buscar() //Metodo - BUSCAR.
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            DataSet miDataset = new DataSet();
            string cmdString = "select * from " + tabla + "";
            //
            try
            {
                myConexion.Open();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(cmdString, myConexion);
                myDataAdapter.Fill(miDataset, tabla);
                myConexion.Close();
            }
            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return miDataset;
        }
        //
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Registrar()
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            bool operacion_correcta = false;
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "insert into " + tabla + "(nombre) values('" + Nombre + "')";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }

            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return operacion_correcta;
        }
        //
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //
        public bool Eliminar()
        {
            MySqlConnection myConexion = new MySqlConnection();
            ConfigurarcionSQL miConfigSql = new ConfigurarcionSQL();
            bool operacion_correcta = false;
            myConexion.ConnectionString = miConfigSql.GetConexionStr();
            string cmdString = "delete from " + tabla + " where nombre = '" + Nombre + "'";
            try
            {
                myConexion.Open();
                MySqlCommand myCmd = new MySqlCommand(cmdString, myConexion);
                myCmd.ExecuteReader();
                operacion_correcta = true;
            }
            catch (MySqlException myError) { MessageBox.Show(myError.Message, "MySql Error"); }
            finally { myConexion.Close(); }
            return operacion_correcta;
        }
    }
    //
    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
}