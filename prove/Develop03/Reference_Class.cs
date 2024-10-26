// This is the Reference Class. This class will handle the actions saved for the reference of the scripture.
class ScriptureReference
{
    // Attributes
    // Variable that will store the book name
    private string _bookName;
    // Variable that will store the book chapter
    private string _bookChapter;
    // Variables that will store the scripture verse
    private string _initalVerse;
    private string _finalVerse;

    // Constructors
    // #1 This constructor accepts the name of the book, chapter, first and last verse
    public ScriptureReference(string book, string chapter, string firstVerse, string endingVerse)
    {
        // This sets the variables to proper values
        _bookName = book;
        _bookChapter = chapter;
        _initalVerse = firstVerse;
        _finalVerse = endingVerse;

    } // End of constructor #1 

    // #2 This constructor accepts the name of the book, chapter, first and last verse
    public ScriptureReference(string book, string chapter, string firstVerse)
    {
        // This sets the variables to proper values
        _bookName = book;
        _bookChapter = chapter;
        _initalVerse = firstVerse;

    } // End of constructor #2

    // Behaviors
    // This builds the scripture reference
    public string CreateReference(string userResponse)
    {   
        // if statement that checks if there is a final verse
        if (userResponse == "yes")
        {
            // This creates the scripture reference
            string scriptureRef = $"{_bookName} {_bookChapter}: {_initalVerse}-{_finalVerse} ";

            // This returns the created reference
            return scriptureRef;

        } // End of if statement

        // Else statement that creates a scripture reference if there is no finalVerse
        else
        {
            // This creates the scripture reference
            string scripRef = $"{_bookName} {_bookChapter}: {_initalVerse} ";
            
            // This returns the created reference
            return scripRef;

        } // End of else

    } // End of CreateReference() method

    // This is for testing only. This method displays the scripture reference
    public void DisplayScriptureReference()
    {
        Console.Write($"{_bookName} {_bookChapter}: {_initalVerse}-{_finalVerse} ");
    } // End of DisplayScriptureReference method

} // End of ScriptureReference Class