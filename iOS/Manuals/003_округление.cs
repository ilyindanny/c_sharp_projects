using System;

public class Program
{
	static public void Main()
	{
		// округление: $"{a:F3}"

		double a = 2.22222222;
		Console.WriteLine($"{a:F3}");


		// округление в вычислении. в скобках метода Round после выражения задается через запятую порядок округления:

		int result = Math.Round(a * a, 2);
	}
}
