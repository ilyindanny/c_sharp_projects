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

		FillArray(array);
		PrintArray(array);



void FillArray(int[,] array)
{
			int x = 0;
			int y = 0;
			int count = 1;
			int n = 0;


			while (count <= array.Length)
	{


switch (n)
		{
			case 0:
				{
					while (array[x, y] == 0)
				{
					array[x, y] = count++;
					if (y + 1 < array.GetLength(1) && array[x, (y + 1)] == 0) y++;
				}
				x++;
				n = 1;
				break;
				}
			case 1:
				{
					while (array[x, y] == 0)
				{
					array[x, y] = count++;
					if (x + 1 < array.GetLength(0) && array[x + 1, y] == 0) x++;
				}
				y = y - 1;
				n = 2;
				break;
				}
			case 2:
				{
					while (array[x, y] == 0)
				{
					array[x, y] = count++;
					if (y - 1 >= 0 && array[x, y - 1] == 0) y = y - 1;
				}
				x = x - 1;
				n = 3;
				break;
				}
			case 3:
				{
					while (array[x, y] == 0)
				{
					array[x, y] = count++;
					if (x - 1 >= 0 && array[x - 1, y] == 0) x = x - 1;
				}
				y++;
				n = 0;
				break;
				}
			
		}
	}
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