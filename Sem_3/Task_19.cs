Console.WriteLine("Введите 5-ти значное число");
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = -number;
}

if (number < 100000 && number > 9999)
{
    int FirstDigital = number / 10000;
    int SecondDigital = number / 1000 % 10;
    int ForthDigital = number / 10 % 10;
    int FifthDigital = number % 10;

    if (FirstDigital == FifthDigital && SecondDigital == ForthDigital)
    {
        Console.WriteLine(number + " - палиндром");
    }
    else
    {
        Console.WriteLine(number + " - НЕ палиндром");
    }

}
else Console.WriteLine(number + " - это не 5-ти значное число");