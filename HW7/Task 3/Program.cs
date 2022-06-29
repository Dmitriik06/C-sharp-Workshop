// Задача 3:
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    { Console.Write($"{array[i]:F2} "); }
}

int[,] Fill2DArray(int[,] array, int min, int max)
{
    int number;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            number = rnd.Next(min, max);
            array[i, j] = number;
        }
    }
    return array;
}

double[] FindAverageOfColumns(int[,] array)
{
    double[] AverageOfColumns = new double[array.GetLength(0)];
    int ColumnSum = 0;
    double RowsNumber = array.GetLength(0);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        { ColumnSum = ColumnSum + array[i, j]; }
        AverageOfColumns[j] = ColumnSum / RowsNumber;
        ColumnSum = 0;
    }
    Console.WriteLine();
    return AverageOfColumns;
}

int[,] NewArrayMxN = InitArrayMxN(5, 5);

NewArrayMxN = Fill2DArray(NewArrayMxN, 0, 10);

Print2DArray(NewArrayMxN);

double[] NewColumnsAverage = FindAverageOfColumns(NewArrayMxN);

PrintArray(NewColumnsAverage);