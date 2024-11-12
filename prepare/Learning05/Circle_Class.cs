// This is a child class named circle
class Circle : Shapes
{   
    // Attributes
    // This variable holds the value of the radius
    private double _radius = 8;

    // Constructors
    public Circle()
    {

    } // End of constructor

    // Behaviors
    // This method returns the area of a circle
    public override double GetArea()
    {
       // This returns the area
       return Math.PI * _radius * _radius;

    } // End of GetArea

} // End of child class circle