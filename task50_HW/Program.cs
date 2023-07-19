/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] Get2DArray(int rowNumber, int colNumber)
{
    int[,] array = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            array[i,j] = new Random().Next(-100, 100);
        }
    }
    return array;
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

void ElementValue(int[,] array)
{
    Console.WriteLine("введите номер строки ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите номер столбца ");
    int m = Convert.ToInt32(Console.ReadLine());
    if ((n > array.GetLength(0)) || (m > array.GetLength(1)))
        {
            Console.WriteLine($"Элемента с заданными параметрами в массиве нет");
        }
    else    
        {
            Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {array[n - 1, m - 1]}");
        }
       
}

int[,] array = Get2DArray(3, 4);
Print2DArray(array);
Console.WriteLine();
ElementValue(array);
