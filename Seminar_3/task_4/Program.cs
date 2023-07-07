Math.Pow(5, 4); //Возведение в степень
Math.Sqrt(8); // Взятие квадратного корня
Math.Round(14.774253252, 3); // Округление числа

int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(", "), int.Parse); //Заполняем массив при помощи строки
System.Console.WriteLine(string.Join(" | ", numbers)); // Вывод массива через string.Join

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите коорднаты первой точки через пробел");
int [] fp = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // Split по умолчанию считает за разделитель пробел или " . "

System.Console.WriteLine("Введите коорднаты второй точки");
int [] sp = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(fp[0] - sp[0], 2) + Math.Pow(fp[1] - sp[1], 2) ), 3 ) );