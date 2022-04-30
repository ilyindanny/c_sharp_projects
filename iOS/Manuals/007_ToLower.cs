using System;

public class Program
{
	static public void Main()
	{


		// понижает регистр:


		string S = "ABCdef".ToLower();

		Console.WriteLine(S);


		// понижает регистр:

		S = "aBcDeF";

		S = S.ToLower();

		Console.WriteLine(S);


		// только проверяет соответствие по пониженному регистру (в консоль возвращает с высоким регистром):

		S = "abcDEF";

		if (S.ToLower() == "abcdef")
		{
			Console.WriteLine(S);
		}


		// понижает регистр при выводе в консоль:

		if (S.ToLower() == "abcdef")
		{
			Console.WriteLine(S.ToLower());
		}

	}
}
