// Write last digit from any numder

Console.WriteLine("Enter number: ");
int UserNumber = int.Parse(Console.ReadLine() ?? "0");

int result = UserNumber % 10;
Console.WriteLine($"last digit is: {result}");