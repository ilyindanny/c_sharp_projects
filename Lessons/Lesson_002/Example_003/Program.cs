// More information about array and methods:


// Method to put sume cosuale numbers to array.

void FillArray(int[] NameArray)
{
    int length = NameArray.Length;
    int index = 0;

    while (index < length)
    {
        NameArray[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] NameArray)
{
    int count = NameArray.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(NameArray[position]);
        position++;
    }
}


int IndexOf(int[] NameArray, int NumberWeFind)
{
    int length = NameArray.Length;
    int index = 0;
    int position = -1;

    while (index < length)
    {
        if (NameArray[index] == NumberWeFind)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
int NumberThatWeFind = 7;

FillArray(array);

PrintArray(array);

Console.WriteLine();

int answer = IndexOf(array, NumberThatWeFind);

Console.Write("your number \""); Console.Write(NumberThatWeFind); Console.Write("\" is in this position: ");
Console.Write(answer);
Console.WriteLine();
Console.WriteLine();


