// This is the parent class of the program called shapes
using System.Runtime.CompilerServices;

abstract class Shapes
{   
    // Attributes
    // This variable holds the color of the shape
    private string _color = "blue";

    // Constructors
    public Shapes()
    {

    } // End of the constructor

    // Behaviors
    // This method returns the color of the shape
    public string GetColor()
    {   
        // This returns the color of the shape
        return _color;

    } // End of GetColor method

    // This method sets the color of the shape
    public void SetColor(string color)
    {
        // This assigns the value of the color
        _color = color;

    } // End of the SetColor method

    // This is an abstract method that returns the area of the shape
    public abstract double GetArea();

} // End of class program