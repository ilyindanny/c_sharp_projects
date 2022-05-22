using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {



void ShuffleArray(int[,] array)
{
	int x;
	int y;
	int temp;

	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			x = new Random().Next(0, array.GetLength(0) - 1);
			y = new Random().Next(0, array.GetLength(1) - 1);
			temp = array[i, j];
			array[i, j] = array[x, y];
			array[x, y] = temp;
		}
	}
}













    }
}
