//
/*******************************************
Найти элементы массива, у которых оба индекса четные
Изменить каждый такой элемент на его квадрат

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
		array = MyMethods.ChangeArray(array);
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
	/// изменение элемента массива на его квадрат, если оба индекса четные
	/// </Summary>
	public static int[,] ChangeArray(int[,] array)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				array[i, j] = i != 0 && i % 2 == 0 && j % 2 == 0 ? array[i, j] * array[i, j] : array[i, j];
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
