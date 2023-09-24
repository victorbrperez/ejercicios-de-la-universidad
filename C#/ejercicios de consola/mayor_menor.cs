//De una cantidad de numeros introducidos determina cual es el mayor y cual es el menor
//©Victor Manuel - hdbowser@gmail.com

using System;

namespace Mayor_Menor
{
	public class Program
	{
		static void Main()
		{
			int tamano_vector;
			int mayor = 1;
			int menor = 1000;
			Console.Write("Escriba la cantidad de numeros a introducir: ");
			tamano_vector = Int32.Parse(Console.ReadLine());
			int[] vector = new int[tamano_vector];
			for (short i = 0;i < tamano_vector; i++)
			{
				Console.Write("Introduzca valor {0}: ",i);
				vector[i] = Int32.Parse(Console.ReadLine());
				if (vector[i] > mayor)
				{
					mayor = vector[i];
				}
				
				if (vector[i] < menor)
				{
					menor = vector[i];
				}
			}
			Console.WriteLine("El numero de menor tamaño introducido: {0}",menor);
			Console.Write("El numero de mayor tamaño introducido: {0}",mayor);
			Console.ReadKey();
		}
	}
}