using System;

using static System.Console;

using System.Linq;

public class Program
{
    static public void Main ()
    {

/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


int m = int.Parse(ReadLine());
int n = int.Parse(ReadLine());

double[,] array = GetArray(m, n);
PrintArray(array);



double[,] GetArray(int rows, int columns)
{
	double[,] array = new double[rows, columns];
	for(int i = 0; i < rows; i++)
	{
		for(int j = 0; j < columns; j++)
		{
			// array[i, j] = Convert.ToDouble(new Random().Next(-99, 100)) / 10;
			
			array[i, j] = new Random().Next(2) == 0 
			? Convert.ToDouble(new Random().Next(-99, 100)) / 10 
			: Convert.ToDouble(new Random().Next(-9, 10));
		}
	}
	return array;
}


void PrintArray(double[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			Write("{0, 5}", array[i, j]);
		}
		WriteLine();
	}
}
    }
}
