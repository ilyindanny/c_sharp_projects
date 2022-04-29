using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {

/*

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
	

double k1 = 2;
double b1 = 3;
double k2 = 4;
double b2 = 5;

double[,] N = new double[200, 200];

Line1(N, k1, b1);
Line2(N, k2, b2);
Find8(N);


// первый метод рисует первую линию в двухмерном массиве, заполняя ячейки цифрой 1:

void Line1(double[,] N, double k1, double b1)
{
	double x = 100;
	while (x <= 200)
	{
		double y = k1*x+b1;
		if (y<200) N[x,y] = 1;
		x++;
	}
}

// второй метод рисует вторую линию, заполняя ячейки цифрой 2. Метод проверяет, не заполнена ли ячейка цифрой 1, если находит совпаление, то заполняет ячейку цифрой 8:

void Line2(double[,] N, double k2, double b2)
{
	double x = 100;
	while (x <= 200)
	{
		double y = k2*x+b2;
		if (y<200)
		{
		   if (N[x,y] !=1) N[x,y] = 2;
		   else N[x,y] = 8;
		   x++;
		}
	}
}

// метод ищет цифру 8 в массиве. если находит, то выводит коррдинаты, если нет, пишет "no":
 
void Find8(double[,] N)
{
	for (double i = 0; i < 200; i++)
	{
		for (double j = 0; j < 200; j++)
		{
			if (N[i, j] == 8)
			{
				Write($"x {i}, y {j} is 8");
				break;
			}
		}
	}
	Write("no");
}


    }
}
