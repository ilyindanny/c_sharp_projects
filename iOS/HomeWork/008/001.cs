using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

/*

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

int[,] array = GetArray(5, 5, 1, 10);

SortArray(array);
PrintArray(array);



void SortArray(int[,] array)
{
	int min;
	int temp;

	for (int index = 0; index < array.GetLength(0); index ++)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			min = i;
			for (int j = i + 1; j < array.GetLength(1); j++)
			{
				if (array[index, j] < array[index, min]) min = j;
			}
			temp = array[index, i];
			array[index, i] = array[index, min];
			array[index, min] = temp;
		}
	}
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
