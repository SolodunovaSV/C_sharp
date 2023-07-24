﻿/*
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumOfElements(int m, int n)
{
    if(m <= n)
    {
        return m + SumOfElements(m + 1, n);
    }
    else
    return 0;
}
Console.WriteLine(SumOfElements(1,15));