using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {

int[,] matrix = new int[10, 10];


matrix = DrowSqrt(matrix);

PrintMatrix(FillSpace(matrix));


// метод рисует квадрат внутри матрицы
int[,] DrowSqrt(int[,] matrix)
{
	int x = 1;
	int y = 1;

	for (y = 1; y < 8; y++) matrix[x, y] = 1;
	for (x = 1; x < 8; x++) matrix[x, y] = 1;
	for (y = 8; y > 1; y -= 1) matrix[x, y] = 1;
	for (x = 8; x > 1; x -= 1) matrix[x, y] = 1;

	return matrix;
}


int[,] FillSpace(int[,] matrix)
{
	int x = 2;
	int y = 2;
	
	
	for (int i = 0; i < 100; i++)
	{
	 
	 if (matrix[x, y + 1] == 0)
	 {
	 y +=1;
	 matrix[x, y] = 8;
	 }
	 else
	  {
	    if (matrix[x + 1, y] == 0)
	    {
	    x +=1;
	    matrix[x, y] = 8;
	    }
	    else
	    {
	      if (matrix[x, y - 1] == 0)
	      {
	      y -= 1;
	      matrix[x, y] = 8;
	      }
	      else
	      {
	        if (matrix[x - 1, y] == 0)
		     {
	         x -= 1;
	         matrix[x, y] = 8;
	         }
	       }
	     }
	    }
	   }
	 
	 return matrix;
}



void PrintMatrix(int[,] matrix)
{
	for (int x = 0; x < matrix.GetLength(0); x++)
	{
		for (int y = 0; y < matrix.GetLength(1); y++)
		{
			Write(matrix[x, y] + " ");
		}
		WriteLine("");
	}
}

    }
}


