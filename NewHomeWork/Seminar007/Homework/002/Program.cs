using System;

using static System.Console;

public class Program
{
	static public void Main()
	{

		/*
		Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
		Например, задан массив:
		1 4 7 2
		5 9 2 3
		8 4 2 4
		17 -> такого числа в массиве нет
		*/



		int findByRows = int.Parse(ReadLine());
		int findByColumns = int.Parse(ReadLine());

		int[,] array = GetArray(5, 5);

		FindArray(array, findByRows, findByColumns);



		int[,] GetArray(int rows, int columns)
		{
			int[,] array = new int[rows, columns];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					array[i, j] = new Random().Next(10);
				}
			}
			return array;
		}


		void FindArray(int[,] array, int indexOfRows, int indexOfColumns)
		{

			if (indexOfRows >= 0 && indexOfRows < array.GetLength(0) &&
				indexOfColumns >= 0 && indexOfColumns < array.GetLength(1))
			{
				Write(array[indexOfRows, indexOfColumns]);
			}
			else
			{
				Write("такого числа в массиве нет");
			}
		}

	}
}
