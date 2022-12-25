int[,,] matrix = CreateMatrix(4, 4, 4, 10, 99);
PrintMatrix(matrix);





void PrintMatrix(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int l = 0; l < inArray.GetLength(2); l++)
            {
                Console.Write($"{inArray[i, j, l]}({i},{j},{l}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] CreateMatrix(int m, int n, int k, int min, int max)
{
    int[,,] matrix = new int[m, n, k];
    bool[] boolArray = new bool[100];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
               
                int temp = new Random().Next(min, max + 1);
                if (boolArray[temp] == false)
                {
                    boolArray[temp] = true;
                    matrix[i,j,l] = temp;
                }
                else while (boolArray[temp]==true)
                {
                    temp = new Random().Next(min, max + 1);
                }
                boolArray[temp] = true;
                matrix[i,j,l] = temp;
                
            }
            
        }
    }

    return matrix;
}
