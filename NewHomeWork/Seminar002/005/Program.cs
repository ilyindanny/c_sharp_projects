/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14  ->  нет
46  ->  нет
161 ->  да
*/
using System;
using static System.Console;


WriteLine("введите любое число");
int num = Convert.ToInt32(ReadLine());

//int a = 1;
//int b = 2;

string result = (num % 7 == 0 && num % 23 == 0) ? "кратно" : "не кратно";


Write(result);