//
/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


Console.WriteLine("input number");

double N = Convert.ToDouble(Console.ReadLine());
double index = 1;

while (index <= N)
{
	double result02 = Math.Pow(index, 3);
	Console.WriteLine($"{index}^3 = {result02}");
	index += 1;
}

/*
for (double index2 = 1; index2 <= N; index2 += 1)
{
	double result02 = Math.Pow(index2, 3);
	Console.WriteLine($"{index2}^3 = {result02}");
}
*/