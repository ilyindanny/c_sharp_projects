// Find the third digit of number (going from left side) or write if there isn't one

Console.WriteLine("Enter some number: ");
int UserNumber = int.Parse(Console.ReadLine()!);


// use "while" to find the number of digit:


int itsUserNumber1 = UserNumber;
int count = 0;

while (itsUserNumber1 != 0)
{
	itsUserNumber1 = itsUserNumber1 / 10;
	count++;
}


// Take the third digit and write:


int itsUserNumber2 = UserNumber;

if (count < 3) Console.WriteLine("There isn't the third digit in your number");
else
{
	while (count > 3)
	{
		itsUserNumber2 /= 10;
		count -= 1;
	}
	if (itsUserNumber2 < 0) itsUserNumber2 *= -1;
	Console.Write("The third digit of your number is "); Console.Write(itsUserNumber2 % 10);
}