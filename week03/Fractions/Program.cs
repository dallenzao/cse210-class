using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(8, 3);
        
        PrintFractionStuff(f1, 1);
        PrintFractionStuff(f2, 2);
        PrintFractionStuff(f3, 3);
        PrintFractionStuff(f4, 4);
        Console.WriteLine("------");
        Console.WriteLine("------");
        Fraction f5 = MakeAFraction();
        PrintFractionStuff(f5, 5);

    }
    static void PrintFractionStuff(Fraction f, int fnumber){ //Method to print out all the fractions stuff for testing
        Console.WriteLine($"Fraction Number: {fnumber}");
        Console.WriteLine("Top:" + f.GetTop());
        Console.WriteLine("Bottom: " + f.GetTop());
        Console.WriteLine("String Version: " + f.GetFractionString());
        Console.WriteLine("Decimal Version: " + f.GetDecimalValue());
        Console.WriteLine("------");
    }

    static Fraction MakeAFraction(){
        // This is mostly so we can test the Set methods
        Console.Write("Numerator? :");
        string strtop = Console.ReadLine();
        Console.Write("Denominator? :");
        string strbottom = Console.ReadLine();

        // This tries to make the entered strings an int, if it cant, it just makes it null.
        Nullable<int> top;
        Nullable<int> bottom;
        try{ top = Int32.Parse(strtop); }
        catch {top = null; }
        try{ bottom = Int32.Parse(strbottom); }
        catch {bottom = null; }
        
        Fraction myFraction = new Fraction();
        Console.WriteLine(bottom);
        if (top != null && bottom != null){
            myFraction.SetTop(top.Value);
            myFraction.SetBottom(bottom.Value);
        }
        else if (top != null && bottom == null){
            myFraction.SetTop(top.Value);
        }
        return myFraction;

    }
}