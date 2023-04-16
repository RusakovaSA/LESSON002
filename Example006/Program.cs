// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.Write("Случайное трехзначное число ");
Console.WriteLine(number);
int num1 = number / 100;
int num3 = number % 10;
Console.Write("Первая и последняя цифры числа образуют число ");
Console.WriteLine($"{num1}{num3}");
