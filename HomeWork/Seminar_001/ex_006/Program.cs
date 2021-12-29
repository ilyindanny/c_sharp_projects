// Write larger digit from any numder

Console.WriteLine("Enter number (from 10 to 99): ");
int UserNumber = int.Parse(Console.ReadLine() ?? "0");


int FirstNum = UserNumber / 10;
int SecondNum = UserNumber % 10;

if (FirstNum == SecondNum) Console.WriteLine("two digit are same");
else
{
    if (FirstNum > SecondNum) Console.WriteLine($"The best digit is {FirstNum}");
    else
    {
        Console.WriteLine($"The best digit is {SecondNum}");
    }
}