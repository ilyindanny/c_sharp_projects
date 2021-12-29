// Delete the second digit of a three-digit number

Console.WriteLine("Enter three-digit number: ");
int UserNumber = int.Parse(Console.ReadLine() ?? "0");

// use "while" to find if it is realy a three-digit number:

int itsUserNumber = UserNumber;
int count = 0;

while (itsUserNumber > 0)
{
    itsUserNumber = itsUserNumber / 10;
    count++;
}


// remove second digit:

if (count == 3)
{
    int FirstDig = UserNumber / 100;
    int ThirdDig = UserNumber % 10;
    Console.WriteLine($"second digit was deleted. result: {FirstDig}{ThirdDig}");
}
else
{
    Console.WriteLine("it isn't three-digit number. restart the program");
}