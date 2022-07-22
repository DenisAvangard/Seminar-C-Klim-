// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetMatrix(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            Console.Write($"{mtrx[i, j],4} |");
        }
        Console.WriteLine();
    }
}

void DescendingSort(int[,] result)
{
    int temp = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1) - 1; k++)
            {
                if(result[i, k+1] > result[i, k])
                {
                    temp = result[i, k+1];
                    result[i, k+1] = result[i, k];
                    result[i, k] = temp;
                }
            }
        }
    }
}


int[,] result = GetMatrix(4, 5, 1, 10);
PrintMatrix(result);
DescendingSort(result);
System.Console.WriteLine();
PrintMatrix(result);