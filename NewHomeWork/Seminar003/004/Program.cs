/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.

2 -> 1,4

*/


using System;
using static System.Console;


double N = Convert.ToDouble(ReadLine() ?? "0");

double index = 1;
double result = 1;

while (index < N)
{
	result = Math.Pow(index, 2);
	WriteLine(result);
	index += 1;
}