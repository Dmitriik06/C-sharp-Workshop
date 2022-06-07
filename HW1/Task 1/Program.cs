Console.WriteLine("Enter the first number => ");
string NumStr1 = Console.ReadLine();
int Num1 = int.Parse(NumStr1);
Console.WriteLine("Enter the second number => ");
string NumStr2 = Console.ReadLine();
int Num2 = int.Parse(NumStr2);

if (Num1 > Num2)
{
    Console.Write($"The First number ({Num1}) is greater than the Second number ({Num2})");
}
else
{
    if (Num2 > Num1)
{
    Console.Write($"The Second number ({Num2}) is greater than the First number ({Num1})");
}
else
{
    Console.Write($"The numbers are equal");  
}
}
