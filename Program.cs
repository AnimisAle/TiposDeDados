using System;
using System.Globalization;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			bool n99 = false;
			bool n100 = true;
			byte n1 = 126;
			int n2 = 1000;
			int n3 = 2147483647;
			long n4 = 2147483648L;
			char genero1 = 'M';
			char genero2 = 'F';
			float n5 = 4.5F;
			double n6 = 4.5;
			string nome = "Lucas Lindo";
			// O tipo string é imutável.
			object nome2 = "Lucas gostoso";
			object obj = 4.6f;

			Console.WriteLine(n99);
			Console.WriteLine(n100);
			Console.WriteLine(n1);
			Console.WriteLine(n2);
			Console.WriteLine(n3);
			Console.WriteLine(n4);
			Console.WriteLine(n5);
			Console.WriteLine(n6);
			Console.WriteLine(genero1);
			Console.WriteLine(genero2);
			System.Console.WriteLine(nome);
			System.Console.WriteLine(nome2);
			System.Console.WriteLine(obj);

			int valorMinimo = int.MinValue;
			System.Console.WriteLine(valorMinimo);

			int valorMaximo = int.MaxValue;
			System.Console.WriteLine(valorMaximo);

			decimal valorMaximoDecimal = decimal.MaxValue;
			System.Console.WriteLine(valorMaximoDecimal);

			double virgula = 454544554.545454;
			System.Console.WriteLine(virgula.ToString("F2"));

			System.Console.WriteLine(virgula.ToString("F4", CultureInfo.InvariantCulture));
			//imprimir com o . no lugar da vírgula   	
		}

	}
}
