using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

// обработка исключений
// в блоке catch можно объявить переменную класса Exception, объявленную в пространстве имен System. у переменной есть свойство exc.Message - выводимая информация не та деже самая, как при WriteLine(exc);
// если хотя бы один оператор в блоке try вызывает исключение, то весь блок try не обрабатывается
// пример:	

int i = 0;
double n = Double.NaN;
do
{
	try
	{
		n = Double.Parse(ReadLine());
		WriteLine("done");
		i = 1;
	}
	catch (Exception exc)
	{
		WriteLine(exc.Message);
	}
}
while (i == 0);

    }
}
