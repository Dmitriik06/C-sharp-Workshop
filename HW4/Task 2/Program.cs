// Задача 2:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int DigitSum(int Num)
{
    int result = 0;

    while(Num != 0)
    {
        result = result + Num % 10;
        Num = Num / 10;
    }

    return result;
}

int Number = prompt("Enter number => ");
int answer = DigitSum(Number);

Console.WriteLine($"The sum of digits of numer {Number} is {answer}");