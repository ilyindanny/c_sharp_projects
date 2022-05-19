using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

int[,] array = new int[4, 4];

PrintArray(array);

Fil(array);

PrintArray(array);

FillArray(array);

PrintArray(array);

void FillArray(int[,] array)
{
	int n = 0;
	int x = 0;
	int y = 0;
	int count = 14;
	int lengthRows = array.GetLength(0);
	int lengthColumns = array.GetLength(1);
	int length = array.GetLength(0) * array.GetLength(1);
	
	while(count < length)
	{
	if (n == 0)
	{
		while(array[x, y] == -1)
		{
			array[x, y] = count++;
			if (array[x, y + 1] == -1) y++;
		}
		x++;
		n = 1;
	}
	
	else if (n == 1)
	{
		while(array[x, y] == -1)
		{
			array[x, y] = count++;
			if (array[x + 1, y] == -1) x++;
		}
		y = y - 1;
		n = 2;
	}
	
	else if (n == 2)
	{	
		while(array[x, y] == -1)
		{
			array[x, y] = count++;
			if (array[x, y - 1] == -1) y = y - 1;
		}
		x = x - 1;
		n = 3;
	}
	
	else if (n == 3)
	{
		while(array[x, y] == -1)
		{
			array[x, y] = count++;
			if (array[x - 1, y] == -1) x = x - 1;
		}
		y++;
		n = 0;
	}
	
	}
}



void Fil(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				array[i, j] = -1;
			}
		}
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
