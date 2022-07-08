using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {


int num = 10;
F(num);


void F(int n)
{
	while (n > 0)
	{
		WriteLine(n);
		F(n-8);

	}
}

    }
}
