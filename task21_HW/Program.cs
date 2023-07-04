/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координату X для первой точки ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для первой точки ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z для первой точки ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X для второй точки ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для второй точки ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z для второй точки ");
int bZ = Convert.ToInt32(Console.ReadLine());

int a = aY - bY;
int b = aX - bX;
int c = aZ - bZ;
double distance = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine(distance);