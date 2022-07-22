// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void MinSumRowElem(int[,] arr)
{
    int row = 0;
    int minsum = 10000;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if(sum < minsum)
        {
            minsum = sum;
            row = i + 1;
        }
    }
    Console.WriteLine($"Cтрока с наименьшей суммой элементов: {row}, сумма равна: {minsum}");
}

int[,] result = GetMatrix(3, 4, 0, 10);
PrintMatrix(result);
Console.WriteLine();
MinSumRowElem(result);
