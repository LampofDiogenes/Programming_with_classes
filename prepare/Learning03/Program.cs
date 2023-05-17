using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction Number1 = new Fraction();
        Number1.FractionFormat();
        Console.WriteLine(Number1);
        Number1.SetTop("5");

    }
}