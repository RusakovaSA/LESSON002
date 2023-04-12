// Найти максимальное значение из 9, путем перебора тройками значений.

int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a = 4;
int b = 7;
int c = 1;
int d = 366666;
int e = 4;
int f = 15;
int g = 2;
int h = 30;
int i = 8;

// int max1 = max (a, b, c);
// int max2 = max (d, e, f);
// int max3 = max (g, h, i);
// int result = max (max1, max2, max3);

int result = max(
    max(a, b, c),
    max(d, e, f),
    max(g, h, i));

Console.Write("Максимальное значение из списка ");
Console.WriteLine(result);