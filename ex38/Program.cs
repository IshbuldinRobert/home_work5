// Задача 38:
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] mass = new int[7];

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

FillArr(mass);
PrintArr(mass);

int i = 0;
int max = mass[i];
int min = mass[i];

while (i < mass.Length)
{
    if (mass[i] > max)
    {
        max = mass[i];
    }
    else if (mass[i] < min)
    {
        min = mass[i];
    }
    i++;
}
Console.WriteLine($"Разница между максимальным и минимальныи элементами: {max - min}");