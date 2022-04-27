using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {
int[] array = {111, 444, 333, -22, -1};
	

// оператор return прерывает выполнение. если он указывается в середине метода, то выполнение кода останавливается при первом де совпадении:
	

WriteLine(FindNumString(array,111));

string FindNumString(int[] array, int num)
{
	string result = String.Empty;
	foreach (int el in array)
	{
		if (el == num) return result = "yes"; // тут при совпадении код останавливается
	}
	result = "no"; // если бы не было предыдущего оператора return, то return result всегда был бы равен "no"
	return result;
}


// в следуюшем методе в конце указан оператор return false, но если по условию предыдущий оператор вернул true, то выполнение кода метода останавливатеся и метод возвращает true

bool FindNum(int[] array, int num)
{
	foreach (int el in array)
	{
		if (el == num)
		{
			return true;
		}
	}
	return false;
}

// вывод в консоль результата работы метода типа bool. так как этот метод возвращает истину или ложь, то с обращением к методу уместно использовать тернарный оператор. метод WeiteLine сначала обработает весь код в скобках, поэтому вернет не значение метода, а то, что вернет тернарый оператор:

WriteLine(FindNum(array, 111) ? "Yes" : "No");




    }
}
