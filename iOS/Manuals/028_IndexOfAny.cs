using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

char[] ach = {'m', 'A', 'a', 'n', 'N'};
string[] astr = {"abc", "bca", "cba", "cbb"};
int count = 0;

for(int i = 0; i < astr.Length; i++)
{
	if (astr[i].IndexOfAny(ach) != -1)
	count++;
}
WriteLine(count);










    }
}
