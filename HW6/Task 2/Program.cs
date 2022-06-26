// Задача 2. 
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

double[] FindIntersectionPoint(double k1, double b1, double k2, double b2)
{
    double[] intersectionPoint = new double[2];
    if (k1 == k2)
    {
        if (b1 == b2)
        { Console.WriteLine("Lines coincide. Infinite number of intersection points"); }
        else
        { Console.WriteLine("Lines are parallel. There is no intersection point"); }
    }
    else
    {
        double XCoordinate = (b2 - b1) / (k1 - k2); // координата Х точки пересечения
        intersectionPoint[0] = XCoordinate;
        double YCoordinate = k1 * XCoordinate + b1; // координата Y точки пересечения
        intersectionPoint[1] = YCoordinate;
        Console.WriteLine($"The coorinates (X, Y) of intersection point is ({intersectionPoint[0]},{intersectionPoint[1]})");
    }
    return intersectionPoint;
}

int k1 = Prompt("Enter k1 =>");
int b1 = Prompt("Enter b1 =>");
int k2 = Prompt("Enter k2 =>");
int b2 = Prompt("Enter b2 =>");

double[] XYCoordinate = FindIntersectionPoint(k1, b1, k2, b2);