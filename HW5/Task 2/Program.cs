// Задача 2:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumOddElements(int[] arr)
{
    int i = 0;
    int Sum = 0;
    for (i = 0; i < arr.Length; i = i + 2)
    {
        Sum = Sum + arr[i];
    }
    return Sum;
}

int[] NewArray = InitArray(4);

NewArray = FillRandArr(NewArray, -10, 10);

PrintArray(NewArray);

Console.Write($"Sum of odd elements in array is {SumOddElements(NewArray)}");
