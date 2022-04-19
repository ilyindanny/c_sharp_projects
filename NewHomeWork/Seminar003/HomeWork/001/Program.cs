//
/*

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/


// first way

Console.WriteLine("input 5 digit number");
string aNum = Console.ReadLine();

if (aNum[0] == aNum[4])
{
	if (aNum[1] == aNum[3])
		Console.WriteLine("yes");
}
else
{
	Console.WriteLine("not");
}


// second way

string result = (aNum[0] == aNum[4] && aNum[1] == aNum[3]) ? "yes" : "not";

Console.WriteLine(result);