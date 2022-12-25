int[,] matrix1 = CreateMatrix(4, 5, 0, 5);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrix(5, 4, 0, 5);
PrintMatrix(matrix2);
Console.WriteLine();
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    PrintMatrix(MultipliesMatrix(matrix1, matrix2));
}
else
{
    Console.WriteLine("Умножение матриц невыполнимо");
}



int[,] MultipliesMatrix(int[,] array1, int[,] array2)
{
    int row = array1.GetLength(0);
    int column = array2.GetLength(1);
    int[,] MultiArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            MultiArray[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                MultiArray[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return MultiArray;
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