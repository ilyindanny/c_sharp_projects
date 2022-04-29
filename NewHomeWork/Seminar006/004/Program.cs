// 
/*
**Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3

Если N = 3 -> 0 1 1

Если N = 7 -> 0 1 1 2 3 5 8
*/

using System;
using static System.Console;
Clear();

// тут вроде не хватает еще проверки на то, если числа =0 или =1. тогда счетчик ставится в другую позицию. что-то вроде того

int a1 = int.Parse(ReadLine()!);
int a2 = int.Parse(ReadLine()!);
int N = int.Parse(ReadLine()!);
int Feb = 0;
int temp = 0;

for (int i = 0; i < N; i++)
{
	Feb = (a1 + a2);
	temp = a1 + a2;
	a1 = a2;
	a2 = temp;
	Write(Feb + " ");
}
