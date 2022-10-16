// Задача 54: Задайте двумерный массив. 
// Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1, 9);

PrintArray(array);
Console.WriteLine();

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] newArray = SortArray(array);


int[,] SortArray(int[,] inputArray)
{
    int[,] sortArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(1) - 1; k++)
            {
                if (array[i, k] < inputArray[i, k + 1])
                {
                    int temp = inputArray[i, k + 1];
                    inputArray[i, k + 1] = inputArray[i, k];
                    inputArray[i, k] = temp;
                }
            }
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
    return sortArray;

}

// Не совсем правильно работает. Нарушаются цифры в массиве, то в первом ряду, то в последнем.
// Не понимаю, что не так
