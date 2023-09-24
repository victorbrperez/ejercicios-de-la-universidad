//©Victor Manuel - hdbowser@gmail.com.

using System;
using MisClases;

namespace Herencia
{
	public class  VentanaModerna :  Ventana
	{
		public void MostrarEstado()
		{
			Console.WriteLine("Altura: {0}",alto);
			Console.WriteLine("Ancho: {0}",ancho);
			if(cerrada){Console.WriteLine("Ventana cerrada");}
			else {Console.WriteLine("Ventana abierta");}
		}
		
	}
	
	public class Program
	{
		static void Main()
		{
			VentanaModerna miVentana = new VentanaModerna();
			char opcion;
			Console.Write("Desea abrir la ventana S/N: ");
			opcion = Convert.ToChar(Console.ReadLine());
			if (opcion == 's'){miVentana.Abrir();}
			Console.WriteLine("------------------------------------------------------------");
			miVentana.MostrarEstado();
			Console.ReadKey();
			
		}
	}
}