// Задача 1:
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] InitArrayMxN(int m, int n)
{
    double[,] ArrayMxN = new double[m, n];
    return ArrayMxN;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { Console.Write($"{array[i, j]:F3} "); }
        Console.WriteLine();
    }
}

double[,] Fill2DArray(double[,] array, int min, int max)
{
    double number;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            number = rnd.Next(min, max) + rnd.NextDouble();
            array[i, j] = number;
        }
    }
    return array;
}

double[,] NewArrayMxN = InitArrayMxN(10, 10);

NewArrayMxN = Fill2DArray(NewArrayMxN, 0, 10);

Print2DArray(NewArrayMxN);