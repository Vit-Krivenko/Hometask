Console.WriteLine("Введите количество вводимых чисел");
int M = int.Parse(Console.ReadLine()!);
int[] array = new int[M];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число");
    array[i] = int.Parse(Console.ReadLine()!);
}
PrintArray(array);
Console.WriteLine("Количество введеных чисел больше 0 : " + numberPlus(array));

int numberPlus(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            number++;
        }
    }
    return number;
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}