// Задача 36:
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] mass = new int[5];

void FillArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-25, 26);
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

int FindSum(int[] mass)
{
    int i = 0;
    int sum = 0;
    while (i < mass.Length)
    {
        if (i % 2 != 0)
        {
            sum = sum + mass[i];
        }
        i++;
    }
    return sum;
}

FillArr(mass);
PrintArr(mass);

Console.WriteLine($"Сумма элементов на нечетных позициях: {FindSum(mass)}");