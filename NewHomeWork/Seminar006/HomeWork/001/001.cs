using System;

using static System.Console;

using System.Linq;

public class Program
{
    static public void Main ()
    {

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


// 1th

Method01();

void Method01()
{

WriteLine("input some numbers with spase: 1 2 3");

string[] M = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] N = new int[M.Length];

NewArray(M, N);
WriteLine(String.Join(" ", N));
WriteLine(PositiveNum(N));



void NewArray(string[] M, int[] N)
{
	for (int i = 0; i < M.Length; i++)
	{
		N[i] = Convert.ToInt32(M[i].ToString());
	}
}


int PositiveNum(int[] N)
{
	int result = 0;
	foreach (int el in N)
	{
		result += el > 0 ? 1 : 0;
	}
	return result;
}

}


// 2th

Method02();

void Method02()
{

WriteLine("input some numbers with spase: 1 2 3");
string[] M = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(String.Join(" ", M));
NumOfPosotive(M);

void NumOfPosotive(string[] M)
{
	int result = 0;
	for (int i = 0; i < M.Length; i++)
	{
		result += Convert.ToInt32(M[i].ToString()) > 0 ? 1 : 0;
	}
	WriteLine(result);	
}

}

    }
}
