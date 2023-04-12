// Рандомное заполнение массива и поиск нужного элемента массива

void FillArray(int [] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length;
    int position=0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine ();

int pos = IndexOff(array, 5);
Console.Write ("Искомая позиция имеет индекс ");
Console.WriteLine(pos);
