/* *Задача 2:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

В итоге получается вот такой массив:

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7 */

int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
Console.WriteLine();

if (array.GetLength(0) == array.GetLength(1))
{
    int[,] arr = ChangeArray(array);
    PrintArray(arr);
}
else Console.WriteLine("Невозможно поменять массив");

// Пересмена первой и последней строчки массива
int[,] ChangeArray(int[,] array)
{
    int[,] res = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res[i, j] = array[j, i];
        }
    }
    return res;
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