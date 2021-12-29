// Степень


Console.Write("введите число, которое нужно возвести в степень: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("введите степень, в которую возвести: ");
int B = int.Parse(Console.ReadLine() ?? "0");

int index = 0; 
int result = 1;

while (index < B)
{
    result = result * A;
    index++;
}
Console.WriteLine(result);
