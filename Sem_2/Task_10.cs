Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

if (number / 100 >= 1 && number < 1000)
{
    number = number / 10 - number/100*10;
    Console.WriteLine("Вторая цифра введенного числа - " + number);
}
else
{
    Console.WriteLine("Это не трехзначное число!");
}
