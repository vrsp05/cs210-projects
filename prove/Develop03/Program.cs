using System;
using System.Runtime.CompilerServices;

// Main Program Class
class Program
{   
    // Main function
    static void Main(string[] args)
    {
        // The variable for user input when memorizing the scripture
        string enterInput;

        // This creates an empty list that will be used as a parameter for the scripture constructor
        List<string> verseList = [];

        // This variable will hold the scripture reference
        string scripReference;

        // Welcome message
        Console.WriteLine("Welcome to the scripture memorizer app.");
        Console.WriteLine();

        // Prompts the user to enter the information about the scripture desired to memorize
        Console.Write("Please enter the name of the book: ");
        // This reads the user input
        string bookName = Console.ReadLine();

        Console.Write("Please enter the chapter: ");
        // This reads the user input
        string bookChapter = Console.ReadLine();

        Console.Write("Please enter the first verse: ");
        // This reads the user input
        string firstVerse = Console.ReadLine();

        // This asks the user if there are more than one verse
        Console.Write("Is there more than one verse (yes or no)? ");
        string userResponse = Console.ReadLine();

        // If statement that checks the user if the scripture has more than one verse
        if (userResponse == "yes")
        {
            Console.Write("Please enter the last verse: ");
            // This reads the user input
            string lastVerse = Console.ReadLine();

            // This builds an object for the scripture reference
            ScriptureReference referenceClass = new ScriptureReference(bookName, bookChapter, firstVerse, lastVerse);

            // This creates the scripture reference
            scripReference = referenceClass.CreateReference(userResponse);

        } // End of if statement

        // This if there is only one verse
        else
        {
            // This builds an object for the scripture reference
            ScriptureReference referenceClass = new ScriptureReference(bookName, bookChapter, firstVerse);

            // This creates the scripture reference
            scripReference = referenceClass.CreateReference(userResponse);

        } // End of else statement

        // Prompts the user to enter the information about the scripture desired to memorize
        Console.WriteLine("Please write the entire verse or verses of the scripture reference:");
        // This reads the user input
        string verse = Console.ReadLine();

        // This builds an object for the scripture verse
        ScriptureVerse verseClass = new ScriptureVerse(verse);

        // This creates the list of the original list
        verseList = verseClass.StringToList();

        // This builds an object for the full completed scripture
        Scripture scriptureClass = new Scripture(verseList, scripReference);

        // Do While Loop that runs until the user enters quit or all words are hidden
        do
        {
            // This displays the verse
            scriptureClass.DisplayFullScripture();

            // This is the prompt for the user
            Console.WriteLine();
            Console.Write("Please press enter to continue or type 'quit' to exit: ");
            // This reads the user input
            enterInput = Console.ReadLine();

            // This calls the method that replaces the words
            scriptureClass.HideRandomWord();

        } 
        while (enterInput != "quit"); // End of Do While loop

    } // End of Main function

} // End of Main Program Class