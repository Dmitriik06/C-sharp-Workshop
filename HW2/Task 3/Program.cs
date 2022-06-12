Console.Write("Enter a number => ");
string NumStr = Console.ReadLine();
int Num = int.Parse(NumStr);
int NumLength = NumStr.Length;
if (Num < 0)
{
    Num = -Num;
    NumLength = NumLength - 1;
}
if (Num < 100)
{
    Console.WriteLine($"Number {Num} does not contain third digit, try again");
}
else
{
    while (NumLength > 3)
    {
        Num = Num / 10;
        NumLength = NumLength - 1;
    }
    Num = Num % 10;
    Console.WriteLine($"{Num}");
}