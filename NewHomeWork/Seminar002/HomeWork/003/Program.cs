/*

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

*/



using System;
using static System.Console;



// the first way


int result05 = Convert.ToInt32(Console.ReadLine());

if (result05 == 6 | result05 == 7)
{
	Console.WriteLine("yes");
}
else
{
	Console.WriteLine("not");
}



// the second way


int result06 = Convert.ToInt32(Console.ReadLine());

string answer01;

if (result06 == 6 | result06 == 7)
{
	answer01 = "yes";
}
else
{
	answer01 = "not";
}

Console.WriteLine(answer01);



// the third way


int result07 = Convert.ToInt32(Console.ReadLine());

string answer02 = (result07 == 6) ? "yes" : (result07 == 7) ? "yes" : "not";

Console.WriteLine(answer02);