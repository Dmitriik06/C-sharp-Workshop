int Num = new Random().Next(100, 1000);
int result = Num / 100 * 10 + Num % 10;
Console.WriteLine($"The random number is {Num}");
Console.WriteLine($"The result is {result}");