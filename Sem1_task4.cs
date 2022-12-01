int max;

string num1;
Console.WriteLine("Введите первое число");
num1 = Console.ReadLine()!;
int parsednum1; 
parsednum1 = int.Parse(num1);

string num2;
Console.WriteLine("Введите второе число");
num2 = Console.ReadLine()!;
int parsednum2; 
parsednum2 = int.Parse(num2);

string num3;
Console.WriteLine("Введите третье число");
num3 = Console.ReadLine()!;
int parsednum3; 
parsednum3 = int.Parse(num3);

if (parsednum1 > parsednum2)
{
    max = parsednum1; 
}
else 
{
    max = parsednum2;
}

if (max > parsednum3)
{
    Console.WriteLine(" максимальное число " + max);
}
else 
{
    Console.WriteLine(" максимальное число " + parsednum3);
}
