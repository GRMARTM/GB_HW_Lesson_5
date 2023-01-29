// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[9];

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

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine($"Максимальное значение равно: {max}");

int Min(int arg4, int arg5, int arg6)
{
    int result = arg4;
    if (arg5 < result) result = arg5;
    if (arg6 < result) result = arg6;
    return result;
}
int min = Min(
    Min(array[0], array[1], array[2]),
    Min(array[3], array[4], array[5]),
    Min(array[6], array[7], array[8])
);
Console.WriteLine($"Миимальное значение равно: {min}");

int otvet = max - min;
Console.WriteLine($"Разница значений равна: {otvet} ");
