// Вывести случайное число от 10 до 99
// Показать наибольшую цифру числа

Console.Write("Вывести случайное число от ");
int min = ReadInt();
Console.Write(" до ");
int max = ReadInt();

int number = GetRandomNumber(min, max);

Console.Write("Случайное число ");
Console.WriteLine(number);

if (GetFirstDigit(number) > GetSecondDigit(number))
{
    Console.WriteLine("Первая цифры больше второй");
}
else
{
    Console.WriteLine("Второая цифра больше первой");
}

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int GetFirstDigit(int number)
{
    return number / 10;
}

int GetSecondDigit(int number)
{
    return number % 10;
}

int ReadInt()
{
    return int.Parse(Console.ReadLine());
}
