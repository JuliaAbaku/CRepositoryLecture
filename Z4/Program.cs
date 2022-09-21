// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Write("Введите три числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int с = int.Parse(Console.ReadLine());
int max = a;
if (max<b);
max = b;
if(max<с);
max = с;
Console.Write("Максимальное число: " + max);
