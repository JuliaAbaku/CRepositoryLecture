// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();


int[] array = FillArray(10,100,1000);

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max+1);
    }
    return filledArray;
}

Console.WriteLine("[" + String.Join(",",array) + "]");

int count = 0;

 for (int i = 0; i < array.Length; i++)
 {
    if (array[i]%2==0)
        count += 1;
    else
        count += 0;
 }

Console.WriteLine($"Количество чётных чисел в массиве: {count}");