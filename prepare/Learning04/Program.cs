using System;
// Main program class
class Program
{   
    // Main function
    static void Main(string[] args)
    {   
        // Welcome message
        Console.WriteLine("Welcome to week 7 activity.");
        Console.WriteLine();

        // This creates a new object for the class Assignment
        Assignment student = new Assignment("Samuel Bennett", "Multiplication");
        // This displays the info for the Assignment class
        student.GetSummary();
        Console.WriteLine();

        // This creates a new object for the class MathAssignments
        MathAssignments mathHomework = new MathAssignments("7.3","8-19", "Roberto Rodriguez", "Fractions");
        // These display the info
        mathHomework.GetSummary();
        mathHomework.GetHomeworkList();

       // This creates a new object for the class MathAssignments
        WritingAssignments writingHomework = new WritingAssignments("The Causes of World War II by Mary Waters", "Mary Waters", "European History");
        // These display the info
        writingHomework.GetSummary();
        writingHomework.GetWritingInfo();

    } // End of main function

} // End of Main class