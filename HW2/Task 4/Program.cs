Console.WriteLine("Please enter the number of day of the week (1-7) => ");
string DayStr = Console.ReadLine();
int Day = int.Parse(DayStr);
if (Day < 1 || Day > 7)
{
    Console.WriteLine("Incorrect input, please try again");
}
else
{
    if (Day == 6 || Day == 7)
    {
        Console.WriteLine($"The day number {Day} is a Holiday!");
    }
    else
    {
        Console.WriteLine($"The day number {Day} is not a Holiday!");
    }
}