using System;

public class Program
{
    static public void Main ()
    {

double i = 16;
i = Math.Sqrt(i + 4 * 2 - 8);
Console.WriteLine(i);

i = Math.Pow(i  + 4 * 2 - 8, 3);
Console.WriteLine(i);


string[] array = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

double temp = Convert.ToDouble(array[3]);
Console.WriteLine(array[3]);
Console.WriteLine($"{temp:F0}");

    }
}
