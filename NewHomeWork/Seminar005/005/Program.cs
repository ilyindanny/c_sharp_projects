// 
/*

**Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2] -> 0

[10, 11, 12, 13, 14] -> 5

*/

using System;
using static System.Console;
using System.Linq;


var array = new int[12].Select(x => new Random().Next(0, 1000)).ToArray();
var count = 0;


foreach (var el in array)
{
	if (el > 10 && el < 99) count++;
}
WriteLine(count);
WriteLine(String.Join(" ", array));