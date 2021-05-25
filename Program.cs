using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		/*Определить наибольший элемент каждого столбца матрицы*/
		static void Main(string[] args)
		{
			int n, m, i, j, max;

			Console.WriteLine("Введите количество строк в массиве");
			n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите количество столбцов в массиве");
			m = Convert.ToInt32(Console.ReadLine());
			Random rand = new Random();
			int[,] arr = new int[n, m];
			for (i = 0; i < n; i++)
			{
				Console.WriteLine("");
				for (j = 0; j < m; j++)
				{
					arr[i, j] = rand.Next(-15, 15);
					Console.Write(arr[i, j] + " ");
				}
			}
			Console.WriteLine(" ");
		
			for (j = 0; j < m; j++)
			{
				max = arr[0, j];
				for (i = 0; i < n; i++)
				{
					if (max < arr[i, j])
					{
						max = arr[i, j];
					}
				}
				Console.WriteLine("Максимальный элемент каждого столбца=" + max);
			}

			Console.ReadKey();






	}
}


