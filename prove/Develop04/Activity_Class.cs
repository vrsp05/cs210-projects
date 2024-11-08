// This is the activity class, which will serve as the parent class for this program
class Activity
{
    //Attributes
    // This variable will hold the timer in seconds
    private int _timer;
    // This variable will hold the name of the activity
    private string _activityName;
    // This variable will hold the description of the activity
    private string _activityDescription;

    // Constructors
    public Activity (string actName, string actDescription)
    {
        // This assigns the variables
        _activityName = actName;
        _activityDescription = actDescription;

    } // End of constructor

    // Behaviors
    // This method sets the timer value for other 
    public void SetTimer(int seconds)
    {   
        // This sets the timer value
        _timer = seconds;

    } // End of SetTimer method

    // This method gets the timer amout and displays it
    public int GetTimer()
    {
        // This displays the timer time for testing
        return _timer;

    } // End of GetTimer method

    // This method displays the start message for the activity
    public void StartMessage()
    {   
        // This clears the console
        Console.Clear();

        // This displays the activity start message
        Console.Write($@"
Welcome to the {_activityName} activity!

{_activityDescription}

How long, in seconds, would you like for your session? ");

    } // End of StartMessage method

    // This method will be use to display the end message of the activity
    public void EndMessage(string actName)
    {
        // This displays the end message of the activity
        Console.WriteLine($@"
Well done!!
You have completed another {_timer} second session of the {actName} activity.");

    } // End of EndMessage method

    // This method will help with the small countdown sequences
    public void Countdown(int seconds)
    {
        // For loop to execute the small countdown
        for (int i = seconds; i >= 0; i--)
        {   
            // If #1: Checks if the i is bigger than 0 to display the number
            if (i > 0)
            {   
                // Display countdown in the same spot
                Console.Write($"\b{i}");

                // Wait for 1 second
                System.Threading.Thread.Sleep(1000);

            } // End of if #1

            // If #2: Only if the i is equal to 0
            else if (i == 0)
            {
                // Display countdown in the same spot
                Console.Write($"\b ");

                // Wait for 1 second 
                System.Threading.Thread.Sleep(1000);

            } // End of if #2

        } // End of for loop

        // This separetes the lines
        Console.WriteLine();

    } // End of the Countdown method

    // This is the loading animation method
    public void LoadingAnimation()
    {
        // Time delay in milliseconds between each step of the animation
        int delay = 250;

        // Repeat the sequence a few times
        for (int i = 0; i < 2; i++)
        {
            // Step 1: Show one asterisk
            Console.Write("*");
            System.Threading.Thread.Sleep(delay);

            // Step 2: Show two asterisks
            Console.Write("*");
            System.Threading.Thread.Sleep(delay);

            // Step 3: Show three asterisks
            Console.Write("*");
            System.Threading.Thread.Sleep(delay);

            // Step 4: Show four asterisks
            Console.Write("*");
            System.Threading.Thread.Sleep(delay);

            // Step 5: Show five asterisks
            Console.Write("*");
            System.Threading.Thread.Sleep(delay);

            // Step 4: Remove asterisks one by one
            Console.Write("\b \b"); // Remove the last asterisk
            System.Threading.Thread.Sleep(delay);

            Console.Write("\b \b"); // Remove the fourth asterisk
            System.Threading.Thread.Sleep(delay);

            Console.Write("\b \b"); // Remove the third asterisk
            System.Threading.Thread.Sleep(delay);

            Console.Write("\b \b"); // Remove the second asterisk
            System.Threading.Thread.Sleep(delay);

            Console.Write("\b \b"); // Remove the first asterisk
            System.Threading.Thread.Sleep(delay);

        } // End of for loop

    } // End of LoadingAnimation method

    // This method is used to display a message
    public void GetReady()
    {
        // This clears the console
        Console.Clear();

        // Displays the message
        Console.WriteLine("Get ready...");

        // This calls the animation method
        LoadingAnimation();

    } // End of GetReady method

    // This method selects and displays a random prompt from the list
    public string RandomPromptorQuestion(List<string> list)
    {
        // This calls the random class
        Random random = new Random();

        // This selects a random prompt
        int listIndex = random.Next(list.Count());

        // This returns the random prompt
        return list[listIndex];

    } // End of RandomPrompt method

} // End of Activity class