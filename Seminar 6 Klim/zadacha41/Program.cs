// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
СountPositive(array);

void СountPositive(int[]array)
{
    
    int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0)
            {
                count++;
            }
        }
    Console.WriteLine($"Колличество чисел больше 0 = {count}");        
}
