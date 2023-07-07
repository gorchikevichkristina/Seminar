// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите коорднаты первой точки через пробел");
int [] fp = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // Split по умолчанию считает за разделитель пробел или " . "

System.Console.WriteLine("Введите коорднаты второй точки");
int [] sp = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

//System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(fp[0] - sp[0], 2) + Math.Pow(fp[1] - sp[1], 2) ), 3 ) );

int point1 = (int)Math.Pow(fp[0] - sp[0], 2);
int point2 = (int)Math.Pow(fp[1] - sp[1], 2);

System.Console.WriteLine(Math.Round(Math.Sqrt(point1 + point2), 3));