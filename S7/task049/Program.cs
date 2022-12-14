/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса нечётные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
1 47 2
5 92 3
8 42 4
Новый массив будет выглядеть вот так:
1 47 2
5 81 9
8 42 4 */

using static UserMethods.Method;

Console.WriteLine("Create 2d array: enter m(rows) and n(colums)");
int [,]arrayCreate = CreatedRandom2dArray(InputUIntNumberTryParse(), InputUIntNumberTryParse());
Print2dArray(arrayCreate);
Console.WriteLine();
int [,]arrayResult = SquareForUnevenIndexs(arrayCreate);
Print2dArray(arrayResult);

int[,] SquareForUnevenIndexs(int[,] arr)
{
    int[,] arr2 = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                arr2[i, j] = arr[i, j] * arr[i, j];
            }
            else
            {
                arr2[i, j] = arr[i, j];
            }
        }
    }
    return arr2;
}

