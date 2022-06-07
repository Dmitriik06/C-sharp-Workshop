Console.WriteLine("Enter the random natural number => ");
string NumStr1 = Console.ReadLine();
int Num1 = int.Parse(NumStr1);
int i = 2;

while ( i < Num1)
{
    if ( i + 1 == Num1)
    {
        Console.Write($"{i}");
        i = i + 2;
    }
    else
    {
        Console.Write($"{i}, ");
        i = i + 2;
    }
}
if (Num1 % 2 == 0)
{
    Console.Write(Num1);
}