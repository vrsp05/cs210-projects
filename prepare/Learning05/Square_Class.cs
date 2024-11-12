// This is is a child class from the parent shape class
class Square : Shapes
{
    // Attributes
    // This variable hold the value of the side of the square
    private double _side = 10;

    // Constructor
    public Square()
    {

    } // End of constructor

    // Behavior
    // This method returns the area of the shape of a square
    public override double GetArea()
    {   
        // This returns the area of the square
        return _side * _side;

    } // End of the GetArea method

} // End of child class Square