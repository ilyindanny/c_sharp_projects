// is it square?

Console.WriteLine("input larger digit: ");
int LargerDigit = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("input smaller digit: ");
int SmallerDigit = int.Parse(Console.ReadLine() ?? "0");

int CheckingSquare = SmallerDigit * SmallerDigit;

if(LargerDigit == CheckingSquare)
{
    Console.WriteLine("Ok, digit {0} is square of digit {1}", LargerDigit, SmallerDigit);
}
Console.WriteLine("Not, digit {0} isn't square of digit {1}", LargerDigit, SmallerDigit);