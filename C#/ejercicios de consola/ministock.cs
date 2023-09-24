//Mini stock virtual.
//©Victor Manuel - hdbowser@gmail.com.
using System;
public class Program
{
	static void Main()
	{
		double precio = 0;
		double total = 0;
		ushort articulos = 0;
		Console.WriteLine("***************** SUMADORA MINI STACK *****************");
		do
		{
			Console.Write("Precio articulo:=>",++articulos);
			precio = Convert.ToDouble(Console.ReadLine());
			total += precio;
		}while (precio != 0);
		Console.WriteLine("Total de articulos:=> {0}",articulos - 1);
		Console.Write("Total a pagar:=>" + total.ToString("0.00"));
		Console.ReadKey();
	}
}