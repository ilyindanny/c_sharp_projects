using System;

using static System.Console;

public class Program
{
	static public void Main()
	{

		/*

		Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
		b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
		*/


		double k1 = 5;
		double b1 = 2;
		double k2 = 9;
		double b2 = 4;

		double x = (b2 - b1) / (k1 - k2);
		double y = k1 * x + b1;

		WriteLine($"{x}, {y}");

	}
}
