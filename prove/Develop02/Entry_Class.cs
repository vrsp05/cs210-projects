// This is the entry class. It will handle the variables and functions used for input or user entry.

public class Entry
{
    //Attributes
    // This serves for journal entries
    public string _journalInput;
    // This serves for menu selection
    public string _menuInput;
    // The list with the prompts
    public List<string> _promptList = ["Who was the most interesting person I interacted with today?",
    "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"];

    //Behaviors
    
    // This constructs the class
    //public Entry()
    //{}

    // This function reads and returns the input
    public string GetInput(){
        //This reads the value
        string userInput = Console.ReadLine();
        // This returns the value
        return userInput;
    } // End of GetInput function

    // This function randomly selects a value from the _prompList
    public string RandomizePrompt()
    {   // Calling the Random class
        Random randomNumber = new Random();
        // Selecting a random index from the list
        int index = randomNumber.Next(_promptList.Count);
        // Returning the prompt base on the random index selected
        return _promptList[index];
    } // End of RandomizePrompt

    // This function gets the current date for our journal
    public string GetDate()
    {   // This returns the current date
        return DateTime.Now.ToString("MM/dd/yyyy");
    } // End of GetDate function

} // End of Entry Class