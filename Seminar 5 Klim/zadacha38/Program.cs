// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите колличество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);

double[] GetArrayRandom(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
        array[i] = Math.Round(array[i], 5);
    }
    return array;
}

void PrintArray(double[] GetArrayRandom)
{
     foreach (var item in GetArrayRandom)
     {
        Console.Write(item+" ");
     }
}
double[] array2 = GetArrayRandom(size);
PrintArray(array2);


void DiffBetwMaxMin(double[] array2)
{
    double min = array2[0];
    double max = array2[0];
    for (int i = 1; i < array2.Length; i++)
    {
        if(array2[i] < min)
        {
            min = array2[i];
        }
        if(array2[i] > max)
        {
            max = array2[i];
        }
    }
    min = Math.Round(min, 5);
    max = Math.Round(max, 5);
    double Difference = max - min;
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {Difference}");
}

DiffBetwMaxMin(array2);


