// Final test work

using System;
using static System.Console;
class Program
{
	static void Main()
	{
		string[] startArray = { "hello", "2", "world", ":-)" };

		string[] newArray = GetNewArray(GetCounter(startArray), startArray);

		WriteLine("[ {0} ]", String.Join(", ", startArray));
		WriteLine("[ {0} ]", String.Join(", ", newArray));

		int GetCounter(string[] arr)
		{
			int counter = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i].Length <= 3) counter++;
			}
			return counter;
		}

		string[] GetNewArray(int counter, string[] arr1)
		{
			string[] arr2 = new string[counter];
			for (int i = 0, j = 0; i < arr1.Length; i++)
			{
				if (arr1[i].Length <= 3)
				{
					arr2[j] = arr1[i];
					j++;
				}
			}
			return arr2;
		}
	}
}