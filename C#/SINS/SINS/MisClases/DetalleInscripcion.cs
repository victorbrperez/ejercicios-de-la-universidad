using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class DetalleInscripcion
    {
        public int IdSeccion { get; set; }
        public int IdInscripcion { get; set; }
        //
        public ParError Registrar()
        {
            ParError log = new ParError();
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            //
            sql.AppendFormat("INSERT INTO tblDetalleInscripcion(IdSeccion,IdInscripcion) VALUES({0},{1})", this.IdSeccion.ToString(), this.IdInscripcion.ToString());
            //
            if (sqlman.insertar(sql.ToString()))
            {
                log.Error = false;
                log.Mensaje = "Se ha insertado el registro satisfactoriamente";
            }
            else
            {
                log.Error = false;
                log.Mensaje = "No she ha podido insertar el registro";
            }
            return log;
        }
    }
}
