// is one a multiple of four?


Console.WriteLine("input smaller digit: ");
int SmallerDigit = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("input larger digit: ");
int LargerDigit = int.Parse(Console.ReadLine() ?? "0");



// Find if LargerDigit is biger than SmallerDigit:

if (LargerDigit < SmallerDigit) Console.WriteLine("First enter smaller digit and than larger. Restart the program");


// code:

int Result = LargerDigit % SmallerDigit;

if (Result == 0) Console.WriteLine($"{SmallerDigit} is a multiple of {LargerDigit}");
else
{
    Console.WriteLine($"{SmallerDigit} is NOT a multiple of {LargerDigit}. The remainder is {Result}");
}