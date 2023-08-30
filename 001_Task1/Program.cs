/**Задача 1:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

8 4 2 4

5 9 2 3

1 4 7 2 */

int[,] array = GetArray(4, 3, 0, 10);
PrintArray(array);
Console.WriteLine();
int[,] arr = ChangeArray(array);
PrintArray(arr);

// Пересмена первой и последней строчки массива
int[,] ChangeArray(int[,] array)
{
    int temporary = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temporary = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temporary;
        temporary = 0;
    }
return array;
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