using System;

public class Program
{
    static public void Main ()
    {

Programs.Pause("overloaded"); // Перегрузили метод

Programs.Pause();


    }
}

public class Programs
{


public static void Pause() // Создали метод
{
	Console.ReadKey();
}


public static void Pause(string msg)
{
	Console.WriteLine(msg);
	Console.ReadKey();
}
}