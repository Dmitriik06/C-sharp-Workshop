// Задача 2:
// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumEvenNums(int M, int N)
{
    int Sum = 0;
    while (M < 0) //только натуральные
    {
        M++;
    }
    if (M <= N)
    {     
        Sum = M + SumEvenNums(++M, N);
    }
    return Sum;
}

Console.WriteLine(SumEvenNums(1, 15));