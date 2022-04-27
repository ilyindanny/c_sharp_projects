using System;

using static System.Console;

using System.Linq;

public class Program
{
    static public void Main ()
    {

// 

string a = "123456";

string result = String.Empty;


// тут что-то не работает:

// result += (a.Select(x => x + "hh")).ToString();


for (int i = 0; i < a.Length; i++)
{
	result += a[i] + "+";
}

Write(a + "\n");

Write(result);






	













    }
}
