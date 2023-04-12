// Ищем find в массиве array

int[] array = { 1, 2, 4, 6, 77, 8, 9, 10, 77 };

int N = array.Length;
int find = 77;
int index = 0;

while (index < N)
{
    if (array[index] == find)
    {
        Console.Write("Искомая позиция ");
        Console.WriteLine(index);
        break;
    }
    index++;
}

