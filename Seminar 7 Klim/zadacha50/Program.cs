// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество рядов двумерного массива: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("Введите min позицию: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите max позицию: ");
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


void ItemInIndex(int[,] result)

{
    Console.WriteLine("Для поиска нужного вам элемента ");
    Console.Write("Введите ряд элемента двумерного массива: ");
    int mx = int.Parse(Console.ReadLine()!);
    Console.Write("Введите колонку элемента двумерного массива: ");
    int nx = int.Parse(Console.ReadLine()!);

    if (result.Length >= (mx * nx))
    {
        Console.WriteLine($"Элемент в индексе [{mx},{nx}]: " + result[mx - 1, nx - 1]);
    }
    else
    {
        Console.WriteLine("Нет числа");
    }

}

int[,] result = GetMatrix(row, column, min, max);
PrintMatrix(result);
ItemInIndex(result);
