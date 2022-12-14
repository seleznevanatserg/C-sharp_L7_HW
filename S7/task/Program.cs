int [,] array = CreatedRandom2dArray(4,4);
Print2dArray(array);

int [,] CreatedRandom2dArray(int countOfRows, int countOfColumns)
{
    Random rnd = new Random();
    int [,] array = new int [countOfRows, countOfColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-10,11);
        }
    }
    return array;
}

void Print2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i,j]}] ");
        }
        Console.WriteLine();
    }
}