// Вывести большее число из двух?

/*

взять первое число из консоли.
взять второе число из консоли.
если второе число является квадратом первого, напиши мне "да", иначе напиши мне "нет".

*/


// int GGG = int.Parse(Console.ReadLine());




Console.WriteLine("input first digit:");
string input_first = Console.ReadLine();
Console.WriteLine("input second digit:");
string input_second = Console.ReadLine();


int digit_first = Int32.Parse(input_first);
int digit_second = Int32.Parse(input_second);


if (digit_first == digit_second * digit_second)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}