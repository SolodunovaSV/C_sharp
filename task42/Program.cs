﻿/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.WriteLine("Введите число ");
int value = Convert.ToInt32(Console.ReadLine());

int binary = 0;
int shift = 1;
while(value != 0)
{
    binary += value % 2 * shift;
    shift *= 10;
    value /= 2;
}

Console.Write(binary);