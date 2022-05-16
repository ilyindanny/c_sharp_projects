using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

int[,] array = GetArray(5, 5);

FindAverage(array);
WriteLine();
PrintArray(array);



int[,] GetArray(int rows, int columns)
{
	int[,] array = new int[rows, columns];
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
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
			sum += array[i, j];
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
