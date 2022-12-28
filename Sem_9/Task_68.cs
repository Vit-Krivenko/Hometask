Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Функция Аккермана для m и n " + AkkermanFunction(m, n));



int AkkermanFunction(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if ((a != 0) && (b == 0))
    {
        return AkkermanFunction(a - 1, 1);
    }
    else
    {
        return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
    }
}