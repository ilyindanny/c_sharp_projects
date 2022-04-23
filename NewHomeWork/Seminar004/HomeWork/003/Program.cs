//
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

using System;
using static System.Console;


// 1th

WriteLine("input numbers with space");
WriteLine(String.Join(", ", (ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries))));


// 2th

NewArray();

void NewArray()
{
	int[] array = new int[8];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(1, 100);
	}
	WriteLine(String.Join(", ", array));
}


// 3th

WriteLine("input numbers with space");
string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine(String.Join(", ", array));


// 4th

PrintArray(array);

void PrintArray(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Write($"{array[i]}, ");
	}
}