using System;

public class Program
{
    static public void Main ()
    {

// convert string to integer


int A = 5;
string bStr;
int bInt;
Console.WriteLine("input integer: ");
bStr = Console.ReadLine();
bInt = Int32.Parse(bStr);
int C = A + bInt;
Console.WriteLine(C);





// simple method


string D = "5";
int E = Int32.Parse(D);

Console.WriteLine(E);





// or else

string a = Console.ReadLine();
int aa = Int32.Parse(a);
string b = Console.ReadLine();
int bb = Int32.Parse(b);
Console.WriteLine($"{aa} and {bb}");



    }
}
