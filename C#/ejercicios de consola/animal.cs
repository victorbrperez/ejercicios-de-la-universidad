//©Victor Manuel - hdbowser@gmail.com.

using System;
using MisClases;

namespace Clase_Animal
{
	public class Program
	{
		static void Main()
		{
			Animal Perro = new Animal();
			Perro.Matar();
			Console.Write("Especie del animal: ");
			Perro.Establecer_Especie(Console.ReadLine());
			Console.Write("Tipo de animal: ");
			Perro.Establecer_Tipo(Console.ReadLine());
			Console.WriteLine("-------------------------------------------------------");
			Console.ReadKey();
		}
	}
}