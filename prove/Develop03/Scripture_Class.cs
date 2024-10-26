// This is the Scripture Class. This class will handle the actions saved for the scripture.
using System.ComponentModel.DataAnnotations;

class Scripture
{
    // Attributes
    // This will hold the scripture verse in list form (original version)
    private List<string> _originalWords;
    // This will hold the edited list with the hidden words
    private List<string> _hiddenWords;
    // This will hold the scripture reference
    private string _scriptureReference;
    // This will hold the underscore
    private string _underscoreWord = "___";
    // This is the variable will hold the underscore used to replace the words.
    private int _wordsToDelete = 3;
    
    // Constructors
    // This constructor takes the list from the ScriptureVerse class and the reference from the ScriptureReference class
    public Scripture(List<string> verseList, string scripRef)
    {   
        // This stores the previusly created values from the other classes
        _originalWords = verseList;
        _hiddenWords = new List<string>(_originalWords);
        _scriptureReference = scripRef;

    } // End of constructor

    // Behaviors
    // This method will hide the words from the list and clear the console
    public void HideRandomWord()
    {
        // Create an object from the Random class
        Random random = new Random();

        // This an expression that checks and assigns the variable the number of words that are not hidden
        int wordsLeftToHide = _hiddenWords.Count(word => word != _underscoreWord);

        // If statement that checks if there are still words left to hide.
        if (wordsLeftToHide > 0)
        {
            // For loop that will run until the words to be deleted are hidden
            for (int i = 0; i < _wordsToDelete && wordsLeftToHide > 0; i++)
            {
                // This assigns a random number from the length of the list
                int ranIndex;

                // Do while loop that will assign an index value while the index does not have an underscore
                do
                {
                    // This assigns a random index
                    ranIndex = random.Next(_hiddenWords.Count);

                } while (_hiddenWords[ranIndex] == _underscoreWord); // End of do while loop

                // This replaces the selected word with an underscore
                _hiddenWords[ranIndex] = _underscoreWord;

                // This decreases the amounts of words left to hide
                wordsLeftToHide--;

            } // End of for loop

            // This clears the console
            Console.Clear();            
        
        } // End of if statement

        // Else statement that stops the program if there are no other words to hide
        else
        {   
            // This calls the method that terminates the program
            TerminateProgram();

        } // Else of statement

    } // End of HideRandomWord()

    // This will display the scripture
    public void DisplayFullScripture()
    {   
        // This displays the scripture reference
        Console.WriteLine();
        Console.Write(_scriptureReference);

        // This foreach will display the verse
        foreach (string word in _hiddenWords)
        {   
            // This displays each word
            Console.Write(word + " ");

        } // End of foreach

    } // End of DisplayFullScripture() method

    // This method will terminate the program and give a message
    private void TerminateProgram()
    {
        // This print a message if all words are hidden and informs the user that the program is terminated
        Console.WriteLine();
        Console.WriteLine("All words have been hidden!");
        Console.WriteLine("Closing program...");

        // This terminates the program when there are no other words to hide
        Environment.Exit(0);

    } // End of TerminateProgram method

} // End of Scripture Class