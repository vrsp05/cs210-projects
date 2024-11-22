// This is the child class that manages the actions for the simple goals
class SimpleGoal : GoalClass
{
    // Attributes
    protected bool _completed;

    // Constructors

    // Behaviors
    // This abstract method will ask simple goal questions
    public override void AskGoalInfo()
    {
        // These questions and answers help setting the goal
        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        // This sets the information of the goal
        SetGoalInfo(name, description, points);

    } // End of AskUserInfo method

    // This abstract method returns the simple goal info
    public override string GetGoalInfo()
    { 
        // Display [ ] for incomplete and [X] for completed goals
        string status = _completed ? "[X]" : "[ ]";

        // This formats how to display the info
        string simpleInfo = $"{status} {_goalName} ({_goalDescription})";
        
        // This returns the displayble info
        return simpleInfo;

    } // End of GetGoalInfo

    // This formats how to save the goal
    public override string SetGoalsFullInfo()
    {   
        // This returns the formatted string
        return $"SimpleGoal:{_goalName},{_goalDescription},{_rewardPoints},{_completed}";

    } // End of GoalsFullInfo

    // This method helps with setting the loaded status of a simple goal
    public void SetCompletion(bool completed)
    {   
         // This assigns the value
         _completed = completed;

    } // End of SetCompletion method

} // End of child class SimpleGoal