Console.WriteLine("Введите порядковое число дня недели");
int number = int.Parse(Console.ReadLine()!);

if (number > 0 && number < 8)
    if (number == 6 || number == 7)
    {
        Console.WriteLine("День выходной");
    }
    else
    {
        Console.WriteLine("День НЕ выходной");
    }
else
    if (number<=0)
    {
        Console.WriteLine("Порядковое число недели не может быть 0 или меньше!");
    }
    if (number>7)
    {
    Console.WriteLine("Дней недели всего 7 !!!");
    }
