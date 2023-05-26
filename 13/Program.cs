// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите техзначное число");

int number = Math.Abs(int.Parse(Console.ReadLine()));
int result;

if (number > 99) 
{
    result = number / 100;
    result = result % 10;
    Console.WriteLine($"{result}");
}
else Console.WriteLine("Третьей цифры нет");