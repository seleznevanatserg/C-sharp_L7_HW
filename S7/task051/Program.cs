/* Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив: 
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */

using static UserMethods.Method;

Console.WriteLine("Create 2d array: enter m(rows) and n(colums)");
int [,]arrayCreate = CreatedRandom2dArray(InputUIntNumberTryParse(), InputUIntNumberTryParse());
Print2dArray(arrayCreate);
int sumStrip = SumStripArray(arrayCreate);
Console.WriteLine($"{sumStrip} = sum numbers on main diagonal ([0,0], [1,1] and etc.)");

int SumStripArray (int [,] array)
{
    int sum = 0;
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == i)
            {
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}