Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
double[,] newMatrix = Create2DArray(m, n, -10, 10);
Print2DArray(newMatrix);
Console.WriteLine("Среднее арифметическое каждого столбца");
PrintArray(ArithmeticMean(newMatrix));


double[] ArithmeticMean(double[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }

        array[i] = Math.Round(sum / matrix.GetLength(0), 2);
        sum = 0;
    }
    return array;
}


double[,] Create2DArray(int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write(matrix[i] + " ");
    }
    Console.WriteLine();
}
