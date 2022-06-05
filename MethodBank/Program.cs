/*

// ARRAY METHODS

void CreateRandomArrayNPrint(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + " ");
    }
}

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

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

void FlipTheArray(int[] array)
{

    for (int i = 0; i < array.Length / 2; i++)
    {
        int temporary = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temporary;
    }
}

void SortArray(int[] array)
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


// MATRIX METHODS

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
}

void SwapRowsWithColumns(int[,] matrix)
{
    int size = matrix.GetLength(0);

    for (int i = 0; i < size; i++)
    {
        for (int j =1+i; j < size; j++)
        {
            int temporary = matrix[j, i];
            matrix[j, i] = matrix[i, j];
            matrix[i, j] = temporary;
        }
    }
}

void SortMatrixRowsMinToMax(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            int min = j;

            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] < matrix[i, min]) min = k;
            }
                int temporary = matrix[i,j];
                matrix[i,j] = matrix[i, min];
                matrix [i, min] = temporary;
        }
    }
}

void FillMatrixSpirally(int[,] matrix)
{
    int length = matrix.GetLength(0);
    int count = 1;
    int spiralCount = length / 2 + length % 2;

    for (int i = 1; i <= spiralCount; i++)
    {
        for (int j = i - 1; j <= length - i; j++) matrix[i - 1, j] = count++;
        for (int j = i; j <= length - i; j++) matrix[j, length - i] = count++;
        for (int j = length - i - 1; j >= i - 1; j--) matrix[length - i, j] = count++;
        for (int j = length - i - 1; j >= i; j--) matrix[j, i - 1] = count++;
    }
}

// MATHEMATICS METHODS

bool IsTriangleExist(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        return true;
    }
    return false;
}

int ExponantiateANumber(int numA, int numB)
{
    int exponAtoB = 1;

    for (int i = 1; i <= numB; i++)
    {
        exponAtoB = exponAtoB*numA;
    }
    return exponAtoB;
}

*/