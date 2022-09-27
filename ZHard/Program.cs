// // Напишите программу, которая на вход принимает радиус круга 
// и находит его площадь округленную до целого числа, 
// необходимо вывести максимальную цифру в полученном округлённом значении площади круга.

Console.WriteLine("Введите радиус: ");
int numb = int.Parse(Console.ReadLine());

double Sqr = 3.14 * Math.Pow((numb),2);

Console.WriteLine(Sqr);

Console.WriteLine(Math.Round(Sqr, 0)); // Не понимаю, как можно округлить число. Типа а = Math.Round(Sqr, 0), но выдает ошибку
int numb1 = int.Parse(Console.ReadLine());

string numb2 = numb1.ToString(); // Тут тоже не могу алгоритм написать. Нужно проиндексироваь число и сравнить вес каждого индекса. И выбрать максимальный
int length = numb2.Length;
int max = 0;
for(int i = 0; i < length; i++)
{
    if(numb2[i] > max) max = i;
}
Console.WriteLine($"Максимальное число {max}");

// string Sqr1 = Sqr.ToString();

// int max = Sqr1[0];

// for(int i = 0; i < Sqr1.Length; i++)
// {
//     int max > Sqr1[i];
//     int max = Sqr1[i];
// }
// Console.WriteLine($"Максимальное число {max}");