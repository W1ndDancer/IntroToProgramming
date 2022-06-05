// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

/*
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

int[,] newMatrix = new int[4,7];
FillMatrix(newMatrix);
PrintMatrix(newMatrix);
Console.WriteLine();
SortMatrixRowsMinToMax(newMatrix);
PrintMatrix(newMatrix);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
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
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

int FindRowWithMinSum(int[,] matrix)
{
    int[] sumOfRows = new int[matrix.GetLength(0)];
    int sum = 0;
    int minIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        sumOfRows[i] = sum;
        sum = 0;
    }

    for (int k = 1; k < sumOfRows.Length; k++)
    {
        if (sumOfRows[minIndex] > sumOfRows[k]) minIndex = k;
    }
    return minIndex;
}

Console.Write("Input number of rows in matrix. n = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns in matrix. m = ");
int m = Convert.ToInt32(Console.ReadLine());

if (n == m) Console.Write("Rows and columns cant be equal. Please repeat.");
else
{
    int[,] newMatrix = new int[n, m];
    FillMatrix(newMatrix);
    Console.WriteLine("Randomly generated matrix is:");
    PrintMatrix(newMatrix);
    int RowWithMinSum = FindRowWithMinSum(newMatrix);
    Console.Write($"Index oF row with min sum is {RowWithMinSum}");
}
*/

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

/*
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

int[,] newMatrix = new int[6, 6];
FillMatrixSpirally(newMatrix);
PrintMatrix(newMatrix);
*/
