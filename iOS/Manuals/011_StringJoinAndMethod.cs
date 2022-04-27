using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {

Example();



void Example()
{


WriteLine(String.Join(" ", Method03(Convert.ToInt32(Console.ReadLine()))));

WriteLine(Method01(Convert.ToInt32(Console.ReadLine())));



int[] Method03(int a)
{
	string text = Convert.ToString(a);
	int[]array = new int[text.Length];
	for (int i = 0; i < array.Length; i++)
	{
		
		// когда нужно char (символ из string) конвертировать в int, то чтобы возвращался символ, а не кодировка, сначала конвертирует в string метод .ToString() - обязательно со скобками, как и любой метод

		array[i] = Convert.ToInt32(text[i].ToString());
	}
	return array;
}


int Method01(int a)
{
	a++;
	return a;
}


void Method02(int a)
{
	a++;
}

}

    }
}
