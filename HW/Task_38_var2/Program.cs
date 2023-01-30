// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите длинну массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("В заданном массиве [");
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]}, ");

    }
    Console.Write("\b\b]");
    Console.WriteLine();
}
PrintArray(array);

int max = 0;
int min = 0;

// void Searching(int max, int min)
// {
    min = array[0];
    max = array[0];
    for (int i = 0; i < len; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
// }
// Searching(max, min);
int result = max - min;
Console.WriteLine($"Разница между максимальным значением  {max} и минимальным значением {min} равна {result} ");
