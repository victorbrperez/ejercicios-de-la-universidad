//Suma de vectores usando clases y llamando la clase desde otro archivo llamado mis_clases.
//©Victor Manuel - hdbowser@gmail.com.
using System;
using MisClases;

namespace SumaVectores
{
	public class Program
	{
		static void Main()
		{
			Vector vectorA  = new Vector();
			Vector vectorB = new Vector();
			Vector vectorR = new Vector();
			
			Console.Write("Valor de X para vector A: ");
			vectorA.x = int.Parse(Console.ReadLine());
			Console.Write("Valor de Y para vector A: ");
			vectorA.y = int.Parse(Console.ReadLine());
			Console.WriteLine("");
			Console.Write("Valor de X para vector B: ");
			vectorB.x = int.Parse(Console.ReadLine());
			Console.Write("Valor de Y para vector B: ");
			vectorB.y = int.Parse(Console.ReadLine());
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine("Vector A = ({0},{1})",vectorA.x,vectorA.y);
			Console.WriteLine("Vector B = ({0},{1})",vectorB.x,vectorB.y);
			vectorR.x = vectorA.x - vectorB.x;
			vectorR.y = vectorA.y - vectorB.y;
			Console.WriteLine("Vector R = ({0},{1})",vectorR.x,vectorR.y);
			Console.ReadKey();
			
		}
	}
}