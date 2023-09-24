/*Un programa que almacene en una tabla el número de días que tiene cada mes (supondremos que es un año no bisiesto), 
pida al usuario que le indique un mes (1=enero,12=diciembre) y muestre en pantalla el número de días que tiene ese mes*/

//©Victor Manuel - hdbowser@gmail.com

using System;

public class Program
{
	static void Main()
	{
		int mes;
		int[] meses = {31,28,31,30,31,30,31,31,30,31,30,31};
		Console.Write("Escriba el numero del mes: ");
		mes = Int32.Parse(Console.ReadLine());
		Console.Write("Este mes tiene {0} dias",meses[mes - 1]);
		Console.ReadKey();
	}
}