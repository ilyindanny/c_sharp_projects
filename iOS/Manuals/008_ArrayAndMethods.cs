using System;

public class Program
{
    static public void Main ()
    {
string[] a = {"41", "23", "65", "14", "97"};

double[] NewA(string[] array)
{
	int length = array.Length;
	double[] b = new double[length];
	
	for(int index = 0; index < length; index += 1)
	{
	b[index] = Convert.ToDouble(array[index]);
	Console.WriteLine($"double {b[index]} = string {array[index]}");
	}
	return b;
}


double[] c = NewA(a);
int length = c.Length;

Console.WriteLine(length);




    }
}
