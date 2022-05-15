using System;

using static System.Console;

using System.Linq;

public class Program
{
    static public void Main ()
    {
// // написать метод, создающий двумерный массив и заполняющий его случайными числами

int[,] array = GetDoubleArray(5, 5);
WriteLine(array[2,2]);


int[,] GetDoubleArray(int x, int y)
{
	int[,] array = new int[x, y];
	for (int i = 0; i < x -1; i++)
	{
		for (int j = 0; j < y -1; j++)
		{
			array[i, j] = new Random().Next(10);
		}
	}
	return array;
}


int[,] GetDoubleArray02(int x, int y)
{
	int[,] array = new int[x, y].Select(x => new Random().Next(10)).Select(y => new Random().Next(10)).ToArray();
	return array;
}






    }
}
