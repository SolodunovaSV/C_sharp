/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [] newArray = Numbers(90); 
int[,,] GetRandom3DArray(int rows, int columns, int depth)
{
    int[,,] result = new int[rows, columns, depth];
    int randomNum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           for (int k = 0; k < depth; k++)
           {
             result[i,j,k] = newArray[randomNum];
             randomNum++;
           }
        }
    }
    return result;
}

void Print3DArray(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                Console.Write($"{arrayToPrint[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

int[] Numbers(int arraySize)
{
    int[] numbers = new int[arraySize];
    for (int i = 0; i < numbers.Length; i++)
    {
        int num;
        do
        {
            num = new Random().Next(10, 100);
        } 
        while(Array.IndexOf(numbers, num) != -1);
        numbers[i] = num;
    } 
    return numbers;
} 

int[,,] matrix = GetRandom3DArray(2, 2, 2);
Print3DArray(matrix);
