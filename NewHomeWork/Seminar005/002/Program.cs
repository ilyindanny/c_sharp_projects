//
/*
**Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

using System;
using static System.Console;

int[] array = { 12, 52, -632, -52, 532, 52, 631, -14 };
WriteLine(String.Join(" ", array));
WriteLine(String.Join(" ", ChangeArray(array)));

int[] ChangeArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] *= -1;
	}
	return array;
}

