//
using System;
using static System.Console;
using System.Linq;
class Program
{
	static void Main()
	{

		int[,] array = MyClasses.MyExample.GetArray(5, 5, 1, 100);

		WriteLine(array[1, 1]);

		MyClasses.MyExample.PrintArray(array);


	}
}

