// Задача 2:
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

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

double FindElement(double[,] array, int m, int n)
{
    if ( m > array.GetLength(0)
    || n > array.GetLength(1)
    || m < 1
    || n < 1)
    {
        Console.WriteLine($"This array doesn't content searching element ({m}, {n})");
        return -1;        
    }
    Console.WriteLine($"The required element ({m},{n}) is equal to {array[m - 1, n - 1]:F3}");
    return array[m - 1, n - 1];
}

int M = Prompt("Enter the number of rows (M) => ");
int N = Prompt("Enter the number of columns (N) => ");

double[,] NewArrayMxN = InitArrayMxN(M, N);

NewArrayMxN = Fill2DArray(NewArrayMxN, 0, 10);

Print2DArray(NewArrayMxN);

int ElementRow = Prompt("Enter the row of searching element => ");
int ElementColumn = Prompt("Enter the column of searching element => ");

FindElement(NewArrayMxN, ElementRow, ElementColumn);
