/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int mult = 0;

if (Number > 0)
{
    while (count < Number + 1)
    {
        mult = count * count * count;
        count++;
        Console.Write($"{mult}, ");
    }
}
else 
{
    count = count * (-1);
    while (count > Number - 1)
    {
        mult = (count * count * count) * (-1);
        count = count - 1;
        Console.Write($"{mult}, ");
    }
}