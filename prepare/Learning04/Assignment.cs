// This will be the parent class for this weeks program
class Assignment
{   
    // Attributes
    // This variable holds the student's name
    private string _studentName;
    // This variable hold the name of the topic
    private string _topic;

    // Constructors
    public Assignment(string name, string topic)
    {
        // These assign a values to the variables
        _studentName = name;
        _topic = topic;

    } // End of constructor

    // Behaviors
    // This method will display the name and topic
    public void GetSummary()
    {
        // This displays the summary
        Console.WriteLine($"{_studentName} - {_topic}");

    } // End of GetSummary method

} // End of Assignment class