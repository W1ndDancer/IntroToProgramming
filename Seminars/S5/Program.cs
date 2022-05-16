// TASK 1. Write a method wich swap all negative numbers is array to positive, and all positive to negative.

/*
int[] SwapPosNNegatInArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= (-1);
    }
    return array;
}
*/

// TASK 2. Create an array and set some a number. Write a method that will check if this number is in the array.

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
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

// int CheckIfNumberIsInArray(int[] array, int number)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number) count++;
//     }
//     return count;
// }

string CheckIfNumberInArray2(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]== number) return "Number IS in array";
    }
    return "Number ISN'T in array";
}

Console.Write("Set size of array --> ");
int arraySize = Convert.ToInt32(Console.ReadLine());

Console.Write("Set MIN border of array --> ");
int minBord = Convert.ToInt32(Console.ReadLine());

Console.Write("Set MAX border of array --> ");
int maxBord = Convert.ToInt32(Console.ReadLine());

int[] arrayForTask = CreateRandomArray(arraySize, minBord, maxBord);
Console.WriteLine();
ShowArray(arrayForTask);
Console.WriteLine();

Console.Write("Set a number to check if it is in array --> ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write(CheckIfNumberInArray2(arrayForTask, num));

// int countNum = CheckIfNumberIsInArray(arrayForTask, num);
// if(countNum == 0) Console.Write("Ur set number ISN'T is in array");
// else Console.Write("Ur set number IS is in array");
*/

// TASK 3. Specify a one-dimensional array of 15 random numbers. Find the number of array elements whose values lie in the segment [10,99].

/*
int[] CreateRandomArray(int min, int max)
{
    int[] array = new int[15];

    for (int i = 0; i < 15; i++)
    {
        array[i] = new Random().Next(min, max + 1);
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

int CountNumbersInSegment(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

Console.Write("Set MIN border of array --> ");
int minBord = Convert.ToInt32(Console.ReadLine());

Console.Write("Set MAX border of array --> ");
int maxBord = Convert.ToInt32(Console.ReadLine());

int[] arrayForTask3 = CreateRandomArray( minBord, maxBord);
Console.WriteLine();
ShowArray(arrayForTask3);
Console.WriteLine();

int countNum = CountNumbersInSegment(arrayForTask3);
Console.Write($"{countNum} numbers lies in the segment [10,99]");
*/

// TASK 4. Find the product of pairs of numbers in a one-dimensional array. We consider the first and last element, the second and penultimate, etc. as a pair. 
//         Write the result in a new array.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
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

int[] ProductOfPairs(int[] array)
{
    int newSize = array.Length / 2;
    int[] arrOfPairs = new int[newSize];

    for (int i = 0, j = array.Length - 1; i < newSize; i++, j--)
    {
        arrOfPairs[i] = array[i]*array[j];
    }
    return arrOfPairs;
}


Console.Write("Set size of array --> ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] arrayForTask4 = CreateRandomArray(arraySize);
Console.WriteLine("Ur array is:");
ShowArray(arrayForTask4);
Console.WriteLine();

int[] newArray = ProductOfPairs(arrayForTask4);
ShowArray(newArray);
*/

