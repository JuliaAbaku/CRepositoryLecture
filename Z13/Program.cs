// Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");

int a = int.Parse(Console.ReadLine());
string a1 = a.ToString();

if (a1.Length >=3)
    Console.WriteLine(a.ToString()[2]);
else
    Console.WriteLine("Третьей цифры нет");