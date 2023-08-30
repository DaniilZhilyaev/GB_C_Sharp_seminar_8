// Задача 3: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
int[,] arr = MinElArray(array);
Console.WriteLine();
PrintArray(arr);

// Нахожднение минимального элемента массива и удаление строки и столбца

int[,] MinElArray(int[,] array)
{
    int[,] res = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[imin, jmin] > array[i, j])
            {
                imin = i;
                jmin = j;
            }
        }
    }
    Console.WriteLine($"min i = {imin} min j = {jmin} element = {array[imin, jmin]}");
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {

        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            if (i < imin && j < jmin) res[i, j] = array[i, j];
            if (i < imin && j >= jmin) res[i, j] = array[i, j+1];
            if (i >= imin && j < jmin) res[i, j] = array[i+1, j];
            if (i >= imin && j >= jmin) res[i, j] = array[i+1, j+1];
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