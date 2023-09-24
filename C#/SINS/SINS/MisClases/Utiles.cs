using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

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
        public enum Permisos
        {
            Padres,
            Hijos
        }
        public enum DbOptionSelect
        {
            Todo,
            Basico,
            PorSeccion,
            PorVarios,
            SeccionProfesor,
            Seccion,
            ExcluirAsignatura
        }
        public enum OpcionBusqueda
        {
            Busqueda,
            BusquedaYEnvio,
            Condicional,
            Normal
        }
        public enum Meridiano
        {
            AM,
            PM
        }
        public enum DiasDeSemana
        {
            Dominto,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Vernes,
            Sabado
        }
        public enum Verificacion
        {
            Omitir,
            Verificar
        }
        public static string obtenerConexionString()
        {
            return ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        }
        public static string obtenerDia(int dia)
        {
            string[] Dias = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
            if (dia > 0 && dia <= 7)
            {
                dia--;
                return Dias[dia];
            }
            else
                return "";
        }
        public static int obtenerDia(string v_dia)
        {
            int dia = 0;
            string[] Dias = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
            for (int i = 0; i < Dias.Length; i++)
            {
                if (Dias[i] == v_dia)
                {
                    dia = i + 1;
                    break;
                }
            }
            return dia;
        }
        /// <summary>
        /// Identifica si dos horarios colisionan
        /// </summary>
        /// <param name="h2"></param>
        /// <returns></returns>
        public static bool hayConflictos(Horario v_h1, Horario v_h2)
        {
            bool r = false;
            Horario h1;
            Horario h2;
            h1 = v_h1;
            h2 = v_h2;
            //
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
                h1.HoraInicio.Reset();
                h1.HoraFin.Reset();
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
                h2.HoraInicio.Reset();
                h2.HoraFin.Reset();
            }
            return r;
        }
        /// <summary>
        /// Borra todos los horarios de la base de datos que tengan la seccion indicada
        /// </summary>
        /// <returns></returns>
        public static ParError BorarHorarios(int id_seccion)
        {
            ParError r = new ParError();
            r.Error = false;
            ParError error = new ParError();
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.AppendFormat("DELETE FROM tblHorario_Seccion WHERE IdSeccion = {0}", id_seccion);
            //
            if (sqlman.Borrar(sql.ToString()))
            {
                r.Error = false;
                r.Mensaje = "Registro de horarios borrados satisfactoriamente";
            }
            else
            {
                r.Error = true;
                r.Mensaje = "No se ha podido borrar el registro de horario";
            }
            return r;
        }
        public static ParError BorrarInscripcion(int id_estudiante)
        {
            ParError r = new ParError();
            r.Error = false;
            ParError error = new ParError();
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.AppendFormat("DELETE FROM tblDetalleInscripcion WHERE IdInscripcion IN (SELECT IdInscripcion FROM tblInscripcionActiva WHERE IdEstudiante = {0})", id_estudiante);
            //
            if (sqlman.Borrar(sql.ToString()))
            {
                r.Error = false;
                r.Mensaje = "Registro  borrados satisfactoriamente";
            }
            else
            {
                r.Error = true;
                r.Mensaje = "No se ha podido borrar el registro";
            }
            return r;
        }
        public static void SelectAll(this  NumericUpDown numericUpDown)
        {
            numericUpDown.Select(0, numericUpDown.Value.ToString().Length);
        }
    
    }
}
