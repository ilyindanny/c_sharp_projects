﻿//
/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

using System;
using static System.Console;
Clear();

int[] array1 = { 1, 2, 3, 4, 5 };
int[] array2 = new int[array1.Length];

for (int i = 0; i < array1.Length; i++)
{
	array2[i] = array1[i];
	Write($"{array1[i]} -> {array2[i]} ");
}
