// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[5];
void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("В заданном массиве: [");
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(-9, 10);
        Console.Write($"{array[i]}, ");

    }
    Console.Write("\b\b]");
    Console.WriteLine();
}
PrintArray(arr);

int count = 0;
foreach(int item in arr){
    if(item % 2 == 0) count++;
}
Console.Write($" \b\b количество четных элементов равно: {count}");