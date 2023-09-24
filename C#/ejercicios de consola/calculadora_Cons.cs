//Calculadora basica en Consola.
//©Victor Manuel - hdbowser@gmail.com
using System;
namespace Calculadora
{
	public class Program
	{
		static void Main()
		{
			double valor1;
			double valor2;
			char operador;
			char fin;
			Console.WriteLine("**************** CALCULADORA ****************");
			Console.Write("\n");
			do
			{
				Console.Write("Valor 1: ");
				valor1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Valor 2: ");
				valor2 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Operador? [s = suma | r = resta | m = multiplicacion | d division]: ");
				operador = Convert.ToChar(Console.ReadLine());
				switch(operador)
				{
					case 's':
							Console.WriteLine("Resultado: {0}",valor1 + valor2);
							break;
					case 'r':
							Console.WriteLine("Resultado: {0}",valor1 - valor2);
							break;
					case 'm':
							Console.WriteLine("Resultado: {0}",valor1 * valor2);
							break;
					case 'd':
							Console.WriteLine("Resultado: {0}",valor1 / valor2);
							break;
					default:
							Console.WriteLine("Oprador no valido");
							break;
				}	
				Console.Write("Nueva operacion? [S/N]:");
				fin = Convert.ToChar(Console.ReadLine());
			}while(fin != 'n');
		}
	}
}