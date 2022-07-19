using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

int N = 5;
string result = GetNumbers (1, N);
WriteLine(result);

static string GetNumbers (int start, int end)
{
if (start == end) return start.ToString();
return (start + "_" + GetNumbers(start + 1, end));
}

    }
}
