﻿/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5  -> 2, 4
8  -> 2, 4, 6, 8
*/

using System;
using static System.Console;

WriteLine("input some number:");
int N = Convert.ToInt32(ReadLine());

int D = 2;

while (D <= N)
{
    WriteLine(D);
    D+=2;
}