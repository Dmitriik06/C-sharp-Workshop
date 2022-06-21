// Задача 1:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] InitArray(int arrLen)
{
    int[] Arr = new int [arrLen];
    return Arr;
}

void PrintArray(int[] arr)
{
    foreach(int element in arr)
    {
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}

int[] FillRandArr(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int CountEven(int[] arr)
{
    int i = 0;
    foreach(int element in arr)
    {
        if (element % 2 == 0)
        {
            i++;
        }
    }
    Console.WriteLine($"There is/are {i} even numbers in array");
    return i;
}

int[] NewArray = InitArray(100);

FillRandArr(NewArray, 100, 999);

PrintArray(NewArray);

CountEven(NewArray);