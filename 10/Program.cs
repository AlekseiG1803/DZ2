// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите техзначное число");

int number = Math.Abs(int.Parse(Console.ReadLine()));
int result;

if (number < 1000 & number > 99) 
{
    result = number / 10;
    result = result % 10;
    Console.WriteLine($"{result}");
}
else Console.WriteLine("Вы ввели не трехзначное число");