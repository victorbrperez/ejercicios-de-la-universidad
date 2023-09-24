using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class Par
    {
        public Par(string valor1, string valor2)
        {
            Primero = valor1;
            Segundo = valor2;
        }
        public string Primero { get; set; }
        public string Segundo { get; set; }
    }
}
