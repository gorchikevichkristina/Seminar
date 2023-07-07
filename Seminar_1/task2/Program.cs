// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Введите первое число: "); //Приглашение пользователя ко вводу числа (вывод в терминал)
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: "); //Приглашение пользователя ко вводу числа (вывод в терминал)
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number1 * number2)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}

// System.Console.WriteLine($"Квадрат введенного числа равен: {result}");