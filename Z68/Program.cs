// Задача 68: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

// M = 28; N = 7 -> 7

Console.Clear();

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Введите число M: ");
int M = int.Parse(Console.ReadLine());

int res = 0;
for (int i = 1; i <= N && i<=M; i++)
{
    if(N%i==0 && M%i==0)
        res = i;
}
Console.WriteLine(res);