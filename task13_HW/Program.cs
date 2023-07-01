/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int Prompt(string msg)
{
    Console.WriteLine(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int ThirdNum(int number)
{
    while (number > 999)
    {
        number = number /10;
    }
    return number % 10;
}
bool check(int number)
{
    if (number < 100) 
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int number = Prompt("Введите число ");
if (check(number))  
{
    Console.WriteLine($"Третьей цифрой числа {number} является {ThirdNum(number)}");
}