Console.WriteLine("Enter the random integer number => ");
string NumStr1 = Console.ReadLine();
int Num1 = int.Parse(NumStr1);

if ( Num1 % 2 == 0)
{
    Console.WriteLine($"The number you entered ({Num1}) is even");
}
else
{
    Console.WriteLine($"The number you entered ({Num1}) is odd");
}