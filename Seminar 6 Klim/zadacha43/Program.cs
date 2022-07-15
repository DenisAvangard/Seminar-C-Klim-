// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 4);
    y = Math.Round(y, 4);
    Console.WriteLine($"Точка пересечения двух прямых: {x};{y}");
}

IntersectionPoint(b1, k1, b2, k2);







