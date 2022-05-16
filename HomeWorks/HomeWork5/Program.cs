// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int ExponantiateANumber(int numA, int numB)
{
    int exponAtoB = 1;

    for (int i = 1; i <= numB; i++)
    {
        exponAtoB = exponAtoB*numA;
    }
    return exponAtoB;
}

Console.Write("A --> ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("B --> ");
int numberB = Convert.ToInt32(Console.ReadLine());

int expAtoB = ExponantiateANumber(numberA, numberB);
Console.Write("A^B = " + expAtoB);
*/

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int FindSumOfDiggits(int number)
{
    int sumOfDiggits = 0;
    for (int i = Math.Abs(number); i > 0; i = i / 10)
    {
        int lastDigit = i % 10;
        sumOfDiggits = sumOfDiggits + lastDigit;
    }
    return sumOfDiggits;
}

Console.Write("Input number N --> ");
int n = Convert.ToInt32(Console.ReadLine());

int sumOfDiggitsForTask = FindSumOfDiggits(n);
Console.Write("Sum of diggits in number N is --> " + sumOfDiggitsForTask);
*/

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
void CreateRandomArrayNPrint(int min, int max)
{
    int[] array = new int[8];
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

Console.Write("Min border --> ");
int minBorder = Convert.ToInt32(Console.ReadLine());

Console.Write("Max border --> ");
int maxBorder = Convert.ToInt32(Console.ReadLine());

CreateRandomArrayNPrint(minBorder, maxBorder);
*/