//
/*
**Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21
*/

using System;
using static System.Console;

public class Program
{
    static public void Main ()
	{
	



int[] array = { 1, 3, 3, 9, 4, 6};

WriteLine(String.Join(" ",MultiArray(array)));

int[] MultiArray(int[] array)
{
	int[] arr = new int[array.Length / 2];

	for (int i = 0; i < array.Length / 2; i++)
	{
		arr[i] = array[i] * array[array.Length - i - 1];
		
	}
	if (array.Length % 2 == 1) WriteLine(array[array.Length / 2]);
	return arr;
}


	}
}