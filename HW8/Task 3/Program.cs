// Задача 3:
// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

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

int[,] MultiplyMatriсes(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        int[,] MatrixAxB = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int i = 0; i < MatrixAxB.GetLength(0); i++)
        {
            for (int j = 0; j < MatrixAxB.GetLength(1); j++)
            {
                for (int k = 0; k < matrixA.GetLength(1); k++)
                { MatrixAxB[i, j] = MatrixAxB[i, j] + matrixA[i, k] * matrixB[k, j]; }
            }
        }
    return MatrixAxB;
    }
    else
    {
        Console.WriteLine("Can't multiply matriсes");
        Console.WriteLine($"Columns of MatrixA ({matrixA.GetLength(1)}) have to equal Rows ({matrixB.GetLength(0)}) of MatrixB");
        return new int[1,1];
    }
}

int[,] MatrixA = InitArrayMxN(3, 2);
MatrixA = Fill2DArray(MatrixA, 0, 9);
int[,] MatrixB = InitArrayMxN(2, 3);
MatrixB = Fill2DArray(MatrixB, 0, 9);
Console.WriteLine("MatrixA =>");
Print2DArray(MatrixA);
Console.WriteLine("MatrixB =>");
Print2DArray(MatrixB);
Console.WriteLine("MatrixAxB =>");
Print2DArray(MultiplyMatriсes(MatrixA, MatrixB));