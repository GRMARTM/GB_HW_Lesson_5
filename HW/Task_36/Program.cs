// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[5];

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("В заданном массиме [");
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(-9, 10);
        Console.Write($"{array[i]}, ");

    }
    Console.Write("\b\b]");
    Console.WriteLine();
}
PrintArray(arr);

int sum = 0;
for (int i = 1; i < arr.Length; i += 2) sum += arr[i];
Console.Write($"Сумма нечетных элементов равна: {sum}");