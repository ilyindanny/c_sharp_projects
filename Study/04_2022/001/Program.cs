// test

double FriendFirst = 3;
double FriendSecond = 4;
double Dog = 7;
int Direction = 2;
double Time = 0;
double Distance = 10000;
int count = 0;



while (Distance > 10)
{
    if (Direction == 2)
    {
        Time = Distance / (FriendSecond + Dog);
        Distance = Distance - (FriendFirst + FriendSecond) * Time;
        Direction = 1;
    }
    else
    {
        Time = Distance / (FriendFirst + Dog);
        Distance = Distance - (FriendFirst + FriendSecond) * Time;
        Direction = 2;
    }
    count++;
}


Console.WriteLine($"that is {count} times.");           //  ($"{x} text")
