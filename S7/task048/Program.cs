/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4. 
0 1 2 3
1 2 3 4
2 3 4 5 */

using static UserMethods.Method;

Console.WriteLine("Create 2d array: enter m(rows) and n(colums)");
int [,] arrayMxN = CreatedRandom2dArray(InputUIntNumberTryParse(),InputUIntNumberTryParse());
Print2dArray(arrayMxN);

int[,] CreatedRandom2dArray(uint countOfRows, uint countOfColumns)
{
    int[,] array = new int[countOfRows, countOfColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}