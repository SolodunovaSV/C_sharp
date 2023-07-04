/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.WriteLine("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int mult = 0;

if (Num > 0)
{
    while (count < Num + 1)
    {
        mult = count * count;
        count++;
        Console.Write($"{mult}, ");
    }
}
else 
{
    count = count * (-1);
    while (count > Num - 1)
    {
        mult = count * count;
        count = count - 1;
        Console.Write($"{mult}, ");
    }
}