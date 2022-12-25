int[,] matrix = CreateMatrix(4, 3, 0, 10);
PrintMatrix(matrix);
Console.Write($"Наименьшая сумма элементов в строке № {FindRowMinSum(matrix)} ");



int FindRowMinSum(int[,] array)
{
    int minSum = 0;
    int number = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        if (i == 0)
        {
            minSum = sum;

        }
        else if (sum < minSum)
        {
            number = i + 1;
            minSum = sum;
        }


    }

    return number;
}


void PrintMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }

    return matrix;
}