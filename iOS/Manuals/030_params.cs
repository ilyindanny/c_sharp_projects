using System;
using static System.Console;
using System.Linq;
public class Program
{
    static public void Main ()
    {
		
// дополнительная информация по массивам

// вот способ передать методу в качестве аргумента массив сразу из консоли (из консоли вводятся цифры через запятую без пробелов):
	

WriteLine(Average(ReadLine().Split(",").Select(item => Convert.ToDouble(item)).ToArray()));
	   
double Average(double[] array) // это просто метод, возвращающий среднеарифметическое
	{
		double temp = 0;
		foreach (double i in array)
			{
				temp += i;
			}
			return temp / array.Length;
	}
	
	
	// ключевое слово params указанное в параметре метода, позволяет при вызове метода в в качестве аргумента вводить сразу числа или переменные. в следующем примере в качестве одного из аргументов после запятой указан метод:
	

WriteLine(Average2(1,2,3,4,Average(ReadLine().Split(",").Select(item => Convert.ToDouble(item)).ToArray()),5,6,7,8,9,10));
	   
double Average2(params double[] array) 
	{
		double temp = 0;
		foreach (double i in array)
			{
				temp += i;
			}
			return temp / array.Length;
	}
	
	
	
    }
}
