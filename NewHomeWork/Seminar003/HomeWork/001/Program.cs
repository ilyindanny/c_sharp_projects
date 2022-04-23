//
/*

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/


using System;

using static System.Console;


// first way

Console.WriteLine("input 5 digit number");
string aNum = Console.ReadLine() ?? "0";

if (aNum[0] == aNum[4])
{
	if (aNum[1] == aNum[3])
		Console.WriteLine("yes");
}
else
{
	Console.WriteLine("not");
}


// second way

string result01 = (aNum[0] == aNum[4] && aNum[1] == aNum[3]) ? "yes" : "not";

Console.WriteLine(result01);


// 3th

WriteLine((Polidrom(NewArray(ReadLine() ?? "0"))));

string Polidrom(int[] array)
{
	string result02 = "поли... что-то там";
	for (int index = 0; index < array.Length / 2; index++)
	{
		if (array[index] != array[array.Length - 1 - index])
		{
			result02 = "не пойми что там";
			break;
		}
	}
	return result02;
}


// метод для создания массива на основе строки из консоли

int[] NewArray(string line)
{
	int[] array = new int[line.Length];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = Convert.ToInt32(line[i].ToString());
	}
	return array;
}