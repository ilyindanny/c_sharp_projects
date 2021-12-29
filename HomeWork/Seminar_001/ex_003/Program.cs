// Write all numders from -n to N


Console.WriteLine("input number smaller than 0: ");
int SmallerNumber = int.Parse(Console.ReadLine() ?? "0");

while (SmallerNumber >= 0)
{
    Console.WriteLine("input number smaller than 0: ");
    SmallerNumber = int.Parse(Console.ReadLine() ?? "0");
}


Console.WriteLine("input a number larger than 0: ");
int LargerNumber = int.Parse(Console.ReadLine() ?? "0");

while (LargerNumber <= 0)
{
    Console.WriteLine("input a number larger than 0: ");
    LargerNumber = int.Parse(Console.ReadLine() ?? "0");
}

int count = LargerNumber;
int current = SmallerNumber;

while (current <= count)
{
    Console.Write("{0}, ", current);
    current++;
}