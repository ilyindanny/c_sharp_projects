/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 ->  max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


using System;
using static System.Console;

WriteLine("input fiirst digit:");
int FirstD = Convert.ToInt32(ReadLine() ?? "0");
WriteLine("input second digit:");
int SecondD = Convert.ToInt32(ReadLine() ?? "0");

if (FirstD > SecondD)
{
	WriteLine($"{FirstD} > {SecondD}");
}
else
{
	WriteLine($"{FirstD} < {SecondD}");
}