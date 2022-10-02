// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();

// Console.WriteLine("Введите число");
// int numb = int.Parse(Console.ReadLine());

// string numb1 = numb.ToString();

// int sum = 0;
// for (int i = 0; i <= numb1.Length-1; i++)
// {
//    sum = sum + Convert.ToInt32(numb1[i]-'0'); // сама думала что  sum = sum + numb1[i], но не получается.
//                                             // Потом поняла, что надо конвертировать numb1[i] в число int
//                                             // Все равно не получалось. В интернете нашла что надо -'0'
//                                             // Но я не понимаю, что это. Дайте, пожалуйста, пояснение
// }
// Console.WriteLine(sum);




Console.Clear();

Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine());
int sum = 0;
while (numb>0)
{
    sum = sum + (numb%10);
    numb = numb/10;
}
Console.WriteLine(sum);