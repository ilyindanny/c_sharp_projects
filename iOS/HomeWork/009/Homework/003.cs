/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29


из интернета:

		 / n + 1 если m = 0
		 |
F(m, n)<  F(m - 1, 1) если m != 0 и n = 0
		 |
		 \ F(m - 1, F(m, n - 1)) если m и n больше нуля
*/

using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

Write(GetFunction(3, 2));


int GetFunction(int m, int n)
{
	return m == 0 ? n + 1 : m != 0 && n == 0 ? GetFunction(m - 1, 1) : GetFunction(m - 1, GetFunction(m, n - 1));
}

    }
}
