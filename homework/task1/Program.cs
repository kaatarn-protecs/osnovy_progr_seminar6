// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел ");
int countdig = Convert.ToInt32(Console.ReadLine());
//int[] digarray = new int[];

int[] ParseDigit(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите целое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int SearchDig(int[] sarr)
{
    int sdig = 0;
    for (int i = 0; i < sarr.Length; i++)
    {   
        if (sarr[i] > 0) sdig = sdig + 1;
    }
    return sdig;
}

int[] digarray = ParseDigit(countdig);
PrintArray(digarray);
countdig = SearchDig(digarray);
Console.Write($" -> {countdig}");