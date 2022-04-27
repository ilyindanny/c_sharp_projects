using System;

public class Program
{
    static public void Main ()
    {

int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(String.Join(", ", NewArray(length)));


// WriteLine(String.Join(", ", array(8)) );

// эти массивы и строка, которые создаются этими методами, называются ДИНАМИЧЕСКИМИ, потому что размер массива или строки берется из переменной.


string[] NewArray(int length)
{
	string[] array = new string[length];
	for (int i = 0; i < length; i++)
	{
		array[i] = Convert.ToString(new Random().Next(0, 2)) + "!";
	}
	return array;
}


int[] NewArrayInt(int length)
{
	int[] array = new int[length];
	for (int i = 0; i < length; i++)
	{
		array[i] = new Random().Next(0, 2) + 11;
	}
	return array;
}


string NewText(int length)
{
	string text = String.Empty;
	for (int i = 0; i < length; i++)
	{
		int temp = new Random().Next(4, 6);
		text += Convert.ToString(temp) + ", ";
	}
	return text;
}


    }
}
