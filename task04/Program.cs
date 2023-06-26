/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите трехзначное число ");

int number = Convert.ToInt32(Console.ReadLine());
int integer = 0;

if (number < 100 || number > 999) Console.WriteLine("Трехзначное");

else 
{
    integer = number % 10;
    Console.WriteLine(integer);
}