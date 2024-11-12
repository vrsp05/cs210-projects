// This is the child class named Rectangle
class Rectangle : Shapes
{
    // Attribute
    // This variable holds the width of the rectangle
    private double _width = 60;
    // This variable hold the lenqth of the reactangle
    private double _length = 70;

    // Constructor
    public Rectangle()
    {

    } // End of constructor

    // Behavior
    // This method returns the area of a rectangle
    public override double GetArea()
    {
        // This returns the area of the rectangle
        return _length * _width;

    } // End of the GetArea method 

} // End of child class rectangle