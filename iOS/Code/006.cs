using System;

public class Program
{
    static public void Main ()
    {

void fillArray(int[] array)
{
	int length = array.Length;
	int index = 0;
	while (index < length)
	{
		array[index] = new Random().Next(10, 100);
		index += 1;
	}
}

int middleNum(int[] array)
{
	int length = array.Length;
	int index = 1;
	int middle = array[0];
	while (index < length)
	{
		middle += array[index];
		index += 1;
	}
	middle /= length;
	return middle;
}


void printArray(int[] array)
{
	int length = array.Length;
	int index = 0;
	while (index < length)
	{
		Console.WriteLine(array[index] + " ");
		index += 1;
	}
}


int[] array = new int [new Random().Next(10, 16)];


fillArray(array);
int middle = middleNum(array);

Console.WriteLine(middle + " - middle");

printArray(array);




    }
}
