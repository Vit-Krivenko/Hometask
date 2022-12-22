Console.WriteLine("Введите первую позицию элемента");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую позицию элемента");
int y = int.Parse(Console.ReadLine()!);
int[,] newMatrix = Create2DArray(4, 4, -10, 10);
Print2DArray(newMatrix);
if (x < newMatrix.GetLength(0) && y < newMatrix.GetLength(1) && x >= 0 && y >= 0)
{
    Console.WriteLine("Искомый элемент " + ElementXY(newMatrix, x, y));
}
else
{
    Console.WriteLine("Элемента с заданными позициями в массиве не существует");
}



int ElementXY(int[,] matrix, int m, int n)
{
    return matrix[m, n];
}

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
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
