//
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

using System;
using static System.Console;
public class Program
{
	static public void Main()
	{
		int[,] array1 = GetArray(5, 5, 1, 10);
		int[,] array2 = GetArray(5, 5, 1, 10);

		PrintArray(array1);
		WriteLine();
		PrintArray(array2);
		WriteLine();

		PrintArray(ProductArrays(array1, array2));


		int[,] ProductArrays(int[,] array1, int[,] array2)
		{
			int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];
			for (int i = 0; i < array1.GetLength(0); i++)
			{
				for (int j = 0; j < array1.GetLength(1); j++)
				{
					newArray[i, j] = array1[i, j] * array2[i, j];
				}
			}
			return newArray;
		}


		int[,] GetArray(int rows, int columns, int min, int max)
		{
			int[,] array = new int[rows, columns];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					array[i, j] = new Random().Next(min, max);
				}
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
