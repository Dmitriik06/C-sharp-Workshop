// Задача 2:
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumRowElements(int[,] array, int i)
{
    int Sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Sum = Sum + array[i, j];
    }
    return Sum;
}

void FindSmallestRow(int[,] array)
{
    int minRowID = 0;
    int minSum = SumRowElements(array, minRowID);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (SumRowElements(array, i) < minSum)
        {
            minSum = SumRowElements(array, i);
            minRowID = i;
        }
    }
    Console.WriteLine($"The row {minRowID+1} has the smallest ({minSum}) sum of elements");
}

int[,] NewMatrix = InitArrayMxN(4, 5);
NewMatrix = Fill2DArray(NewMatrix, 0, 9);
Console.WriteLine("Initialized matrix:");
Print2DArray(NewMatrix);
FindSmallestRow(NewMatrix);