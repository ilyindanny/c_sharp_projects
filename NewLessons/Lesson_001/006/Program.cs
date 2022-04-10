// Triangle of Serpinsky


///Console.SetCursorPosition(10, 4);
///Console.WriteLine("+");


Console.Clear();


int Ax = 21, Ay = 1,
    Bx = 1, By = 21,
    Cx = 41, Cy = 21;


/*

Console.SetCursorPosition(Ax, Ay);
Console.WriteLine("+");
Console.SetCursorPosition(Bx, By);
Console.WriteLine("+");
Console.SetCursorPosition(Cx, Cy);
Console.WriteLine("+");

*/


int x = Ax, y = Ay;  //It's the first point to start. You can choose either point for that.

int count = 0;

while (count < 4000)
{
    int RandomPoint = new Random().Next(0, 3);
    if (RandomPoint == 0)
    {
        x = (x + Ax) / 2;
        y = (y + Ay) / 2;
    }
    if (RandomPoint == 1)
    {
        x = (x + Bx) / 2;
        y = (y + By) / 2;
    }
    if (RandomPoint == 2)
    {
        x = (x + Cx) / 2;
        y = (y + Cy) / 2;

    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;

}

int CountForSpace = 0;
while (CountForSpace < 12)
{
    Console.WriteLine(" ");
    CountForSpace++;
}
