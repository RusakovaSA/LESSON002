﻿// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число ");
int number = int.Parse(Console.ReadLine());

int num3 = number % 10;

if (num3 != 0)
{
    if (number>100)
    {
        Console.Write("Третья цифра заданного числа " + num3);
    }
    else
    {
    Console.Write("Третьей цифры нет!");
    }
}