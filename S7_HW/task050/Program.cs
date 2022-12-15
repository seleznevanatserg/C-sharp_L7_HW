/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using static UserMethods.Method;

int [,] generatedArray = GeneratedRandom2dArray();
Console.WriteLine("Enter row's and column's number for get number from array:");
int coordinateRow = InputIntNumberTryParse();
while(coordinateRow < 0) // отсеивание значений < 0 для строки, пока юзер нормально не введёт.
{
    Console.WriteLine($"Entered unacceptable number for ROW. Need number >= 0");
    coordinateRow = InputIntNumberTryParse(); 
}
int coordinateColumn = InputIntNumberTryParse();
while(coordinateColumn < 0) // отсеивание значений < 0 для столбца, пока юзер нормально не введёт.
{
    Console.WriteLine($"Entered unacceptable number for COLUMN. Need number >= 0");
    coordinateColumn = InputIntNumberTryParse(); 
}

Print2dGenArray(generatedArray);
Console.WriteLine($"Your coordinates: [{coordinateRow},{coordinateColumn}]");
string findResult = string.Empty;
bool result = FounderNumberInArray(coordinateRow, coordinateColumn, generatedArray, out findResult);
Console.WriteLine(findResult);

//
bool FounderNumberInArray(int coorRow, int coorColumn, int [,] array, out string findResult)
{

    if (coorRow < array.GetLength(0) && coorColumn < array.GetLength(1))
    {
        findResult = $"{array[coorRow,coorColumn]}";
        return true;
    }
    else
    {
        findResult = "Sorry, not found";
        return false;
    }
}

// Генерация массива с раномными строками/столбцами и значениями
int[,] GeneratedRandom2dArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(3,7);
    int columns = rnd.Next(3,7);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-20,21);
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
           // Console.SetCursorPosition((0+6*j), 0);
            Console.Write($"[{array[i, j]}]" + "\t");
        }
        Console.WriteLine();
    }
}