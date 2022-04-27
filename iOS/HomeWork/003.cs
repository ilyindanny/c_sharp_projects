using System;

public class Program
{
    static public void Main ()
    {
/*

Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


// first way

Console.WriteLine("input 5 digit number");

string aNum = Console.ReadLine();

if (aNum[0] == aNum[4])
{
	if (aNum[1] == aNum[3])
	Console.WriteLine("yes");
}
else
{
	Console.WriteLine("not");
}

// second way

string result = (aNum[0] == aNum[4] && aNum[1] == aNum[3]) ? "yes" : "not";

Console.WriteLine(result);




/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.WriteLine("imput coordinate x1");

double x1 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.WriteLine("imput coordinate y1");

double y1 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.WriteLine("imput coordinate z1");

double z1 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.WriteLine("imput coordinate x1");

double x2 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.WriteLine("imput coordinate y1");

double y2 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.WriteLine("imput coordinate z1");

double z2 = Convert.ToDouble(Console.ReadLine() ?? "0");



//double b = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(z2 - z1, 2));
//double resoult02 = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(b, 2));

// alternative:

double resoult02 = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(z2 - z1, 2)), 2));

Console.WriteLine(resoult02);




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
	double result03 = Math.Pow(index, 3);
	Console.WriteLine($"{index}^3 = {result03}");
	index += 1;
}


for (double index2 = 1; index2 <= N; index2 += 1)
{
	double result03 = Math.Pow(index2, 3);
	Console.WriteLine($"{index2}^3 = {result03}");
}

    }
}
