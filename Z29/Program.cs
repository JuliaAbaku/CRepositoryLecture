// Задача 29: Напишите программу, которая задаёт массив из N элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите число элементов в массиве");
int N = int.Parse(Console.ReadLine());

int[] Random01(int[] array_local)
{
    Random rnd = new Random();
    for (int i = 0; i < array_local.Length; i++)
    {
        array_local[i] = rnd.Next(0, 11); // тут 11 - это числа которые можно использовать. 
                                          // Получается массив будет состоять из чисел от 0 до 10
                                          
    }
    return array_local;
}

int[] array = new int[N];
array = Random01(array);

Console.Write(String.Join(",",array));