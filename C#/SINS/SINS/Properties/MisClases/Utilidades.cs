using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SINS.MisClases
{
    public static class Utilidades
    {
        public static string encriptar(string text)
        {
            return CryptorEngine.ComputeHash(text,"sha512",null);
        }
    }
}
