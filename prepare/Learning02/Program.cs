using System;

class Program
{
    static void Main(string[] args)
    {
        // Creat new instance of the Job class
        Job job1 = new Job();
        job1._jobTitle = "bob";
        job1._company = "tim";
        job1._startYear = 23;
        job1._endYear = 23;

        // Creat new instance of the Job class
        Job job2 = new Job();
        job1._jobTitle = "bob";
        job1._company = "tim";
        job1._startYear = 23;
        job1._endYear = 23;

        // Creats an instance of Resume
        
        Resume resume1 = new Resume();
        resume1._name = "Jammy Tims";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        // job1.Display();

    }
}