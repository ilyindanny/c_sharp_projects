// Write second digit from any numder

Console.WriteLine("Enter number: ");
int UserNumber = int.Parse(Console.ReadLine() ?? "0");


int result = UserNumber / 10;
result = result % 10;
Console.WriteLine($"second digit is: {result}");