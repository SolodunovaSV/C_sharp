/*
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int FillNumberInArray (int [] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end)
        {
            count++;
        }
    }
    return count;
}

int [] getRandomArray(int length, int deviation)
{
    int [] result = new int[length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, deviation + 1);
    }
    return result;
}

void printArray (int[] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("[");
    for(int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor = ConsoleColor.White;
}

int [] MyArray = getRandomArray(123, 1000);
printArray(MyArray);

int result = FillNumberInArray(MyArray, 10, 99);
Console.WriteLine($"Колличество двухзначных чисел в массиве - {result}");