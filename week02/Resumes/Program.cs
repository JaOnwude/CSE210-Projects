using System;

class Program
{
    static void Main(string[] args)
    {       
        Job job1 = new Job();
        job1._jobTitle = "Software Engineering";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "James Uchenna";

        myResume._myJobs.Add(job1);
        myResume._myJobs.Add(job2);

        myResume.Display();
        // Console.WriteLine("Hello World! This is the Resumes Project.");
    }
}