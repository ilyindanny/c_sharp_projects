using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

int[] array = {1,2,3,4};

WriteLine(String.Join(" ", array));

int[] f(int[] n)
{
	n[0] = 111;
	return n;	
}

WriteLine(String.Join(" ", f(array)));
WriteLine(String.Join(" ", array));















    }
}
