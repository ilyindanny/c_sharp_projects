/*
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0]

*/

using System;
using static System.Console;

int num = Convert.ToInt32(ReadLine());
int[] array = new int[num];
Fillarray(array);
int count0 = Count(array);
int count1 = array.Length - count0;


WriteLine($"{count0} - количество нулей; {count1} - количество единиц; {array.Length} - общее количество");



int Count(int[] array)
{
	int count0 = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] == 0)
		{
			count0 += 1;
		}
	}
	return count0;
}


WriteLine(String.Join(" ", array));

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Write($"{array[i]} ");
	}
}



void Fillarray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(0, 2);
	}
}