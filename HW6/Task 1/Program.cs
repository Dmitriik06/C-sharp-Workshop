// Задача 1:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int CountPositiveNumbers()
{
    int Number = 0;
    int Positive = 0;
    
    int M = Prompt("How much numbers do you want to add?");
    
    for (int i = 0; i < M; i++)
    {
        Number = Prompt("Enter number =>");
        if (Number > 0)
           { Positive++; }
    }
    return Positive;
}

int EnteredPositives = CountPositiveNumbers();

Console.WriteLine($"You entered {EnteredPositives} positive number/numbers");