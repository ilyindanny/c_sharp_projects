/*

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

*/



using System;

public class Program
{
    static public void Main ()
    {



// N10

// the first way

int result01 = Convert.ToInt32(Console.ReadLine());

result01 = result01 / 10 % 10;

Console.WriteLine(result01);


// the second way

string result02 = Console.ReadLine();

Console.WriteLine(result02[1]);


// the third way (if you wanna convert a string to an integer)

int result03 = Convert.ToInt32(Console.ReadLine()[1].ToString());


Console.WriteLine(result03);



// N13

string result04 = Console.ReadLine();

int length = result04.Length;

if (length < 3) Console.WriteLine("there isn't the third digit");
else
{
	Console.WriteLine(result04[2]);
}

	

// N15

// the first way

int result05 = Convert.ToInt32(Console.ReadLine());

if (result05 == 6 | result05 == 7)
{
	Console.WriteLine("yes");
}
else
{
	Console.WriteLine("not");
}


// the second way

int result06 = Convert.ToInt32(Console.ReadLine());

string answer01;

if (result06 == 6 | result06 == 7)
{
	answer01 = "yes";
}
else
{
	answer01 = "not";
}

Console.WriteLine(answer01);


// the third way

int result07 = Convert.ToInt32(Console.ReadLine());

string answer02 = (result07 == 6) ? "yes" : (result07 == 7) ? "yes" : "not";

Console.WriteLine(answer02);

















	
	
    }
}
