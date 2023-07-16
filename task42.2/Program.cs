double DecimalToBinary(int dec)
{
double bin = 0;
int count = 0;
while (dec > 0)
{
bin += dec % 2 * Math.Pow(10, count);
dec /= 2;
count++;
}
return bin;
}

Console.WriteLine(DecimalToBinary(45));