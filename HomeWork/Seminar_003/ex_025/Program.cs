// 

Console.Write("введите число: ");
int N = int.Parse(Console.ReadLine());

int index = 1;
int summ = 0;


while (index <= N)
{
    summ = summ + index;
    index++;
}
Console.WriteLine("сумма чисел от 1 до {0} - {1}", N, summ);