// Задайте одномерный массив из N элементов, заполненный случайными числами. 
// Необходимо определить, в какой последовательности заданы элементы массива: 
// по возрастанию, по убыванию, хаотично, или все элементы одинаковы.

// [1,2,3,4] -> по возрастанию

// [4,3,2,1] -> по убыванию

// [4,2,3,1] -> хаотично

// [1,1,1,1] -> все элементы равны


Console.Clear();
Console.WriteLine("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());


int[] array = FillArray(N, 0, 4);

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

// Логику понимаю, но код не получается. 
// Тут алгоритм сравнивает каждое число и по каждому сравнению выдает результат

// for (int i = 0; i < array.Length-1; i++)
// {
//     if (array[i] > array[i+1])
//     Console.WriteLine("по убыванию");
//     else if (array[i] < array[i+1])
//     Console.WriteLine("по возрастанию");
//     else if (array[i] == array[i+1])
//     Console.WriteLine("все элементы равны");
//     else
//     Console.WriteLine("хаотично");

// }

// int numb = array[0];
// for (int i = 0; i < array.Length-1; i++)
// {
//     if (numb>array[i])
//     {
//         numb = array[i];
//         Console.WriteLine("по убыванию");
//     }
//     else if (numb<array[i])
//     {
//         numb = array[i];
//         Console.WriteLine("по убыванию");
//     }
//     else if (numb==array[i])
//     {
//         numb = array[i];
//         Console.WriteLine("все элементы равны");
//     }
//     else
//     Console.WriteLine("хаотично");

// }