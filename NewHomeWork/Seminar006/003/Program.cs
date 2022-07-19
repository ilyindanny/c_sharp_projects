//
/*
**Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10
*/

using System;
using static System.Console;

// первый способ. в строковую переменную добавляется по значению в цикле (добавляется в начало, таким образом нумеруется с конца):

Method01();

void Method01()
{
	int A = 18;

	string result = "0";


	while (A % 2 > 0)
	{
		result = (A % 2).ToString() + result;
		A = A / 2;
	}

	Write(result);
}


// От Roman Bachinsky (делали в группе вместе)

Method02();

void Method02()
{
	int A = int.Parse(ReadLine()!);
	string result = string.Empty;

	while (A > 0)
	{
		result = A % 2 + result;
		A = A / 2;
	}
	WriteLine(result);
}



// пример от Тимура Попова. пока что не понятно, что это и как сделано

DecToNum(18, 2);

string DecToNum(int decNumber, int otherSystem)
{
	string res = "";
	string nums = "0123456789ABCDEF";
	while (decNumber > 0)
	{
		int ost = decNumber / otherSystem;
		res = nums[decNumber - otherSystem * ost] + res;
		decNumber /= otherSystem;
	}
	return res;
}

