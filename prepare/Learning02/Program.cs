using System;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creat new instance of the Job class
            Job job1 = new Job();
            job1._jobTitle = "Software Engineer ";
            job1._company = "Microsoft";
            job1._startYear = 2001;
            job1._endYear = 2007;

            // Creat new instance of the Job class
            Job job2 = new Job();
            job2._jobTitle = "Manager";
            job2._company = "Apple";
            job2._startYear = 2019;
            job2._endYear = 2023;

            // Creats an instance of Resume

            Resume resume1 = new Resume();
            resume1._name = "Jammy Tims";
            resume1._jobs.Add(job1);
            resume1._jobs.Add(job2);

            resume1.Display();

            

        }
    }
}