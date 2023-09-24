//Saber la si el procesador es de 32 o de 64 bits
//©Victor Manuel - hdbowser@gmail.com
using System;
public class Program
{
	static void Main()
	{
		Console.Write("Mi procesador tiene una arquitectura de {0} bits.",IntPtr.Size * 8);
		Console.ReadKey();
	}
}