// TASK 1. Programm finds max number using array

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = { 12, 32, 43, 554, 25, 16, 337, 28, 99 };

// int maxArray = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

// Console.Write(maxArray);

// TASK 2. We Have one-dimesional array, what contains N elements, we need to find an index of element of array what is equal FIND.

int[] array = { 17, 92, 53, 34, 15, 26, 27, 39, 34 };
int n = array.Length;
int find = 34;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}