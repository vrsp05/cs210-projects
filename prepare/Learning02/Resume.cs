//New class that holds job values and definitions.
public class Resume
{
    //Attributes
    public string _personName;
    public List<Job> _previousJobs = new List<Job>();

    //Behaviors
    public Resume()
    {}

    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");

        foreach (Job jobs in _previousJobs)
        {
            jobs.Display();
        }
    }

} // End of class