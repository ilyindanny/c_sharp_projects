using System;

public class Program
{
	static public void Main()
	{



		double a;


		// класс Math. методы Pow и Sqrt (тип данных всегда double):


		a = Math.Sqrt(16); // это извлечение квадратного корня. в скобках любое выражение, из которого извлекается квадратный корень

		a = Math.Pow(a, 3); // это возведение в степень. до запятой и после может быть любое выражение



		// метод Switch. ищет совпадение только по числам, константам, литералу или выражению, но не по переменной. аргументом не может быть тип double или decimal. внутри оператора switch в фигурных скобках находятся разделы. ключевое слово case с константой и двоеточием называется "метка". один из разделов может иметь метку default — выполняется, если соответстаие не было найдено (эта метка не обязательна).

		switch (a)  // учесть тип переменной
		{
			case 64: // если переменная = 64
				{
					Console.WriteLine("case 1");
					break; // break как поавило используется всегда (либо return, throw или goto)
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
		
		// в однлм разделе может быть несколько меток. а также оператор goto (указывающий на константу или default) позволяет перейти в другому разделу:
		switch (a)
		{
			case 64:
			case 65:
			case 66:
			case 67:
				{
					Console.WriteLine("ok");
					goto default;
				}
			default:
				{
					Console.WriteLine("not");
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
