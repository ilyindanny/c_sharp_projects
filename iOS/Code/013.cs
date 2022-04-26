using System;

using static System.Console;

using System.Linq;

public class Program
{
    static public void Main ()
    {

Write("imput size of array: ");
int N = Convert.ToInt32(ReadLine()!);
var array = new int[N].Select(x => new Random().Next(10)).ToArray();

WriteLine($"first array: {String.Join(", ", array)} \n");


ProductPairs(array);

void ProductPairs(int[] arr)
{
    int product = 1;
    int[] newArray = (N % 2 == 0) ? new int[N / 2] : new int[N / 2 + 1];
    for (int i = 0; i < N / 2; i++)
    {
        product = arr[i] * arr[N - 1 - i];
        newArray[i] = product;
    }

    if (N % 2 == 1) newArray[N / 2] = arr[N / 2];
    Write($"second array: {String.Join(", ", newArray)}");
}






    }
}
