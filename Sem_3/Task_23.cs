Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);

for (int i=1; i<N; i++)
{
    Console.Write(Math.Pow(i,3) + ", ");
}
Console.Write(Math.Pow(N,3) + ".");