//
/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

7 -> 28

4 -> 10

8 -> 36

*/

Console.WriteLine("input num");
Console.WriteLine(Summa(Convert.ToInt32(Console.ReadLine())));

int Summa(int number)
{
	int sum = 0;
	for (int i = 0; i < number; i++)
	{
		sum += i;
	}
	return sum;
}


/*
Console.Write("Введите А: ");
Console.WriteLine(Summa(int.Parse(Console.ReadLine())));


int Summa(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
*/
