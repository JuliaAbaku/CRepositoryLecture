﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

double[,] array = FillArray(rowCount, columnCount, 0.1, 0.9); // Тут числа мин и макс не учавствуют

PrintArray(array);


double[,] FillArray(int rows, int columns, double min, double max)
{
    double[,] filledArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().NextDouble(); // Не могу сюда задать мин и макс числа из которых надо собирать массив
            filledArray[i, j] = Math.Round(filledArray[i, j], 1);
        }
    }
    return filledArray;
}

void PrintArray(double[,] inputArray)
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