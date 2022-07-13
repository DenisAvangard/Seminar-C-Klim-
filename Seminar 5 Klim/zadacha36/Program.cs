// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите колличество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] GetArrayRandom(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

void PrintArray(int[] GetArrayRandom)
{
    foreach (var item in GetArrayRandom)
    {
        Console.Write(item+" ");
    }
}
int[] array2 = GetArrayRandom(size);
PrintArray(array2);
int sum = 0;
for (int i = 0; i < array2.Length; i+=2)
{
    sum = sum + array2[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве = {sum}");