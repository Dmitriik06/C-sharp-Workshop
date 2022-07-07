// Задача 1:
// Задайте значения M и N. Напишите программу, которая выведет все чётные
// НАТУРАЛЬНЫЕ числа в промежутке от M до N с помощью рекурсии.

void PrintEvenNums(int M, int N)
{
    if (M <= N)
    {
        if (M % 2 == 0)
        {
            if (M >= 0) { Console.Write($"{M} "); } // выводим только натуральные
            M = M + 2;
            PrintEvenNums(M, N);
        }
        else
        {
            if (M != N)
            {
                M = M + 1;
                if (M >= 0) { Console.Write($"{M} "); } // выводим только натуральные
                M = M + 2;
                PrintEvenNums(M, N);
            }
        }
    }
}

PrintEvenNums(-11, 20);