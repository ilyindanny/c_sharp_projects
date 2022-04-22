// 
/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3

78 -> 2

89126 -> 5

*/

using System;
using static System.Console;

/*
WriteLine("input number");
int num = Convert.ToInt32(ReadLine());


int result = Counter(Math.Abs(num));
WriteLine(result);


int Counter(int a)
{
	int counter = 1;
	while (a / 10 > 0)
	{
		a = a / 10;
		counter += 1;

	}
	return counter;
}
*/


double num = -10.099;

int result = Counter(Math.Abs(num));
WriteLine(result);

int Counter(double a)
{
	int counter = 2;
	while (a / 10 >= 10)
	{
		a = a / 10;
		counter += 1;

	}
	return counter;
}

