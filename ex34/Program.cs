// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[10];

void FillArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(100, 1000);
    }
}

void PrintArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (i == 0) Console.Write($"[{mass[i]}, ");
        else if (i == mass.Length - 1) Console.WriteLine($"{mass[i]}]");
        else Console.Write($"{mass[i]}, ");
    }
}

void FindEvenNumbers(int[] mass)
{
    int count = 0;
    int i = 0;
    while (i < mass.Length)
    {
        if (mass[i] % 2 == 0) count++;
        i++;
    }
    Console.WriteLine($"Четных чисел в массиве: {count}");
}

FillArr(arr);
PrintArr(arr);
FindEvenNumbers(arr);