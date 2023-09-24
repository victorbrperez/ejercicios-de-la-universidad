using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class HorarioSeccion
    {
        public int IdSeccion{ get; set; }
        private int Dia { get; set; }
        private int IdAula { get; set; }
        private int IdCentro { get; set; }

        public List<Horario> obtenerHorariosPor(Utiles.DbOptionSelect sql_op)
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            List<Horario> LiHorarios = new List<Horario>();
            //
            if (this.IdSeccion > 0)
            {
                if (sql_op == Utiles.DbOptionSelect.PorSeccion)
                {
                    sql.AppendFormat("SELECT Dia,HoraInicio,HoraFin,IdSeccion,IdAula,IdCentro FROM tblHorario_Seccion WHERE IdSeccion = {0}", this.IdSeccion);
                }

                else if (sql_op == Utiles.DbOptionSelect.PorVarios)
                {
                    if (this.Dia > 0 && this.IdAula > 0 && this.IdCentro > 0)
                    {
                        sql.AppendFormat("SELECT Dia,HoraInicio,HoraFin,IdSeccion,IdAula,IdCentro FROM tblHorario_Seccion WHERE IdCentro = {0} AND IdAula = {1} AND Dia = {2}", this.IdCentro, this.IdAula, this.Dia);
                    }
                }
                
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        while (sqlman.reader.Read())
                        {
                            Horario h = new Horario(new Reloj(sqlman.reader["HoraInicio"].ToString()), new Reloj(sqlman.reader["HoraFin"].ToString()));
                            h.Dia = Convert.ToInt32(sqlman.reader["Dia"].ToString());
                            h.IdAula = Convert.ToInt32(sqlman.reader["IdAula"].ToString());
                            h.IdCentro = Convert.ToInt32(sqlman.reader["IdCentro"].ToString());
                            h.IdSeccion = Convert.ToInt32(sqlman.reader["IdSeccion"].ToString());
                            LiHorarios.Add(h);
                        }
                        sqlman.reader.NextResult();
                    }
                    sqlman.reader.Close();
                }
            }
            return LiHorarios;
        }
    }
}
