// array

using System;
using static System.Console;

/*

index    -   0,  1,  2,  3,  4...
int [] array = {2, 47, 6, 48, 941, 3, 50, 7, 9};

add to array into index 4 (it's 4th position):
array [4] = 65;

*/


void fillArray(int[] array)
{
	int length = array.Length;
	int index = 0;
	while (index < length)
	{
		array[index] = new Random().Next(0, 1000);
		index += 1;
	}
}


int Max(int[] array)
{
	int length = array.Length;
	int result = array[0];
	int index = 1;
	while (index < length)
	{
		if (result < array[index])
		{
			result = array[index];
		}
		index += 1;
	}
	return result;
}


void printArray(int[] array)
{
	int length = array.Length;
	int index = 0;
	while (index < length)
	{
		Write(array[index] + " ");
		index += 1;
	}

}


int[] array = new int[10];


fillArray(array);


int result = Max(array);

printArray(array);

WriteLine("");

WriteLine(result);