// Задача 66: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AckermanFunction(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AckermanFunction(n - 1, 1);
    else
      return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}
Console.WriteLine(AckermanFunction(2, 3));