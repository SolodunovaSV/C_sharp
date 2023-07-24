/*
Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

void NumbersRec(int start, int end)
{
    if(start <= end)
    {
        Console.Write(start + " ");
        NumbersRec(start + 1, end);
    }
}
NumbersRec(1, 5);