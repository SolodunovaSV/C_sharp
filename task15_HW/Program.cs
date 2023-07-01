/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру, обозначающую день недели ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

if (DayOfWeek < 1 || DayOfWeek > 7) 
{
    Console.WriteLine("Вы ввели неверное число, не совпадающее с днем недели");
    return;
}
if (DayOfWeek > 5)
{
    Console.WriteLine("Ура! Это выходной!");
}
else
{
    Console.WriteLine("К сожалению, это рабочий день...");
}
