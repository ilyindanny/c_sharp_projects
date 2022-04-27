using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {


	
int[] array = NewArray(ReadLine());

string result = "поли... что-то там";

for (int index = 0; index <= array.Length / 2; index++)
{
   if (array[index] != array[array.Length - 1 - index])
   {
      result = "не пойми что там";
	  break;
   }
}

WriteLine(result);





// метод для создания массива на основе строки из консоли

int[] NewArray(string line)
{
	int[] array = new int[line.Length];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = Convert.ToInt32(line[i].ToString());
	}
	return array;
}

    }
}
