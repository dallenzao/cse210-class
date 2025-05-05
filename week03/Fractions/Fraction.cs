// Dallen Harmon
//CSE210
// Week 3 - Fraction Example

using System.IO.Compression;

public class Fraction
{
    private int _top; // Numerator 
    private int _bottom; // Denominator

    public Fraction() // Makes the fraction 1 over 1 if no arguments are given.
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) // Creates a fraction for a Whole Number
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) // Creates a fraction.
    {
        _top = top;
        _bottom = bottom;
    }

    // Setters and Getters fuctions
    public int GetTop(){ return _top;} // Returns top value
    public int GetBottom() { return _bottom;} // Returns bottom value
    public void SetTop(int top){ _top = top;} // Sets top value
    public void SetBottom(int bottom){ _bottom = bottom;} // Sets bottom value

    public string GetFractionString(){
        return $"{_top}/{_bottom}"; // Returns the fraction as a string
    }
    public double GetDecimalValue(){
        double top = _top;
        double bottom = _bottom;
        return top / bottom; // Returns the fractions as a decimal
    }
    

}
