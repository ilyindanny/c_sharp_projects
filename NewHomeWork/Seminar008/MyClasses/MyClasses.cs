namespace MyClasses;
using System;
using static System.Console;
public class MyMethods
{
	/// <Summary>
	/// удаление столбца и строки, пересекающихся с координатами минимального числа
	///</Summary>
	/// <param> name="array"> двумерный массив</param>
	/// <param> name="coord"> одномерный массив</param>
	/// <returns>новый массив с удаленными строкой и столбцом</returns>
	public static int[,] DeleteRowAndColumn(int[,] array, int[] coord)
	{
		int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
		int k = 0;
		int l = 0;

		for (int i = 0; i < array.GetLength(0); i++)
		{
			if (i != coord[0])
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (j != coord[1])
					{
						newArray[k, l] = array[i, j];
						l++;
					}
				}
				l = 0;
				k++;
			}
		}
		return newArray;
	}


	/// <Summary>
	/// поиск минимального (первого попавшегося)
	///</Summary>
	/// <param> name="array"> одномерный массив</param>
	/// <returns>массив с координатами минимального числа</returns>
	public static int[] FindMin(int[,] array)
	{
		int[] coord = { 0, 0 };
		int min = array[coord[0], coord[1]];

		for (int i = 0; i < array.GetLength(0) - 1; i++)
		{
			for (int j = 0; j < array.GetLength(1) - 1; j++)
			{
				if (array[i, j] < min)
				{
					coord[0] = i;
					coord[1] = j;
					min = array[coord[0], coord[1]];
				}
			}
		}
		return coord;
	}


	/// <Summary>
	/// создать строку с количеством повторений цифр
	///</Summary>
	/// <param> name="array"> одномерный массив</param>
	/// <returns>строка с счетчиком количества цифр</returns>
	public static string GetStringCount(int[] array)
	{
		int temp = 1;
		string strCount = String.Empty;
		int i = 0;
		while (i < array.Length - 1)
		{
			if (array[i] == array[i + 1])
			{
				temp++;
			}
			else
			{
				strCount += temp + " ";
				temp = 1;
			}
			i++;
		}
		strCount += temp + " ";
		return strCount;
	}


	/// <Summary>
	/// создать строку с перечнем цифр
	///</Summary>
	/// <param> name="array"> одномерный массив</param>
	/// <returns>строка с перечнем цифр</returns>
	public static string GetStringNum(int[] array)
	{
		int temp = 1;
		string strNum = String.Empty;
		int i = 0;
		while (i < array.Length - 1)
		{
			if (array[i] != array[i + 1])
			{
				strNum += array[i] + " ";
			}
			i++;
		}
		strNum += array[i] + " ";
		return strNum;
	}


	/// <Summary>
	/// сортировка в двух массивах
	///</Summary>
	/// <param> name="countArray"> одномерный массив</param>
	/// <param> name="numArray"> одномерный массив</param>
	public static void SortTwoArrays(int[] countArray, int[] numArray)
	{
		int max;
		int temp;
		for (int i = 0; i < countArray.Length; i++)
		{
			max = i;
			for (int j = i + 1; j < countArray.Length; j++)
			{
				if (countArray[j] > countArray[max]) max = j;
			}
			temp = countArray[i];
			countArray[i] = countArray[max];
			countArray[max] = temp;
			temp = numArray[i];
			numArray[i] = numArray[max];
			numArray[max] = temp;
		}
	}


	/// <Summary>
	/// группировка одинаковых чисел
	///</Summary>
	/// <param> name="array"> одномерный массив</param>
	public static void SortArray(int[] array)
	{
		int max;
		int temp;
		for (int i = 0; i < array.Length; i++)
		{
			max = i;
			for (int j = i + 1; j < array.Length; j++)
			{
				if (array[j] > array[max]) max = j;
			}
			temp = array[i];
			array[i] = array[max];
			array[max] = temp;
		}
	}


	/// <Summary>
	/// преобразование двумерного массива в одномерный
	///</Summary>
	/// <param> name="array"> двумерный массив</param>
	/// <returns>одномерный массив</returns>
	public static int[] TransformArray(int[,] array)
	{
		int[] transformedArray = new int[array.GetLength(0) * array.GetLength(1)];
		int index = 0;
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				transformedArray[index] = array[i, j];
				index++;
			}
		}
		return transformedArray;
	}


	/// <Summary>
	/// замена первой и последней строки внутри массива
	///</Summary>
	public static void ChangeArray(int[,] array)
	{
		int temp = 0;
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[0, j] = array[array.GetLength(0) - 1, j];
			array[array.GetLength(0) - 1, j] = temp;
		}
	}


	/// <Summary>
	/// замена внутри существующего массива. проверка на равенство сторон
	///</Summary>
	public static void TurnArray(int[,] array)
	{
		int length = 0;
		if (array.GetLength(0) == array.GetLength(1))
		{
			length = array.GetLength(0);
			int temp = 0;
			for (int i = 0; i < length; i++)
			{
				for (int j = i; j < length; j++)  // а еще будет работать, если сделать j=0; j < i
				{
					temp = array[i, j];
					array[i, j] = array[j, i];
					array[j, i] = temp;
				}
			}
		}
		else
		{
			WriteLine("cannot turn");
		}
	}


	/// <Summary>
	/// замена с созданием нового массива. проверка на равенство сторон не нужна
	///</Summary>
	public static int[,] TurnArrayToNew(int[,] array)
	{
		int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				newArray[j, i] = array[i, j];
			}
		}
		return newArray;
	}


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
	/// Печать двумерного массива
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


	/// <Summary>
	/// Печать одномерного массива
	///</Summary>
	public static void PrintArray(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			Write("{0, 5}", array[i] + " ");
		}
	}

	/// <Summary>
	/// Печать двух массивов
	///</Summary>
	public static void PrintArray(int[] array1, int[] array2)
	{
		for (int i = 0; i < array1.Length; i++)
		{
			WriteLine("{1, 3} is founded {0, 3} times", array1[i], array2[i]);
		}
	}
}
