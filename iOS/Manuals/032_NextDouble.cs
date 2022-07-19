using System;
using static System.Console;
public class Program
{
    static public void Main()
    {


        double[,] CreateMatrx()
        {
            double[,] matrix = new double[5, 10];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round((new Random().Next(-9, 10) + new Random().NextDouble()), 2);
                }
            }
            return matrix;
        }

        void PrintMatrx(double[,] matrix)
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

        PrintMatrx(CreateMatrx());

    }
}