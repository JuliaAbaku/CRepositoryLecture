// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");

int number = int.Parse(Console.ReadLine());

if (number > 7)
     Console.WriteLine("Некорректное число.");
else
{
    if (number == 6 || number == 7)
        {
        Console.WriteLine("Выходной");
        }
    else 
        {
        Console.WriteLine("Будний день");
        }
}
