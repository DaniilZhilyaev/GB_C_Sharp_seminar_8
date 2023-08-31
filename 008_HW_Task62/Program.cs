/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] array = GetSpiralArray(4);
PrintArray(array);

// Создание массива
int[,] GetSpiralArray(int m)
{
    int[,] res = new int[m, m];
    int k = 0;
    int pos = 1;
    for (int i = 0; i < m; i++)
    {
        res[k, i] = pos;
        pos++;
    }
    for (int i = 1; i < m; i++)
    {
        res[i, m-1] = pos;
        pos++;
    }
    for (int i = m-2; i >= 0; i--)
    {
        res[m-1, i] = pos;
        pos++;
    }
    for (int i = m-2; i > 0; i--)
    {
        res[i, k] = pos;
        pos++;
    }
    for (int i = k+1; i < m-1; i++)
    {
        res[k+1, i] = pos;
        pos++;
    }
    for (int i = m-2; i >= k+1; i--)
    {
        res[m-2, i] = pos;
        pos++;
    }
    return res;
}

// int[,] Spiral(int n)
// {
//     int[,] result = new int[n, n];

//     int pos = 1;
//     int count = n;
//     int value = -n;
//     int sum = -1;

//     do
//     {
//         value = -1 * value / n;
//         for (int i = 0; i < count; i++)
//         {
//             sum += value;
//             result[sum / n, sum % n] = pos++;
//         }
//         value *= n;
//         count--;
//         for (int i = 0; i < count; i++)
//         {
//             sum += value;
//             result[sum / n, sum % n] = pos++;
//         }
//     } while (count > 0);

//     return result;
// }

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

