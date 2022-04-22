/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4  -> 24
5  -> 120
*/

Console.Write("Введите А: ");
Console.WriteLine(Product(int.Parse(Console.ReadLine())));


int Product(int number)
{
	int prod = 1;
	for (int i = 1; i <= number; i++)
	{
		prod *= i; // prod = prod * i;
	}
	return prod;
}


// 1*2*3*4*5