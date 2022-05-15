//
using System;
using static System.Console;
using System.Linq;
using MyClasses;
class Program
{
	static void Main()
	{
		int[,] array = MyExample.GetArray(5, 5, 33);

		WriteLine(array[1, 1]);

		MyExample.PrintArray(array);

	}
}

