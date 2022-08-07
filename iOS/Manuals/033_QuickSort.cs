using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

// метод быстрой сортировки от умника из GB:



int[] arr = {9,8,7,6,5,4,3,2,1};

QuickSort(arr, 0, arr.Length - 1);

Console.Write($"sorted: {string.Join(",",arr)}");


void QuickSort (int[] inputArray, int minIndex, int maxIndex)
{
	if (minIndex >= maxIndex) return;
	
	int pivot = Sort(inputArray, minIndex, maxIndex);
	QuickSort (inputArray, minIndex, pivot - 1);
	QuickSort (inputArray, pivot + 1, maxIndex);
	return;
}
	
	
int Sort(int [] inputArray, int minIndex, int maxIndex)
{
	int pivotIndex = minIndex - 1;
	for (int i = minIndex; i <= maxIndex; i++)
	{
		if (inputArray[i] < inputArray[maxIndex])
		{
			pivotIndex++;
			Swap (inputArray, i, pivotIndex);
		}
	
	}
	pivotIndex++;
	Swap (inputArray, pivotIndex, maxIndex);
	return pivotIndex;
}


void Swap (int[] inputArray, int leftValue, int rightValue)
{
	int temp = inputArray[leftValue];
	inputArray[leftValue] = inputArray[rightValue];
	inputArray[rightValue] = temp;
}





    }
}
