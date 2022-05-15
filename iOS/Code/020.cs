using System;

using System. Ling;

public class Program
{
    static public void Main ()
    {





string text = "(1,2) (2,3) (4,5) (6,7)"
.Replace(" (","")
.Replace (")", "")
;
Console.WriteLine(text);

var data = text.Split(" ").Select((item => item.Split('. ')).Select(e => x: int.Parse(e[0]), y: int.Parse(e[1]))).ToArray();

for (int i = 0; i < data.Lenght; i++)
{
Concole.WriteLine(data[i].x*10);
}




 
    }
}
