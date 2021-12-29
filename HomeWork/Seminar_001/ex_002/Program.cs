// What day is it?

Console.WriteLine("input number of day of week: ");
int NumberOfWeek = int.Parse(Console.ReadLine() ?? "0");
string NameOfDay = "0";

if (NumberOfWeek == 1) NameOfDay = "Monday";
if (NumberOfWeek == 2) NameOfDay = "Tuesday";
if (NumberOfWeek == 3) NameOfDay = "Thursday";
if (NumberOfWeek == 4) NameOfDay = "Wednsday";
if (NumberOfWeek == 5) NameOfDay = "Friday";
if (NumberOfWeek == 6) NameOfDay = "Saturday";
if (NumberOfWeek == 7) NameOfDay = "Sunday";

Console.Write("{1}-th day of week is {0}", NameOfDay, NumberOfWeek);