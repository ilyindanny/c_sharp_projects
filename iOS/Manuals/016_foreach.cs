using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {
// цикл foreach () {}
// цик похож на for, но уже настроен на перебор всех элементов массива. переменная int el доступна только для чтения: 
	
	
int a = 0;
int b = 0;
int[] array = {1,4,6,-2,-9};

foreach (int el in array)
{
	a += el > 0 && el < 5 ? el : 0;
	b += el < 0 && el > -3 ? el : 0;
}

WriteLine($"{a} {b}");












    }
}
