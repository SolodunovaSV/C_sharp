﻿/*
Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

void Numbers(int start, int end, int n) //Где-то здесь спрятался Фибоначчи...
{
    if (n > 1)
    {
        Console.Write(start + " ");
        Numbers(end, start + end, n - 1);
    }
    else
    {
        Console.WriteLine(start);
    }
}
Numbers(3,4,5);