// This is the child class for the math assignments
class MathAssignments : Assignment
{   
    // Attributes
    // This variable will hold the textbook section
    private string _textbookSection;
    // This variable will hold the math problems of the textbook section
    private string _problems;

    // Constructors
    public MathAssignments(string section, string problem, string name, string topic) : base(name, topic)
    {   
        // This assigns values to the variables
        _textbookSection = section;
        _problems = problem;

    } // End of constructor

    // Behaviors
    // This method displays the homework list
    public void GetHomeworkList()
    {
        // This displays the HW list
        Console.WriteLine($"Section {_textbookSection} Problems {_problems}");
        Console.WriteLine();

    } // End of GetHomeworkList

} // End of MathAssignments