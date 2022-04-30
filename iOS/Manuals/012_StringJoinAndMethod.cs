using System;

using static System.Console;

public class Program
{
	static public void Main()
	{
		/*

		-- Strung.Join(array) вывод в консоль массива с разделителем между каждым элементом

		-- string[] array = ReadLine().Split(" ", String)
		*/


		// на консоль выводится два метода. аргумент методов - строка из консолия:

		WriteLine((String.Join("", Method01(Convert.ToInt32(Console.ReadLine())))) + " " + (String.Join("", Method02(Convert.ToInt32(Console.ReadLine())))));



		string text = "what kind of fun did you see?";

		string[] aArray = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

		string[] bArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

		print(aArray);
		print(bArray);

		WriteLine(String.Join(" ", Method03(text)));



		// еще способ заполнить массив. массив обязательно string. объявить массив. потом прсле оператора присваивания указать переменную и потом: .Split("", StringSplitOptions.RemoveEmptyEntries);

		string[] Method03(string text)
		{
			string[] array = text.Split("", StringSplitOptions.RemoveEmptyEntries);
			return array;
		}


		// создать массив по длине аргумента и потом заполнить аргументом:

		int[] Method01(int a)
		{
			int[] array = new int[Convert.ToString(a).Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToInt32(Convert.ToString(a)[i].ToString());
			}
			return array;
		}


		// создать массив по длине аргумента, заполнить аргументом и потом отсортировать цифры в массиве по убыванию:

		int[] Method02(int a)
		{
			int[] array = new int[Convert.ToString(a).Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToInt32(Convert.ToString(a)[i].ToString());
			}
			for (int index = 0; index < array.Length - 1; index++)
			{
				int max = index;

				for (int count = index + 1; count < array.Length; count++)
				{
					if (array[max] < array[count]) max = count;
					int change = array[max];
					array[max] = array[index];
					array[index] = change;
				}
			}
			return array;
		}


		void print(string[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Write($"{array[i]} ");
			}
		}

	}
}
