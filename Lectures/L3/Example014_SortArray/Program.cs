// Sort massive from min no max number.

int[] arr = { 1, 4, 5, 98, 2, 2, 4, 7, 12, 32 };

void printArray(int[] array)
{
    int lenght = array.Length;

    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j; // To sort array from Max to Min. U should change "<" to ">" in this line.
        }

        int temporary = array[i];       // Change current possition
        array[i] = array[minPosition];  // with position
        array[minPosition] = temporary; // what we have find
    }
}


printArray(arr);

selectionSort(arr);
printArray(arr);