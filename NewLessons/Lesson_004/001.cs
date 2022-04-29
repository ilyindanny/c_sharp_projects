using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {

// двумерные массивы

//строки и столбцы нумеруются с нуля:

//  0,0   0,1   0,2
//  1,0   1,1   0,2
//  2,0   2,1   2,2

string[,] table = new string[5, 5];

int[,] matrix = new int[5, 5];

// так задается вручную:

int[,] matrixPlus = new int[,]
{
	{0,0,0},
	{0,0,0},
	{0,0,0}
};

// точно так же можно присвоить значение:

table [1, 2] = "W";

// количество строк возвращает метод GetLength(0):
int rows = matrix.GetLength(0);

// количество столбцов возвращает метод GetLength(1):
int columns = matrix.GetLength(1);

// распечатать при помощи метода (будет вложенный цикл):

PrintMatrix(matrix);




void PrintArray(string[,] matrix)
{
	for (int i = 0; i < 5; i++)
	{
		for (int i2 = 0; i2 < 5; i2++)
		{
			Write(matrix[i, i2] + ".");
		}
		WriteLine("");
	}
}



void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Write(matrix[i, j] + " ");
		}
		WriteLine("");
	}
}






    }
}
