﻿/*
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void NatureNum (int number, int count = 1)
{
    if (number < count)
    return;
    else
    {
       Console.Write(count + " ");
       NatureNum(number, count + 1);
    }
}
NatureNum(5);