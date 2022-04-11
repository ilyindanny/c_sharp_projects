/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

using System;
using static System.Console;

WriteLine("input first digit:");
int A = Convert.ToInt32(ReadLine());
WriteLine("input second digit:");
int B = Convert.ToInt32(ReadLine());
WriteLine("input third digit:");
int C = Convert.ToInt32(ReadLine());

int max = A;

if (B > max) max = B;
if (C > max) max = C;

WriteLine($"{max} is the biggest");




/* Напишите программу, которая принимает на вход трехзначное число и выдаёт бОльшую цифру в числе.



WriteLine("input three digit:");
int Didg = Convert.ToInt32(ReadLine());

int A = Didg % 10;
int B = Didg / 10 % 10;
int C = Didg / 100 % 10;

int max = A;

if (max < B) max = B;
if (max < C) max = C;

WriteLine(max);


*/