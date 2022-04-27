using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {


int[] array = GetArray(12, -9, 9);

WriteLine(String.Join(" ", array));

for (int i = 0; i < array.Length; i++)
{
	array[i] *= -1;
}

WriteLine(String.Join(" ", array));


array[0] = 111;



////
WriteLine(test(array,111));

string test(int[] array, int num)
{
	string result = String.Empty;
	foreach (int el in array)
	{
		if (el == num) return result = "yes";
	}
	result = "no";
	return result;
}






bool FindNum(int[] array, int num)
{
	foreach (int el in array)
	{
		if (el == num)
		{
			return true;
		}
	}
	return false;
}



int[] GetArray(int size, int min, int max)
{
	int[] array = new int[size];
	for (int i = 0; i < size; i++)
	{
		array[i] = new Random().Next(min, max);
	}
	return array;
}

    }
}
