// Задача 45: 
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.WriteLine("Введите длину массива ");
int n = Convert.ToInt32(Console.ReadLine());


int[] CreateArrayRndInt(int size, int min, int max) // Метод создания массива
{
    int[] array = new int[size];
    Random rnd = new Random(); // Создаем объект рандом

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
int[] array = CreateArrayRndInt(n, 0, 10);
Console.WriteLine();
int[] CopyArray (int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

PrintArray(array);
CopyArray(array);
PrintArray(array);


