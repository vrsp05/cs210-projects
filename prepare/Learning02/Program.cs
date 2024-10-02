using System;

class Program
{
    static void Main(string[] args)
    {   
        // Welcome to program message
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine();

        // Calling of class
        Job job1 = new Job();
        Job job2 = new Job();

        //Asigning values to the attributes
        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Asigning values to the attributes
        job2._companyName = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;


        //Calling the Job method
        job1.Display();
        job2.Display();
        Console.WriteLine();


        // Calling the Resume class
        Resume resume1 = new Resume();

        // Adding a value to the list attribute
        resume1._previousJobs.Add(job1);
        resume1._previousJobs.Add(job2);
        resume1._personName = "Alison";

        //Displaying the added value
        resume1.Display();

    } // End of main
} // End of class program