// Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите два числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if(a>b)
{
    Console.Write("Большее число " + a + ", меньшее число " + b);
}
else
{
    Console.Write("Большее число " + b + ", меньшее число " + a);
}