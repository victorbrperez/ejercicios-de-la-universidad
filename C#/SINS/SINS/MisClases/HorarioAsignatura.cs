using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class HorarioAsignatura
    {
        public int IdAsignatura { get; set; }
        public int DiaHorario { get; set; }
        public string HoraInicioHorario { get; set; }
        public string HoraFinHorairo { get; set; }
        public int AulaHorario { get; set; }
        public int CentroHorario { get; set; }
        //
        //******METODOS MIEMBROS********************************************************************************************************
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool Registrar()
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("INSERT INTO tblSeccion (IdAsignatura,DiaHorario,HoraInicioHorario,HoraFinHorario,AulaHorario,CentroHorario) ");
            sql.AppendFormat("VALUES ({0},{1},'{2}','{3}',{4},{5});",this.IdAsignatura.ToString(),this.DiaHorario.ToString(),this.HoraInicioHorario,this.HoraFinHorairo,this.AulaHorario.ToString(),this.CentroHorario.ToString());
            return sqlman.insertar(sql.ToString());
        }
    }
}
