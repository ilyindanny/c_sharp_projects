// 



Console.Write("введите число, в котором посчитать цифры: ");
int A = int.Parse(Console.ReadLine() ?? "0");

int count = 0;
int current = A;

while (current >= 1)
{
    current = current / 10;
    count++;
}


Console.WriteLine(count);

