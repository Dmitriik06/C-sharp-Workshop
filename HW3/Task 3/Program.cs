int prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int x = prompt("Enter number");

for (int i = 1; i <= x; i++)
{
    Console.Write($"{i * i * i} ");
}