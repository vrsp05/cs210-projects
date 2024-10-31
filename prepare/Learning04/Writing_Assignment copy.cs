// This is the child class for the writing assignments
class WritingAssignments : Assignment
{
    // Attributes
    // This variable will hold the title of the writing assignment
    private string _title;

    // Constructors
    public WritingAssignments(string title, string name, string topic) : base(name, topic)
    {
        // This assigns the value to the variable
        _title = title;
    }

    // Behaviors
    public void GetWritingInfo()
    {
        // This displays the values
        Console.WriteLine($"{_title}");
        Console.WriteLine();

    } // End of GetWritingInfo

} // End of WritingAssignments