using System;

using static System.Console;

using System.Linq;

public class Program
{
    static public void Main ()
    {

// метод Select класса Linq. обязательно нужна директива на System.Linq


int[] array = {1,4,7,7,8,4,7};

//Select перебирает каждый элемент массива с возможностью изменения элемента:

array = array.Select(x => x+1).ToArray();

string[] arr = Arr(array);
arr = arr.Select(x => x + "1").ToArray();



Write(String.Join(" ", array) + "\n");

Write(String.Join(" ", arr) + "\n");



string[] Arr(int[] array)
{
	string[] arr = new string[array.Length];

	for (int i = 0; i < array.Length; i++)
	{
		arr[i] = Convert.ToString(array[i]);
	}
	return arr;
}

    }
}
