using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create a new Job instance
        Job job1 = new Job();
        job1.Company = "Microsoft";
        job1.JobTitle = "Software Engineer";
        job1.StartYear = 2020;
        job1.EndYear = 2023;

        // Create another Job instance
        Job job2 = new Job();
        job2.Company = "Google";
        job2.JobTitle = "Data Scientist";
        job2.StartYear = 2023;
        job2.EndYear = 2025;

        // Create a Resume instance
        Resume myResume = new Resume();
        myResume.Name = "John Doe";
        myResume.Jobs = new List<Job> { job1, job2 };

        // Display the resume
        myResume.DisplayResume();

    }
}