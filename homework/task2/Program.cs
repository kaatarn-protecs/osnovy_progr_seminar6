// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] Intersection(double b11, double k11, double b22, double k22)
{   
    double[] interarr = new double[2];
    interarr[0] = (b22 - b11) / (k11 - k22); // x
    Console.WriteLine($" x = {interarr[0]}");
    interarr[1] = k11 * interarr[0] + b11; // y
    return interarr;
}
void PrintArrayDouble(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write(array[i]);
    }
    Console.Write(")");
}

double[] inters = Intersection(b1, k1, b2, k2);
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
PrintArrayDouble(inters);
