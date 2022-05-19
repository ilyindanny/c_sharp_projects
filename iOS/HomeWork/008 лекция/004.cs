using System;
using static System.Console;
using System.Linq;
public class Program
{
    static public void Main ()
    {

// найти в массиве наименьшее число и удалить его столбец и строку (наименьшее, видимо, первое попавшееся)


int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
WriteLine();

int[] coord = FindMin(array);

PrintArray1(coord);

WriteLine();

PrintArray(DeleteRowAndColumn(array, coord));



int[,] DeleteRowAndColumn(int[,] array, int[] coord)
{
	int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
	int k = 0;
	int l = 0;

	for(int i = 0; i < array.GetLength(0); i++)
	{
		if(i != coord[0])
		{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			if(j != coord[1])
			{
				newArray[k, l] = array[i, j];
				l++;
			}
		}
		l = 0;
		k++;
		}	
	}
	return newArray;
}




int[] FindMin(int[,] array)
{
	int[] coord = {0, 0};
	int min = array[coord[0], coord[1]];
	
	for(int i = 0; i < array.GetLength(0) - 1; i++)
	{
		for(int j = 0; j < array.GetLength(1) - 1; j++)
		{
			if(array[i, j] < min)
			{
				coord[0] = i;
				coord[1] = j;
				min = array[coord[0], coord[1]];
			}
		}
	}
	return coord;
}







	/// <Summary>
	/// Создание массива от мин до макс
	///</Summary>
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


	/// <Summary>
	/// Печать двумерного массива
	///</Summary>
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


	/// <Summary>
	/// Печать одномерного массива
	///</Summary>
	 void PrintArray1(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			Write("{0, 5}", array[i] + " ");
		}
	}


    }
}
