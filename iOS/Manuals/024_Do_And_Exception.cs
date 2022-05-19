using System;

using static System.Console;

public class Program
{

	static public void Main()
	{


string s;

do
{

	WriteLine("Enter num 1: ");
	decimal d1 = Decimal.Parse(ReadLine());
	WriteLine("Enter num 2: ");
	decimal d2 = Decimal.Parse(ReadLine());
	WriteLine("$ {0, 8:N2}", d1 * d2);
	WriteLine("Do you want to do another? (y/n");
	s = ReadLine().ToLower().Trim();
	
}	
	while (s.Length > 0 && s[0] == 'y');
	
	
	
	// еще пример из книги
	
	double a = Method.GetDouble("enter number");
	WriteLine(a);

	}
}

public class Method
{
static public double GetDouble(string b)
{
	double result = Double.NaN;

	do
	{
	WriteLine(b);
	try
	{
		result = Double.Parse(ReadLine().Trim());
	}
	catch
	{
		WriteLine("broken number");
	}
	}
	while (Double.IsNaN(result));
	return result;
}

}