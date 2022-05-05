using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {

int i = new Random().Next(1, 5);

WriteLine(new string[] {"a", "b", "c", "d"} [i - 1]);


int[,,,] test = new int[5,5,5,5];

test[2,2,2,2] = 555;
WriteLine(test[2,2,2,2] + " " + test.Length + " " + test.GetLength(3));

    }
}
