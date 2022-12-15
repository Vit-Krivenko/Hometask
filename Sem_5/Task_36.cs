Console.WriteLine("Введите размер массива");
int sizeArray = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижний предел массива");
int minArray = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхний предел массива");
int maxArray = int.Parse(Console.ReadLine()!);
int[] array = GenArray(sizeArray, minArray, maxArray);
PrintArray(array);
Console.WriteLine("Сумма элементов стоящих на нечетных позициях : "+ sumElements(array));



int[] GenArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int sumElements(int[] array)
{
    int sum = array[1];
    for (int i = 3; i < array.Length; i++)
    {
       if (i%2 == 1)
       {
        sum +=array[i]; 
       }
       
    }
    return sum;
}