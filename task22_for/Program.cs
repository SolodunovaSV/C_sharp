string Squares(int n)
{
    string squares = "1";
    if (n > 2)
    {
        for (int i = 2; i <= n; i++)
        {
            squares = $"{squares} {i * i}";
        }
    }
    else
    {
        for (int i = 0; i >= n; i--)
        {
            squares = $"{squares} {i * i}";
        }
    }
    return squares;
}
Console.WriteLine("Enter a number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Squares(number));