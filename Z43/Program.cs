// Задача 43. Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

double X = 0;
double Y = 0;

if (k1 == k2)
    Console.WriteLine("Прямые параллельны");

else
{
    X = (b2 - b1) / (k1 - k2);

    Y = k2 * X + b2;
}
Console.WriteLine($"Координаты: ({X} ; {Y})");