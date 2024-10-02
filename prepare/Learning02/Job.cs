//New class that holds job values and definitions.
public class Job
{
    //Attributes
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Behaviors
    public Job()
    {}
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }

} // End of class