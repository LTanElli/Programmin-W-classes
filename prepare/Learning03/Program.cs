using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFraction());
        Console.WriteLine(fraction1.GetDecimal());

        Fraction fraction2 = new Fraction(7);
        Console.WriteLine(fraction2.GetFraction());
        Console.WriteLine(fraction2.GetDecimal());

        Fraction fraction3 = new Fraction(2, 6);
        Console.WriteLine(fraction3.GetFraction());
        Console.WriteLine(fraction3.GetDecimal());

        Fraction fraction4 = new Fraction(10, 100);
        Console.WriteLine(fraction4.GetFraction());
        Console.WriteLine(fraction4.GetDecimal());

        
    }
}



public class Fraction 
{
    private int topNumber;
    private int bottomNumber;

    public Fraction() {
        topNumber = 1;
        bottomNumber = 1;
    }

    public Fraction(int number) {
        topNumber = number;
        bottomNumber = 1;
    }

    public Fraction(int top, int bottom) {
        topNumber = top;
        bottomNumber = bottom;
    }

    public string GetFraction() {
        string fract = $"Fraction: {topNumber}/{bottomNumber}";
        return fract;
    }

    public double GetDecimal() {
        //double is for floating point numbers. In py this was "float". I think this was discussed in class but I had to look it up.
        return (double)topNumber / (double)bottomNumber;
    }
}