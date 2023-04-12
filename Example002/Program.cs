// Найти максимальное значение из 9, путем перебора тройками значений.

int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 4, 3, 4444, 33, 666666, 55, 9, 72, 88 };

int result = max(
    max(array[0], array[1], array[3]),
    max(array[4], array[5], array[6]),
    max(array[6], array[7], array[8])
    );
Console.Write("Максимальное значение из списка ");
Console.WriteLine(result);