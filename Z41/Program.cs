// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Clear();
Console.Write("Введите размер массива: ");

int lenght = int.Parse(Console.ReadLine());
int[] array = new int[lenght];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}: ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Массив: [" + String.Join(",",array) + "]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]>0)
    count =count+1;
    else
    count =count+0;
}
Console.WriteLine($"Вы ввели {count} чисел больше 0");