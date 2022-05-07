using System;

using static System.Console;

public class Program
{
	static public void Main()
	{

		// тип Boolean принимает значения true или false. в выражениях используются операторы ИЛИ "&", И "|", ИЛИ НЕ "^", НЕ "!".

		// выражение dool b = (a | b) & !(a | b); заменяет оператор ИЛИ НЕ.

		// выражение bool bToggle ^= true; всегда меняет значение bToggle;

		// массив заполняется значением false

		// b = Boolean.Parse(str); сравнивает содержимое строки с true и false независимо от регистра

		// b.ToString() возвращает слова True или False

		// Convert.ToBolean() возвращает false, есои значение ноль, и true, если не ноль (не уверен. еще не видел)

		// Convert.ToDecimal() в обратном направлении конвертирует true в 1, а false в 0

		// числа с плавающей точкой сравнивать не желательно, потому что числа содержат искажения. если их нужно соавнить, то сначала необходиомо их округлить до одинакового числа десятичных разрядов.
		
		// проверка типа decimal на infinity, positiveinfinity, negativeinfinity и NaN осуществляется при помощи методов, возвращающих true или false:
		bool b = Double.IsInfinity(4.0 / 0);
		b = Double.IsPositiveInfinity(4.0 / 0);
		b = Double.IsNegativeInfinity(-4.0 / 0);
		b = Double.IsNaN(0.0 / 0);
		
		// а вот вывод на печать с тернарным оператором:
		Console.WriteLine("IsPositiveInfinity(4.0 / 0) == {0}.", Double.IsPositiveInfinity(4.0 / 0) ? "true" : "false");



	}
}
