/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число ");
int sum = 0;
int i = Convert.ToInt32(Console.ReadLine());

while (i > 0)
{
    int num = i % 10;
    i /= 10;
    sum += num;
}
Console.WriteLine($"Сумма цифр в числе равна {sum}");