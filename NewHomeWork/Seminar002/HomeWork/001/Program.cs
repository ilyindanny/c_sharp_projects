/*

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

*/



using System;
using static System.Console;



// the first way


int result01 = Convert.ToInt32(Console.ReadLine());

result01 = result01 / 10 % 10;

Console.WriteLine(result01);



// the second way


string result02 = Console.ReadLine();

Console.WriteLine(result02[1]);



// the third way (if you find out the second digit from tne end)


string result002 = Console.ReadLine();

int resultLength = result002.Length;

Console.WriteLine(result002[resultLength - 2]);



// the 4th way (if you wanna convert a string to an integer)


int result03 = Convert.ToInt32(Console.ReadLine()[1].ToString());


Console.WriteLine(result03);