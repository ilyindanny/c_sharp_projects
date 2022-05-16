using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

string StringWithNum = "₽0 s2gb31 019-82:), ";
double Num = FindNumInString(StringWithNum);
Write(Num);

/// <Summary>
/// поиск в строке цифр, возвращает только цифры или NaN
/// </Summary>
double FindNumInString(string line)
{
	double result = 0;
	double dTemp = 0;
	string sTemp = String.Empty;

	for (int i = 0; i < line.Length; i++)
	{
		try
		{
			dTemp = Double.Parse(line[i].ToString());
			
		}
		catch
		{
			continue;
		}
		sTemp += Convert.ToString(dTemp);
		
	}
	try
	{
		result = Double.Parse(sTemp);
	}
	catch
	{
		result = Double.NaN;
	}
	return result;
}
	}
}
