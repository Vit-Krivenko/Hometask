Console.WriteLine("Введите число b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k2");
double k2 = double.Parse(Console.ReadLine()!);
double[] array = Point(b1, k1, b2, k2);
Console.WriteLine("Координаты точки пересечения : (" + array[0] + ";" + array[1] + ")");



double[] Point(double numA1, double numB1, double numA2, double numB2)
{
    double[] array = new double[2];
    array[0] = (numA2 - numA1) / (numB1 - numB2);
    array[1] = numB1 * (numA2 - numA1) / (numB1 - numB2) + numA1;
    return array;
}
