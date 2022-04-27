using System;

public class Program
{
    static public void Main ()
    {

		int a = 2;
		int b = 1;
		int c = 3;
		
		
		
		string d = (a > c && b > a) ? "f": (a < c && b < a) ? "s" : "n";


Console.WriteLine(d);

		

string alt;

if (a > c && b > a)
{
	alt = "firs right";
}
else
{
	if (a < c && b < a)
	{
		alt = "second right";
	}
	else
	{
		alt = "nothing right";
	}
}


Console.WriteLine(alt);


















    }
}
