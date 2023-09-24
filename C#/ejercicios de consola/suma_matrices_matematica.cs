//Programa que suma 2 matrices
//©Victor Manuel - hdbowser@gmail.com

using System;

public class Program
{
	static void Main()
	{
		Console.WriteLine("=======================SUMA DE MATRICES=======================");
		int[,] matriz_a = new int[3,3];
		int[,] matriz_b = new int[3,3];
		short control_fila = 0;
		for(short i = 0;i < matriz_a.GetLength(1);i++)
		{
			for(short j = 0;j < matriz_a.GetLength(0);j++)
			{
				Console.Write("Introduzca valor para ({0},{1}):",i,j);
				matriz_a[i,j] = int.Parse(Console.ReadLine());
				Console.Write(" ");
			}
		}
		Console.WriteLine("\n");	
		for(short i = 0;i < matriz_b.GetLength(1);i++)
		{
			for(short j = 0;j < matriz_b.GetLength(0);j++)
			{
				Console.Write("Introduzca valor para ({0},{1}):",i,j);
				matriz_b[i,j] = int.Parse(Console.ReadLine());
				Console.Write(" ");
			}
		}
		Console.WriteLine("\n");
		Console.WriteLine("\n---------------------------------------------");
		int[,] matriz_r = new int[matriz_a.GetLength(0),matriz_a.GetLength(1)];
		Console.WriteLine("Matriz A: ");
		control_fila = 0;
		for (short i = 0;i < matriz_a.GetLength(1);i++)
		{
			for(short j = 0; j < matriz_a.GetLength(0);j++)
			{
				if(control_fila == matriz_a.GetLength(1))
				{
					Console.Write("\n");
					control_fila = 0;
				}
				Console.Write(" " + matriz_a[i,j]);
				control_fila++;
			}
		}
		Console.WriteLine("");
		Console.WriteLine("Matriz B: ");
		control_fila = 0;
		for (short i = 0;i < matriz_b.GetLength(1);i++)
		{
			for(short j = 0; j < matriz_b.GetLength(0);j++)
			{
				if(control_fila == matriz_b.GetLength(1))
				{
					Console.Write("\n");
					control_fila = 0;
				}
				Console.Write(" " + matriz_b[i,j]);
				control_fila++;
			}
		}
		Console.WriteLine("\n---------------------------------------------");
		Console.WriteLine("Matriz R:");
		control_fila = 0;
		for (short i = 0;i < matriz_r.GetLength(1);i++)
		{
			for(short j = 0; j < matriz_r.GetLength(0);j++)
			{
				matriz_r[i,j] = matriz_a[i,j] + matriz_b[i,j];
				if(control_fila == matriz_b.GetLength(1))
				{
					Console.Write("\n");
					control_fila = 0;
				}
				Console.Write(" " + matriz_r[i,j]);	
				control_fila++;
			}
		}
		Console.ReadKey();
	}
}