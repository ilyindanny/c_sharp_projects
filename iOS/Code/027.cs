using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {
		Date day = new Date();
		day.iDay = 23;
		day.iMonth = 10;
		day.iYear = 1982;
		
		WriteLine("{0}, {1}", day, day.DayOfYear());
		
    }
}

struct Date
{
	public int iDay;
	public int iMonth;
	public int iYear;
	
	public static bool IfLeapYear(int iYear)
	{
		return iYear % 4 == 0 && (iYear % 100 != 0 || iYear % 400 == 0) ? true : false;
	}
	
	static int[] numOfDays = {0, 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334};
	
	public int DayOfYear()
	{
		return numOfDays[iMonth] + iDay + (iMonth > 2 && IfLeapYear(iYear) ? 1 : 0);
	}
	
	static string[] nameOfMonth = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
	
	public override string ToString()
	{
		return String.Format("{0} {1} {2}", iDay, nameOfMonth[iMonth - 1], iYear);
	}
	
}