Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int count = SumNumbers(number);
Console.WriteLine(count);

int SumNumbers(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}