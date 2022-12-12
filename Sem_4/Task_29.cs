Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число min");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число max");
int max = int.Parse(Console.ReadLine()!);

int[] array = new int[n];
FillArray(array, min, max);
PrintArray(array);

int[] FillArray(int[] collection, int from, int to)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(from, to);
    }
    return collection;
}

void PrintArray(int[] col)
{
    int length = col.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(col[i] + " ");
    }
}