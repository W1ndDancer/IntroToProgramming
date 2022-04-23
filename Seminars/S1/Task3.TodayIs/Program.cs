//Task3. Input a number of a weekday, and programm will say what day is it.
Console.Write("Input a day number ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7)
{
    Console.WriteLine("Dont be a Don Quijote. This day is not existing. Bye!");
}
else
{
    if (day == 1)
        Console.WriteLine("Today is a Sunday");
    if (day == 2)
        Console.WriteLine("Today is a Monday");
    if (day == 3)
        Console.WriteLine("Today is a Tuesday");
    if (day == 4)
        Console.WriteLine("Today is a Wednesday");
    if (day == 5)
        Console.WriteLine("Today is a Thursday");
    if (day == 6)
        Console.WriteLine("Today is a Friday");
    if (day == 7)
        Console.WriteLine("Today is a Saturday");
}