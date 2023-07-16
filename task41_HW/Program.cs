/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

void Array(int length)
{
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Result(int[] array)
{
    int i = 0;
    int result = 0;
    while (i < array.Length)
    {
        if(array[i] > 0)
        result += 1;
        i++;
    }
    return result;
}

Array(length);
Console.Write($"Чисел больше нуля: {Result(array)}");
