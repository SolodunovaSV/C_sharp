/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4
x=2; y=4-> 1
x=-34; y=-30 -> 3
*/

int GetNumberOfQuarter (int X, int Y)
{
    int result = 0;
    if (X > 0 && Y > 0)
    {
        result = 1;
    }
    else if (X < 0 && Y > 0)
    {
        result = 2;
    }
    else if (X < 0 && Y < 0)
    {
        result = 3;
    }
    else if (X > 0 && Y < 0)
    {
        result = 4;
    }
    return result;
}
Console.WriteLine("Введите переменную X ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную Y ");
int userY = Convert.ToInt32(Console.ReadLine());

int quarter = GetNumberOfQuarter(userX, userY);
if (quarter > 0)
{
    Console.WriteLine($"Точка [{userX} : {userY}] находится в {quarter} плоскости");
}
else
{
    Console.WriteLine($"Точка [{userX} : {userY}] находится на пересечениии плоскостей");
}