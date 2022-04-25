//
/*
**Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21
*/

using System;
using static System.Console;




int[] array = { 1, 3, 4 };

Multi(array);

void Multi(int[] array)
{
	int mult = 1;

	for (int index = 0; index < array.Length / 2; index++)
	{
		mult = array[index] * array[array.Length - index - 1];
		WriteLine(mult);
	}
	if (array.Length % 2 == 1) WriteLine(array[array.Length / 2]);
}
