using System;

using static System.Console;

using System.Linq;

public class Program
{
    static public void Main ()
    {

// используя метод Select и Where, можно задать значения элементов массива, например, чтобы все элементы были нечетными:

int[] array = new int [20].Select(x => new Random().Next(0, 10)).Where(x => x % 2 != 0).ToArray();

Write(String.Join(" ", array));


    }
}
