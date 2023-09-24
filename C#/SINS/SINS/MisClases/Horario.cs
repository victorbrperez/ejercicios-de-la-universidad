using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SINS.MisClases;
using System.Windows.Forms;

namespace SINS.MisClases
{
    public class Horario
    {
        public Horario(Reloj ri, Reloj rf)
        {
            HoraInicio = ri;
            HoraFin = rf;
            IdSeccion = 0;
        }
        public Horario(string h1, string h2)
        {
            HoraInicio = new Reloj(h1);
            HoraFin = new Reloj(h2);
            IdSeccion = 0;
        }
        public int Dia { get; set; }
        public Reloj HoraInicio;
        public Reloj HoraFin;
        public int IdAula { get; set; }
        public int IdCentro { get; set; }
        public int IdSeccion { get; set; }
        //
        //*********METODOS MIEMBRO***********************************************************************************************
        /// <summary>
        /// Identifica si dos horarios colisionan
        /// </summary>
        /// <param name="h2"></param>
        /// <returns></returns>
        public bool hayConflictos(Horario h2)
        {
            bool r = false;
            //
            ushort h = this.HoraInicio.Hora;
            ushort m = this.HoraInicio.Minutos;
            //
            Reloj r1 = new Reloj(h,m);
            h = this.HoraFin.Hora;
            m = this.HoraFin.Minutos;
            Reloj r2 = new Reloj(h,m);
            //
            Horario h1 = new Horario(r1,r2);
            if (h1 != null && h2 != null)
            {
                while (h1.HoraInicio.ToString() != h1.HoraFin.ToString())
                {
                    h1.HoraInicio.incrementarMinutos();
                    if (h1.HoraInicio.Hora == h2.HoraInicio.Hora && h1.HoraInicio.Minutos == h2.HoraInicio.Minutos)
                    {
                        r = true;
                    }
                    else if (h1.HoraInicio.Hora == h2.HoraFin.Hora && h1.HoraInicio.Minutos == h2.HoraFin.Minutos)
                    {
                        r = true;
                    }
                }
                //
                h1 = new Horario(r1,r2);
                while (h2.HoraInicio.ToString() != h2.HoraFin.ToString())
                {
                    h2.HoraInicio.incrementarMinutos();
                    if (h2.HoraInicio.Hora == h1.HoraInicio.Hora && h2.HoraInicio.Minutos == h1.HoraInicio.Minutos)
                    {
                        r = true;
                    }
                    else if (h2.HoraInicio.Hora == h1.HoraFin.Hora && h2.HoraInicio.Minutos == h1.HoraFin.Minutos)
                    {
                        r = true;
                    }
                }
            }
            return r;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql_op"></param>
        /// <returns></returns>
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
                    sql.AppendFormat("SELECT Id,Dia,HoraInicio,HoraFin,IdAula,IdSeccion,IdCentro FROM tblHorario_Seccion WHERE IdSeccion = {0}", this.IdSeccion);
                }

                else if (sql_op == Utiles.DbOptionSelect.PorVarios)
                {
                    if (this.Dia > 0 && this.IdAula > 0 && this.IdCentro > 0)
                    {
                        sql.AppendFormat("SELECT Id,Dia,HoraInicio,HoraFin,IdSeccion,IdAula,IdCentro FROM tblHorario_Seccion WHERE IdCentro = {0} AND IdAula = {1} AND Dia = {2} AND NOT IdSeccion = {3}", this.IdCentro, this.IdAula, this.Dia,this.IdSeccion);
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql_op"></param>
        /// <returns></returns>
        public List<Horario> obtenerPorDiaProfesor(int id_profesor)
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            List<Horario> LiHorarios = new List<Horario>();
            //
            if (id_profesor > 0 && Dia > 0)
            {
                sql.AppendFormat("SELECT Dia,HoraInicio,HoraFin,IdAula,IdSeccion,IdCentro FROM tblHorario_Seccion WHERE IdSeccion IN (SELECT Id from tblSeccion WHERE IdProfesor = {0}) AND Dia = {1} AND NOT IdSeccion = {2}", id_profesor, this.Dia,this.IdSeccion);    
                //
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
        /// <summary>
        /// Registra el horario relacionado a la seccion en la base de datos
        /// </summary>
        /// <returns></returns>
        public ParError Registrar()
        {
            ParError error = new ParError();
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            //
            sql.Append("INSERT INTO tblHorario_Seccion (IdSeccion,Dia,HoraInicio,HoraFin,IdAula,IdCentro) ");
            sql.AppendFormat("VALUES ({0},{1},'{2}','{3}',{4},{5});", this.IdSeccion.ToString(), this.Dia.ToString(), this.HoraInicio, this.HoraFin, this.IdAula.ToString(), this.IdCentro.ToString());
            //
            if (sqlman.insertar(sql.ToString()))
            {
                error.Error = false;
                error.Mensaje = "Se ha insertado el registro satisfactoriamente";
            }
            else
            {
                error.Error = true;
                error.Mensaje = "Error al insertar registro en la base de datos";
            }
            //
            return error;
        }
    }
}
