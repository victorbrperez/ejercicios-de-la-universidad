//Convierte de decimal a Hexadecimal y Binario
//©Victor Manuel - hdbowser@gmail.com
using System;

namespace Uso_de_ToString
{
	public class Program
	{
		static void Main()
		{
			int valor;
			Console.WriteLine("******Convierte de decimal a Hexadecimal y Binario******");
			Console.Write("Introduzca un decimal entero: ");
			valor = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Numero en Hexadecimal: " + Convert.ToString(valor,16));
			Console.Write("Numero en Binario: " + Convert.ToString(valor,2));
			Console.ReadKey();
		}
	}
}

