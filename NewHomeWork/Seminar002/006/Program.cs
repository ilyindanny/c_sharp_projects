/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

*/


using System;
using static System.Console;


WriteLine("введите первое число");
int num1 = Convert.ToInt32(ReadLine() ?? "0");

WriteLine("введите второе число");
int num2 = Convert.ToInt32(ReadLine() ?? "0");



string result = (num2 * num2 == num1) ? "первое число - квадрат второго" : (num1 * num1 == num2) ? "второе число - квадрат первого" : "никакое число не является квадратом другого";


Write(result);