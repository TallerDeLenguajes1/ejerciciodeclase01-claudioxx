using System;

namespace AdivinarElNumero
{
	class Program
	{
		static public Random rand = new Random();

		static void Main(string[] args)
		{
			int num = rand.Next(0, 100);
			int respuesta;
			do
			{
				Console.WriteLine("Elija un numero del 1 al 100: ");
				respuesta = Convert.ToInt32(Console.ReadLine());
				if (respuesta < num)
					Console.WriteLine("El numero elegido es menor al numero aleatorio.");
				else if (respuesta > num)
					Console.WriteLine("El numero elegido es mayor al numero aleatorio.");
				else
					Console.WriteLine("El numero es el correcto :D.");
			} while (respuesta != num);
		}
	}
}
