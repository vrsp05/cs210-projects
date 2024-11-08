// This is the listing class, which will serve as a child class for this program
class ListingAct : Activity
{
    //Attributes
    // This is a list that will hold the prompts that will be given to the user
    private List<string> _promptList =
    ["Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"];
    // This is a list that will hold the user listing inputs
    private List<string> _userInputList = new List<string>();

    // Constructors
    public ListingAct (string actName, string actDescription) : base(actName, actDescription)
    {

    } // End of constructor

    // Behaviors
    // This method adds the user inputs into the userListLength list
    public void StartListing()
    { 
        // This displays the random prompt and when to begin
        Console.Write($@"
List as many responses to the following prompt:
--- {RandomPromptorQuestion(_promptList)} ---
You may begin in:  ");
        
        // This is the count down
        Countdown(5);

        // This lets the user enter the responses
        AddUserInput();

    } // End of StartListing method

    // This method gets the list length made by the user to dispaly it later.
    public int GetUserListLength()
    {   
        // This assigns the total number of inputs given by the user
        int userListLength = _userInputList.Count();

        // This returns the value
        return  userListLength;

    } // End of GetUserListLength

    // This method will handle the user input
    public void AddUserInput()
    {
        // This passes the timer value
        int timerDuration = GetTimer();

        // Calculate the end time based on the timer duration
        DateTime endTime = DateTime.Now.AddSeconds(timerDuration);

        // Variable created for the user input
        string userResponses;
        
        // Collect input until time is up
        while (DateTime.Now < endTime)
        {   
            // This indicates where the user is typin the answer
            Console.Write("> ");
            userResponses = Console.ReadLine();

            // Add input to the list
            _userInputList.Add(userResponses);

        } // End of while loop

        // Display the total count
        Console.WriteLine($"\nTime's up! You listed {GetUserListLength()} items.");

    }// Endo of AddUserInput

} // End of ListingAct class