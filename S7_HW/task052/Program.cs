/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using static UserMethods.Method;

int[,] randomArray = GeneratedRandom2dArray();
double[] avgArray = AvgNumbersInColumnsArray(randomArray);
Print2dGenArray(randomArray);
Console.WriteLine("AVG number everyone column:");
PrintArray(avgArray);

//Подсчёт средного значения для каждого столбца массива 
double[] AvgNumbersInColumnsArray(int[,] array)
{
    double[] avgArray = new double[array.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        avgArray[i] = Math.Round(sum / array.GetLength(1), 2);
    }
    return avgArray;
}
// Генерация массива с раномными строками/столбцами и значениями
int[,] GeneratedRandom2dArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(2, 7);
    int columns = rnd.Next(2, 7);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 11);
        }
    }
    return array;
}
// Печать массива
void Print2dGenArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]" + "\t");
        }
        Console.WriteLine();
    }
}