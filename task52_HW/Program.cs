/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int[,] CreateAndFillArray(int rows, int columns, int start, int end)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }   
}

void AverageOfColumns(int[,] array)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average += array[j, i];
        }
        average = average / array.GetLength(0);
        average = Math.Round(average, 2);
        Console.Write(average + "; ");
   }
    Console.WriteLine();
}

int[,] numbers = CreateAndFillArray(3, 4, 1, 10);
PrintArray(numbers);
AverageOfColumns(numbers);