// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

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
            matrix[i,j] = i + j;
        }
    }
}

Console.Write("Input number of rows. m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of colums. n = ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] newMatrix = new int[m,n];

FillMatrix(newMatrix);
PrintMatrix(newMatrix);
*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
            matrix[i, j] = new Random().Next(1, 6);
        }
    }
}

void EquaMatrixlIndextoSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+= 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+= 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] newMatrix = new int[4, 4];

FillMatrix(newMatrix);
PrintMatrix(newMatrix);
Console.WriteLine();
EquaMatrixlIndextoSquare(newMatrix);
PrintMatrix(newMatrix);
*/

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д

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

int FindSumOfMainDiagonal(int[,] matrix)
{
    int sumOfMainDiagonal = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumOfMainDiagonal += matrix[i, i];
    }
    return sumOfMainDiagonal;
}

int[,] newMatrix = new int[5, 5];

FillMatrix(newMatrix);
PrintMatrix(newMatrix);
Console.WriteLine();
Console.Write("Sum of main diagonal is --> " + FindSumOfMainDiagonal(newMatrix));
*/