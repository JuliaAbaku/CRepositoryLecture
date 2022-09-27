// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");

int numb = int.Parse(Console.ReadLine());
string numb1 = numb.ToString();


if (numb1.Length != 5) // Не понимаю, почему 5, а не 4, ведь индексы идут с 0,1,2,3,4
                       // что соответствует числу                           9 8 7 8 9
{
    Console.WriteLine("Вы ввели неверное число.");
}
else
{
    if (numb1[0]==numb1[4] && numb1[1]==numb1[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

