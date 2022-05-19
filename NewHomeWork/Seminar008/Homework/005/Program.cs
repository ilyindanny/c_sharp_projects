//
/*
Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

using System;
using static System.Console;
public class Program
{
	static public void Main()
	{
		int[,] array = new int[4, 4];

		PrintArray(array);
		WriteLine();
		PrintArray(FillArray(array));


		int[,] FillArray(int[,] array)
		{
			int n = array.GetLength(0);
			int m = array.GetLength(1);

			int rows = 0;
			int columns = 0;
			int dx = 1;
			int dy = 0;
			int dirChanges = 0;
			int visits = m;

			for (int i = 0; i < array.Length; i++)
			{
				array[rows, columns] = i + 1;
				if (--visits == 0)
				{
					visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
					int temp = dx;
					dx = -dy;
					dy = temp;
					dirChanges++;
				}
				columns += dx;
				rows += dy;
			}
			return array;
		}


		void PrintArray(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					Write("{0, 5}", array[i, j] + " ");
				}
				WriteLine();
			}
		}
	}
}