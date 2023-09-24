using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class Reloj
    {
        public Reloj()
        {
            hora = 0;
            minutos = 0;
        }
        ushort hora;
        ushort minutos;
        ushort hora_bkp;
        ushort minutos_pkp;
        //
        public Reloj(ushort v_hora, ushort v_minutos)
        {
            if (v_hora < 24 && v_hora >= 0)
            {
                hora = v_hora;
            }
            else if (v_minutos == 24)
            {
                hora = 0;
            }
            if (v_minutos > 0 && v_minutos < 60)
            {
                minutos = v_minutos;
            }
            //
            hora_bkp = hora;
            minutos_pkp = minutos;
        }
        public Reloj(string v_hora_str)
        {
            ushort h;
            ushort m;
            string[] arr_char = new string[2];
            //
            if (!string.IsNullOrEmpty(v_hora_str))
            {
                arr_char = v_hora_str.Split(':');
                try
                {
                    h = Convert.ToUInt16(arr_char[0]);
                    m = Convert.ToUInt16(arr_char[1]);
                    //
                    if (h < 24 && h >= 0)
                    {
                        hora = h;
                    }
                    else if (m == 24)
                    {
                        hora = 0;
                    }
                    if (m >= 0 && m < 60)
                    {
                        minutos = m;
                    }
                }
                catch (Exception)
                {
                    hora = 0;
                    minutos = 0;
                    throw;
                }
            }
            //
            hora_bkp = hora;
            minutos_pkp = minutos;
        }
        public ushort Hora
        {
            get { return hora; }
        }
        public ushort Minutos
        {
            get { return minutos; }
        }
        public void Reset()
        {
            minutos = minutos_pkp;
            hora = hora_bkp;
        }
        /// <summary>
        /// Incrementa los minutos y suma horas cuando los minutos llegan a 59
        /// </summary>
        public void incrementarMinutos()
        {
            if (minutos == 59)
            {
                hora++;
                minutos = 0;
            }
            else
            {
                minutos++;
            }
        }
        /// <summary>
        /// Devuelve la hora en formato de cadena (24 horas)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return hora.ToString() + ":" + minutos.ToString();
        }
        //
        public string toAmPm()
        {
            if (hora > 12)
            {
                return ((hora - 12).ToString()).PadLeft(2,'0') + ":" + minutos.ToString().PadLeft(2, '0') + " PM";
            }
            else if (hora == 0)
            {
                return "12" + ":" + minutos.ToString().PadLeft(2, '0') + " AM";
            }
            else if (hora == 12)
            {
                return hora.ToString().PadLeft(2, '0') + ":" + hora.ToString().PadLeft(2, '0') + " M";
            }
            else
                return hora.ToString() .PadLeft(2,'0')+ ":" + minutos.ToString().PadLeft(2, '0') + " AM";
        }

    }
}
