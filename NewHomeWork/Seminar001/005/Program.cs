/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
    
    456 -> 6
    
    782 -> 2
    
    918 -> 8
*/


using System;

int N = Int32.Parse(Console.ReadLine() ?? "0");

int x = N / 10;
int y = N % 10;

Console.WriteLine($"x {x}");
Console.WriteLine($"y {y}");




