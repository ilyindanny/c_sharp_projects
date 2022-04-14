/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

456 -> 46

782 -> 72

918 -> 98

using System;
using static System.Console;



int num = new Random().Next(100, 1000);
int first = num / 100;
int third = num % 10;

WriteLine(num);
Write(first);
Write(third);
*/

using System;
using static System.Console;



int num = new Random().Next(100, 1000);
string numS = num.ToString();

int first = Convert.ToInt32(numS[0].ToString());
int third = Convert.ToInt32(numS[2].ToString());


WriteLine(num);
Write(first);
Write(third);



