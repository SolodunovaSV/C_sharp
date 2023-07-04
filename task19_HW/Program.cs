/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    if (number / 10000 == number % 10 || number / 1000 % 10  == 100 / 10)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.Write($"Число {number} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Необходимо ввести пятизначное число");
}
