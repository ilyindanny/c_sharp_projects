using System;

using static System.Console;

using System.Linq;

public class Program
{
    static public void Main ()
    {

// 1) создание массива при помощи метода с использованием метода Select
// 2) создание второго массива из перемноженных элементов первого массива с использованием временной переменной типа string, в которую записываются через пробел произведения
// вывод на монитор центрального элемента массива, если количество элементов первого массива не четное 
	
	
int[] array = GetArray(4, 1, 9);

Write(String.Join(" ", array) + "\n");

Write(String.Join(" ", ProductArray(array)) + "\n");


string middle = array.Length % 2 == 0 ? "" : (Convert.ToString(array[array.Length / 2]));

WriteLine(middle);



int[] GetArray(int size, int min, int max)
{
	int[] array = new int[size].Select(x => new Random().Next(min, max + 1)).ToArray();
	return array;
}




string[] ProductArray(int[] array)
{
	string temp = "";
	for (int i = 0; i < array.Length / 2; i++)
	{
		temp  += (array[i] * (array[array.Length - 1 - i])).ToString() + " ";
	}
	string[] arrayNext = temp.Split(" ", StringSplitOptions.RemoveEmptyEntries);
	return arrayNext;
}






    }
}
