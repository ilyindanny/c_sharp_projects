// вывести первую цифру из четырехзначного числа

using System;

int N = Int32.Parse(Console.ReadLine() ?? "0");

//int x = N / 10 / 10 / 10;

int x = N / 1000;

Console.WriteLine(x);


//int y = N %10 ;
//Console.WriteLine(y);


