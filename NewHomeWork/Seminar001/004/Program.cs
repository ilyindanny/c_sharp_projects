// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.


using System;

int N = Int32.Parse(Console.ReadLine());
int B = -N;

while (B <= N)
{
    Console.Write($"{B} ");
    B+=1;
}