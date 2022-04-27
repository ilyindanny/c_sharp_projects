using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {

int x = 3;
for (int i = 0; i < 32; i++)
{
	x = checked(x * x);
	WriteLine(x);
}


for (int i = 0; i < 32; i++)
{
	x = unchecked(x * x);
	WriteLine(x);
}



checked
{
	for (int i = 0; i < 32; i++)
{
	x = (x * x);
	WriteLine(x);
}
}






    }
}
