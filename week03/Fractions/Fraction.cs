using System;
 
public class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        // Default constructor initializes to 1/1
        _top = 1;
        _bottom = 1;
    }
    // Constructor with one parameter - creates whole number fraction
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with two parameters - creates any fraction
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for top (numerator)
    public int GetTop()
    {
        return _top;
    }

    // Setter for top (numerator)
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for bottom (denominator)
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for bottom (denominator)
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns fraction as a string in format "top/bottom"
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // Return format - decimal
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}

