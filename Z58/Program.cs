// Задача 58: Задайте две матрицы. 
// Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

int[,] array1 = FillArray(rowCount, columnCount, 1, 9);

PrintArray(array1);

Console.WriteLine();

int[,] array2 = FillArray(rowCount, columnCount, 1, 9);

PrintArray(array2);


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


int[,] array3 = Multiply(rowCount, columnCount);


int[,] Multiply(int rows, int columns)
{
    int[,] multiply = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            for (int k = 0; k < columns; k++)
            {
                sum += array1[i,k]*array2[k,j];
                
            }
           multiply[i,j] = sum;
        }
    }
    return multiply;
}

Console.WriteLine();
PrintArray(array3);