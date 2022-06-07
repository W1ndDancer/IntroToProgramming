// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int FindSumFromNum1toNum2(int num1, int num2)
{

    if (num1 <= num2)
        return (num1 + FindSumFromNum1toNum2(num1 + 1, num2));
    else return 0;
}

Console.Write("Input 1st number. m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd number. n = ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

int sumFromNtoM = FindSumFromNum1toNum2(m, n);
Console.Write($"Sum of elements in interval [{m}; {n}] is {sumFromNtoM}");
*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

/*
int FindSumOfDiggits(int number)
{
    if (Math.Abs(number) > 0)
    {
        int lastDigit = Math.Abs(number) % 10;
        return lastDigit + FindSumOfDiggits(number/10);
    }
    else return 0;
}
Console.Write("Input number --> ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfDiggits = FindSumOfDiggits(number);
Console.Write("Sum of diggits in ur number is --> " + sumOfDiggits);
*/