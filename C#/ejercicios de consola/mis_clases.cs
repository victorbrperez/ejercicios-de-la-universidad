//©Victor Manuel - hdbowser@gmail.com.
using System;

namespace MisClases
{
	//----------------------------------------------------------------------------------------
	public class Vector
	{
		public Vector(){}
		public int x;
		public int y;
	}
	//----------------------------------------------------------------------------------------
	public class Animal
	{
		public Animal(){}
		
		private bool vivo = true;
		private string especie;
		private string tipo;
		private string raza;
		
		public void Establecer_Especie(string valor)
		{
			if(vivo)
			{
				especie =  valor;
			}
			else {Console.WriteLine("No se puede, el animal esta muerto");}
		}
		public void Establecer_Tipo(string valor)
		{
			if(vivo)
			{
				tipo = valor;
			}
			else {Console.WriteLine("No se puede, el animal esta muerto");}
		}
		public void Establecer_Raza(string valor)
		{
			if(vivo)
			{
				raza = valor;
			}
			else {Console.WriteLine("No se puede, el animal esta muerto");}
		}
		public void Matar()
		{
			if(vivo)
			{
				vivo = false;
			}
			else {Console.WriteLine("No se puede, el animal esta muerto");}
		}
	}
}