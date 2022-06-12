Console.Write("Enter a three-digit number => ");
string NumStr = Console.ReadLine();
int Num = int.Parse(NumStr);
if (Num < 0)
{
    Num = -Num;
}
if (Num < 100 || Num > 999)
{
    Console.WriteLine("Incorrect input. Please try again.");
}
else
{
    Console.WriteLine($"{Num % 100 / 10}");
}
