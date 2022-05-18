//
/*
заменить элементы внутри массива
*/
namespace MyClasses;
using System;
using static System.Console;
using System.Linq;
class Program
{
	static void Main()
	{
		int[,] array = MyMethods.GetArray(5, 5, 1, 10);
		MyMethods.PrintArray(array);
		WriteLine();

		MyMethods.TurnArray(array);  // замена внутри существующего массива. проверка на равенство сторон
		MyMethods.PrintArray(array);
		WriteLine();

		int[,] newArray = MyMethods.TurnArrayToNew(array);  // замена с созданием нового массива. проверка на равенство сторон не нужна
		MyMethods.PrintArray(newArray);
	}
}