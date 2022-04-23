//Task2. Check if number A is equal number B^2

Console.Write("Input 1st integer number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd integer number: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA == numB * numB)
{
    Console.WriteLine("1st number is equal to square of the 2nd number");
}
else
{
    Console.WriteLine("1st number is NOT equal to square of the 2nd number");
}