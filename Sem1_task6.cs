string num1;
Console.WriteLine("Введите число");
num1 = Console.ReadLine()!;
int parsednum1; 
parsednum1 = int.Parse(num1);

if (parsednum1%2==0)
{
    Console.WriteLine(parsednum1 + " - да");
}
else
{
    Console.WriteLine(parsednum1 + " - нет");
}