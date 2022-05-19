//
/*
поменять первую и последнюю строчку местами в массиве
*/
namespace MyClasses;
using System;
using static System.Console;
using System.Linq;
class Program
{
	static void Main()
	{
		int[,] array = MyMethods.GetArray(5, 6, 1, 10);
		MyMethods.PrintArray(array);
		WriteLine();
		MyMethods.ChangeArray(array);
		MyMethods.PrintArray(array);
	}
}