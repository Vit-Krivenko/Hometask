Console.WriteLine("Введите размер заполняемого квадратного массива");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[n, n];
PrintMatrix(FillSpiralMatrix(array, n));


int[,] FillSpiralMatrix(int[,] array, int n)
{
    int k = 1;
    int i = 0;
    int j = 0;
    int p = 0;
    while (p < n / 2 + 2)
    {

        while (j < n)
        {

            array[i, j] = k;
            k++;
            j++;

        }
        i = p + 1;
        int l = n - 1;
        while (i < n)
        {
            array[i, l] = k;
            k++;
            i++;
        }
        i = n - 1;
        j = j - 1;
        while (j > p)
        {
            array[i, j] = k;
            k++;
            j--;

        }


        while (i > p)
        {
            array[i, j] = k;
            k++;
            i--;
        }
        i = i + 1;
        j = j + 1;

        n = n - 1;
        p++;
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
