// probability theory

int mNum = 39;
double index = 0;
int indexLittle = 0;

double indexTimes = 0;

while (indexTimes < 100000)
{
	indexLittle = 0;
	int current = new Random().Next(0, 1000);
	while (mNum != current)
	{
		current = new Random().Next(0, 1000);
		index += 1;
		indexLittle += 1;
	}
	Console.Write(indexLittle + " ");

	indexTimes += 1;
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("index all =" + index);
Console.WriteLine("times " + indexTimes);
Console.WriteLine("probability " + index / indexTimes);

