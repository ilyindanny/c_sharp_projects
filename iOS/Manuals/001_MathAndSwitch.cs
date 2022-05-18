using System;

public class Program
{
	static public void Main()
	{



		double a;


		// класс Math. методы Pow и Sqrt (тип данных всегда double):


		a = Math.Sqrt(16); // это извлечение квадратного корня. в скобках любое выражение, из которого извлекается квадратный корень

		a = Math.Pow(a, 3); // это возведение в степень. до запятой и после может быть любое выражение



		// метод Switch. ищет совпадение только по числам или строке, даже с переменной не сравнивает

		switch (a)  // учесть тип переменной
		{
			case 64: // если переменная = 64
				{
					Console.WriteLine("case 1");
					break; // без break не работает вроде
				}
			case 16: // если переменная = 16
				{
					Console.WriteLine("case 2");
					break;
				}
			default: // если совпадений не было
				{
					Console.WriteLine("default");
					break;
				}
		}



		// примеры использования класса Math с методами Pow и Sqrt


		a = Math.Pow(2, 8);

		Console.WriteLine(a);

		a = ((Math.Pow(2, 4)) * (Math.Pow(2, 4)));

		Console.WriteLine(a);

		a = Math.Sqrt((Math.Pow(Math.Sqrt(16), 4)) * (Math.Pow(2, 4)));




		Console.WriteLine(a);

	}
}
