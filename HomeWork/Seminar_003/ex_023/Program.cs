// description

Console.Write("input your digit: ");
int N = int.Parse(Console.ReadLine());

int index = 1;
Console.WriteLine("The tab of square: ");

while (index <= N)
{
    int square = index * index;
    Console.WriteLine(index + " * " + index + " = " + square);

    index++;
}