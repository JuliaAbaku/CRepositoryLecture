// Задача 64: Задайте значения N и M. 
// Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8


Console.Clear();

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Введите число M: ");
int M = int.Parse(Console.ReadLine());



for (int i = N; i <= M; i++)
{
    if (i%2==0)
        Console.Write($"{i}" + " ");
}

// int res = Result;
// int Result(int N, int M)
// {
// if(N<=M)
// N = N+1;
// Console.Write($"{N}" + " ");
// if(N%2==0)
// return Result;

// }
