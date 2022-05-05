using System;

using static System.Console;

using System.Linq;

public class Program
{
	static public void Main()
	{
		// способы задать массив


		// создание массива с помощью метода NewArray:

		void Method01()
		{

			// способ вызвать метод и заполнить аргументы из консоли:

			//WriteLine(String.Join(" ", NewArray(Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()))));

			// способ вызвать метод и заполнить аргументы переменными:

			//var size = 15;
			//var minValue = -99;
			//var maxValue = 99;
			//
			//WriteLine(String.Join(" ", NewArray(size, minValue, maxValue)));


			// еще способ вызова этого метода с указанием значений аргументов метода:

			int[] array = NewArray(12, -9, 9);
			WriteLine(String.Join(" ", array));


			// собственно сам метод:

			int[] NewArray(int size, int minValue, int maxValue)
			{
				int[] array = new int[size];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = new Random().Next(minValue, maxValue + 1);
				}
				return array;
			}
		}


		// второй метод  основан на том, чтобы при обращении к методу WriteLine указать метод String.Join для вывода на монитор массива, а в месте аргумента указать ReadLine с методом Split, позволяющим заполнить массив данными из консоли, введенными через пробел. В данном коде массив не сохраняется в программе:

		void Method02()
		{

			WriteLine(String.Join(" ", ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)));

		}


		// тот же метод, только с возможностью сохранить массив в программе, но тип данных массива string:

		void Method03()
		{
			string[] array = (ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

			WriteLine(String.Join(" ", array));
		}



		// новый метод. необходима директива на класс System.Linq. используется метод .Select()

		void Method04()
		{

			var array = new int[4].Select(x => new Random().Next(10)).ToArray();

			WriteLine($"array: {String.Join(", ", array)} \n");

		}

	}
}
