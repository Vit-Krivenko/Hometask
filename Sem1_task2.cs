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

if (parsednum1 > parsednum2)
{
    Console.WriteLine(parsednum1 + " большее число");
}
if (parsednum1 < parsednum2)
{
    Console.WriteLine(parsednum2 + " большее число");
}
if (parsednum1 == parsednum2)
{
    Console.WriteLine("Числа равны");
}