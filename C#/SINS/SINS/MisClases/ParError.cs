using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class ParError
    {
        public ParError()
        {
            Error = false;
            Mensaje = string.Empty;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
    }
}
