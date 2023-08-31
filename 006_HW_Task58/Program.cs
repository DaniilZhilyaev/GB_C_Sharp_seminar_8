/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] firstmatrix = GetArray(3, 2, 0, 10);
PrintArray(firstmatrix);
Console.WriteLine();
int[,] secondmatrix = GetArray(2, 3, 0, 10);
PrintArray(secondmatrix);
Console.WriteLine();

if ((firstmatrix.GetLength(1)) == secondmatrix.GetLength(0))
{
    int[,] resultmatrix = MultiplicationArray(firstmatrix, secondmatrix);
    PrintArray(resultmatrix);
}
else Console.WriteLine("Неправильные размеры матриц");

// Произведение двух матриц

int[,] MultiplicationArray(int[,] array1, int[,] array2)
{
    int[,] res = new int[array1.GetLength(0), array2.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            k = 0;
            while (k < array1.GetLength(0) - 1)
            {
                res[i, j] = res[i, j] + array1[i, k] * array2[k, j];
                k++;
            }
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