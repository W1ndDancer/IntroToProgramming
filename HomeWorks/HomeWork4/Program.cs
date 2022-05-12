// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindEvenNumbers(int[] array)
{
    int countEven = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) countEven++;
    }
    return countEven;
}

Console.Write("Input size of array --> ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(arraySize);
ShowArray(newArray);

Console.Write("Array contains " + FindEvenNumbers(newArray) + " even numbers.");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element --> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfNotEvenElementsInArray(int[] array)
{
    int notEvenSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) notEvenSum += array[i];
    }
    return notEvenSum;
}

Console.Write("Input size of array --> ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(arraySize);
ShowArray(newArray);

Console.Write("Sum of not even elements is " + SumOfNotEvenElementsInArray(newArray));
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

/*
double[] CreateArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element --> ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindArrayMax(double[] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double FindArrayMin(double[] array)
{
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.Write("Input array size --> ");
int arraySize = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateArray(arraySize);
ShowArray(newArray);

Console.Write("Diference beetwen array max and min is --> " + (FindArrayMax(newArray) - FindArrayMin(newArray)));
*/