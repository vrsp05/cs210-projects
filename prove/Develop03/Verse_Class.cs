// This is the SScriptureVerse Class. This class will handle the actions saved for the scripture words.
class ScriptureVerse
{
    // Attributes
    // This variable will hold the entire verse
    private string _verseString;
    // This list will hold each word of the verse
    private List<string> _verseWords = new List<string>();
    
    // Constructors
    public ScriptureVerse(string verse)
    {   
        // This assigns the value into the variable created
        _verseString = verse;

    } // End of constructor

    // Behaviors
    // This method will turn the string into a list
    public List<string> StringToList()
    {   
        // This will split the verse
        string[] words = _verseString.Split(" ");

        // This clears the list in case it has content
        _verseWords.Clear();

        // This adds each word into the verse words list
        foreach (string word in words)
        {   
            // This adds each word into my list.
            _verseWords.Add(word);

        } // End of foreach

        // This will return the created list
        return _verseWords;

    } // End of StringToList method

    // This method is for testing only. This method displays the list
    public void DisplayOriginalList()
    {   
        // This calls the string to list method to prepare the list
        _verseWords = StringToList();

        // This displays each word of the list
        foreach(string word in _verseWords)
        {   
            // Displays each word
            Console.Write($"{word} ");

        } // End of foreach

    } // End of DisplayOriginalList method

} // End of ScriptureVerse Class