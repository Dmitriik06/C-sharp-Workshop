// Задача 1:
// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] InitArrayMxN(int m, int n)
{
    int[,] ArrayMxN = new int[m, n];
    return ArrayMxN;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { Console.Write($"{array[i, j]}    "); }
        Console.WriteLine();
    }
}

int[,] Fill2DArray(int[,] array, int min, int max)
{
    int number;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            number = rnd.Next(min, max + 1);
            array[i, j] = number;
        }
    }
    return array;
}

void SortRowElements(int[,] array, int i, int k = 0)
{
    if (k < array.GetLength(1) - 1)
    {
        int minID = 0;
        int min = array[i, minID];
        for (int j = 1; j < array.GetLength(1) - k; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minID = j;
            }
        }
        array[i, minID] = array[i, array.GetLength(1) - 1 - k];
        array[i, array.GetLength(1) - 1 - k] = min;
        SortRowElements(array, i, ++k);
    }
}

void SortMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortRowElements(array, i, 0);
    }
}

int[,] NewMatrix = InitArrayMxN(5, 10);
NewMatrix = Fill2DArray(NewMatrix, 0, 9);
Console.WriteLine("Initialized matrix:");
Print2DArray(NewMatrix);
Console.WriteLine("Sorted matrix:");
SortMatrix(NewMatrix);
Print2DArray(NewMatrix);