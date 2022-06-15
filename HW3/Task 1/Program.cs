Console.WriteLine("Enter number => ");
string Pal = Console.ReadLine();
int Len = Pal.Length;

bool q = true;

for (int i = 0; i <= Len / 2; i++)
{
    if (Pal[i] != Pal[Len - 1 - i])
    {
        Console.WriteLine($"{Pal} is not a Palindrome");
        q = false;
        break;
    }
}

if (q == true)
{
    Console.WriteLine($"{Pal} is a Palindrome");
}