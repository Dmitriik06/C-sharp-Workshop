// Задача 1:
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

double Power(double A, int B)
{
    double result = 1 / A;

    for (int i = 0; i <= B; i++)
    {
        result = result * A;
    }

    return result;
}

int NumA = prompt("Enter base number => ");
int NumB = prompt("Enter power number => ");

double answer = Power(NumA, NumB);

Console.WriteLine($"{NumA} raised to the power {NumB} equals {answer}");