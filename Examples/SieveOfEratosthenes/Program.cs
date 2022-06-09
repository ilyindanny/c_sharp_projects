// SieveOfEratosthenes

using System;
using static System.Console;
using System.Linq;
class Program
{
	static void Main()
	{
		WriteLine("Enter max number");
		int iMax = Int32.Parse(ReadLine()!);
		bool[] abIsPrime = new bool[iMax + 1];

		// инициализация массива значением true:

		for (int i = 0; i <= iMax; i++)
		{
			abIsPrime[i] = true;
		}

		// отсеивание. из двух делителей только один может быть больше квадратного корня из максимума, иначе произведение превысит максимум. поэтому первый делитель ограничен квадратным корнем из максимума, а второй частным от деления максимума на первый делитель:

		for (int i = 2; i * i <= iMax; i++)
			if (abIsPrime[i])
				for (int j = 2; j <= iMax / i; j++)
					abIsPrime[i * j] = false;

		// вывод в консоль (выводится индекс, а не значение ячейки):

		for (int i = 2; i <= iMax; i++)
		{
			if (abIsPrime[i]) Write("{0} ", i);
		}

	}
}