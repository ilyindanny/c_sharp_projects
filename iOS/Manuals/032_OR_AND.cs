using System;

using static System.Console;

public class Program
{
    static public void Main ()
    {

// условное И (&&) - если первая часть False, вторая не проверяется
// условное ИЛИ (||) - если первая часть True, вторая не проверяется

// это позволяет обойти проблемы с делением на нуль:
int i = 0;

bool b = (i > 0 && 5 / i < 3);
     b = (i == 0 || 5 / i > 3);



    }
}
