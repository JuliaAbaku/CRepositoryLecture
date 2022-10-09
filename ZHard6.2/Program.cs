// Напишите программу, которая задаёт массив из n элементов, 
// которые необходимо заполнить случайными значениями 
// и определить существует ли пара соседних элементов с одинаковыми значениями, 
// при наличии такого элемента заменить его на уникакальное значение.

// [1,2,3,3] -> [1,2,3,4]

Console.Clear();

Console.Write("Введите размер массива: ");
int lenght = int.Parse(Console.ReadLine());

int[] array = FillArray(lenght,0,4);

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


int [] array1 = new int [array.Length];

for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != array[i+1])
            Console.WriteLine("В массиве нет одинаковых рядомстоящих элементов");
        else
        {
            if(array[i] == array[i+1])
                array1[i] = array[i];
                array1[i+1] = new Random().Next();
        }
    }
Console.WriteLine("[" + String.Join(",",array1) + "]");