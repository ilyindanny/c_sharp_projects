using System;
using static System.Console;
using System.Linq;
public class Program
{
    static public void Main ()
    {


int[] array = {9, 9, 9, 4, 4, 4, 3, 3, 3, 1};


int temp = 1;
string strCount = String.Empty;
string strNum = String.Empty;
int i;
for(i = 0; i < array.Length - 1; i++)
{
	if (array[i] == array[i + 1])
	{
		temp++;
	}
	else
	{
		strCount += temp + " ";
		strNum += array[i] + " ";
		temp = 1;	
	}	
}
strCount += temp + " ";
strNum += array[i] + " ";

int[] array1 = strCount.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();

int[] array2 = strNum.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();



//int[] array1=array.Select(x=>x*-1).ToArray();

PrintArray(array1, array2);


void PrintArray(int[] array1, int[] array2)
{
	for(int i = 0; i < array1.Length; i++)
	{
	WriteLine("{1, 3} is founded {0, 3} times", array1[i], array2[i]);
	}
}
    }
}
