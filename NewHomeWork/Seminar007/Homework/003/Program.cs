﻿using System;

using static System.Console;

public class Program
{
	static public void Main()
	{

		/*
		Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
		Например, задан массив:
		1 4 7 2
		5 9 2 3
		8 4 2 4
		Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
		*/

		int[,] array = GetArray(5, 5);

		PrintArray(array);
		WriteLine("Среднее арифметическое каждого столбца:");
		FindAverage(array);


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


		void FindAverage(int[,] array)
		{
			double sum = 0;
			for (int j = 0; j < array.GetLength(1); j++)
			{
				for (int i = 0; i < array.GetLength(0); i++)
				{
					sum += Convert.ToDouble(array[i, j]);
				}
				Write("{0, 5}", sum / array.GetLength(0));
				sum = 0;
			}

		}


		void PrintArray(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					Write("{0, 5}", array[i, j]);
				}
				WriteLine();
			}
		}
	}
}
