/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 28 */

int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
SortLinesArray(array);
PrintArray(array);

// Упорядочить строки по возрастанию
void SortLinesArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sort = 0;
        while (sort < array.GetLength(1))
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                int temporary = 0;
                if (array[i, j] > array[i, j - 1])
                {
                    temporary = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = temporary;
                }
            }
            sort++;
        }

    }
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