// More information about array:



void FillArray (int [] AnyArrayName)
{
    int length = AnyArrayName.Length;
    int index = 0;

    while (index < length)
    {
        AnyArrayName[index] = new Random().Next(1, 1440);
        index++;
    }
}


void PrintArray (int [] OtherAnyArrayName)
{
    int count = OtherAnyArrayName.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(OtherAnyArrayName[position]);
        position++;
    }
}

int [] array = new int [10];

FillArray(array);
PrintArray(array);