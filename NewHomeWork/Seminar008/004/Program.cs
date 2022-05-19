//
/*
// найти в массиве наименьшее число и удалить его столбец и строку (наименьшее, видимо, первое попавшееся)
*/

namespace MyClasses;
using System;
using static System.Console;
using System.Linq;
class Program
{
	static void Main()
	{
		int[,] array = MyMethods.GetArray(5, 5, 0, 10);
		MyMethods.PrintArray(array);
		WriteLine();

		// метод FindMin находит координаты наименьшего числа в массиве и возвращает массив с координатами:
		int[] coord = MyMethods.FindMin(array);

		MyMethods.PrintArray(coord);
		WriteLine("\n");

		// метод DeleteRowAndColumn создает новый массив размером меньше на одну строку и на одну колонку
		// Возвращаемый массив не имеет удаленных строки и колонки:
		MyMethods.PrintArray(MyMethods.DeleteRowAndColumn(array, coord));
	}
}