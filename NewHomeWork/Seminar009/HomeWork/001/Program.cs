/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа по убыванию в промежутке от M до N.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 5, 4"
*/

using System;
using static System.Console;
public class Program
{
	static public void Main()
	{

		WriteLine("Enter start number");
		int m = Int32.Parse(ReadLine());
		WriteLine("Enter final number");
		int n = Int32.Parse(ReadLine());

		string result = GetClearNumbers(m, n);
		WriteLine("[{0}]", result);

		string GetClearNumbers(int starting, int final)
		{
			string a = final.ToString();
			if (final == starting) return a;
			return a += ", " + GetClearNumbers(starting, final - 1);
		}

	}
}
