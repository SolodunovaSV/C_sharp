/*
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i,j] = new Random().Next(-deviation,deviation + 1);
        }
    }
    return result;
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

int[,] ProductOfMatrices(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Расчитать произведение двух матриц невозможно");
    }

    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
        int result = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result += matrix1[i, k] * matrix2[k, j];
            }
            product[i, j] = result;
        }
    }
    return product;
}

int[,] matrix1 = GetRandom2DArray(2, 2, 5);
int[,] matrix2 = GetRandom2DArray(2, 2, 5);
Print2DArray(matrix1);
Console.WriteLine();
Print2DArray(matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет: ");
Print2DArray(ProductOfMatrices(matrix1, matrix2));