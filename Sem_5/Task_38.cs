Console.WriteLine("Введите размер массива");
int sizeArray = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижний предел массива");
double minArray = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхний предел массива");
double maxArray = double.Parse(Console.ReadLine()!);
double[] array = GenArray(sizeArray, minArray, maxArray);
PrintArray(array);
Console.WriteLine("Разница между максимальным и минимальным элементами массива : " + Difference(array));



double[] GenArray(int n, double min, double max)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*(max-min)+min,2) ;
    }
    return array;
}

void PrintArray(double[] array)
{
 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double Difference(double[] array)
{
    double minElement = array[0];
    double maxElement = array[0];
    double diffMaxMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>maxElement)
        {
            maxElement = array[i];
        }
        else if (array[i]<minElement)
        {
            minElement = array[i];
        }
    }
    diffMaxMin = maxElement - minElement;
    return diffMaxMin;
}