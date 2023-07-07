// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (i <= number)
// {
//     System.Console.WriteLine(Math.Pow(i , 2) + " ");
//     i++;
// }

for (int i = 1; i <= number; i++) // счетчик объявляем сразу, отдельно переменную не создаем
{
    System.Console.WriteLine(Math.Pow(i , 2) + " ");
}