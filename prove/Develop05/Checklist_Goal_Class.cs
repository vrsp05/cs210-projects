// This is the child class that manages the actions for the checklist goals
class ChecklistGoal : GoalClass
{
    // Attributes
    // This variable holds the value for the bonus points
    private int _bonusPoints;
    // This variable hold the amount of times required for the goal to be completed
    private int _timesToComplete;
    // This variable holds the current amount of times completed
    private int _timesCompleted;
    // This variable marks if the goal is completed
    private bool _isCompleted;

    // Constructors
    public ChecklistGoal()
    {

    } // End of constructor

    // Behaviors
    // This abstract method will ask checlist goal questions
    public override void AskGoalInfo()
    {
        // These questions and answers help setting the goal
        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal needs to be accomplished for a bonus? ");
        _timesToComplete = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

        // This sets the information of the goal
        SetGoalInfo(name, description, points);

    } // End of AskUserInfo method

        // This abstract method returns the simple goal info
    public override string GetGoalInfo()
    {   
        // Display [ ] for incomplete and [X] for completed goals
        string status = _isCompleted ? "[X]" : "[ ]";

        // This formats how to display the info
        string checklistInfo = $"{status} {_goalName} ({_goalDescription}) -- Currently completed: {_timesCompleted}/{_timesToComplete}";

        // This returns the displayble info
        return checklistInfo;

    } // End of GetGoalInfo

    // This formats how to save the goal
    public override string SetGoalsFullInfo()
    {   
        // This returns the formatted string
        return $"ChecklistGoal:{_goalName},{_goalDescription},{_rewardPoints},{_bonusPoints},{_timesToComplete},{_timesCompleted}";

    } // End of GoalsFullInfo

    // This method helps with setting up the exclusive information of the checklist goals
    public void SetChecklistDetails(int bonus, int timesToComplete, int timesCompleted, bool completed)
    {   
        // This assigns the values
        _bonusPoints = bonus;
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
        _isCompleted = completed;
    
    } // End of SetChecklistDetails

    // This method helps with setting the loaded status of a simple goal
    public void SetCompletion(bool completed)
    {   
         // This assigns the value
         _isCompleted = completed;

    } // End of SetCompletion method

} // End of child class ChecklistGoal