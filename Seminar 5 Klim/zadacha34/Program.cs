//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.

Console.Write("Введите колличество трехзначных чисел в массиве: ");
int size = int.Parse(Console.ReadLine()!);

int[] GetArrayRandom(int size)
{
    int[]array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void PrintArray(int[]GetArrayRandom)
{
    foreach (var item in GetArrayRandom)
    {
        Console.Write(item+ " ");
    }
}

int[]array2 = GetArrayRandom(size);
PrintArray(array2);

//int[]array = new int[] {321, 561, 555, 459, 693, 767, 429, 123};

void NumberOfEvenNumbers(int[]array2)
{
    int count = 0;
        for (int i = 0; i < array2.Length; i++)
        {
            if(array2[i] % 2 == 0)
            {
                 count++;
            }    
        }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}
NumberOfEvenNumbers(array2);
    



