using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {

//
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/



WriteLine(Summator(ReadLine()));

int Summator(string line)
{
  int result = 0;
  for (int i = 0; i < line.Length; i++)
  {
    result += Convert.ToInt32(line[i].ToString());
  }
  return result;
}

    }
}
