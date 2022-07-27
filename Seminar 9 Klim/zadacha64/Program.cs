// Задача 64: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumOfElem(int m, int n, int sum = 0)
{   
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + m;
    m++;
    SumOfElem(m, n, sum);
}

SumOfElem(2, 5);