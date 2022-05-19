using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

int[,] array = GetArray(5, 5, 0, 10);

PrintArray(array, SortArray(array));





int[] SortArray(int[,] array)
{
	int[] sum = new int[array.GetLength(0)];
	
	for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				sum[i] += array[i, j];
			}
		}
		return sum;
			
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


void PrintArray(int[,] array, int[] array2)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				Write("{0, 3}", array[i, j]);
			}
			Write(" => sum {0, 3} ", array2[i]);
			WriteLine();
		}
	}
	
    }
}
