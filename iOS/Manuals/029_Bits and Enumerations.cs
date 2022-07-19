using System;
using static System.Console;

enum DayOfWeek
	{
		Sunday,
		Monday,
		Tuesday,
		Wednesday,
		Friday,
		Saturday
	}

public class Program
{
    static public void Main ()
    {
// биты и перечисления. "упаковака" и "распаковка". булевы операторы с целыми числами.


// булевы операторы сравнивают побайтово:

int i1 = 1100;
int i2 = 1110;
WriteLine("{0, 16}", Convert.ToString(i1, 2));
WriteLine("{0, 16}", Convert.ToString(i2, 2));

WriteLine
	("And  {0, 11:X}\nOr:  {1, 11:X}\nXor: {2, 11:X}",
	Convert.ToString(i1 & i2, 2), 
	Convert.ToString(i1 | i2, 2),
	Convert.ToString(i1 ^ i2, 2)
	);

// добавление байта и извлечение в переменную boolean:

string str = "10000001";
int data = Convert.ToInt32(str, 2);

str = "100000";
int parameter = Convert.ToInt32(str, 2);

data |= parameter;
bool bParameter = (data & parameter) != 0; // это называется "проверка бита". обязательно оператор И в скобках (у него приоритет ниже проверки на неравенство)

WriteLine
	("{0, 16} data\n{1, 16} bool",
	Convert.ToString(data, 2), bParameter
	);

// а вот запись в data на основании значения bool:

bParameter = false;

data = bParameter ? data | parameter : data ^ parameter; // но предлагается выполнить оператор И между data и 0x7FFFFFDF (это везде единицы, кроме нуля в нужном месте и в начале на месте знакового бита), тогда запишется нуль в нужном месте

WriteLine
	("{0, 16} data\n{1, 16} bool",
	Convert.ToString(data, 2), bParameter
	);
	
	// еще вариант — использование унарного оператора побитового дополнения, который инвертирует каждый бит ~
	
	bParameter = true;
	data &= bParameter ? ~parameter : 0;
	WriteLine
	("{0, 16} data\n{1, 16} bool",
	Convert.ToString(data, 2), bParameter
	);
	
	
	
	//в итоге слелующее получется:
	
	str = "100000";
	parameter = Convert.ToInt32(str, 2);
	
	data &= ~parameter; // удаляет бит
	data |= parameter; // добавляет бит
	data ^= parameter; // инвертирует бит
	
	
	
	// сдвиг (выполняется побитово). сдвиг на 1 означает деление или умножение на 2, потому что один битовый разряд это степень двойки. приоритет сдвига выше догических операторов:
	
	// сдвиг вправо на сеьм бит:
	
	data = data >> 7;
	
	// влево на семь бит:
	
	data = data << 7;
	
	// следующий код выполняет сдвиг единицы влево (количество передано переменной parameter):
	
	parameter = 3;
	data |= (1 << parameter);
	
	
	// упаковка даты в переменную и распаковка:
	
int iYear = 47;
int iMonth = 12;
int iDay = 31;

int iDate = (iYear << 9) | (iMonth << 5) | (iDay);

int monthMask = Convert.ToInt32("1111", 2); // эта переменная для того, чтобы не подставлять маску-число 0xF
int dayMask = Convert.ToInt32("11111", 2); // эта переменная для того, чтобы не подставлять маску-число 0x1F

WriteLine(iDate >> 9);
WriteLine(iDate >> 5 & monthMask);
WriteLine(iDate & dayMask); // вместо переменной можно сразу конвертировать строчку, с конвертацией из двузначного формата: Convert.ToInt32("11111", 2)

	
	
	
	// перечисления (объявляются обычно вне класса):
	
	/*
	enum DayOfWeek
	{
		Sunday,
		Monday,
		Tuesday,
		Wednesday,
		Friday,
		Saturday
	}
	*/
	
	// если переменной нужно присвоить значение перечисления, то переменную объявляют как тип с именнм именного этого пересисления:
	
	//DayOfWeek nDay = DayOfWeek.Friday;
	
	// или так: 
	
	DayOfWeek nDay = (DayOfWeek) 0; // тут приведение целой "0" к типу DayOfWeek
	
	// можно и наоборот, привести член перечисления к целочисленному типу:
	
	int intDay = (int) DayOfWeek.Saturday;
	
	// метод, проверяющий, является ли 
	
	bool BoolMethod (DayOfWeek nDay)
	{
		return nDay == DayOfWeek.Monday | nDay == DayOfWeek.Tuesday;
	}
	WriteLine(BoolMethod(nDay));
	
	
	// или наоборот, привести перечисление к целому:
	
	// (int) DayOfWeek.Wednesday;
	
	
	
    }
}
