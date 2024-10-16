class Fraction
{
    //Attributes
    // This variable will have the numerator
    private int _top;
    // This variable will have the denominator
    private int _bottom;

    //Constructors
    // Empty constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that accepts whole numbers
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor that accepts two numbers
    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    //Behaviors
    public void GetTop()
    {
        Console.WriteLine(_top);
    }

    public void SetTop(int topNumber)
    {
        _top = topNumber;   
    }

    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }

    public void SetBottom(int bottomNumber)
    {
        _bottom = bottomNumber;
    }

    public string GetFractionString()
    {
        string stringFraction = $"{_top}/{_bottom}";

        return stringFraction;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;

        return decimalValue;
    }

} // End of Fraction class