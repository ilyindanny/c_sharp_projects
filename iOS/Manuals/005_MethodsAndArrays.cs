using System;

public class Program
{
    static public void Main ()
    {



void fillArray (int[] array)
{
	int length = array.Length;
	int index = 0;
	while (index < length)
	{
		array[index] = new Random().Next(9, 101);
		index +=1;
	}
	
}


void printArray (int[] array)
{
	int length = array.Length;
	int index = 0;
	while (index < length)
	{
		Console.Write($"{array[index]} ");
		index +=1;
	}
}


int maxNumber (int [] array)
{
	int length = array.Length;
	int index = 1;
	int max = array[0];
	while (index < length)
	{
		if (array[index] > max) max = array[index];
		index +=1;
	}
	return max;

}


int minNumber (int [] array)
{
	int length = array.Length;
	int index = 1;
	int min = array[0];
	while (index < length)
	{
		if (array[index] < min) min = array[index];
		index +=1;
	}
	return min;

}


int[] array = new int[new Random().Next(10, 100)];


fillArray(array);

int max = maxNumber(array);
int min = minNumber(array);

Console.WriteLine(min + " - min");
Console.WriteLine(max + " - max");

printArray(array);






    }
}
