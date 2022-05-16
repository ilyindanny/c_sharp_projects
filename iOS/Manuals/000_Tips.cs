using System;
using static System.Console;
public class Program
{
	static public void Main()
	{
		/********************************************
		правило - всегда писать комментарий
		********************************************/


		// неизменные значения лучше обьявлять как константы.

		// если метод вызывает структуру, то лучше перед точкой писать саму структуру, а не псевдоним: Int32.Parse лучше чем int.Parse

		// можно выравнивать в строке однотипные элементы. так код чиать удобнее (не в любом операторе можно ставить перенос строки. например, в выражении $"result {Num / 100}" нельзя):

		int Num = 3025;

		WriteLine("result: " + Num / 100 + ","
								+ Num % 100 + " c");

		// часто удобно использовать целочисленные значения, даже если есть копейки или центы, таким образом компьютер будет округлять до копеек (к примеру, 10 руб, 00 коп записывается как 1000, а выводится с делением на 100 и вычислением остатка от деления на 100). это удобно


		// инициализировать переменные можно в одной строке:

		int a = 12, b = 14, c = 8;

		// цифровые форматы можно переводить между друг другом без вызова метода структуры Convert. достаточно написать в скобках перед выражением псевдоним типа: (int), (decimal), (long), (sbyte). приведение ставится перед всем выражением, потому что имеет наивысший приоритет и все элементы будут приведены до вычисления. то есть ксли выражение должно выполняться, когда каждый член конвертирован в другой тип, то нельзя ставить перед скобками, нужно ставить перед одним из элементов оператора непосредственно:

		// можно:
		decimal d = (decimal)a / c;
		WriteLine($"{d} and {a}, {b}, {c}");

		// нельзя:
		d = (decimal)(a / c);
		WriteLine($"{d} and {a}, {b}, {c}");

	}
}
