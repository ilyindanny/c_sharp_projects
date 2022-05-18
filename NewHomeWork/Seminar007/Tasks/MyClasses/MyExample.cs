/*
commands:

создание:

**************************************************************************************************************************************************
в папке Seminar001: dotnet new sln -o Tasks (создает папку Tasks и в ней файл Tasks)

Потом в папке Tasks создать папку MyClasses и в ней выполнить: dotnet new classlib (будет создан новый файл шаблона, файл .cs можно переименовать)
**************************************************************************************************************************************************

добавление:

в папке Tasks: dotnet sln Tasks.sln add .\MyClasses\MyClasses.csproj

потом нужно создать папку с программой (создается в папке Tasks в данном случае)

потом в папке Tasks: dotnet sln Tasks.sln add  .\001\001.csproj (это добавляет проект c с программой тоже в Tasks)

потом команда добавления ссылки на проект с методами: dotnet add .\002\002.csproj reference .\MyClasses\MyClasses.csproj

при вызове методов из MyClasses необходимо подключить пространство имен директивой using MyClasses. Метод вызывается с указанием класса: MyExample.GetArray


__________________________________________________________________________________________________________________________________________________
добавление комментария к методу:
/// <Summary>
/// Создание массива от мин до макс
///</Summary>

если метод продублировать, изменить код и сохранить с новым комментарием (имя метода остается то же) то у метода появится перегрузка
__________________________________________________________________________________________________________________________________________________

*/


namespace MyClasses;
using System;
using static System.Console;
public class MyExample
{
	/// <Summary>
	/// Создание массива от мин до макс
	///</Summary>
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

	/// <Summary>
	/// Создание массива до макс
	///</Summary>
	public static int[,] GetArray(int rows, int columns, int max)
	{
		int[,] array = new int[rows, columns];
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				array[i, j] = new Random().Next(0, max);
			}
		}
		return array;
	}

	/// <Summary>
	/// Печать массива
	///</Summary>
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


