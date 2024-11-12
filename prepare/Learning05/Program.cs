using System;

// This is the main class program
class Program
{   
    // This is the main function of the program
    static void Main(string[] args)
    {   
        // This is the welcome message to the program
        Console.WriteLine();
        Console.WriteLine("Hello Learning05 World!");

        // This creates a square object
        Square squareShape = new Square();

        // This creates a rectangle object
        Rectangle rectangleShape = new Rectangle();

        // This creates a circle object
        Circle circleShape = new Circle();

        // This returns and displays the color of the shape
        Console.WriteLine();
        Console.WriteLine("Square Area and Color:");
        string colorSqr = squareShape.GetColor();
        Console.WriteLine(colorSqr);

        // This returns and displays the area of a square
        double sqrArea = squareShape.GetArea();
        Console.WriteLine(sqrArea);

        // This returns and displays the color of the shape
        Console.WriteLine();
        Console.WriteLine("Rectangle Area and Color:");
        string colorRec = rectangleShape.GetColor();
        Console.WriteLine(colorRec);

        // This returns and displays the area of a square
        double recArea = rectangleShape.GetArea();
        Console.WriteLine(recArea);

        // This returns and displays the color of the shape
        Console.WriteLine();
        Console.WriteLine("Circle Area and Color:");
        string colorCirc = circleShape.GetColor();
        Console.WriteLine(colorCirc);

        // This returns and displays the area of a square
        double circArea = circleShape.GetArea();
        Console.WriteLine(circArea);

    } // End of function program

} // End of the main program class