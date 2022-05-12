// TASK 1. Program take a nummber and give back a summ from 1 to A

/*
int NaturalSum(int numA)
{
    int sum = 0;

    if (numA<1) return 0;
    else
    {
        for (int i = 1; i <= numA; i++)
        {
            sum +=i; // <-- it's equal --> sum = sum + i;  
        }
        return sum;
    }
}

Console.Write("input number --> ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Sum of elements is " + NaturalSum(number));
*/

// TASK 2. Program take a number and then must say how much diggit's has a number

/*
int DiggitsCounter(int number)
{
    int count = 0;
    
    if (number == 0) return 1;
    else
    {
        for (int i = 1; number>0; i++)
        {
            number = number/10;
            count =i;
        }
    }

    return count;
}

Console.Write("Input integer number --> ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.Write("Number of diggits is " + DiggitsCounter(num));
*/

// TASK 3. Program take a nummber and find A! .

/*
int FindFactorial(int num)
{
    int factorial = 1;

    if (num<=0) return 0;
    else
    {
        for (int i = 1; i <= num; i++)
        {
            factorial *=i; // <-- it's equal --> f = f * i;  
        }
        return factorial;
    }
}

Console.Write("Input number --> ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Factorial is " + FindFactorial(number));
*/

// TASK 4. Program must generete array then fill this array with 0 and 1. For the last step program must show us this array

/*
void FillNPrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write(array[i] + " | ");
    }
}

int[] arr = new int[10];

FillNPrintArray(arr);
*/

// TASK 5. Fill array wich contains 12 random number from -9 to 9 and find sum of negative and positive elemets of array.

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

// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write("Input" + i + "element --> ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
     Console.WriteLine();
}

void FindSumOfElements(int[] array)
{
    int plusSum = 0;
    int minusSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) plusSum += array[i];
        else minusSum += array[i];
    }

    Console.WriteLine("Sum of positive elements is: " + plusSum);
    Console.WriteLine("Sum of negative elements is: " + minusSum);
}

int[] myArray = CreateRandomArray(6, -9, 9);
ShowArray(myArray);
FindSumOfElements(myArray);
*/