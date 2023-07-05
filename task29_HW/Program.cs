/*
Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите число, обозначающее начало"); //Что бы лишить пользователя права выбора, можно использовать просто рандомные числа.
int A = Convert.ToInt32(Console.ReadLine());             //Тогда первые 4 строки убираем
Console.WriteLine("Введите число, обозначающее окончание");
int B = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(A, B);   //А здесь пишем, например, array[i] = new Random().Next(0, 100);
}

PrintArray(array);