string num1;
Console.WriteLine("Введите число");
num1 = Console.ReadLine()!;
int parsednum1; 
parsednum1 = int.Parse(num1);

for (int i=1; i < parsednum1-1; i++)
    if (i%2 == 0)
{
    Console.Write(i+",");
}

if (parsednum1%2 == 0)
{
    Console.Write(parsednum1);
}
else 
{
    Console.Write(parsednum1-1);
}