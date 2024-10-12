// This is the journal class. It will handle the actions that the journal needs to perform.
using System.IO;

public class Journal
{
    //Attributes
    // This list stores the clean strings
    public List<string> _totalEntries = new List<string>();
    // This holds the variable for password
    public string _currentPassword = "journal123";

    //Behaviors
    //public Journal()
    //{}

    // This combines the dates, random prompt, and entry to clean it and make it pretty
    public string CombineEntry(string date, string prompt, string entry)
    {   
        // This formats the entry with the date, random prompt, and the user entry
        string formattedEntry = @$"Date: {date} - Prompt: {prompt}
{entry}";
        // This returns the formatted string
        return formattedEntry;
    } // End of CombineEntry function

    // This is the method that saves the entries
    public void Save(string fileName, List<string> entriesList)
    {   
        // This method calls the WriteTxt that writes the the file with the entries
        WriteTxt(fileName, entriesList);
    } // End of Save function

    // This is the load function, it loads the a txt file after putting the name
    public void Load(string fileName)
    {   
        // This reads the txt file and stores each line in the array called lines
        string[] lines = System.IO.File.ReadAllLines(fileName);
        // This iterates through each index in the array
        foreach (string line in lines)
        {   
            // This adds each line of the array in the _totalEntries list
            _totalEntries.Add(line);
        } // End of foreach

    } // End of Load function

    // This function writes the file with the entries
    public void WriteTxt(string fileName, List<string> entriesList)
    {
        // This writes a file with the input given
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            // This writes the welcome message
            outputFile.WriteLine("Welcome to your journal.");
            outputFile.WriteLine();
            // This will write each clean entry
            foreach (string entry in entriesList)
            {   
                // This displays each clean entry
                outputFile.WriteLine(entry);
            } // End of foreach

        } // End of using

    } // End of WriteTxt function

    // This function displays the entries
    public void DisplayEntries()
    {
        // Foreach that reads each entry in the list
        foreach (string Entry in _totalEntries)
        {   
            //This displays the list
            Console.WriteLine(Entry);
        } // End of foreach

    } // End of DisplayEntries function

    // This function protects the system by asking for a password.
    public void PasswordCheck(string password)
    {   
        // This checks if the password is not the correct one
        if (password != _currentPassword)
        {   
            // This tells the user that the password is incorrect
            Console.WriteLine("Incorrect password. Exiting...");
            Environment.Exit(0); // Close the program if password is wrong
        }// End of if statement
    } // End of PasswordCheck function

} // End of Journal Class>