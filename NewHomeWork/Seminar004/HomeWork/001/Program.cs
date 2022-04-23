//
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using System;

using static System.Console;


WriteLine(Expo(ReadLine(), ReadLine()));

int Expo(string num1, string num2)
{
	int a = Convert.ToInt32(num1.ToString());
	int b = Convert.ToInt32(num2.ToString());
	int result = 1;
	int x = 1;

	for (int i = 0; i <= b; i++)
	{
		result *= x;
		x = a;
	}
	return result;
}


// alternative

/*
int Expo(string num1, string num2)
{
	int a = Convert.ToInt32(num1.ToString());
	int b = Convert.ToInt32(num2.ToString());
	int result = 1;
	if (b > 0)
	{
		for (int i = 0; i < b; i++)
		{
			result *= a;
		}
	}
	else
	{
		result = 1;
	}
	return result;
}
*/

