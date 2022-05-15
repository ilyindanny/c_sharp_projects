/*
commands:
в папке Seminar001: dotnet new sln -o Tasks (создает папку Tasks и в ней файл Tasks)
Потом в папке Tasks создать папку MyClasses и в ней выполнить: dotnet new classlib (будет создан новый файл шаблона, который нужно переименовать)
в папке Tasks: dotnet sln Tasks.sln add .\MyClasses\MyClasses.csproj
потом нужно создать папку с программой (создается в папке Tasks в данном случае)
потом в папке Tasks: dotnet sln Tasks.sln add .\Classes\Classes.csproj (это тоже добавляет проект в Tasks)
потом команда добавления ссылки на проект с методами: dotnet sln Tasks.sln add .\Classes\Classes.csproj
*/


namespace MyClasses;
using System;
using static System.Console;
public class MyExample
{

	public static int[,] GetArray(int rows, int columns, int min, int max)
	{
		int[,] array = new int[rows, columns];
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				array[i, j] = new Random().Next(min, max);
			}
		}
		return array;
	}

	public static void PrintArray(int[,] array)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				Write("{0, 5}", array[i, j] + " ");
			}
			WriteLine();
		}
	}
}


