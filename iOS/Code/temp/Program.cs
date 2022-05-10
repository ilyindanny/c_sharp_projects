using System;

using static System.Console;

public class Program
{

	static public void Main()
	{

		// вычисление глубины шкафа при условии заданной высоты шкафа
		// вычисление расстояния по горизонтали от точки на стене до точки на дуге открывания люка (задается расстояние от потолка, то есть длинна катета по вертикали):

		double dR = 1000; // радиус дуги
		double dCathetB = 638; // катет (по вертикали)
		double dCathetA = Math.Sqrt(dR * dR - dCathetB * dCathetB); // возвращает длинну катета по горизонтали

		double dDepthSize = 400 + dR - dCathetA; // вычисление расстояния от точки на стене до точки на дуге (по горизонтали) 400 - это расстояние от стены до люка

		WriteLine("depth size of wardrobe = {0:N2}", dDepthSize);



		// вычисление необходимой высоты шкафа, при условии заданной глубины шкафа.

		dDepthSize = 630;
		dCathetA = dR + 400 - dDepthSize;
		dCathetB = Math.Sqrt(dR * dR - dCathetA * dCathetA);

		WriteLine("size from wardrobe to ceiling = {0:N2}", dCathetB);


		// вычисление угла открывания люка при условии, что петли со стороны шкафа

		dDepthSize = 630;
		dCathetB = 300;
		dCathetA = dDepthSize - 400;

		double dHypotenuse = Math.Sqrt(dCathetB * dCathetB + dCathetA * dCathetA); // вычисление гипотенузы треугольника

		// а дальше надо вычислить угол. как-то через косинусы

		WriteLine("A, B, C: {0:N2} {1:N2} {2:N2}", dCathetA, dCathetB, dHypotenuse);

		// WriteLine(Math.Cos(30 / (180 / Math.PI)));
		WriteLine((Math.Tan(0.3420) * (180 / Math.PI)));


	}
}