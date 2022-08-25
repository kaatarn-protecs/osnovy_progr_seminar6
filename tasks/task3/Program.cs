// Задача 42: Напишите программу, 
// которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// Console.WriteLine("Введите число ");
// long a = long.Parse(Console.ReadLine()!);

// long b = 0;
// long c = 1;
// long number = 0;

// for (int i = 1; a != 0; i++)
// {
//     b = a % 2;
//     a = a / 2;
//     c = c * 10;
//     number = number + b * c;
// }

// Console.WriteLine($"Номер: {number / 10}");  // ПЛОХОЕ РЕШЕНИЕ

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

int TransToBinary(int num)
{
    int result = 0;
    int i = 1;

    while (num > 0)
    {
        result += num % 2* i;
        num /= 2;
        i*= 10;
    }
    return result;
}

long res = TransToBinary(a);
Console.WriteLine($"{a} = {res}");
