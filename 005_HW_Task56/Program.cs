/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] array = GetArray(3, 3, 0, 10);
PrintArray(array);
Console.WriteLine();
MinSumLineArray(array);

// Поиск номера строки с наименьшей суммой элементов
void MinSumLineArray(int[,] array)
{
    int minsum = 0;
    int linesum = 0;
    int tempsum = 0;
    int firstsum = 0;
    while (firstsum < array.GetLength(1))
    {
        linesum = linesum + array[0, firstsum];
        firstsum++;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempsum = tempsum + array[i, j];
            if (linesum > tempsum)
            {
                minsum = i;
                linesum = tempsum;
            }
        }
        tempsum = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minsum}");
}

// Создание массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}
// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}