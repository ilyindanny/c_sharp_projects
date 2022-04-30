using System;

public class Program
{
	static public void Main()
	{

		string n = "bunny";
		Console.WriteLine("hi, " + n + "!");

		string firstFriend = "Maria";
		string secondFriend = "Sage";
		Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

		Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
		Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");



		string test = Console.ReadLine();
		string test2 = test.ToLower();
		int len = test.Length;
		Console.WriteLine($"The word {test2} has {len} latters.");



		string greeting = "      Hello World!       ";
		Console.WriteLine($"[{greeting}]");

		string trimmedGreeting = greeting.TrimStart();
		Console.WriteLine($"[{trimmedGreeting}]");

		trimmedGreeting = greeting.TrimEnd();
		Console.WriteLine($"[{trimmedGreeting}]");

		trimmedGreeting = greeting.Trim();
		Console.WriteLine($"[{trimmedGreeting}]");



		string sayHello = "Hello World!";
		Console.WriteLine(sayHello);
		sayHello = sayHello.Replace("Hello", "Greetings");
		Console.WriteLine(sayHello);

	}
}
