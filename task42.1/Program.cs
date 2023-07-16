void DecimalToBinary(string[] args)
{
Console.Write("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string binaryNumber = Convert.ToString(decimalNumber, 2);

Console.WriteLine("Двоичное представление: " + binaryNumber);
}

DecimalToBinary(new string[0]);