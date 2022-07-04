using System;

using static System.Console;

public class Program
{
	static public void Main()
	{
		// цикл foreach () {}
		// цик похож на for, но уже настроен на перебор всех элементов массива или строки (можно использовать метод, возвращающий массив или строку). переменная el ( возможно любое имя) доступна только для чтения. нужно верно указывать формат переменной. для строки это char. в отличие от for не вызывает на каждом круге массив заново


		int a = 0;
		int b = 0;
		int[] array = { 1, 4, 6, -2, -9 };

		foreach (int el in array)
		{
			a += el > 0 && el < 5 ? el : 0;
			b += el < 0 && el > -3 ? el : 0;
		}

		WriteLine($"{a} {b}");
		
		
		// к примеру, вывод каждого символа строки:
		
		string str = "abcdefghi";
		
		foreach (char ch in str)
		Write("{0} ", ch);
		
		

	}
}
