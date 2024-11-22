// This is the child class that manages the actions for the eternal goals
class EternalGoal : GoalClass
{
    // Attributes: NONE FOR NOW

    // Constructors
    public EternalGoal()
    {

    } // End of constructor

    // Behaviors
        // This abstract method will ask eternal goal questions
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

    // This abstract method returns the eternal goal info
    public override string GetGoalInfo()
    {   
        // This formats how to display the info
        string eternalInfo = "[ ] " + $"{_goalName} ({_goalDescription})";
        
        // This returns the displayble info
        return eternalInfo;

    } // End of GetGoalInfo

    // This formats how to save the goal
    public override string SetGoalsFullInfo()
    {   
        // This returns the formatted string
        return $"EternalGoal:{_goalName},{_goalDescription},{_rewardPoints}";

    } // End of GoalsFullInfo

} // End of child class EternalGoal