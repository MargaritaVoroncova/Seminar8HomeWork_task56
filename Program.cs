/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(min,max);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[] SumRow(int[,] array)
{
    int[] result = new int [array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           result[i] = result[i] + array[i,j];
        }
    }
    return result;
}

int MinValueIndex(int[] array)
{
    int result = 0;
    int minValue = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < minValue)
        {
            result = i;
            minValue = array[i];
        }
    }
    return result;
}

int rows = new Random().Next(2,10);
int columns = rows;

int[,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

int[] sumRow = SumRow(array);
for(int i = 0; i < sumRow.Length; i++)
{
    Console.Write($"{sumRow[i]} ");
Console.WriteLine();
}
Console.WriteLine($"Наименьшая сумма элементов в строке {MinValueIndex(sumRow) + 1}.");
