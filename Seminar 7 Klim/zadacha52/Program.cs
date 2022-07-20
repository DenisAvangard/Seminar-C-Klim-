// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество рядов двумерного массива: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("Введите min значение элементов матрицы: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите max значение элементов матрицы: ");
int max = int.Parse(Console.ReadLine()!);


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

void ArithmeticMeanColumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        double answer = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }

        answer = sum / array.GetLength(0);

        Console.WriteLine($"Среднее арифметическое элементов в столбце {i} = {answer,4} ");
    }
}

int[,] result = GetMatrix(row, column, min, max);
PrintMatrix(result);
System.Console.WriteLine();
ArithmeticMeanColumn(result);
