// study

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
using System;
using static System.Console;


void ConvertArrayToDouble(string[] array01, double[] array02)
{
	int length = array01.Length;
	for (int index = 0; index < length; index += 1)
	{
		array02[index] = Convert.ToDouble(array01[index]);
	}
}


WriteLine("input coordonates with space: x1 y1 z1 x2 y2 z2");
string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[] a = new double[6];

ConvertArrayToDouble(array, a);

double resoult = Math.Sqrt(Math.Pow(a[4] - a[1], 2) + Math.Pow(Math.Sqrt(Math.Pow(a[3] - a[0], 2) + Math.Pow(a[5] - a[2], 2)), 2));

WriteLine($"{resoult:N2}");


/*
// Alternative:

Console.WriteLine("input coordonates with space: x1 y1 z1 x2 y2 z2");
string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

double x1 = Convert.ToDouble(array[0]);
double y1 = Convert.ToDouble(array[1]);
double z1 = Convert.ToDouble(array[2]);
double x2 = Convert.ToDouble(array[3]);
double y2 = Convert.ToDouble(array[4]);
double z2 = Convert.ToDouble(array[5]);

//double b = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(z2 - z1, 2));
//double resoult = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(b, 2));

// alternative:

double resoult = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(z2 - z1, 2)), 2));

Console.WriteLine($"{resoult:N2}");
*/