int prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

double Sqr(double Num)
{
    return Num * Num;
}

int x1 = prompt("Enter x1");
int y1 = prompt("Enter y1");
int z1 = prompt("Enter z1");
int x2 = prompt("Enter x2");
int y2 = prompt("Enter y2");
int z2 = prompt("Enter z2");

double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double S = Sqr(x2 - x1) + Sqr(y2 - y1) + Sqr(z2 - z1);
    double result = Math.Sqrt(S);
    return result;
}

Console.WriteLine($"Distance between dots is {Dist(x1, y1, z1, x2, y2, z2)}");