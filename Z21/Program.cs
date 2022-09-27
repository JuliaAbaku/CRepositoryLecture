// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки: ");
int xa = int.Parse(Console.ReadLine());
int ya = int.Parse(Console.ReadLine());
int za = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
int xb = int.Parse(Console.ReadLine());
int yb = int.Parse(Console.ReadLine());
int zb = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));

Console.WriteLine($"Расстояние между точками: {result}.");