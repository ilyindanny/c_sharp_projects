/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

using System;
using static System.Console;

WriteLine("input three digit:");
int Didg = Convert.ToInt32(ReadLine());

int A = Didg % 10;
int B = Didg / 10 % 10;
int C = Didg / 100 % 10;

WriteLine(A);
WriteLine(B);
WriteLine(C);