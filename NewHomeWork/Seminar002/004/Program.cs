// число с клавы любой разрядности. вывести первый разряд и последний.

using System;
using static System.Console;




WriteLine("введите любое число");
string nString = (ReadLine() ?? "0");
int leength = nString.Length;

int first = Convert.ToInt32(nString[0].ToString());
int third = Convert.ToInt32(nString[leength - 1].ToString());


Write(first);
Write(third);