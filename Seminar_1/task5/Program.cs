//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
 //456 -> 6
 //782 -> 2
 //918 -> 8

 System.Console.WriteLine("Введите трехзначное число:");
 int number1 = Convert.ToInt32(Console.ReadLine());
 if(number1 > 99 && number1 < 1000)
 {
    System.Console.WriteLine(number1 % 10);
 }
 else
 {
    System.Console.WriteLine("Введено не трехзначное число!");
 }