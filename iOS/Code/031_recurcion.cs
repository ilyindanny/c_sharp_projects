using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {



double[,] CreateMatr()
{
	double[,] matrix = new double[ 5, 10];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix [i, j] = new Random ().Next (-10, 10);
		}
	}
	return matrix;
}

void PrintMatr(double[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write("{0, 3} ", matrix[i, j]);
		}
		Console.WriteLine();
	}
}

PrintMatr(CreateMatr());


    }
}
