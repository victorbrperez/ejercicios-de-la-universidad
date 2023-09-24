using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class Pago
    {
        public Pago()
        {
            Id = 0;
            Activo = true;
            Fecha = DateTime.Now;
        
        }
        public int Id { get; set; }
        public int IdEstudiante { get; set; }
        public DateTime Fecha { get; set; }
        public double CantidadPagada { get; set; }
        public string Observaciones { get; set; }
        public bool Activo { get; set; }
        //
        //******METODOS MIEMBROS********************************************************************************************************
        /// <summary>
        /// Meetetodo que registra el pago en la base de datos
        /// </summary>
        /// <param name="liFiltros"></param>
        /// <returns></returns>
        public bool Registrar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("INSERT INTO tblPago (IdEstudiante,Fecha,CantidadPagada,Observaciones)  ");
            sql.AppendFormat("VALUES ({0},'{1}',{2},'{3}');",this.IdEstudiante,this.Fecha.ToShortDateString(),this.CantidadPagada.ToString(),this.Observaciones );
            return sqlman.insertar(sql.ToString());
        }
    }
}
