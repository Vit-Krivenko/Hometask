Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);
PrintNumber(n);


void PrintNumber(int n)
{
    if (n == 1)
    {
        Console.Write("1 ");
        return;
    }
    Console.Write(n + ", ");
    PrintNumber(n - 1);

}