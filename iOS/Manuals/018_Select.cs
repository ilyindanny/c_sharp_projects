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


// а здесь используется метод Where, который я не знаю, что он делает:

int[] array02 = new int [8].Select(x => new Random().Next(0, 1000)).Where(x => x >= 9 && x <= 100).ToArray();


// используя метод Select и Where, можно задать значения элементов массива, например, чтобы все элементы были нечетными:

int[] array03 = new int [20].Select(x => new Random().Next(0, 10)).Where(x => x % 2 != 0).ToArray();

Write(String.Join(" ", array03));



// тут метод для конвертации массива int в string

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
