using System;

using static System.Console;

public class Program
{
	static public void Main()
	{

		WriteLine(String.Join(", ", (ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries))));


		//
		//WriteLine String.Join(", ", array) - печать массива
		//
		//ReadLine().Split(" ", ) - возвращение массива из консоли
		//

	}
}
