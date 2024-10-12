using System;

// This is the main class
class Program
{   
    // This is the main function
    static void Main(string[] args)
    {   
        // Welcome message to program
        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine();

        // Calling of both classes
        Entry entryActions = new Entry();
        Journal journalActions = new Journal();

        // This gets the date
        string currentDate = entryActions.GetDate();

        // This asks the user for the password
        Console.Write("Please enter the password: ");

        // This reads the input
        string password = entryActions.GetInput();

        // This calls for the method that checks the password
        journalActions.PasswordCheck(password);

        // Do-While loop that will until the user decides to exit
        do {
            // This prints an extra line 
            Console.WriteLine();

            // This displays the menu of the program
            Console.Write(@"Please select one of the following choices:
1- Write an journal entry.
2- Display your journal entries.
3- Save entry.
4- Load a txt file.
5- Exit journal.
What would you like to do? ");

            //This reads the input from the menu
            entryActions._menuInput = entryActions.GetInput();
            
            // Extra line that separates
            Console.WriteLine();

            // If statements that execute depending on the user's input
            // If #1: This will ask the user to enter an entry
            if (entryActions._menuInput == "1")
            {   
                // This randomly displays a prompt.
                string ranPrompt = entryActions.RandomizePrompt();
                Console.WriteLine(ranPrompt);

                // This reads the user input and stores it into a variable
                Console.Write("> ");
                entryActions._journalInput = entryActions.GetInput();
                string journalEntry = entryActions._journalInput;

                // This combines the parts for the formatted entry
                string cleanEntry = journalActions.CombineEntry(currentDate, ranPrompt, journalEntry);

                //This add the entry in the _totalEntries List
                journalActions._totalEntries.Add(cleanEntry);

            } // End of if #1

            // If #2: This displays all of the entries
            else if (entryActions._menuInput == "2")
            {
                //This displays the list of entries
                journalActions.DisplayEntries();

            } // End of if #2

            // If #3: This asks the user for the name the file and saves the entries into that newly created file
            else if (entryActions._menuInput == "3")
            {
                // This asks the user for the name of the txt file
                Console.WriteLine("What is the name of the file? ");

                // This gets the user input
                string fileName = entryActions.GetInput();

                // This calls the save method, which will call the WriteTxt method and write the file
                journalActions.Save(fileName, journalActions._totalEntries);


            } // End of if #3

            // If #4
            else if (entryActions._menuInput == "4")
            {
                // This asks the user for the name of the txt file
                Console.WriteLine("What is the name of the file? ");

                // This gets the user input
                string fileName = entryActions.GetInput();

                // This calls the load method
                journalActions.Load(fileName);

            } // End of if #4

        } while (entryActions._menuInput != "5"); // End of Do-WHile loop

    } // End of main

} // End of class program