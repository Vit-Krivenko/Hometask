Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Сумма между m и n включительно составляет " + SummBetweenNumbers(m, n));


int SummBetweenNumbers(int a, int b)
{
    if (a == b)
    {
        return a;
    }
    else
    {
        return a + SummBetweenNumbers(a + 1, b);
    }
}