using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {


Date someDate = new Date(); // такая интциализация заполняет нулями все возможные значения объекта структуры. желательно так интциализировать структурную переменную до присвоения ей конкретного значения


Date[] aSomeDate = new Date[5]; // так инициализируется массив структуры в операторе объявления. при помощи квадратных скобок индексируется переменная массива, затем после точки указывается имя поля и таким образом элемент ссылается на свое поле

aSomeDate[2].iMonth = 10;
someDate.iDay = 23;

WriteLine(someDate.iDay);
WriteLine(aSomeDate[2].iMonth);


// структура похожа на класс. но класс это ссылочный тип, поэтому при объявлении экземпляра не выделяется память в куче. следовательно, для массива нужно будет интциализировать каждый элемент ключевым словом new

DateClass someDateClass = new DateClass();
DateClass[] aSomeDateClass = new DateClass[5];

for (int i = 0; i < aSomeDateClass.Length; i++)
{
	aSomeDateClass[i] = new DateClass();
}

aSomeDateClass[2].iMonth = 10;
someDateClass.iDay = 23;

WriteLine(someDateClass.iDay);
WriteLine(aSomeDateClass[2].iMonth);

    }
}

struct Date
{
	public int iDay;
	public int iMonth;
	public int iYear;
}

class DateClass
{
	public int iDay;
	public int iMonth;
	public int iYear;
}