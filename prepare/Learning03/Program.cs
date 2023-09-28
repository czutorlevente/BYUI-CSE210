using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number = new Fraction(1, 3);
        int top = number.GetTop();
        int bottom = number.GetBottom();
        Console.WriteLine(top);
        Console.WriteLine(bottom);

        string fraction_2 = number.GetFractionString();
        Console.WriteLine(fraction_2);

        double decimal_1 = number.GetDecimalValue();
        Console.WriteLine(decimal_1);
    }
}