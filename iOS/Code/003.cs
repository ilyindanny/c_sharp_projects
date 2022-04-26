using System;

public class Program
{
    static public void Main ()
    {
        
		int a = 2;
		int b = 1;
		int c = 3;
		
		int d = (a > c && b > a) ? (-1) : (a < c && b < a) ? (-2) : (-3);
		
		string alt = (d == -1) ? "firs right" : (d == -2) ? "second right" : "nothing right";
		
		
		Console.WriteLine(alt);
		
		
		
		
		
		
    }
}
