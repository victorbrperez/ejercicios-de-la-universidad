//Programa que analiza cual fue la mejor calificacion.
//©Victor Manuel - hdbowser@gmail.com

using System;

public class Program
{
	public struct Alumno
	{
		public string nombre;
		public string matricula;
		public float calificacion;
	}
	static void Main()
	{
		Alumno[] misAlumnos = new Alumno[3];
		Alumno mejorAlumno = new Alumno();
		mejorAlumno.calificacion = 0;
		for(short i = 0; i < 3; i++)
		{
			Console.Write("Nombre del Alumno {0}:",i + 1);
			misAlumnos[i].nombre = Console.ReadLine();
			Console.Write("Matricula del Alumno {0}:",i + 1);
			misAlumnos[i].matricula = Console.ReadLine();
			Console.Write("Calificacion del Alumno {0}:",i + 1);
			misAlumnos[i].calificacion = float.Parse(Console.ReadLine());
		}
		
		for(short i = 0;i < 3; i++)
		{
			if(misAlumnos[i].calificacion >s mejorAlumno.calificacion)
			{
				mejorAlumno.nombre = misAlumnos[i].nombre;
				mejorAlumno.matricula = misAlumnos[i].matricula;
				mejorAlumno.calificacion = misAlumnos[i].calificacion;
			}
		}
		Console.WriteLine("---------------------------------------------------");
		Console.WriteLine("Alumno con mejor calificacion: ");
		Console.WriteLine("Nombre:{0} ",mejorAlumno.nombre);
		Console.WriteLine("Matricula: {0}",mejorAlumno.matricula);
		Console.WriteLine("Calificacion: {0}",mejorAlumno.calificacion);
		Console.ReadKey();
	}
}