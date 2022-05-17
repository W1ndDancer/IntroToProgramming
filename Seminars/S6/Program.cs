// TASK 1. Write a method what took lenght of 3 line segments and then method must check if exist a triangle with this line segments.

/*
bool IsTriangleExist(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        return true;
    }
    return false;
}

if(IsTriangleExist(1,1,1)) Console.Write("Yes");
else Console.Write("No");
*/

// TASK 2. Flip array

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

int[] FlipTheArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temporary = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temporary;
    }
    return array;
}

Console.Write("Size --> ");
int newSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Min --> ");
int newMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Max --> ");
int newMax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[] newArray = CreateRandomArray(newSize, newMin, newMax);
ShowArray(newArray);
Console.WriteLine();

newArray = FlipTheArray(newArray);
ShowArray(newArray);
*/

// TASK 3. Method take a number and then must display numbers Fibonacci from 1 to this number. First 2 numbers in : 0 and 1.

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
     Console.WriteLine();
}


int[] FibonacciToNumber(int number)
{
    int[] fibonacciNumbers = new int[number];

    if(number == 1) fibonacciNumbers[0] = 0;
    else
    {
        fibonacciNumbers[0] = 0;
        fibonacciNumbers[1] = 1;
        for (int i = 2; i < number; i++) fibonacciNumbers[i] = fibonacciNumbers[i-2] + fibonacciNumbers[i-1];
    }
    return fibonacciNumbers;
}

Console.Write("Number --> ");
int num = Convert.ToInt32(Console.ReadLine());

int[] newFibonacciNumbers = FibonacciToNumber(num);
ShowArray(newFibonacciNumbers);