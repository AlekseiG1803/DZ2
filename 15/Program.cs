﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите день недели");

int number = int.Parse(Console.ReadLine());

if (number > 0 & number < 8)
{
    if (number == 6 || number == 7) 
    {
        Console.WriteLine("Выходной");
    }
    else Console.WriteLine("Не выходной");
}
else Console.WriteLine("Нет такого дня");