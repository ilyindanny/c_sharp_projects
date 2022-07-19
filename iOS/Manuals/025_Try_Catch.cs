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

	for (int i = 0; i < line.Length; i++)
	{
		try
		{
			dTemp = Double.Parse(line[i].ToString());
			
		}
		catch (Exception exc) // или FormatException, OverflowException, ArgumentNullException
		{
			WriteLine(exc); // или WriteLine(exc.Message)
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


// в целом вот перечень исключений:
Write("\n \n \nnew block \n");

double el = Double.NaN;

do
{
	try  // первый блок
	{
		el = Double.Parse(ReadLine());
	}
	catch (FormatException exc)  // второй блок
	{
		WriteLine(exc.Message + "111");
		return;
	}
	catch (OverflowException exc)
	{
		WriteLine(exc. Message + "222");
	}
	catch (ArgumentNullException exc)
	{
		WriteLine(exc. Message + "333");
	}
	catch (Exception exc) // обработка любого исключения
	{
		WriteLine(exc. Message + "444");
	}
	finally  // третий блок, выполняется даже если в catch есть return
	{
		Write("text ");
	}
}
while(Double.IsNaN(el));



// исключение throw. пока непонятно, что за исключение генерируется

string line = ReadLine();
if (line == null)
throw new ArgumentNullException();


	}
}
