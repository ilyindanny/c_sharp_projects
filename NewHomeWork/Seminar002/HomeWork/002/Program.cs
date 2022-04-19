/*

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/



using System;
using static System.Console;






// if you wanna find out the third digit from tne beginning.

string result04 = Console.ReadLine() ?? "0";


int length = result04.Length;

if (length < 3) Console.WriteLine("there isn't the third digit");
else
{
	Console.WriteLine(result04[2]);
}



// Alternative exercise. if you wanna find out the third digit from tne end.


string result004 = Console.ReadLine() ?? "0";

int length01 = result004.Length;

if (length01 < 3) Console.WriteLine("it isn't the third digit number");
else
{
	Console.WriteLine(result004[length01 - 3]);
}
