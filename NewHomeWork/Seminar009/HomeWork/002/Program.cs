/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
using static System.Console;
public class Program
{
	static public void Main()
	{

		int m = 1;
		int n = 15;

		WriteLine(GetSum(m, n));

		int GetSum(int starting, int final)
		{
			return starting == final ? starting : starting + (GetSum(starting + 1, final));
		}

	}
}
