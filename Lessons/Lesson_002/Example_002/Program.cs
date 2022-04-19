// New method with array and functions:

/*
int [] array = {9, 8, 7, 67, 5, 46, 3, 2, 1};

int FindMaxMethod (int a, int b, int c)
{
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}


int max = FindMaxMethod(
    FindMaxMethod(array[0], array[1], array[2]), FindMaxMethod(array[3], array[4], array[5]), FindMaxMethod(array[6], array[7], array[8]));

Console.WriteLine(max);
*/


// More good method:


int[] array = { 9, 8, 7, 67, 5, 46, 3, 2, 1 };

int n = array.Length;
int FindSomeMyDigit = 1;
int ArrayElementsCounter = 0;

while (ArrayElementsCounter < n)
{
	if (array[ArrayElementsCounter] == FindSomeMyDigit)
	{
		Console.WriteLine(ArrayElementsCounter);
	}
	ArrayElementsCounter++;
}