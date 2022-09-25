// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");

int a = int.Parse(Console.ReadLine());

int b = a / 10;
int c = a / 100 * 10;
int d = b - c;
Console.WriteLine(d);
