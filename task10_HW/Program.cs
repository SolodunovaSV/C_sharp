/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число ");

int number = Convert.ToInt32(Console.ReadLine());
int numberTwo = 0;

if (number < 100 || number > 999) Console.WriteLine("Необходимо ввести трехзначное число");

else 
{
    numberTwo = number / 10 % 10;
    Console.WriteLine($"Введенное число - {number}");
    Console.WriteLine($"Вторая цифра числа - {numberTwo}");
}
