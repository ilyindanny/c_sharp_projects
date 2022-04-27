using System;

public class Program
{
    static public void Main ()
    {



// WriteLine(String.Join(", ", array(8)) );




string text = "abcde";

//на вывод текста этот метод не влияет:

Console.WriteLine(String.Join(" ", text));
Console.WriteLine(String.Join(" ", text));

string[] text2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] myArray = StringToArray(text);

print(text2);
method1(text);
method2(text);
print(myArray);



// а вот так можно начать печатать и сразу же внутри метода запустить метод создания массива, а внутри этого метода в свою очередь в качестве аргумента указать ввод с консоли:

Console.WriteLine(String.Join(" ", StringToArray(Console.ReadLine())));






// тут два метода для разделения букв в строке и вывода на печать букв с разлелителем:

// через дополнительную переменную, в которой суммируется строка и строка и пробелы:

void method1(string text)
{
	string a = String.Empty;
	for (int i = 0; i < text.Length; i++)
	{
		a += text[i] + " YES ";
	}
	text = a;
	Console.Write(text);
}


// через вывод на печать по одной ячейке с пробелом:

void method2(string text)
{
	string a = String.Empty;
	for (int i = 0; i < text.Length; i++)
	{
		Console.Write($"{text[i]}, U ");
	}
}


// печать массива:

void print(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write(array[i] + " ");
	}
	Console.WriteLine("");
}


// создание массива внутри метода (возвращающий тип метода) на основе строки, которая указывается в аргументе метода:

string[] StringToArray(string text)
{
	string[] array = new string[text.Length];
	for (int i = 0; i < text.Length; i++)
	{
		array[i] = Convert.ToString(text[i]);
	}
	return array;
}



    }
}
