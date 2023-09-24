//Suma dos vectores en el plano.
//©Victor Manuel - hdbowser@gmail.com

using System;

public class Program
{
	static void Main()
	{
		double[] vector_a  = new double[2];
		double[] vector_b  = new double[2];
		double[] vector_r = new double[2];
		Console.Write("Introduzca valor de X vector A: ");
	    vector_a[0] = double.Parse(Console.ReadLine());
		Console.Write("Introduzca valor de Y vector A: ");
	    vector_a[1] = double.Parse(Console.ReadLine());
		Console.Write("\n");
		Console.Write("Introduzca valor de X vector B: ");
	    vector_b[0] = double.Parse(Console.ReadLine());
		Console.Write("Introduzca valor de Y vector B: ");
	    vector_b[1] = double.Parse(Console.ReadLine());
		
		Console.WriteLine("---------------------------------------------------------");
		Console.WriteLine("Vector A = ({0},{1})",vector_a[0],vector_a[1]);
		Console.WriteLine("Vector B = ({0},{1})",vector_b[0],vector_b[1]);
		vector_r[0] = vector_a[0] - vector_b[0];
		vector_r[1] = vector_a[1] - vector_b[1];
		Console.Write("Vector R = ({0},{1})",vector_r[0],vector_r[1]);
		Console.ReadKey();
	}
}