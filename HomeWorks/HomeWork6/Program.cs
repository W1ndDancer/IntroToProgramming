// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input number " + i + " --> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void CountNumbersGreaterThenZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count++;
    }
    Console.Write($"{count} numbers greater then zero");
}

Console.Write("How much numbers do U want to enter? --> ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arrayForTask = CreateArray(number);
Console.WriteLine();
CountNumbersGreaterThenZero(arrayForTask);
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

/*
void ShowArray(int[] array, int decNum)
{
    Console.Write(decNum + " --> ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

int FindSizeForBinaryNumber(int decNumber)
{
    int size = 0;

    for (double i = decNumber; i >= 1; i = i / 2)
    {
        size++;
    }
    return size;
}

int[] ConvertDecimalToBinary(int decNumber, int size)
{
    int[] binaryNumber = new int[size];

    for (int i = size - 1; i >= 0; decNumber = decNumber / 2, i--)
    {
        int remainder = decNumber % 2;

        if (remainder == 0) binaryNumber[i] = 0;
        else binaryNumber[i] = 1;
    }
    return binaryNumber;
}

Console.Write("Input decimal number what U want to convert --> ");
int decNum = Convert.ToInt32(Console.ReadLine());

int sizeForTask = FindSizeForBinaryNumber(decNum);
int[] binNum = ConvertDecimalToBinary(decNum, sizeForTask);
if(decNum == 0) Console.Write("0 --> 0");
else ShowArray(binNum, decNum);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.Write("k1 --> ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1 --> ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 --> ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 --> ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = ((b2-b1)/(k1-k2));
double y = k2*x + b2;
Console.Write($"[{Math.Round(x,2)}; {Math.Round(y,2)}]");
*/