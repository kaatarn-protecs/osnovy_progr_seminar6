// Задача 44: 
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



bool inNumberResult;
Console.WriteLine("Введите число N");

inNumberResult = int.TryParse(Console.ReadLine(), out int checknumber);

if (inNumberResult)
{
    int[] fib = new int[checknumber];
    fib[0] = 0;
    fib[1] = 1;
    Console.Write($"Если N = {checknumber} -> {fib[0]} {fib[1]} ");
    for (int i = 2; i < fib.Length; i++)
    {
        if (i >= 2) fib[i] = fib[i -1] + fib[i - 2];
        Console.Write($"{fib[i]} ");
    }
}
else Console.WriteLine("Неверное число!"); // Сделать в метод!