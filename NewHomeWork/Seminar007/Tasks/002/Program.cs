//
/*******************************************
Задайте двумерный массив размера m * n
Каждый элемент массива находится по формуле:
Amn = m + n
Выведите полученный массив на экран
********************************************/

using System;
using MyClasses;
using static System.Console;
using System.Linq;
class Program
{
	static void Main()
	{
		int m = int.Parse(ReadLine()!);
		int n = int.Parse(ReadLine()!);

		int[,] array = MyMethods.GetArray(m, n);
		MyMethods.PrintArray(array);
	}
}

public class MyMethods
{
	/// <Summary>
	/// создание двумерного массива
	/// </Summary>
	public static int[,] GetArray(int rows, int columns)
	{
		int[,] array = new int[rows, columns];
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				array[i, j] = i + j;
			}
		}
		return array;
	}

	/// <Summary>
	/// вывод на экран двумерного массива
	/// </Summary>
	public static void PrintArray(int[,] array)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				Write("{0, 4}", array[i, j]);
			}
			WriteLine();
		}
	}
}
