// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void ChangeRows(int[,] matrix)
{
    int i = matrix.GetLength(0) - 1;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temporary = matrix[i, j];
        matrix[i, j] = matrix[0,j];
        matrix[0, j] = temporary;
    }
}

int[,] newMatrix = new int[5, 3];

FillMatrix(newMatrix);
PrintMatrix(newMatrix);
Console.WriteLine();

ChangeRows(newMatrix);
PrintMatrix(newMatrix);
*/

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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


int[,] newMatrix = new int[4, 4];

FillMatrix(newMatrix);
PrintMatrix(newMatrix);
Console.WriteLine();

SwapRowsWithColumns(newMatrix);
PrintMatrix(newMatrix);
*/