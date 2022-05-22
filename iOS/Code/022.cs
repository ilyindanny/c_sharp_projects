using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

int i = 0;

	
M("g");

void M(string s)
{
		s += "a";
		Write("{0} ", s);

	while(i <10)
	{
	i++;
	M(s);
	}
}














    }
}
