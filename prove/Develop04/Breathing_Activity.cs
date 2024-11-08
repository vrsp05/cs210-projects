// This is the breathing class, which will serve as a child class for this program
class BreathingAct : Activity
{
    //Attributes: No attributes for the moment

    // Constructors
    public BreathingAct (string actName, string actDescription) : base(actName, actDescription)
    {

    } // End of constructor

    // Behaviors
    // This method handles the breathing cycles
     public void StartBreathing()
    {   
        // This passes the timer value
        int timerDuration = GetTimer();

        // Calculate the end time based on the timer duration
        DateTime endTime = DateTime.Now.AddSeconds(timerDuration);

        // While loop until the elapsed time is the same as the total time
        while (DateTime.Now < endTime)
        {
            // Breathe in for 4 seconds cycle
            Console.WriteLine();
            Console.Write("Breathe in... ");

            // This displays a breif countdown
            Countdown(4);

            // Breathe out for 6 seconds
            Console.Write("Breathe out... ");

            // This displays a breif countdown
            Countdown(6);

        } // End of while loop

        // This displays that the activity was completed
        Console.WriteLine();
        Console.WriteLine("Breathing activity complete.");

    } // End of StartBreathing method

} // End of BreathingAct class