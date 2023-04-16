// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да

Console.WriteLine("Введите любое число от 1 до 7.");
int numberDay = int.Parse(Console.ReadLine());

switch (numberDay)
{
    case 1:
        Console.Write("Понедельник не выходной день((");
        break;
    case 2:
        Console.Write("Вторник не выходной день((");
        break;
    case 3:
        Console.Write("Среда не выходной день((");
        break;
    case 4:
        Console.Write("Четверг не выходной день((");
        break;
    case 5:
        Console.Write("Пятница не выходной день((");
        break;
    case 6:
        Console.Write("Суббота это ВЫХОДНОЙ день!!!");
        break;
    case 7:
        Console.Write("Воскресение это ВЫХОДНОЙ день!!!");
        break;
}
