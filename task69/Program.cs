/*
Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int AToPowerB(int A, int B)
{
    if(B == 1)
    {
        return A;
    }
    else
    {
        return A * AToPowerB(A, B - 1);
    }
}
Console.WriteLine(AToPowerB(2, 3));