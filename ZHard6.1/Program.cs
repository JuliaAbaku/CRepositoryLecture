// Напишите программу, которая задаёт массив из n элементов, 
// которые необходимо заполнить случайными значениями 
// и сдвинуть элементы массива влево, или вправо на 1 позицию.

// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево

// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо


Console.Clear();

Console.Write("Введите размер массива: ");
int lenght = int.Parse(Console.ReadLine());

int[] array = FillArray(lenght,0,9);

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max+1);
    }
    return filledArray;
}

Console.WriteLine("Изначальный массив [" + String.Join(",",array) + "]");

int[] array1 = new int[array.Length];

    for (int i = 0; i < array.Length-1; i++)
    {
        array1[i] = array[i+1];
    }
    array1[array1.Length-1] = array[0];

Console.WriteLine("Массив сдвинут влево [" + String.Join(",",array1) + "]");



int[] array2 = new int[array.Length];

    for (int i = array.Length-1; i >= 1; i--)
    {
        array2[i] = array[i-1];
    }
    array2[0] = array[array1.Length-1];

Console.WriteLine("Массив сдвинут вправо [" + String.Join(",",array2) + "]");