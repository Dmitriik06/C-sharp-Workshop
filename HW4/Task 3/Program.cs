// Задача 3:
// Напишите программу, которая задаёт массив из 8 элементов случайными числами (от 0 до 9999) и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
}

int[] OctoRandom()
{
    int[] OctoArray = new int[8];

    for (int i = 0; i < OctoArray.Length; i++)
    {
        OctoArray[i] = new Random().Next(0, 10000);
    }

    return OctoArray;
}

int[] NewArray = OctoRandom();

PrintArray(NewArray);