// Задача 3:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.


double[] InitArray(int arrLen)
{
    double[] Arr = new double [arrLen];
    return Arr;
}

void PrintArray(double[] arr)
{
    foreach(int element in arr)
    {
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}

double[] FillRandArr(double[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

double[] FindMinMax(double[] arr)
{
    double Min = arr[0];
    double Max = arr[0];
    double[] result = new double[2];
    foreach(double element in arr)
    {
        if (element > Max)
        {
            Max = element;
        }
        if (element < Min)
        {
            Min = element;
        }
    }
    result[0] = Min;
    result[1] = Max;
    return result;
}

double[] NewArray = InitArray(5);

NewArray = FillRandArr(NewArray, 0, 100);

PrintArray(NewArray);

Console.Write("The Min and Max elements in array:");
PrintArray(FindMinMax(NewArray));
Console.Write($"The difference between Max and Min is {FindMinMax(NewArray)[1] - FindMinMax(NewArray)[0]}");