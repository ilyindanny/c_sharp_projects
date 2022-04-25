//
/*
**Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да
*/

// foreach

using System;
using static System.Console;


int[] size = 33
int num = 5327;

int[] FillArray(int size)
{
	int[] array = new int[size];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(1, 10);
	}
}
WriteLine(FindNum(array, num) ? "yes" : "no");


bool FindNum(int[] array, int num)
{
	foreach (int el in array)
	{
		if (el == num)
		{
			return true;
		}
	}
	return false;
}


