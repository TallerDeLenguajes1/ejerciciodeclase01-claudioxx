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
				try
				{
					respuesta = Convert.ToInt32(Console.ReadLine());
					if (respuesta < num)
						Console.WriteLine("El numero " + respuesta + " es menor al numero aleatorio.\n");
					else if (respuesta > num)
						Console.WriteLine("El numero " + respuesta + " es mayor al numero aleatorio.\n");
				}
				catch (Exception ex)
				{
					Console.WriteLine("Valor fuera de rango.\n");
					respuesta = -1;
					Console.WriteLine(ex.GetHashCode());
				}
				
					
			} while (respuesta != num);

			Console.WriteLine("El numero " + respuesta + " es el correcto :D.");
		}
	}
}
