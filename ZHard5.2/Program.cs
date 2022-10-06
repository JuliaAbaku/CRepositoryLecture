// Задайте одномерный массив, заполненный случайными числами. 
// Из входного массива сформируйте массив 
// с чётными и массив с нечётными значениями элементов входного массива. 
//Найдите ср. арифметическое из полученных значений элементов массивов 
// и выведите результат сравнения средних арифметических.

// [1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами

// [2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами

// [1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами


Console.Clear();

int[] array = FillArray(10,1,9);

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

int countPos = 0;

 for (int i = 0; i < array.Length; i++)
 {
    if (array[i]%2==0)
        countPos += 1;
    else
        countPos += 0;
 }
Console.WriteLine($"Количество чётных чисел в массиве: {countPos}");

int countNeg = array.Length - countPos;

Console.WriteLine($"Количество нечётных чисел в массиве: {countNeg}");

int [] positiveArray = new int[countPos];
int [] negativeArray = new int[countNeg];

for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0)
        positiveArray[i] = array[i];
    }
// не понимаю как вывести положит. массив
