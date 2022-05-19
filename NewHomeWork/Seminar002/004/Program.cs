// вводится с клавиатуры число любой разрядности. вывести первый разряд и последний.

using System;
using static System.Console;


WriteLine("введите любое число");
string nString = (ReadLine() ?? "0");
int length = nString.Length;

int first = Convert.ToInt32(nString[0].ToString());
int last = Convert.ToInt32(nString[length - 1].ToString());

Write(first);
Write(last);