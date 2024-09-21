using System;

class Program
{
    static void Main(string[] args)
    {
        // This just writes the message
        Console.WriteLine("Hello Prep2 World!");
        // This writes an extra space line
        Console.WriteLine();
        
        // This is part 2 of the prep hw
        Console.Write("What is your grage percentage? ");
        // This reads the input
        string gradeString = Console.ReadLine();
        // This converts the input from String to Integer
        int grade = int.Parse(gradeString);

        // Declaring variable
        string letter = "";
        
        // This will the chain of if statements that checks the grade
        if (grade >= 90)
        {
            letter = "A";
            //Console.WriteLine("You have an A.");
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
            //Console.WriteLine("You have an B.");
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
            //Console.WriteLine("You have an C.");
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
            //Console.WriteLine("You have an D.");
        }
        else if (grade < 60)
        {
            letter = "F";
            //Console.WriteLine("You have an F.");
        }

        if (grade >= 70) 
        {   
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You failed the class.");
        }

        Console.WriteLine($"Your grade is {letter}.");

    } // END OF STATIC VOID

} // END OF CLASS PROGRAM