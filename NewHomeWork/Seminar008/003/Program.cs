//
/* составить частотный словарь элементов двумерного массива
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

		// преобразование двумерного массива в одномерный:
		int[] transformedArray = MyMethods.TransformArray(array);
		WriteLine();

		// сортировка внутри одномерного массива (идентичные цифры собираются вместе):
		MyMethods.SortArray(transformedArray);
		WriteLine();

		// вызов метода GetStringCount (возвращает строку с количествами одинаковых цифр):
		int[] arrayCount = MyMethods.GetStringCount(transformedArray).Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

		// вызов метода GetStringNum (возвращает строку с перечнем найденных цифр без повторений):
		int[] arrayNum = MyMethods.GetStringNum(transformedArray).Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

		// метод SortTwoArrays сортирует сразу два массива, располагая по частоте нахождения:
		MyMethods.SortTwoArrays(arrayCount, arrayNum);

		MyMethods.PrintArray(arrayCount, arrayNum);
	}
}
