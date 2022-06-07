Console.WriteLine("Enter the first number => ");
string NumStr1 = Console.ReadLine();
int Num1 = int.Parse(NumStr1);
Console.WriteLine("Enter the second number => ");
string NumStr2 = Console.ReadLine();
int Num2 = int.Parse(NumStr2);
Console.WriteLine("Enter the third number => ");
string NumStr3 = Console.ReadLine();
int Num3 = int.Parse(NumStr3);
int max = Num1;

if (Num2 > max)
{
    max = Num2;
}
if (Num3 > max)
{
    max = Num3;
}
Console.WriteLine($"The maximum number is {max}");