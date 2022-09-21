// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число больше 1: ");

int a = int.Parse(Console.ReadLine());
int b = 2;
if (a <=1)
{
     Console.WriteLine("Некорректное число");
}
while (b <= a)
{
    Console.WriteLine(b);
    b = b + 2;
}