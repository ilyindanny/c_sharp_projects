using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

// особенности цикла for. можно объявить несколько переменных или инициализировать. но нельзя объявить одну и инициализировать другую. также нельзя объявлять разные типы

for (int i = 0, j = 100; i < j; i++, j-= 5)
{
	
}

// бесконечный цикл. эквивалентен while (true):

//	for (;;)
//	{
	
//	}


// можно включать в цикл методы (в месте инициализатора и итератора). при этом тело оператора for - пустой оператор, состоящий из точки с запятой:

for (int i = 0; i < 10; Write(i++ + " "));
WriteLine("\n");

string[] astr = {"1","2","3","4","5","6"};

for (int i = 0; i < astr.Length; i++)
{
	Write("{0, 6} ", astr[i]);
	if (i % 3 == 2) WriteLine();
}






    }
}
