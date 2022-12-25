int[,] matrix = CreateMatrix(5, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(SortMaxMinArray(matrix));



int[,] SortMaxMinArray(int[,] array)
{
    int[,] newArray2D = new int[array.GetLength(0), array.GetLength(1)];
    int[] newArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j] = array[i, j];
        }
        Array.Sort(newArray, (x, y) => y.CompareTo(x));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = newArray[j];
        }

    }

    return array;
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


