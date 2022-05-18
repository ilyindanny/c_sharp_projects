using System;

using static System.Console;

public class Program
{
	static public void Main()
	{


		// ToLower() возвращает строку в нижнем регистре. вот примеры использования в разных операторах:
		
		// понижается регистр литерала и присваивается строке:

		string S = "ABCdef".ToLower();
		WriteLine(S);


		// понижается регистр строковой переменной и присваивается переменной:

		S = "aBcDeF";
		S = S.ToLower();
		WriteLine(S);


		// только проверяет соответствие по пониженному регистру (сама переменная остается неизменной):

		S = "abcDEF";
		if (S.ToLower() == "abcdef")
		{
			WriteLine(S);
		}


		// понижает регистр при выводе на монитор:
		WriteLine(S.ToLower());
		
		// метод экземпляра класса String под названием Trim удаляет пробелы до и после:
		
		S = ReadLine().ToLower().Trim();
		WriteLine(S);

	}
}
