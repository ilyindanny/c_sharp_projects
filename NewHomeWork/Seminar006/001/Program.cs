//
/*
**Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]

[6 7 3 6] -> [6 3 7 6]

*/


using System;
using System.Linq;
Console.Clear();

int length = 9;

int[] array01 = new int[length].Select(x => x = new Random().Next(0, 20)).ToArray();

Console.WriteLine(String.Join(" ", array01));

// замена элементов массива при помощи вспомогательной переменной

for (int i = 0; i < length / 2; i++)
{
	int temp = array01[i];
	array01[i] = array01[length - i - 1];
	array01[length - i - 1] = temp;
}

Console.WriteLine(String.Join(" ", array01));

// создание второго массива и заполнение в обратном порядке

int[] array02 = new int[length];
for (int i = 0; i < length; i++)
{
	array02[length - i - 1] = array01[i];
}
Console.WriteLine(String.Join(" ", array02));
