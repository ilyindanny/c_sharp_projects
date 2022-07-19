using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

// перевод из десятичной счислительной системы в другую:

int number = int.Parse(ReadLine());
int root = int.Parse(ReadLine());

Write("number {0} in root {1} = ", number, root);
WriteLine(GetFromDec(number, root));

string GetFromDec(int n, int r)
{
	string line = "0123456789ABCDEF";
	string result = String.Empty;
		
	while(n > 0)
	{
		result = line[n % r] + result;
		n /= r;
	}
	return result;
}


// перевод в десятичную систему счисления:

string nums = "0123456789ABCDEF";
string n = "11"; // число в другой системе счисления

WriteLine("number {0} (2) in root {1} = {2}", n, 10, GetDec(n, nums, 2));


// основной метод, выполняющий перевод:

int GetDec(string n, string nums, double root)
{
	n = Inversion(n);
	int res = 0;
	
	for(int i = 0; i < n.Length; i++)
	{
		res += GetValue(n[i], nums) * Convert.ToInt32((Math.Pow(root, i)));
	}
	return res;
}


// метод, вычисляющий десятичное значение символа:

int GetValue(char n, string nums)
{
	string a = Convert.ToString(n);
	int res = 0;
	
	for(int i = 0; i < nums.Length; i++)
	{
		if(a == nums[i].ToString()) res = i;
	}
	return res;
}


// метод, разворачивающий строку с числом:

string Inversion(string n)
{
	string res = String.Empty;
	foreach(var i in n)
	{
		res = i + res;
	}
	return res;
}


    }
}

