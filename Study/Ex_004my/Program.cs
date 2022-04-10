// i'm trying to write


// With the methods:


void FillArray (int [] array)
{
    int N = array.Length;
    int index = 0;
    while (index < N)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
    
}

int FindMax (int [] array)
{
    int N = array.Length;
    int max = array[0];
    int index = 1;
    while (index < N)
    {
        if (array[index] > max) max = array[index];
        index++;
    }
    return max;
}


void PrintArray (int [] array)
{
    int N = array.Length;
    int index = 0;
    while (index < N)
    {
        Console.Write($"{array[index]}, ");
        index++;
    }
}


int FindNumber (int [] array, int number)
{
    int N = array.Length;
    int index = 0;
    int find = -1;
    while (index < N)
    {
        if (number == array[index])
        {
            find = index;
            break;
        }
        index++;
    }
    return find;
}




int [] array = new int [10];
int number = 5;
int max = 0;
int find = 0;


FillArray (array);
max = FindMax (array);
PrintArray (array);

Console.WriteLine();

Console.WriteLine(max);

find = FindNumber(array, number);

Console.WriteLine(find);





/*


int [] array = new int [10];
int max = array[0];


//FillArray

    int N = array.Length;
    int index = 0;
    while (index < N)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }


//Find max

    index = 1;
    while (index < N)
    {
        if (array[index] > max) max = array[index];
        index++;
    }


//Print array

    index = 0;
    while (index < N)
    {
        Console.Write($"{array[index]}, ");
        index++;
    }

    Console.WriteLine();


// FindNumber

    index = 0;
    int number = 5;
    int find = -1;
    while (index < N)
    {
        if (number == array[index])
        {
            find = index;
            break;
        }
        index++;
    }


//Print result

Console.WriteLine(max);
Console.WriteLine(find);

*/