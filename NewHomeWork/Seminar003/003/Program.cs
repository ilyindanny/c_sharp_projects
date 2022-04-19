/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

*/


using System;
using static System.Console;



double x1 = Convert.ToDouble(ReadLine());

double y1 = Convert.ToDouble(ReadLine());

double x2 = Convert.ToDouble(ReadLine());

double y2 = Convert.ToDouble(ReadLine());



/*
double c = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

WriteLine(c);
*/


double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

WriteLine(d);