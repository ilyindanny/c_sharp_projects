//

using System;
using static System.Console;

Method01();
Method02();

void Method02()
{
	int[] array = { 1, 435, 75, 345, 34, 3, 47, 8, 6 };
	int length = method(array).Length;

	WriteLine(String.Join(" ", method(array)));
	WriteLine(length);
	WriteLine(method(array)[0]);

	int[] method(int[] array)
	{
		for (int index = 0; index < array.Length - 1; index++)
		{
			int indexMax = index;
			for (int i = index + 1; i < array.Length; i++)
			{
				if (array[indexMax] < array[i]) indexMax = i;
			}
			int temp = array[indexMax];
			array[indexMax] = array[index];
			array[index] = temp;
		}
		return array;
	}
}

void Method01()
{
	int[] array = { 1, 435, 75, 345, 34, 3, 47, 8, 6 };
	method(array);
	int length = array.Length;

	WriteLine(String.Join(" ", array));
	WriteLine(length);
	WriteLine(array[0]);



	void method(int[] array)
	{
		for (int index = 0; index < array.Length - 1; index++)
		{
			int indexMax = index;
			for (int i = index + 1; i < array.Length; i++)
			{
				if (array[indexMax] < array[i]) indexMax = i;
			}
			int temp = array[indexMax];
			array[indexMax] = array[index];
			array[index] = temp;
		}
	}
}