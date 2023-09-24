using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SINS.MisClases
{
 
    public static class Utiles
    {
       public enum DbItem
        {
            Actualizar,
            Nuevo,
            Detalle,
        }
        public enum DbOptionSelect
        {
            Todo,
            Basico
        }
        public enum Institucion
        {
            CentroEducativo,
            Aula,
            Carrera,
            Asignatura,
            TipoEstudiante
        }
        public enum OpcionBusqueda
        {
            Busqueda,
            BusquedaYEnvio
        }
        public static string obtenerConexionString()
        {
            return ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        }
    }
}
