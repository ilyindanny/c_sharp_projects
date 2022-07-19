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
	double result;
	double dTemp;
	string sTemp = String.Empty;
	string sT = String.Empty;

	for (int i = 0; i < line.Length; i++)
	{
		try
		{
			sT += Convert.ToString(Double.Parse(line[i].ToString()));
			
		}
		catch (Exception exc)
		{
			continue;
		}
		
		
	}
	try
	{
		result = Double.Parse(sT);
	}
	catch
	{
		result = Double.NaN;
	}
	return result;
}
	}
}
