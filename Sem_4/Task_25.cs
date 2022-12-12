Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);

int result = Power(A, B);
Console.WriteLine(result);

int Power(int number, int degree)
{
    int temp = 1;
    for (int i = 1; i <= degree; i++)
    {
        temp = temp * number;
    }
    return temp;
}