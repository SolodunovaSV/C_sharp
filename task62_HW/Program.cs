/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


void FillSpiralMatrix(int[,] array)
{    
    int value = 1;
    int minRow = 0, maxRow = 3;
    int minCol = 0, maxCol = 3;
    while (value <= 16)
    {
        for (int i = minCol; i <= maxCol; i++)   // Вправо
        {
            array[minRow, i] = value++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)   // Вниз
        {
            array[i, maxCol] = value++;
        }
        maxCol--;
        for (int i = maxCol; i >= minCol; i--)   // Влево
        {
            array[maxRow, i] = value++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--)   // Вверх
        {
            array[i, minCol] = value++;
        }
        minCol++;
    }
}

void Print2DArray (int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
FillSpiralMatrix(array);
Print2DArray(array);