// Вывести название дня недели по цифре, введенной с терминала.




Console.WriteLine("input number of day of week:");

//string input = Console.ReadLine() ?? "0";
//int day = Int32.Parse(input);

int day = Int32.Parse(Console.ReadLine());

if (day == 1)
{
	Console.WriteLine("Monday");
}
if (day == 2)
{
	Console.WriteLine("Tuesday");
}
if (day == 3)
{
	Console.WriteLine("Wednesday");
}
if (day == 4)
{
	Console.WriteLine("Thursday");
}
if (day == 5)
{
	Console.WriteLine("Friday");
}
if (day == 6)
{
	Console.WriteLine("Saturday");
}
if (day == 7)
{
	Console.WriteLine("Sunday");
}

