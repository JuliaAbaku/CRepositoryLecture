// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] array = FillArray(10,0,9);

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

int sumNegativeElements = 0;

for (int i = 1; i < array.Length; i=i+2)
{
    sumNegativeElements = sumNegativeElements + array[i];
}

Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях равна {sumNegativeElements}");