using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(2);
        Fraction frac3 = new Fraction(2,3);

        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac3.GetFractionString());
    }
}