using System;

public class Program
{
    static public void Main ()
    {


string[] array = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);



double a = Convert.ToDouble(array[2]);

Console.WriteLine(a);
Console.WriteLine(array[2]);




string[] r = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);


string text = "любой текст с любыми знаками только без кавычек и обратного слэша '()=;{}+-$[]'.:<>!//* ";


string[] aArray = text.Split(" ",StringSplitOptions.RemoveEmptyEntries);


Console.WriteLine(aArray[11]);

int length = aArray.Length;

Console.WriteLine(length);

    }
}
