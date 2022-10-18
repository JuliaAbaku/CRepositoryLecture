// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Введите число M: ");
int M = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = N; i <= M; i++)
{
    sum = sum+i;
}


// Не работает. Возвращает 0.
// int Sum(int N)
// {
//     if (N == M)
//     return sum;

//     return(sum + Sum(N+1));
// }
// int res = Sum(N);

Console.WriteLine(sum);