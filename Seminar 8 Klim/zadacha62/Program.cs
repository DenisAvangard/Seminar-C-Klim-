﻿// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] array = new int[4, 4];
void GetArrayOnSpiral(int[,] array)
{
    int n = 0;
    for (int i = 0; i < array.GetLength(0)-3; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = n + 1;
            n++;
        }   
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1)-1] = n + 1;
            n++;
    }
    for (int j = 2; j >= array.GetLength(1)-4; j--)
    {
        array[array.GetLength(0)-1, j] = n + 1;
            n++;
    }
    for (int i = 2; i > array.GetLength(0)-4; i--)
    {
        array[i, array.GetLength(1)-4] = n + 1;
            n++;
    }
    for (int j = 1; j < array.GetLength(1)-1; j++)
    {
        array[array.GetLength(0)-3, j] = n + 1;
            n++;
    }
    for (int j = 2; j > array.GetLength(0)-4; j--)
    {
        array[array.GetLength(0)-2, j] = n + 1;
            n++;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],3} ");
        }
        System.Console.WriteLine();
    }
}
GetArrayOnSpiral(array);
PrintArray(array);
