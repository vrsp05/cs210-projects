// This is the reflecting class, which will serve as child class for this program
class ReflectingAct : Activity
{
    //Attributes
    // This list will hold the prompts of the activity
    private List<string> _promptList =
    ["Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",];
    // This list will hold the questions of the activity
    private List<string> _promptQuestion =
    ["Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"];

    // Constructors
    public ReflectingAct (string actName, string actDescription) : base(actName, actDescription)
    {

    } // End of constructor

    // Behaviors
    // This will be the method that will start the reflection activity
    public void StartReflection()
    {
        // This tells the user consider the prompt
        Console.Write($@"
Consider the following prompt:
---{RandomPromptorQuestion(_promptList)}---
When you have something in mind, please press enter to continue.
");     
        // This is just for the user to hit enter
        string enter = Console.ReadLine();

        // This gives more instructions to the user
        Console.Write(@"Now ponder on each of the following questions about how they are related to this experience.
You may begin in:  ");

        // This initates the countdown
        Countdown(5);

        // This clears the console and the uses method for the questions
        Console.Clear();
        DisplayReflectionQuestions();

    } // End of StartReflection

    // This method will handle the display of the reflection questions
    public void DisplayReflectionQuestions()
    {
        // This passes the timer value
        int timerDuration = GetTimer();

        // Calculate the end time based on the timer duration
        DateTime endTime = DateTime.Now.AddSeconds(timerDuration);

        // While loop that runs until the time is over
        while (DateTime.Now < endTime)
        {
            // This displays the questions
            Console.Write("> ");
            Console.Write($"{RandomPromptorQuestion(_promptQuestion)} ");

            // For loop that helps in displaying and repeating the animation
            for (int i = 2; i > 0; i--)
            {   
                // This displays the animation
                LoadingAnimation();

            } // End of for loop

        } // End of while loop
        
        // This displays a messege that time is over
        Console.WriteLine("Reflection time is over. Thank you for reflecting!");

    } // End of DisplayReflectionQuestions
    
} // End of ReflectingAct class