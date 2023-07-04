string QuadrantRange(int quadrant)
{
    if (quadrant == 1) return "x > 0; y > 0";
    else if (quadrant == 2) return "x < 0; y > 0";
    else if (quadrant == 3) return "x < 0; y < 0";
    else if (quadrant == 4) return "x > 0; y < 0";
    else return "invalid quadrant";
}
Console.Write("Enter a quadrant number: ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(QuadrantRange(quarter));