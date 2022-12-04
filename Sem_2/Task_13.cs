Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int colnum = 0;
int number2 = 1;

if (number < 0)
{
    number = number * -1;
}

int number1 = number;

while (number1 >= 10)
{
    number1 = number1 / 10;
    colnum++;
}

colnum = colnum - 3;
for (int i = 0; i <= colnum; i++)
{
    number2 = number2 * 10;
}

number = number / number2;

if (colnum >= -1)
{
    Console.WriteLine("Третья цифра числа - " + number % 10);
}
else 
{
    Console.WriteLine("Третьей цифры числа - нет");
}