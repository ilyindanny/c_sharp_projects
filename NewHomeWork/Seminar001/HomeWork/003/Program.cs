/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

using System;
using static System.Console;

WriteLine("input some number:");
int N = Convert.ToInt32(ReadLine() ?? "0");

if (N % 2 == 0)
{
	WriteLine("it's clear number");
}
else
{
	WriteLine("This is not clear number");
}