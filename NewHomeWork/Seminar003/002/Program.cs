/* 

Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

*/

using System;
using static System.Console;

Console.Write("iput x");
int x = Convert.ToInt32(ReadLine() ?? "0");

Console.Write("imput y");
int y = Convert.ToInt32(ReadLine() ?? "0");



if (x == 0 | y == 0)
{
	WriteLine("точка не принадлежит ни одной четверти");
}
if (x < 0 && y > 0)
{
	WriteLine("2");
}
if (x < 0 && y < 0)
{
	WriteLine("3");
}
if (x > 0 && y < 0)
{
	WriteLine("4");
}
if (x > 0 && y > 0)
{
	WriteLine("1");
}
